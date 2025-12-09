using System;
using System.Data;
using System.Data.SqlClient;
using DoAnLapTrinhQuanLy.Data;

namespace DoAnLapTrinhQuanLy.Services
{
    public class NhanVienService
    {
        // 1. Lấy danh sách
        public DataTable GetAll()
        {
            string sql = "SELECT MANV, HOTEN, CHUCVU, DIACHI, SDT, EMAIL, ANH, HOATDONG FROM NHANVIEN WHERE HOATDONG = 1 ORDER BY HOTEN";
            return DbHelper.Query(sql);
        }

        // 2. Thêm mới (Có hình ảnh)
        public bool Add(string ma, string ten, string chucVu, string diaChi, string sdt, string email, byte[] anh)
        {
            // Check trùng mã
            string check = "SELECT COUNT(*) FROM NHANVIEN WHERE MANV = @Ma";
            if (Convert.ToInt32(DbHelper.Scalar(check, DbHelper.Param("@Ma", ma))) > 0)
                throw new Exception($"Mã nhân viên '{ma}' đã tồn tại!");

            string sql = @"INSERT INTO NHANVIEN (MANV, HOTEN, CHUCVU, DIACHI, SDT, EMAIL, ANH, HOATDONG) 
                           VALUES (@Ma, @Ten, @ChucVu, @DiaChi, @Sdt, @Email, @Anh, 1)";

            SqlParameter paramAnh = new SqlParameter("@Anh", SqlDbType.VarBinary);
            if (anh != null) paramAnh.Value = anh;
            else paramAnh.Value = DBNull.Value;

            return DbHelper.Execute(sql,
                DbHelper.Param("@Ma", ma),
                DbHelper.Param("@Ten", ten),
                DbHelper.Param("@ChucVu", chucVu),
                DbHelper.Param("@DiaChi", diaChi),
                DbHelper.Param("@Sdt", sdt),
                DbHelper.Param("@Email", email),
                paramAnh) > 0;
        }

        // 3. Cập nhật
        public bool Update(string ma, string ten, string chucVu, string diaChi, string sdt, string email, byte[] anh)
        {
            string sql = @"UPDATE NHANVIEN 
                           SET HOTEN = @Ten, CHUCVU = @ChucVu, DIACHI = @DiaChi, SDT = @Sdt, EMAIL = @Email, ANH = @Anh
                           WHERE MANV = @Ma";

            SqlParameter paramAnh = new SqlParameter("@Anh", SqlDbType.VarBinary);
            if (anh != null) paramAnh.Value = anh;
            else paramAnh.Value = DBNull.Value;

            return DbHelper.Execute(sql,
                DbHelper.Param("@Ten", ten),
                DbHelper.Param("@ChucVu", chucVu),
                DbHelper.Param("@DiaChi", diaChi),
                DbHelper.Param("@Sdt", sdt),
                DbHelper.Param("@Email", email),
                paramAnh,
                DbHelper.Param("@Ma", ma)) > 0;
        }

        // 4. Xóa (Soft Delete - Update HOATDONG = 0)
        public bool Delete(string ma)
        {
            // Xóa mềm
            string sql = "UPDATE NHANVIEN SET HOATDONG = 0 WHERE MANV = @Ma";
            return DbHelper.Execute(sql, DbHelper.Param("@Ma", ma)) > 0;
        }
    }
}