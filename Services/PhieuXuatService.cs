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
        // 1. Get Customers
        public DataTable LayDanhSachKhachHang()
        {
            return DbHelper.Query("SELECT MAKH, TENKH, DIACHI, SDT FROM DANHMUCKHACHHANG ORDER BY TENKH");
        }

        // 2. Get Products (Using View vw_TonKhoHienTai)
        public DataTable LayDanhSachHangHoa()
        {
            string sql = @"
                SELECT h.MAHH, h.TENHH, h.DVT, h.GIABAN, ISNULL(t.TON_HIEN_TAI, 0) AS TONKHO
                FROM DM_HANGHOA h
                LEFT JOIN vw_TonKhoHienTai t ON h.MAHH = t.MAHH
                WHERE h.ACTIVE = 1
                ORDER BY h.TENHH";
            return DbHelper.Query(sql);
        }

        // 3. Stock Check
        public int CheckTonKho(string maHH)
        {
            string sql = "SELECT ISNULL(TON_HIEN_TAI, 0) FROM vw_TonKhoHienTai WHERE MAHH = @MaHH";
            object result = DbHelper.Scalar(sql, DbHelper.Param("@MaHH", maHH));
            return result != null ? Convert.ToInt32(result) : 0;
        }

        // 4. MAIN TRANSACTION (Strict SP Logic)
        public long LuuPhieuXuat(DateTime ngayLap, string maKH, string ghiChu, bool isThanhToan, List<PhieuXuatChiTietDTO> listChiTiet)
        {
            if (listChiTiet == null || listChiTiet.Count == 0)
                throw new ArgumentException("Danh sách hàng hóa không được để trống.");

            // A. Pre-Validation
            foreach (var item in listChiTiet)
            {
                int currentStock = CheckTonKho(item.MaHH);
                if (currentStock < item.SoLuong)
                    throw new Exception($"Hàng hóa '{item.TenHH}' không đủ tồn kho (Có: {currentStock:N0}, Cần: {item.SoLuong:N0}).");
            }

            long newSoPhieu = 0;

            DbHelper.ExecuteTran((conn, tran) =>
            {
                // B1. Insert Header
                string sqlHeader = @"INSERT INTO PHIEU (NGAYLAP, LOAI, MAKH, GHICHU, TRANGTHAI) 
                                     VALUES (@Ngay, 'X', @MaKH, @GhiChu, 1);
                                     SELECT SCOPE_IDENTITY();";

                newSoPhieu = Convert.ToInt64(DbHelper.ScalarInTran(conn, tran, sqlHeader,
                    DbHelper.Param("@Ngay", ngayLap),
                    DbHelper.Param("@MaKH", maKH),
                    DbHelper.Param("@GhiChu", ghiChu ?? "")
                ));

                decimal totalRevenue = 0;

                // B2. Details & FIFO SP
                foreach (var item in listChiTiet)
                {
                    totalRevenue += item.ThanhTien;

                    // Insert Detail (GIAVON = 0 initially)
                    string sqlDetail = @"INSERT INTO PHIEU_CT (SOPHIEU, MAHH, SL, DONGIA, GIAVON) 
                                         VALUES (@SoPhieu, @MaHH, @SL, @DonGia, 0)";

                    DbHelper.ExecuteInTran(conn, tran, sqlDetail,
                        DbHelper.Param("@SoPhieu", newSoPhieu),
                        DbHelper.Param("@MaHH", item.MaHH),
                        DbHelper.Param("@SL", item.SoLuong),
                        DbHelper.Param("@DonGia", item.DonGiaBan)
                    );

                    // Call SP to run FIFO and calculate/update Cost
                    using (SqlCommand cmd = new SqlCommand("sp_XuatKho_FIFO", conn, tran))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@SoPhieu", newSoPhieu);
                        cmd.Parameters.AddWithValue("@MaHH", item.MaHH);
                        cmd.Parameters.AddWithValue("@SoLuongXuat", item.SoLuong);
                        cmd.ExecuteNonQuery();
                    }
                }

                // B3. Calculate Total COGS from DB
                object totalCostObj = DbHelper.ScalarInTran(conn, tran,
                    "SELECT ISNULL(SUM(GIAVON * SL), 0) FROM PHIEU_CT WHERE SOPHIEU = @SoPhieu",
                    DbHelper.Param("@SoPhieu", newSoPhieu));
                decimal totalCOGS = Convert.ToDecimal(totalCostObj);

                // B4. Accounting
                // Revenue (Credit 511, Debit 131/111)
                string tkNo = isThanhToan ? "111" : "131";
                string descRiv = $"Doanh thu phiếu xuất #{newSoPhieu}";

                DbHelper.ExecuteInTran(conn, tran,
                    "INSERT INTO BUTTOAN_KETOAN (NGAY_HT, TK_NO, TK_CO, SOTIEN, DIEN_GIAI) VALUES (@Ngay, @TkNo, '', @Tien, @Desc)",
                    DbHelper.Param("@Ngay", ngayLap), DbHelper.Param("@TkNo", tkNo), DbHelper.Param("@Tien", totalRevenue), DbHelper.Param("@Desc", descRiv));

                DbHelper.ExecuteInTran(conn, tran,
                    "INSERT INTO BUTTOAN_KETOAN (NGAY_HT, TK_NO, TK_CO, SOTIEN, DIEN_GIAI) VALUES (@Ngay, '', '511', @Tien, @Desc)",
                    DbHelper.Param("@Ngay", ngayLap), DbHelper.Param("@Tien", totalRevenue), DbHelper.Param("@Desc", descRiv));

                // COGS (Credit 156, Debit 632)
                string descCogs = $"Giá vốn phiếu xuất #{newSoPhieu}";
                DbHelper.ExecuteInTran(conn, tran,
                    "INSERT INTO BUTTOAN_KETOAN (NGAY_HT, TK_NO, TK_CO, SOTIEN, DIEN_GIAI) VALUES (@Ngay, '632', '156', @Tien, @Desc)",
                    DbHelper.Param("@Ngay", ngayLap), DbHelper.Param("@Tien", totalCOGS), DbHelper.Param("@Desc", descCogs));

                // Receipt if Paid
                if (isThanhToan)
                {
                    string sqlReceipt = @"INSERT INTO PHIEUTHUCHI (NGAYLAP, LOAI, MAKH, SOTIEN, LYDO)
                                           VALUES (@Ngay, 'T', @MaKH, @SoTien, @LyDo)";
                    DbHelper.ExecuteInTran(conn, tran, sqlReceipt,
                       DbHelper.Param("@Ngay", ngayLap),
                       DbHelper.Param("@MaKH", maKH),
                       DbHelper.Param("@SoTien", totalRevenue),
                       DbHelper.Param("@LyDo", $"Thu tiền ngay phiếu xuất #{newSoPhieu}")
                   );
                }

                return 1;
            });

            return newSoPhieu;
        }
    }
}