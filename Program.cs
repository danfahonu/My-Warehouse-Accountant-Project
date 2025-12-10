using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Data;
using DoAnLapTrinhQuanLy.GuiLayer; // <--- QUAN TRỌNG: Phải có dòng này để thấy FormMain

namespace DoAnLapTrinhQuanLy
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1. Kiểm tra kết nối CSDL trước tiên
            if (!CheckDatabaseConnection())
            {
                FormKetNoiCSDL frmConfig = new FormKetNoiCSDL();
                if (frmConfig.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
            }

            // 2. Mở Form Đăng Nhập
            FormDangNhap frmLogin = new FormDangNhap();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                // 3. Đăng nhập thành công -> Mở Form Main
                // SỬA LỖI Ở ĐÂY: FormMain chứ không phải FromMain
                Application.Run(new FormMain());
            }
            else
            {
                Application.Exit();
            }
        }

        static bool CheckDatabaseConnection()
        {
            try
            {
                DbHelper.ReloadConnectionString();
                using (var conn = new SqlConnection(DbHelper.ConnectionString))
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}