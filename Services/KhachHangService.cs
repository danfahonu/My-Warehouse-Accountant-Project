using System;
using System.Data;
using System.Data.SqlClient;
using DoAnLapTrinhQuanLy.Data; // Sử dụng DbHelper Xịn

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
        public void Add(string ma, string ten, string sdt, string diachi, string email, string ghichu)
        {
            // Kiểm tra trùng mã
            string checkSql = "SELECT COUNT(*) FROM DANHMUCKHACHHANG WHERE MAKH = @Ma";
            int count = Convert.ToInt32(DbHelper.ExecuteScalar(checkSql, DbHelper.Param("@Ma", ma)));

            if (count > 0) throw new Exception($"Mã khách hàng '{ma}' đã tồn tại!");

            string sql = @"INSERT INTO DANHMUCKHACHHANG (MAKH, TENKH, SDT, DIACHI, EMAIL, GHICHU, NGAYTAO) 
                           VALUES (@Ma, @Ten, @Sdt, @DiaChi, @Email, @GhiChu, GETDATE())";

            DbHelper.Execute(sql,
                DbHelper.Param("@Ma", ma),
                DbHelper.Param("@Ten", ten),
                DbHelper.Param("@Sdt", sdt),
                DbHelper.Param("@DiaChi", diachi),
                DbHelper.Param("@Email", email ?? ""),
                DbHelper.Param("@GhiChu", ghichu ?? "")
            );
        }

        // 3. Cập nhật (Update)
        public void Update(string ma, string ten, string sdt, string diachi, string email, string ghichu)
        {
            string sql = @"UPDATE DANHMUCKHACHHANG 
                           SET TENKH = @Ten, 
                               SDT = @Sdt, 
                               DIACHI = @DiaChi, 
                               EMAIL = @Email, 
                               GHICHU = @GhiChu 
                           WHERE MAKH = @Ma";

            DbHelper.Execute(sql,
                DbHelper.Param("@Ma", ma),
                DbHelper.Param("@Ten", ten),
                DbHelper.Param("@Sdt", sdt),
                DbHelper.Param("@DiaChi", diachi),
                DbHelper.Param("@Email", email ?? ""),
                DbHelper.Param("@GhiChu", ghichu ?? "")
            );
        }

        // 4. Xóa (Delete) - ĐÃ SỬA LOGIC KIỂM TRA
        public void Delete(string ma)
        {
            // Kiểm tra xem khách hàng này có trong bảng PHIEU không?
            // (Dựa trên cấu trúc bảng PHIEU: SOPHIEU, NGAYLAP, ..., MAKH)
            string checkSql = "SELECT COUNT(*) FROM PHIEU WHERE MAKH = @Ma";

            int count = Convert.ToInt32(DbHelper.ExecuteScalar(checkSql, DbHelper.Param("@Ma", ma)));

            if (count > 0)
            {
                throw new Exception($"Khách hàng này đã có {count} phiếu giao dịch. Không thể xóa!");
            }

            // Nếu không có phiếu nào thì xóa
            string sql = "DELETE FROM DANHMUCKHACHHANG WHERE MAKH = @Ma";
            DbHelper.Execute(sql, DbHelper.Param("@Ma", ma));
        }

        // 5. Tìm kiếm
        public DataTable Search(string keyword)
        {
            string sql = "SELECT * FROM DANHMUCKHACHHANG WHERE TENKH LIKE @Key OR SDT LIKE @Key OR EMAIL LIKE @Key";
            return DbHelper.Query(sql, DbHelper.Param("@Key", "%" + keyword + "%"));
        }
    }
}