using System;
using System.Data;
using System.Data.SqlClient;
using DoAnLapTrinhQuanLy.Data;

namespace DoAnLapTrinhQuanLy.Services
{
    public class TongHopKhoService
    {
        private readonly NhomHangService _nhomHangService = new NhomHangService();
        private readonly HangHoaService _hangHoaService = new HangHoaService();

        // 1. Hỗ trợ Load ComboBox
        public DataTable GetNhomHang() => _nhomHangService.GetAll();
        public DataTable GetHangHoa() => _hangHoaService.GetAll();

        // 2. Báo cáo TỔNG HỢP TỒN KHO (Tab 1)
        public DataTable GetTongHopTonKho(DateTime tuNgay, DateTime denNgay, string maNhom)
        {
            string sql = @"
                WITH CTE_DATA AS (
                    SELECT 
                        ct.MAHH,
                        -- Tồn đầu: Trước ngày 'TuNgay'
                        SUM(CASE 
                            WHEN p.NGAYLAP < @Tu AND p.LOAI = 'N' THEN ct.SL 
                            WHEN p.NGAYLAP < @Tu AND p.LOAI = 'X' THEN -ct.SL 
                            ELSE 0 
                        END) AS TON_DAU,

                        -- Nhập trong kỳ
                        SUM(CASE 
                            WHEN p.NGAYLAP >= @Tu AND p.NGAYLAP <= @Den AND p.LOAI = 'N' THEN ct.SL 
                            ELSE 0 
                        END) AS NHAP,

                        -- Xuất trong kỳ
                        SUM(CASE 
                            WHEN p.NGAYLAP >= @Tu AND p.NGAYLAP <= @Den AND p.LOAI = 'X' THEN ct.SL 
                            ELSE 0 
                        END) AS XUAT
                    FROM PHIEU p
                    JOIN PHIEU_CT ct ON p.SOPHIEU = ct.SOPHIEU
                    WHERE p.TRANGTHAI = 1 
                      AND p.NGAYLAP <= @Den
                    GROUP BY ct.MAHH
                )
                SELECT 
                    h.MAHH, h.TENHH, h.DVT, nh.TENNHOM,
                    ISNULL(d.TON_DAU, 0) AS TON_DAU,
                    ISNULL(d.NHAP, 0) AS NHAP,
                    ISNULL(d.XUAT, 0) AS XUAT,
                    (ISNULL(d.TON_DAU, 0) + ISNULL(d.NHAP, 0) - ISNULL(d.XUAT, 0)) AS TON_CUOI,
                    (ISNULL(d.TON_DAU, 0) + ISNULL(d.NHAP, 0) - ISNULL(d.XUAT, 0)) * h.GIAVON AS GIATRI_TON
                FROM DM_HANGHOA h
                LEFT JOIN CTE_DATA d ON h.MAHH = d.MAHH
                LEFT JOIN DM_NHOMHANG nh ON h.MANHOM = nh.MANHOM
                WHERE h.ACTIVE = 1 
                  AND (@Nhom = 'ALL' OR h.MANHOM = @Nhom)
                ORDER BY h.TENHH";

            return DbHelper.Query(sql,
                DbHelper.Param("@Tu", tuNgay.Date),
                DbHelper.Param("@Den", denNgay.Date.AddDays(1).AddSeconds(-1)),
                DbHelper.Param("@Nhom", string.IsNullOrEmpty(maNhom) ? "ALL" : maNhom)
            );
        }

        // 3. Báo cáo CHI TIẾT NHẬP XUẤT (Tab 2)
        public DataTable GetBangKeNhapXuat(DateTime tuNgay, DateTime denNgay, string loaiPhieu)
        {
            string sql = @"
                SELECT 
                    p.SOPHIEU, 
                    p.NGAYLAP, 
                    CASE WHEN p.LOAI = 'N' THEN N'Nhập' ELSE N'Xuất' END AS LOAI,
                    h.TENHH, 
                    h.DVT, 
                    ct.SL AS SOLUONG, 
                    ct.DONGIA, 
                    ct.THANHTIEN,
                    ISNULL(ncc.TEN_NCC, kh.TENKH) AS DOI_TUONG
                FROM PHIEU p
                JOIN PHIEU_CT ct ON p.SOPHIEU = ct.SOPHIEU
                JOIN DM_HANGHOA h ON ct.MAHH = h.MAHH
                LEFT JOIN DM_NHACUNGCAP ncc ON p.MA_NCC = ncc.MA_NCC
                LEFT JOIN DANHMUCKHACHHANG kh ON p.MAKH = kh.MAKH
                WHERE p.TRANGTHAI = 1 
                  AND p.NGAYLAP >= @Tu AND p.NGAYLAP <= @Den
                  AND (@Loai = 'ALL' OR p.LOAI = @Loai)
                ORDER BY p.NGAYLAP DESC, p.SOPHIEU DESC";

            return DbHelper.Query(sql,
                DbHelper.Param("@Tu", tuNgay.Date),
                DbHelper.Param("@Den", denNgay.Date.AddDays(1).AddSeconds(-1)),
                DbHelper.Param("@Loai", loaiPhieu)
            );
        }

        // 4. Báo cáo THẺ KHO (Tab 3)
        public DataTable GetTheKho(string maHH, DateTime tuNgay, DateTime denNgay)
        {
            // A. Tồn đầu
            string sqlTonDau = @"
                SELECT ISNULL(SUM(CASE 
                    WHEN p.LOAI = 'N' THEN ct.SL 
                    WHEN p.LOAI = 'X' THEN -ct.SL 
                    ELSE 0 END), 0)
                FROM PHIEU p 
                JOIN PHIEU_CT ct ON p.SOPHIEU = ct.SOPHIEU
                WHERE ct.MAHH = @Ma 
                  AND p.NGAYLAP < @Tu 
                  AND p.TRANGTHAI = 1";

            decimal tonDau = Convert.ToDecimal(DbHelper.ExecuteScalar(sqlTonDau,
                DbHelper.Param("@Ma", maHH),
                DbHelper.Param("@Tu", tuNgay.Date)
            ));

            // B. Giao dịch
            string sqlGiaoDich = @"
                SELECT 
                    p.NGAYLAP, 
                    p.SOPHIEU, 
                    CASE WHEN p.LOAI = 'N' THEN N'Nhập kho' ELSE N'Xuất kho' END AS DIENGIAI,
                    CASE WHEN p.LOAI = 'N' THEN ct.SL ELSE 0 END AS NHAP,
                    CASE WHEN p.LOAI = 'X' THEN ct.SL ELSE 0 END AS XUAT
                FROM PHIEU p 
                JOIN PHIEU_CT ct ON p.SOPHIEU = ct.SOPHIEU
                WHERE ct.MAHH = @Ma 
                  AND p.NGAYLAP >= @Tu AND p.NGAYLAP <= @Den
                  AND p.TRANGTHAI = 1
                ORDER BY p.NGAYLAP ASC, p.SOPHIEU ASC";

            DataTable dt = DbHelper.Query(sqlGiaoDich,
                DbHelper.Param("@Ma", maHH),
                DbHelper.Param("@Tu", tuNgay.Date),
                DbHelper.Param("@Den", denNgay.Date.AddDays(1).AddSeconds(-1))
            );

            // C. Tính cột Tồn
            dt.Columns.Add("TON_LUY_KE", typeof(decimal));

            DataRow rDau = dt.NewRow();
            rDau["NGAYLAP"] = tuNgay.Date;
            rDau["SOPHIEU"] = "";
            rDau["DIENGIAI"] = "Số dư đầu kỳ";
            rDau["NHAP"] = 0;
            rDau["XUAT"] = 0;
            rDau["TON_LUY_KE"] = tonDau;
            dt.Rows.InsertAt(rDau, 0);

            decimal runningBalance = tonDau;
            for (int i = 1; i < dt.Rows.Count; i++)
            {
                decimal nhap = Convert.ToDecimal(dt.Rows[i]["NHAP"]);
                decimal xuat = Convert.ToDecimal(dt.Rows[i]["XUAT"]);
                runningBalance = runningBalance + nhap - xuat;
                dt.Rows[i]["TON_LUY_KE"] = runningBalance;
            }

            return dt;
        }
    }
}