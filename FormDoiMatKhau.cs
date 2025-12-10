using System;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Services;
using DoAnLapTrinhQuanLy.Core; // Để lấy User đang login

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormDoiMatKhau : Form
    {
        private readonly HeThongService _service = new HeThongService();

        public FormDoiMatKhau()
        {
            InitializeComponent();
            // 3 DÒNG THẦN THÁNH
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMoi.Text != txtXacNhan.Text) { MessageBox.Show("Mật khẩu xác nhận không khớp!"); return; }
            if (txtMoi.Text.Length < 3) { MessageBox.Show("Mật khẩu quá ngắn!"); return; }

            try
            {
                // Giả sử có class Session lưu user đang login
                // string currentUser = Session.CurrentUser.Username; 
                string currentUser = "admin"; // Tạm thời hardcode để test nếu chưa có Session

                _service.ChangePassword(currentUser, txtCu.Text, txtMoi.Text);
                MessageBox.Show("Đổi mật khẩu thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}