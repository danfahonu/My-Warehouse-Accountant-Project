namespace DoAnLapTrinhQuanLy.GuiLayer
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnHeThong = new System.Windows.Forms.Button();
            this.btnCongNo = new System.Windows.Forms.Button();
            this.btnThuChi = new System.Windows.Forms.Button();
            this.btnTonKho = new System.Windows.Forms.Button();
            this.btnXuatKho = new System.Windows.Forms.Button();
            this.btnNhapKho = new System.Windows.Forms.Button();
            this.btnYeuCau = new System.Windows.Forms.Button();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblAppName = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();

            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();

            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Name = "FormMain";
            this.Text = "Phần Mềm Quản Lý Kho - SaleGearVN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);

            // 
            // pnlMenu (Menu Trái - Màu Xanh Đậm)
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(26, 32, 40);
            this.pnlMenu.Controls.Add(this.btnDangXuat);
            this.pnlMenu.Controls.Add(this.btnHeThong);
            this.pnlMenu.Controls.Add(this.btnCongNo);
            this.pnlMenu.Controls.Add(this.btnThuChi);
            this.pnlMenu.Controls.Add(this.btnTonKho);
            this.pnlMenu.Controls.Add(this.btnXuatKho);
            this.pnlMenu.Controls.Add(this.btnNhapKho);
            this.pnlMenu.Controls.Add(this.btnYeuCau);
            this.pnlMenu.Controls.Add(this.btnDanhMuc);
            this.pnlMenu.Controls.Add(this.btnDashboard);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(220, 700);
            this.pnlMenu.TabIndex = 0;

            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(0, 102, 204);
            this.pnlLogo.Controls.Add(this.lblAppName);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(220, 60);
            this.pnlLogo.TabIndex = 0;

            // 
            // lblAppName
            // 
            this.lblAppName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(0, 0);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(220, 60);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "SALEGEAR.VN";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // --- CẤU HÌNH TỪNG NÚT (HARDCODE CHUẨN) ---

            // 1. Dashboard
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDashboard.Location = new System.Drawing.Point(0, 60);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(220, 50);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);

            // 2. Danh Mục (Hàng hóa, Đối tác...)
            this.btnDanhMuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhMuc.FlatAppearance.BorderSize = 0;
            this.btnDanhMuc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDanhMuc.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDanhMuc.Location = new System.Drawing.Point(0, 110);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDanhMuc.Size = new System.Drawing.Size(220, 50);
            this.btnDanhMuc.TabIndex = 2;
            this.btnDanhMuc.Text = "Danh Mục Hàng";
            this.btnDanhMuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnHangHoa_Click);

            // 3. Yêu Cầu Nhập
            this.btnYeuCau.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnYeuCau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeuCau.FlatAppearance.BorderSize = 0;
            this.btnYeuCau.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnYeuCau.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnYeuCau.Location = new System.Drawing.Point(0, 160);
            this.btnYeuCau.Name = "btnYeuCau";
            this.btnYeuCau.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnYeuCau.Size = new System.Drawing.Size(220, 50);
            this.btnYeuCau.TabIndex = 3;
            this.btnYeuCau.Text = "Yêu Cầu Nhập Kho";
            this.btnYeuCau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYeuCau.Click += new System.EventHandler(this.btnYeuCau_Click);

            // 4. Nhập Kho
            this.btnNhapKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhapKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapKho.FlatAppearance.BorderSize = 0;
            this.btnNhapKho.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnNhapKho.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNhapKho.Location = new System.Drawing.Point(0, 210);
            this.btnNhapKho.Name = "btnNhapKho";
            this.btnNhapKho.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNhapKho.Size = new System.Drawing.Size(220, 50);
            this.btnNhapKho.TabIndex = 4;
            this.btnNhapKho.Text = "Nhập Kho";
            this.btnNhapKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapKho.Click += new System.EventHandler(this.btnNhapKho_Click);

            // 5. Xuất Kho
            this.btnXuatKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXuatKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatKho.FlatAppearance.BorderSize = 0;
            this.btnXuatKho.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnXuatKho.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnXuatKho.Location = new System.Drawing.Point(0, 260);
            this.btnXuatKho.Name = "btnXuatKho";
            this.btnXuatKho.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnXuatKho.Size = new System.Drawing.Size(220, 50);
            this.btnXuatKho.TabIndex = 5;
            this.btnXuatKho.Text = "Xuất Kho";
            this.btnXuatKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatKho.Click += new System.EventHandler(this.btnXuatKho_Click);

            // 6. Tổng Hợp Kho
            this.btnTonKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTonKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTonKho.FlatAppearance.BorderSize = 0;
            this.btnTonKho.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnTonKho.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTonKho.Location = new System.Drawing.Point(0, 310);
            this.btnTonKho.Name = "btnTonKho";
            this.btnTonKho.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTonKho.Size = new System.Drawing.Size(220, 50);
            this.btnTonKho.TabIndex = 6;
            this.btnTonKho.Text = "Báo Cáo Tồn Kho";
            this.btnTonKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTonKho.Click += new System.EventHandler(this.btnTonKho_Click);

            // 7. Thu Chi
            this.btnThuChi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThuChi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThuChi.FlatAppearance.BorderSize = 0;
            this.btnThuChi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnThuChi.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnThuChi.Location = new System.Drawing.Point(0, 360);
            this.btnThuChi.Name = "btnThuChi";
            this.btnThuChi.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnThuChi.Size = new System.Drawing.Size(220, 50);
            this.btnThuChi.TabIndex = 7;
            this.btnThuChi.Text = "Quản Lý Thu Chi";
            this.btnThuChi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThuChi.Click += new System.EventHandler(this.btnThuChi_Click);

            // 8. Công Nợ
            this.btnCongNo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCongNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCongNo.FlatAppearance.BorderSize = 0;
            this.btnCongNo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCongNo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCongNo.Location = new System.Drawing.Point(0, 410);
            this.btnCongNo.Name = "btnCongNo";
            this.btnCongNo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCongNo.Size = new System.Drawing.Size(220, 50);
            this.btnCongNo.TabIndex = 8;
            this.btnCongNo.Text = "Báo Cáo Công Nợ";
            this.btnCongNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCongNo.Click += new System.EventHandler(this.btnCongNo_Click);

            // 9. Hệ Thống
            this.btnHeThong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHeThong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeThong.FlatAppearance.BorderSize = 0;
            this.btnHeThong.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnHeThong.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHeThong.Location = new System.Drawing.Point(0, 460);
            this.btnHeThong.Name = "btnHeThong";
            this.btnHeThong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHeThong.Size = new System.Drawing.Size(220, 50);
            this.btnHeThong.TabIndex = 9;
            this.btnHeThong.Text = "Quản Trị Hệ Thống";
            this.btnHeThong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHeThong.Click += new System.EventHandler(this.btnTaiKhoan_Click);

            // 10. Đăng Xuất (Bottom)
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDangXuat.ForeColor = System.Drawing.Color.Salmon;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 650);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(220, 50);
            this.btnDangXuat.TabIndex = 99;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);

            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(220, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(980, 60);
            this.pnlHeader.TabIndex = 1;

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(130, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Trang Chủ";

            // 
            // pnlBody (Nơi hiển thị Form con)
            // 
            this.pnlBody.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(220, 60);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(980, 640);
            this.pnlBody.TabIndex = 2;

            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlBody;

        // Buttons
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Button btnYeuCau;
        private System.Windows.Forms.Button btnNhapKho;
        private System.Windows.Forms.Button btnXuatKho;
        private System.Windows.Forms.Button btnTonKho;
        private System.Windows.Forms.Button btnThuChi;
        private System.Windows.Forms.Button btnCongNo;
        private System.Windows.Forms.Button btnHeThong;
        private System.Windows.Forms.Button btnDangXuat;
    }
}