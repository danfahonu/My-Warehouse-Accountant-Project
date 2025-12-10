namespace DoAnLapTrinhQuanLy.GuiLayer
{
    partial class FormKetNoiCSDL
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.lblServer = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lblDb = new System.Windows.Forms.Label();
            this.txtDb = new System.Windows.Forms.TextBox();
            this.grpAuth = new System.Windows.Forms.GroupBox();
            this.chkWindows = new System.Windows.Forms.CheckBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();

            this.grpAuth.SuspendLayout();
            this.SuspendLayout();

            // Form Settings
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 380);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Name = "FormKetNoiCSDL";
            this.Text = "Cấu Hình Kết Nối Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // 1. Server Name
            this.lblServer.Text = "Tên Server (Máy chủ):"; this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(30, 20);
            this.txtServer.Location = new System.Drawing.Point(30, 45); this.txtServer.Size = new System.Drawing.Size(340, 25);
            this.txtServer.Text = ".\\SQLEXPRESS"; // Gợi ý mặc định

            // 2. Database Name
            this.lblDb.Text = "Tên Cơ Sở Dữ Liệu:"; this.lblDb.AutoSize = true;
            this.lblDb.Location = new System.Drawing.Point(30, 80);
            this.txtDb.Location = new System.Drawing.Point(30, 105); this.txtDb.Size = new System.Drawing.Size(340, 25);
            this.txtDb.Text = "SALEGEARVN";

            // 3. Auth Group
            this.grpAuth.Text = "Thông tin đăng nhập";
            this.grpAuth.Location = new System.Drawing.Point(30, 140); this.grpAuth.Size = new System.Drawing.Size(340, 160);

            this.chkWindows.Text = "Xác thực Windows (Không cần Pass)"; this.chkWindows.AutoSize = true;
            this.chkWindows.Location = new System.Drawing.Point(20, 30);
            this.chkWindows.CheckedChanged += new System.EventHandler(this.chkWindows_CheckedChanged);

            this.lblUser.Text = "User (Tài khoản):"; this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(20, 65);
            this.txtUser.Location = new System.Drawing.Point(20, 90); this.txtUser.Size = new System.Drawing.Size(300, 25);
            this.txtUser.Text = "sa";

            this.lblPass.Text = "Password (Mật khẩu):"; this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(20, 120); // Dịch xuống xíu tránh đè
            this.txtPass.Location = new System.Drawing.Point(140, 117); this.txtPass.Size = new System.Drawing.Size(180, 25);
            this.txtPass.PasswordChar = '*';

            this.grpAuth.Controls.Add(this.chkWindows);
            this.grpAuth.Controls.Add(this.lblUser); this.grpAuth.Controls.Add(this.txtUser);
            this.grpAuth.Controls.Add(this.lblPass); this.grpAuth.Controls.Add(this.txtPass);

            // Buttons
            this.btnTest.Text = "Kiểm Tra"; this.btnTest.Location = new System.Drawing.Point(30, 320); this.btnTest.Size = new System.Drawing.Size(100, 35);
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnTest.BackColor = System.Drawing.Color.Teal; this.btnTest.ForeColor = System.Drawing.Color.White;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);

            this.btnSave.Text = "Lưu & Kết Nối"; this.btnSave.Location = new System.Drawing.Point(140, 320); this.btnSave.Size = new System.Drawing.Size(120, 35);
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnSave.BackColor = System.Drawing.Color.RoyalBlue; this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnExit.Text = "Thoát"; this.btnExit.Location = new System.Drawing.Point(270, 320); this.btnExit.Size = new System.Drawing.Size(100, 35);
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnExit.BackColor = System.Drawing.Color.Gray; this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            this.Controls.Add(this.lblServer); this.Controls.Add(this.txtServer);
            this.Controls.Add(this.lblDb); this.Controls.Add(this.txtDb);
            this.Controls.Add(this.grpAuth);
            this.Controls.Add(this.btnTest); this.Controls.Add(this.btnSave); this.Controls.Add(this.btnExit);

            this.grpAuth.ResumeLayout(false); this.grpAuth.PerformLayout();
            this.ResumeLayout(false); this.PerformLayout();
        }

        private System.Windows.Forms.Label lblServer, lblDb, lblUser, lblPass;
        private System.Windows.Forms.TextBox txtServer, txtDb, txtUser, txtPass;
        private System.Windows.Forms.GroupBox grpAuth;
        private System.Windows.Forms.CheckBox chkWindows;
        private System.Windows.Forms.Button btnTest, btnSave, btnExit;
    }
}