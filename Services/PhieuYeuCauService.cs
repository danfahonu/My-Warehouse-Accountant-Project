using System;
using System.Data;
using System.Data.SqlClient;
using DoAnLapTrinhQuanLy.Data;

namespace DoAnLapTrinhQuanLy.Services
{
    public class PhieuYeuCauService
    {
        /// <summary>
        /// Lấy danh sách phiếu yêu cầu đã duyệt theo khoảng thời gian.
        /// Logic cũ: TRANGTHAI = 2 (Đã duyệt).
        /// </summary>
        public DataTable GetDanhSachDaDuyet(DateTime tuNgay, DateTime denNgay)
        {
            try
            {
                string sql = @"
                    SELECT 
                        t.ID, 
                        t.NGAY_YEUCAU, 
                        n.HOTEN AS NGUOI_YEU_CAU, 
                        t.LYDO,
                        CASE 
                            WHEN t.TRANGTHAI = 1 THEN N'Đã duyệt' 
                            WHEN t.TRANGTHAI = 2 THEN N'Đang nhập dở'
                            ELSE N'Khác' 
                        END AS TRANGTHAI_TEXT
                    FROM PHIEU_YEUCAU_NHAPKHO t
                    LEFT JOIN NHANVIEN n ON t.MANV_YEUCAU = n.MANV
                    WHERE t.TRANGTHAI IN (1, 2) 
                    AND t.NGAY_YEUCAU BETWEEN @TuNgay AND @DenNgay
                    ORDER BY t.NGAY_YEUCAU DESC";

                // Ensure strict Date boundaries if time is involved
                return DbHelper.Query(sql,
                    DbHelper.Param("@TuNgay", tuNgay),
                    DbHelper.Param("@DenNgay", denNgay));
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi lấy danh sách phiếu yêu cầu: " + ex.Message);
            }
        }
    }
}
