using System;
using System.Configuration; // Nhớ Add Reference System.Configuration
using System.Data.SqlClient;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Data; // Để gọi DbHelper.ReloadConnectionString()

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormKetNoiCSDL : Form
    {
        public FormKetNoiCSDL()
        {
            InitializeComponent();
        }

        private void chkWindows_CheckedChanged(object sender, EventArgs e)
        {
            // Nếu chọn Windows Auth thì khóa nhập User/Pass
            txtUser.Enabled = !chkWindows.Checked;
            txtPass.Enabled = !chkWindows.Checked;
        }

        // Hàm tạo chuỗi kết nối từ giao diện
        private string GetConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = txtServer.Text.Trim(); // Server
            builder.InitialCatalog = txtDb.Text.Trim(); // Database

            if (chkWindows.Checked)
            {
                builder.IntegratedSecurity = true;
            }
            else
            {
                builder.IntegratedSecurity = false;
                builder.UserID = txtUser.Text.Trim();
                builder.Password = txtPass.Text.Trim();
            }
            // Fix lỗi SSL trên SQL Server bản mới
            builder.TrustServerCertificate = true;

            return builder.ConnectionString;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    conn.Open(); // Thử mở kết nối
                    MessageBox.Show("Kết nối thành công! 🎉", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = GetConnectionString();

                // 1. Thử kết nối lần cuối cho chắc
                using (SqlConnection conn = new SqlConnection(connectionString)) conn.Open();

                // 2. Lưu vào file App.config
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                // Xóa key cũ nếu có
                if (config.ConnectionStrings.ConnectionStrings["Db"] != null)
                    config.ConnectionStrings.ConnectionStrings.Remove("Db");

                // Thêm key mới
                config.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings("Db", connectionString, "System.Data.SqlClient"));

                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("connectionStrings");

                // 3. Báo cho DbHelper biết để load lại
                DbHelper.ReloadConnectionString();

                MessageBox.Show("Đã lưu cấu hình! Ứng dụng sẽ khởi động.", "Thành công");
                this.DialogResult = DialogResult.OK; // Báo OK để Program.cs biết đường chạy tiếp
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu cấu hình: " + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}