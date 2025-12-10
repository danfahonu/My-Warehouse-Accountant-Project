using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    // Lớp này dùng để chứa thông tin của người dùng sau khi đăng nhập thành công
    public class UserData
    {
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; } // Giữ lại mật khẩu để dùng cho chức năng đổi mật khẩu
        public string HoTen { get; set; }
        public string TenQuyen { get; set; }
        public string MaNV { get; set; } // === THÊM DÒNG NÀY ===
        // Thêm dòng này vào nè bà:
        public int MaQuyen { get; set; }
    }
}