using System;
using System.Data;
using DoAnLapTrinhQuanLy.Data;

namespace DoAnLapTrinhQuanLy.Services
{
    public class NhomHangService
    {
        // 1. Lấy tất cả
        public DataTable GetAll()
        {
            string sql = "SELECT * FROM DM_NHOMHANG ORDER BY TENNHOM";
            return DbHelper.Query(sql);
        }

        // 2. Thêm
        public bool Add(string ma, string ten, string ghiChu)
        {
            // Check trùng mã
            string check = "SELECT COUNT(*) FROM DM_NHOMHANG WHERE MANHOM = @Ma";
            if (Convert.ToInt32(DbHelper.Scalar(check, DbHelper.Param("@Ma", ma))) > 0)
                throw new Exception($"Mã nhóm '{ma}' đã tồn tại!");

            string sql = @"INSERT INTO DM_NHOMHANG (MANHOM, TENNHOM, GHICHU) 
                           VALUES (@Ma, @Ten, @GhiChu)";

            return DbHelper.Execute(sql,
                DbHelper.Param("@Ma", ma),
                DbHelper.Param("@Ten", ten),
                DbHelper.Param("@GhiChu", ghiChu)) > 0;
        }

        // 3. Sửa
        public bool Update(string ma, string ten, string ghiChu)
        {
            string sql = @"UPDATE DM_NHOMHANG 
                           SET TENNHOM = @Ten, GHICHU = @GhiChu 
                           WHERE MANHOM = @Ma";

            return DbHelper.Execute(sql,
                DbHelper.Param("@Ten", ten),
                DbHelper.Param("@GhiChu", ghiChu),
                DbHelper.Param("@Ma", ma)) > 0;
        }

        // 4. Xóa
        public bool Delete(string ma)
        {
            // Kiểm tra xem nhóm này có hàng hóa nào không
            string check = "SELECT COUNT(*) FROM DM_HANGHOA WHERE MANHOM = @Ma";
            int count = Convert.ToInt32(DbHelper.Scalar(check, DbHelper.Param("@Ma", ma)));

            if (count > 0) throw new Exception($"Nhóm hàng này đang chứa {count} sản phẩm. Không thể xóa!");

            string sql = "DELETE FROM DM_NHOMHANG WHERE MANHOM = @Ma";
            return DbHelper.Execute(sql, DbHelper.Param("@Ma", ma)) > 0;
        }
    }
}