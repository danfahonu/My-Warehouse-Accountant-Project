using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DoAnLapTrinhQuanLy.Data;

namespace DoAnLapTrinhQuanLy.Services
{
    public class PhieuXuatChiTietDTO
    {
        public string MaHH { get; set; }
        public string TenHH { get; set; }
        public string DVT { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGiaBan { get; set; }
        public decimal ThanhTien => SoLuong * DonGiaBan;
    }

    public class PhieuXuatService
    {
        public DataTable LayDanhSachKhachHang()
        {
            return DbHelper.Query("SELECT MAKH, TENKH, DIACHI, SDT FROM DANHMUCKHACHHANG ORDER BY TENKH");
        }

        public DataTable LayDanhSachHangHoa()
        {
            // Lấy thêm tồn kho
            string sql = @"
                SELECT h.MAHH, h.TENHH, h.DVT, h.GIABAN, ISNULL(t.TON_HIEN_TAI, 0) AS TONKHO
                FROM DM_HANGHOA h
                LEFT JOIN vw_TonKhoHienTai t ON h.MAHH = t.MAHH
                WHERE h.ACTIVE = 1
                ORDER BY h.TENHH";
            return DbHelper.Query(sql);
        }

        public int CheckTonKho(string maHH)
        {
            string sql = "SELECT ISNULL(TON_HIEN_TAI, 0) FROM vw_TonKhoHienTai WHERE MAHH = @MaHH";
            object result = DbHelper.Scalar(sql, DbHelper.Param("@MaHH", maHH));
            return result != null ? Convert.ToInt32(result) : 0;
        }

        // --- HÀM LƯU CHÍNH ---
        public long LuuPhieuXuat(DateTime ngayLap, string maKH, string ghiChu, bool isThanhToan, List<PhieuXuatChiTietDTO> listChiTiet)
        {
            if (listChiTiet == null || listChiTiet.Count == 0)
                throw new ArgumentException("Danh sách hàng hóa rỗng.");

            // 1. Kiểm tra tồn kho
            foreach (var item in listChiTiet)
            {
                int currentStock = CheckTonKho(item.MaHH);
                if (currentStock < item.SoLuong)
                    throw new Exception($"Hàng '{item.TenHH}' không đủ tồn (Có: {currentStock}, Cần: {item.SoLuong}).");
            }

            long newSoPhieu = 0;

            DbHelper.ExecuteTran((conn, tran) =>
            {
                // 2. Insert Header
                string sqlHeader = @"INSERT INTO PHIEU (NGAYLAP, LOAI, MAKH, GHICHU, TRANGTHAI) 
                                     VALUES (@Ngay, 'X', @MaKH, @GhiChu, 1);
                                     SELECT SCOPE_IDENTITY();";

                newSoPhieu = Convert.ToInt64(DbHelper.ScalarInTran(conn, tran, sqlHeader,
                    DbHelper.Param("@Ngay", ngayLap),
                    DbHelper.Param("@MaKH", maKH),
                    DbHelper.Param("@GhiChu", ghiChu ?? "")
                ));

                decimal totalRevenue = 0;

                // 3. Insert Detail & Chạy FIFO
                foreach (var item in listChiTiet)
                {
                    totalRevenue += item.ThanhTien;

                    // Lưu chi tiết
                    string sqlDetail = @"INSERT INTO PHIEU_CT (SOPHIEU, MAHH, SL, DONGIA, GIAVON) 
                                         VALUES (@SoPhieu, @MaHH, @SL, @DonGia, 0)";

                    DbHelper.ExecuteInTran(conn, tran, sqlDetail,
                        DbHelper.Param("@SoPhieu", newSoPhieu),
                        DbHelper.Param("@MaHH", item.MaHH),
                        DbHelper.Param("@SL", item.SoLuong),
                        DbHelper.Param("@DonGia", item.DonGiaBan)
                    );

                    // Chạy FIFO
                    using (SqlCommand cmd = new SqlCommand("sp_XuatKho_FIFO", conn, tran))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@SoPhieu", newSoPhieu);
                        cmd.Parameters.AddWithValue("@MaHH", item.MaHH);
                        cmd.Parameters.AddWithValue("@SoLuongXuat", item.SoLuong);
                        cmd.ExecuteNonQuery();
                    }
                }

                // 4. Lấy tổng giá vốn
                object totalCostObj = DbHelper.ScalarInTran(conn, tran,
                    "SELECT ISNULL(SUM(GIAVON * SL), 0) FROM PHIEU_CT WHERE SOPHIEU = @SoPhieu",
                    DbHelper.Param("@SoPhieu", newSoPhieu));
                decimal totalCOGS = Convert.ToDecimal(totalCostObj);

                // --- 5. HẠCH TOÁN (GHI SỔ KÉP ĐỂ TRÁNH LỖI NULL/EMPTY) ---

                string descRiv = $"Doanh thu phiếu xuất #{newSoPhieu}";
                string descCogs = $"Giá vốn phiếu xuất #{newSoPhieu}";

                // A. Ghi Doanh Thu: Nợ 131 / Có 511
                InsertButToan(conn, tran, ngayLap, "131", "511", totalRevenue, descRiv);

                // B. Ghi Giá Vốn: Nợ 632 / Có 156
                InsertButToan(conn, tran, ngayLap, "632", "156", totalCOGS, descCogs);

                // C. Nếu Thanh Toán: Ghi Nợ 1111 / Có 131
                if (isThanhToan)
                {
                    // Tạo phiếu thu
                    string sqlReceipt = @"INSERT INTO PHIEUTHUCHI (NGAYLAP, LOAI, MAKH, SOTIEN, LYDO)
                                           VALUES (@Ngay, 'T', @MaKH, @SoTien, @LyDo)";
                    DbHelper.ExecuteInTran(conn, tran, sqlReceipt,
                       DbHelper.Param("@Ngay", ngayLap),
                       DbHelper.Param("@MaKH", maKH),
                       DbHelper.Param("@SoTien", totalRevenue),
                       DbHelper.Param("@LyDo", $"Thu tiền ngay phiếu xuất #{newSoPhieu}")
                   );

                    // Hạch toán: Thu tiền mặt (1111), Giảm nợ khách (131)
                    string descPay = $"Thu tiền phiếu xuất #{newSoPhieu}";
                    InsertButToan(conn, tran, ngayLap, "1111", "131", totalRevenue, descPay);
                }

                return 1;
            });

            return newSoPhieu;
        }

        // Hàm chèn bút toán an toàn
        private void InsertButToan(SqlConnection conn, SqlTransaction tran, DateTime ngay, string tkNo, string tkCo, decimal tien, string dienGiai)
        {
            // Lưu ý: Cột SOTIEN, DIEN_GIAI, TK_NO, TK_CO phải khớp với tên cột trong bảng BUTTOAN_KETOAN của bà
            // Ở đây tui giả định tên cột là TK_NO và TK_CO (nếu khác bà sửa lại nhé)
            string sql = @"INSERT INTO BUTTOAN_KETOAN (NGAY_HT, TK_NO, TK_CO, SOTIEN, DIEN_GIAI) 
                           VALUES (@Ngay, @TkNo, @TkCo, @Tien, @Desc)";

            DbHelper.ExecuteInTran(conn, tran, sql,
                DbHelper.Param("@Ngay", ngay),
                DbHelper.Param("@TkNo", tkNo),
                DbHelper.Param("@TkCo", tkCo),
                DbHelper.Param("@Tien", tien),
                DbHelper.Param("@Desc", dienGiai)
            );
        }
    }
}