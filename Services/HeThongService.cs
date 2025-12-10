using System;
using System.Data;
using System.Data.SqlClient;
using DoAnLapTrinhQuanLy.Data;

namespace DoAnLapTrinhQuanLy.Services
{
    public class HeThongService
    {
        // 1. Kiểm tra đăng nhập
        public bool CheckLogin(string user, string pass)
        {
            string sql = "SELECT COUNT(*) FROM HT_TAIKHOAN WHERE USERNAME = @User AND PASSWORD = @Pass AND ACTIVE = 1";
            // Lưu ý: Thực tế nên mã hóa pass (MD5/SHA), ở đây làm demo tui để text trần
            int kq = Convert.ToInt32(DbHelper.ExecuteScalar(sql,
                DbHelper.Param("@User", user),
                DbHelper.Param("@Pass", pass)));
            return kq > 0;
        }

        // 2. Lấy thông tin user
        public DataRow GetUser(string user)
        {
            DataTable dt = DbHelper.Query("SELECT * FROM HT_TAIKHOAN WHERE USERNAME = @User", DbHelper.Param("@User", user));
            if (dt.Rows.Count > 0) return dt.Rows[0];
            return null;
        }

        // 3. Đổi mật khẩu
        public void ChangePassword(string user, string oldPass, string newPass)
        {
            if (!CheckLogin(user, oldPass)) throw new Exception("Mật khẩu cũ không đúng!");
            DbHelper.Execute("UPDATE HT_TAIKHOAN SET PASSWORD = @New WHERE USERNAME = @User",
                DbHelper.Param("@New", newPass), DbHelper.Param("@User", user));
        }

        // 4. Lấy danh sách (Cho Admin)
        public DataTable GetAllUsers()
        {
            return DbHelper.Query("SELECT USERNAME, FULLNAME, ROLE, MANV, ACTIVE FROM HT_TAIKHOAN");
        }

        // 5. Lưu User (Thêm/Sửa)
        public void SaveUser(string user, string pass, string name, string role, string manv, bool active, bool isAdd)
        {
            if (isAdd)
            {
                if (Convert.ToInt32(DbHelper.ExecuteScalar("SELECT COUNT(*) FROM HT_TAIKHOAN WHERE USERNAME=@U", DbHelper.Param("@U", user))) > 0)
                    throw new Exception("Tên đăng nhập đã tồn tại!");

                string sql = "INSERT INTO HT_TAIKHOAN (USERNAME, PASSWORD, FULLNAME, ROLE, MANV, ACTIVE) VALUES (@U, @P, @N, @R, @M, @A)";
                DbHelper.Execute(sql,
                    DbHelper.Param("@U", user), DbHelper.Param("@P", pass),
                    DbHelper.Param("@N", name), DbHelper.Param("@R", role),
                    DbHelper.Param("@M", manv), DbHelper.Param("@A", active));
            }
            else
            {
                string sql = "UPDATE HT_TAIKHOAN SET FULLNAME=@N, ROLE=@R, MANV=@M, ACTIVE=@A WHERE USERNAME=@U";
                DbHelper.Execute(sql,
                     DbHelper.Param("@N", name), DbHelper.Param("@R", role),
                     DbHelper.Param("@M", manv), DbHelper.Param("@A", active),
                     DbHelper.Param("@U", user));

                // Nếu có nhập pass mới thì update riêng
                if (!string.IsNullOrEmpty(pass))
                    DbHelper.Execute("UPDATE HT_TAIKHOAN SET PASSWORD=@P WHERE USERNAME=@U", DbHelper.Param("@P", pass), DbHelper.Param("@U", user));
            }
        }

        // 6. Xóa User
        public void DeleteUser(string user)
        {
            if (user.ToLower() == "admin") throw new Exception("Không được xóa Admin!");
            DbHelper.Execute("DELETE FROM HT_TAIKHOAN WHERE USERNAME=@U", DbHelper.Param("@U", user));
        }

        public DataTable GetNhanVien() => DbHelper.Query("SELECT MANV, HOTEN FROM NHANVIEN WHERE HOATDONG=1");
    }
}