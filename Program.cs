using System;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.GuiLayer;
using DoAnLapTrinhQuanLy.Data; // Để dùng Session nếu cần

namespace DoAnLapTrinhQuanLy
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormDangNhap frmLogin = new FormDangNhap();

            // Nếu đăng nhập thành công
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                // KHÔNG CẦN TRUYỀN USER NỮA (Vì FormDangNhap đã lưu vào Session rồi)
                // Sửa dòng này lại thành:
                Application.Run(new FrmMain());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}