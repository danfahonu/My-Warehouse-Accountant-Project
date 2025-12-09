using System;
using System.Data;
using System.Data.SqlClient;
using DoAnLapTrinhQuanLy.Data; // Chứa DbHelper

namespace DoAnLapTrinhQuanLy.Services
{
    public class KhachHangService
    {
        // 1. Lấy danh sách (GetAll)
        public DataTable GetAll()
        {
            string sql = "SELECT * FROM DANHMUCKHACHHANG ORDER BY TENKH";
            return DbHelper.Query(sql);
        }

        // 2. Thêm mới (Add)
        public bool Add(string ma, string ten, string sdt, string diachi)
        {
            // Kiểm tra trùng mã
            string checkSql = "SELECT COUNT(*) FROM DANHMUCKHACHHANG WHERE MAKH = @Ma";
            int count = Convert.ToInt32(DbHelper.Scalar(checkSql, DbHelper.Param("@Ma", ma)));
            if (count > 0) throw new Exception($"Mã khách hàng '{ma}' đã tồn tại!");

            string sql = @"INSERT INTO DANHMUCKHACHHANG (MAKH, TENKH, SDT, DIACHI, ACTIVE) 
                           VALUES (@Ma, @Ten, @Sdt, @Diachi, 1)";

            return DbHelper.Execute(sql,
                DbHelper.Param("@Ma", ma),
                DbHelper.Param("@Ten", ten),
                DbHelper.Param("@Sdt", sdt),
                DbHelper.Param("@Diachi", diachi)
            ) > 0;
        }

        // 3. Cập nhật (Update)
        public bool Update(string ma, string ten, string sdt, string diachi)
        {
            string sql = @"UPDATE DANHMUCKHACHHANG 
                           SET TENKH = @Ten, SDT = @Sdt, DIACHI = @Diachi 
                           WHERE MAKH = @Ma";

            return DbHelper.Execute(sql,
                DbHelper.Param("@Ten", ten),
                DbHelper.Param("@Sdt", sdt),
                DbHelper.Param("@Diachi", diachi),
                DbHelper.Param("@Ma", ma)
            ) > 0;
        }

        // 4. Xóa (Delete)
        public bool Delete(string ma)
        {
            // Kiểm tra xem khách đã có giao dịch chưa (tránh lỗi khóa ngoại)
            string checkSql = "SELECT COUNT(*) FROM PHIEU WHERE MAKH = @Ma";
            int count = Convert.ToInt32(DbHelper.Scalar(checkSql, DbHelper.Param("@Ma", ma)));
            if (count > 0)
            {
                throw new Exception($"Khách hàng này đã có {count} phiếu giao dịch. Không thể xóa!");
            }

            string sql = "DELETE FROM DANHMUCKHACHHANG WHERE MAKH = @Ma";
            return DbHelper.Execute(sql, DbHelper.Param("@Ma", ma)) > 0;
        }
    }
}