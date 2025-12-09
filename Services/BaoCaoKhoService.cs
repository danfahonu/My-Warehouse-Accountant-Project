using System;
using System.Data;
using DoAnLapTrinhQuanLy.Data;

namespace DoAnLapTrinhQuanLy.Services
{
    public class BaoCaoKhoService
    {
        // Hàm lấy báo cáo Nhập Xuất Tồn theo khoảng thời gian
        public DataTable GetNhapXuatTon(DateTime tuNgay, DateTime denNgay)
        {
            // Logic:
            // 1. Tính Tồn Đầu: Tổng Nhập - Tổng Xuất (của các phiếu TRƯỚC ngày bắt đầu)
            // 2. Tính Nhập/Xuất Trong Kỳ: Tổng theo loại phiếu TRONG khoảng thời gian

            string sql = @"
                SELECT 
                    h.MAHH, h.TENHH, h.DVT,
                    
                    -- Tính Tồn Đầu (Trước ngày TuNgay)
                    ISNULL((SELECT SUM(CASE WHEN p.LOAI = 'N' THEN d.SL ELSE -d.SL END)
                            FROM PHIEU p JOIN PHIEU_CT d ON p.SOPHIEU = d.SOPHIEU
                            WHERE d.MAHH = h.MAHH AND p.NGAYLAP < @TuNgay AND p.TRANGTHAI = 1), 0) AS DAUKY,

                    -- Tính Nhập Trong Kỳ
                    ISNULL((SELECT SUM(d.SL)
                            FROM PHIEU p JOIN PHIEU_CT d ON p.SOPHIEU = d.SOPHIEU
                            WHERE d.MAHH = h.MAHH AND p.LOAI = 'N' 
                            AND p.NGAYLAP BETWEEN @TuNgay AND @DenNgay AND p.TRANGTHAI = 1), 0) AS NHAP,

                    -- Tính Xuất Trong Kỳ
                    ISNULL((SELECT SUM(d.SL)
                            FROM PHIEU p JOIN PHIEU_CT d ON p.SOPHIEU = d.SOPHIEU
                            WHERE d.MAHH = h.MAHH AND p.LOAI = 'X' 
                            AND p.NGAYLAP BETWEEN @TuNgay AND @DenNgay AND p.TRANGTHAI = 1), 0) AS XUAT

                FROM DM_HANGHOA h
                WHERE h.ACTIVE = 1
                ORDER BY h.TENHH";

            // Lưu ý: Param @DenNgay cần cộng thêm 1 ngày để lấy hết cuối ngày
            return DbHelper.Query(sql,
                DbHelper.Param("@TuNgay", tuNgay.Date),
                DbHelper.Param("@DenNgay", denNgay.Date.AddDays(1).AddSeconds(-1)));
        }
    }
}