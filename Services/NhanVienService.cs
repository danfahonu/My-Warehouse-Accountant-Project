using System;
using System.Data;
using System.Data.SqlClient;
using DoAnLapTrinhQuanLy.Data;

namespace DoAnLapTrinhQuanLy.Services
{
    public class NhanVienService
    {
        // 1. Lấy danh sách nhân viên
        public DataTable GetAll()
        {
            string sql = "SELECT MANV, HOTEN, CHUCVU, DIACHI, SDT, EMAIL, ANH, HOATDONG FROM NHANVIEN WHERE HOATDONG = 1 ORDER BY HOTEN";
            return DbHelper.Query(sql);
        }

        // 2. Lấy danh sách Chức vụ (để đổ vào ComboBox)
        public DataTable GetChucVu()
        {
            // Lấy cột CHUCVU từ bảng HESOLUONG làm danh sách chuẩn
            return DbHelper.Query("SELECT CHUCVU FROM HESOLUONG");
        }

        // 3. Thêm mới
        public void Add(string ma, string ten, string chucVu, string diaChi, string sdt, string email, byte[] anh)
        {
            string check = "SELECT COUNT(*) FROM NHANVIEN WHERE MANV = @Ma";
            if (Convert.ToInt32(DbHelper.ExecuteScalar(check, DbHelper.Param("@Ma", ma))) > 0)
                throw new Exception($"Mã nhân viên '{ma}' đã tồn tại!");

            string sql = @"INSERT INTO NHANVIEN (MANV, HOTEN, CHUCVU, DIACHI, SDT, EMAIL, ANH, HOATDONG) 
                           VALUES (@Ma, @Ten, @ChucVu, @DiaChi, @Sdt, @Email, @Anh, 1)";

            SqlParameter paramAnh = new SqlParameter("@Anh", SqlDbType.VarBinary);
            paramAnh.Value = (object)anh ?? DBNull.Value;

            DbHelper.Execute(sql,
                DbHelper.Param("@Ma", ma),
                DbHelper.Param("@Ten", ten),
                DbHelper.Param("@ChucVu", chucVu), // Giá trị từ ComboBox
                DbHelper.Param("@DiaChi", diaChi),
                DbHelper.Param("@Sdt", sdt),
                DbHelper.Param("@Email", email),
                paramAnh);
        }

        // 4. Cập nhật
        public void Update(string ma, string ten, string chucVu, string diaChi, string sdt, string email, byte[] anh)
        {
            string sql = @"UPDATE NHANVIEN 
                           SET HOTEN = @Ten, CHUCVU = @ChucVu, DIACHI = @DiaChi, SDT = @Sdt, EMAIL = @Email, ANH = @Anh
                           WHERE MANV = @Ma";

            SqlParameter paramAnh = new SqlParameter("@Anh", SqlDbType.VarBinary);
            paramAnh.Value = (object)anh ?? DBNull.Value;

            DbHelper.Execute(sql,
                DbHelper.Param("@Ten", ten),
                DbHelper.Param("@ChucVu", chucVu),
                DbHelper.Param("@DiaChi", diaChi),
                DbHelper.Param("@Sdt", sdt),
                DbHelper.Param("@Email", email),
                paramAnh,
                DbHelper.Param("@Ma", ma));
        }

        // 5. Xóa
        public void Delete(string ma)
        {
            DbHelper.Execute("UPDATE NHANVIEN SET HOATDONG = 0 WHERE MANV = @Ma", DbHelper.Param("@Ma", ma));
        }
    }
}