using System;
using System.Data;
using System.Data.SqlClient;
using DoAnLapTrinhQuanLy.Data;

namespace DoAnLapTrinhQuanLy.Services
{
    /// <summary>
    /// Service xử lý nghiệp vụ cho Danh mục Nhóm Hàng.
    /// Chịu trách nhiệm toàn bộ các thao tác với CSDL.
    /// </summary>
    public class NhomHangService
    {
        /// <summary>
        /// Lấy danh sách nhóm hàng, sắp xếp theo tên.
        /// </summary>
        /// <returns>DataTable chứa MANHOM, TENNHOM, GHICHU</returns>
        public DataTable LayDanhSach()
        {
            // Truy vấn đơn giản, lấy tất cả cột cần thiết
            string sql = "SELECT MANHOM, TENNHOM, GHICHU FROM DM_NHOMHANG ORDER BY TENNHOM";
            return DbHelper.Query(sql);
        }

        /// <summary>
        /// Thêm mới nhóm hàng.
        /// </summary>
        /// <param name="ma">Mã nhóm (PK)</param>
        /// <param name="ten">Tên nhóm</param>
        /// <param name="ghiChu">Ghi chú</param>
        /// <returns>True nếu thành công</returns>
        public bool Them(string ma, string ten, string ghiChu)
        {
            // 1. Kiểm tra tồn tại
            string checkSql = "SELECT COUNT(*) FROM DM_NHOMHANG WHERE MANHOM = @Ma";
            int count = Convert.ToInt32(DbHelper.Scalar(checkSql, DbHelper.Param("@Ma", ma)));
            if (count > 0)
                throw new Exception($"Mã nhóm '{ma}' đã tồn tại trong hệ thống.");

            // 2. Thực hiện Insert
            string sql = @"INSERT INTO DM_NHOMHANG (MANHOM, TENNHOM, GHICHU) 
                           VALUES (@Ma, @Ten, @GhiChu)";

            return DbHelper.Execute(sql,
                DbHelper.Param("@Ma", ma),
                DbHelper.Param("@Ten", ten),
                DbHelper.Param("@GhiChu", ghiChu ?? (object)DBNull.Value)
            ) > 0;
        }

        /// <summary>
        /// Cập nhật thông tin nhóm hàng.
        /// </summary>
        /// <param name="ma">Mã nhóm (Không được sửa)</param>
        /// <param name="ten">Tên nhóm mới</param>
        /// <param name="ghiChu">Ghi chú mới</param>
        /// <returns>True nếu thành công</returns>
        public bool Sua(string ma, string ten, string ghiChu)
        {
            // Update dựa theo khóa chính
            string sql = @"UPDATE DM_NHOMHANG 
                           SET TENNHOM = @Ten, GHICHU = @GhiChu 
                           WHERE MANHOM = @Ma";

            return DbHelper.Execute(sql,
                DbHelper.Param("@Ten", ten),
                DbHelper.Param("@GhiChu", ghiChu ?? (object)DBNull.Value),
                DbHelper.Param("@Ma", ma)
            ) > 0;
        }

        /// <summary>
        /// Xóa nhóm hàng.
        /// </summary>
        /// <param name="ma">Mã nhóm cần xóa</param>
        /// <returns>True nếu thành công</returns>
        public bool Xoa(string ma)
        {
            // 1. Kiểm tra sử dụng (Ràng buộc FK)
            string checkSql = "SELECT COUNT(*) FROM DM_HANGHOA WHERE MANHOM = @Ma";
            int count = Convert.ToInt32(DbHelper.Scalar(checkSql, DbHelper.Param("@Ma", ma)));
            if (count > 0)
                throw new Exception($"Không thể xóa nhóm '{ma}' vì đang có {count} hàng hóa trực thuộc.");

            // 2. Thực hiện Delete
            string sql = "DELETE FROM DM_NHOMHANG WHERE MANHOM = @Ma";
            return DbHelper.Execute(sql, DbHelper.Param("@Ma", ma)) > 0;
        }
    }
}
