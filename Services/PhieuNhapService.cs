using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DoAnLapTrinhQuanLy.Data;

namespace DoAnLapTrinhQuanLy.Services
{
    public class PhieuNhapChiTietDTO
    {
        public string MaHH { get; set; }
        public string DVT { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public string GhiChu { get; set; }
        public decimal ThanhTien => SoLuong * DonGia;
    }

    public class PhieuNhapService
    {
        public DataTable LayDanhSachNhaCungCap()
        {
            return DbHelper.Query("SELECT MA_NCC, TEN_NCC FROM DM_NHACUNGCAP ORDER BY TEN_NCC");
        }

        public DataTable LayDanhSachHangHoa()
        {
            return DbHelper.Query("SELECT MAHH, TENHH, DVT, GIAVON FROM DM_HANGHOA ORDER BY TENHH");
        }

        /// <summary>
        /// Lấy chi tiết phiếu yêu cầu để nhập kho (Smart Import Logic).
        /// Tính toán số lượng còn lại chưa nhập.
        /// </summary>
        public DataTable GetChiTietYeuCau(long idYeuCau)
        {
            // Logic: SL_CON_LAI = SL_YEUCAU - SL_DA_NHAP (Tổng các phiếu nhập trước đó có ID_YEUCAU tương ứng)
            string sql = @"
                SELECT 
                   YC.MAHH, 
                   YC.SOLUONG_YEUCAU AS SL_GOC, 
                   (YC.SOLUONG_YEUCAU - ISNULL((SELECT SUM(CT.SL) 
                                    FROM PHIEU P JOIN PHIEU_CT CT ON P.SOPHIEU = CT.SOPHIEU 
                                    WHERE P.ID_YEUCAU = YC.ID_YEUCAU AND CT.MAHH = YC.MAHH AND P.TRANGTHAI = 1), 0)) AS SL_CON_LAI,
                   HH.DVT, HH.GIAVON, HH.TENHH
                FROM PHIEU_YEUCAU_NHAPKHO_CT YC
                JOIN DM_HANGHOA HH ON YC.MAHH = HH.MAHH
                WHERE YC.ID_YEUCAU = @Id";

            return DbHelper.Query(sql, DbHelper.Param("@Id", idYeuCau));
        }

        /// <summary>
        /// Lưu phiếu nhập transaction an toàn.
        /// Bao gồm: Phiếu, Chi tiết, Kho (FIFO), Định khoản, và Thanh toán (Tùy chọn).
        /// </summary>
        public long LuuPhieuNhap(DateTime ngayLap, string maNCC, string ghiChu, long idYeuCau, bool isThanhToan, List<PhieuNhapChiTietDTO> listChiTiet)
        {
            if (listChiTiet == null || listChiTiet.Count == 0)
                throw new ArgumentException("Danh sách hàng hóa rỗng.");

            decimal tongTien = 0;
            foreach (var item in listChiTiet) tongTien += item.ThanhTien;

            // ExecuteTran trả về int (số dòng), nhưng ta cần trả về SoPhieu (long). 
            // Ta dùng biến capture bên ngoài.
            long newSoPhieu = 0;

            DbHelper.ExecuteTran((conn, tran) =>
            {
                // 1. Insert PHIEU Header
                string sqlPhieu = @"INSERT INTO PHIEU (NGAYLAP, LOAI, MA_NCC, GHICHU, TRANGTHAI, ID_YEUCAU) 
                                    VALUES (@Ngay, 'N', @MaNCC, @GhiChu, 1, @IdYeuCau);
                                    SELECT SCOPE_IDENTITY();";

                object idYeuCauParam = idYeuCau > 0 ? (object)idYeuCau : DBNull.Value;

                object phieuIdObj = DbHelper.ScalarInTran(conn, tran, sqlPhieu,
                    DbHelper.Param("@Ngay", ngayLap),
                    DbHelper.Param("@MaNCC", maNCC),
                    DbHelper.Param("@GhiChu", ghiChu ?? (object)DBNull.Value),
                    DbHelper.Param("@IdYeuCau", idYeuCauParam)
                );

                newSoPhieu = Convert.ToInt64(phieuIdObj);

                // 2. Insert Details & Inventory Logic
                foreach (var item in listChiTiet)
                {
                    // a) Insert PHIEU_CT
                    string sqlChiTiet = @"INSERT INTO PHIEU_CT (SOPHIEU, MAHH, SL, DONGIA) 
                                          VALUES (@SoPhieu, @MaHH, @SL, @DonGia);
                                          SELECT SCOPE_IDENTITY();";

                    object ctIdObj = DbHelper.ScalarInTran(conn, tran, sqlChiTiet,
                        DbHelper.Param("@SoPhieu", newSoPhieu),
                        DbHelper.Param("@MaHH", item.MaHH),
                        DbHelper.Param("@SL", item.SoLuong),
                        DbHelper.Param("@DonGia", item.DonGia)
                    );

                    long idChiTiet = Convert.ToInt64(ctIdObj);

                    // b) Insert KHO_CHITIET_TONKHO (FIFO Tracking)
                    string sqlKho = @"INSERT INTO KHO_CHITIET_TONKHO (ID_PHIEUNHAP_CT, MAHH, NGAY_NHAP, SO_LUONG_NHAP, DON_GIA_NHAP, SO_LUONG_TON)
                                      VALUES (@IdCT, @MaHH, @Ngay, @SL, @DonGia, @SL)";

                    DbHelper.ExecuteInTran(conn, tran, sqlKho,
                        DbHelper.Param("@IdCT", idChiTiet),
                        DbHelper.Param("@MaHH", item.MaHH),
                        DbHelper.Param("@Ngay", ngayLap),
                        DbHelper.Param("@SL", item.SoLuong),
                        DbHelper.Param("@DonGia", item.DonGia)
                    );

                    // c) Update Gia Von (Latest Price)
                    string sqlUpdateGia = "UPDATE DM_HANGHOA SET GIAVON = @GiaMoi WHERE MAHH = @MaHH";
                    DbHelper.ExecuteInTran(conn, tran, sqlUpdateGia,
                         DbHelper.Param("@GiaMoi", item.DonGia),
                         DbHelper.Param("@MaHH", item.MaHH)
                    );
                }

                // 3. Update Request Status (Smart Logic)
                if (idYeuCau > 0)
                {
                    // Calculate Status
                    string sqlCheckStatus = @"
                        SELECT 
                            (SELECT SUM(SOLUONG_YEUCAU) FROM PHIEU_YEUCAU_NHAPKHO_CT WHERE ID_YEUCAU = @Id) AS TongYeuCau,
                            (SELECT ISNULL(SUM(CT.SL), 0) FROM PHIEU P JOIN PHIEU_CT CT ON P.SOPHIEU = CT.SOPHIEU WHERE P.ID_YEUCAU = @Id AND P.TRANGTHAI = 1) AS TongDaNhap
                    ";

                    DataTable dtStat = DbHelper.QueryInTran(conn, tran, sqlCheckStatus, DbHelper.Param("@Id", idYeuCau));
                    if (dtStat.Rows.Count > 0)
                    {
                        decimal tongYC = Convert.ToDecimal(dtStat.Rows[0]["TongYeuCau"]);
                        decimal tongDaNhap = Convert.ToDecimal(dtStat.Rows[0]["TongDaNhap"]); // Included current transaction because insert happened above

                        int newStatus = (tongDaNhap >= tongYC) ? 3 : 2;

                        DbHelper.ExecuteInTran(conn, tran,
                            "UPDATE PHIEU_YEUCAU_NHAPKHO SET TRANGTHAI = @Stt WHERE ID = @Id",
                            DbHelper.Param("@Stt", newStatus),
                            DbHelper.Param("@Id", idYeuCau));
                    }
                }

                // 4. Accounting (Double Entry Logic)
                // Step A: Record Inventory Receipt (ALWAYS: Debit 156 - Credit 331)
                // Reflects liability to Supplier upon receiving goods
                DbHelper.ExecuteInTran(conn, tran,
                    "INSERT INTO BUTTOAN_KETOAN (NGAY_HT, TK_NO, TK_CO, SOTIEN, DIEN_GIAI) VALUES (@Ngay, '156', '331', @Tien, @DienGiai)",
                    DbHelper.Param("@Ngay", ngayLap),
                    DbHelper.Param("@Tien", tongTien),
                    DbHelper.Param("@DienGiai", $"Nhập kho phiếu #{newSoPhieu}")
                );

                // Step B: Record Payment (ONLY IF isThanhToan == true)
                // Clears liability (Debit 331) and reduces Cash (Credit 111)
                if (isThanhToan)
                {
                    // 1. Create Payment Voucher (PHIEUTHUCHI)
                    string sqlChi = @"INSERT INTO PHIEUTHUCHI (NGAYLAP, LOAI, MA_NCC, SOTIEN, LYDO)
                                      VALUES (@Ngay, 'C', @MaNCC, @SoTien, @LyDo)";

                    DbHelper.ExecuteInTran(conn, tran, sqlChi,
                        DbHelper.Param("@Ngay", ngayLap),
                        DbHelper.Param("@MaNCC", maNCC),
                        DbHelper.Param("@SoTien", tongTien),
                        DbHelper.Param("@LyDo", $"Chi trả ngay cho phiếu nhập #{newSoPhieu}")
                    );

                    // 2. Accounting Entry for Payment (Nợ 331 - Có 111)
                    DbHelper.ExecuteInTran(conn, tran,
                        "INSERT INTO BUTTOAN_KETOAN (NGAY_HT, TK_NO, TK_CO, SOTIEN, DIEN_GIAI) VALUES (@Ngay, '331', '111', @Tien, @DienGiai)",
                        DbHelper.Param("@Ngay", ngayLap),
                        DbHelper.Param("@Tien", tongTien),
                        DbHelper.Param("@DienGiai", $"Thanh toán tiền nhập hàng phiếu #{newSoPhieu}")
                    );
                }

                return 1;
            });

            return newSoPhieu;
        }

        /// <summary>
        /// Lấy thông tin in phiếu.
        /// </summary>
        public DataTable GetPhieuPrintInfo(long soPhieu)
        {
            string sql = @"
                SELECT P.SOPHIEU, NCC.TEN_NCC, P.NGAYLAP, 
                       SUM(CT.SL * CT.DONGIA) as TONGTIEN,
                       P.GHICHU
                FROM PHIEU P
                JOIN DM_NHACUNGCAP NCC ON P.MA_NCC = NCC.MA_NCC
                JOIN PHIEU_CT CT ON P.SOPHIEU = CT.SOPHIEU
                WHERE P.SOPHIEU = @SoPhieu
                GROUP BY P.SOPHIEU, NCC.TEN_NCC, P.NGAYLAP, P.GHICHU";
            return DbHelper.Query(sql, DbHelper.Param("@SoPhieu", soPhieu));
        }
    }
}
