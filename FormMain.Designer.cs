namespace DoAnLapTrinhQuanLy.GuiLayer
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlSubBaoCao = new System.Windows.Forms.Panel();
            this.btnSubBaoCaoLuong = new System.Windows.Forms.Button();
            this.btnSubBaoCaoTon = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.pnlSubNghiepVu = new System.Windows.Forms.Panel();
            this.btnSubBanHang = new System.Windows.Forms.Button();
            this.btnSubNhapHang = new System.Windows.Forms.Button();
            this.btnNghiepVu = new System.Windows.Forms.Button();
            this.pnlSubDanhMuc = new System.Windows.Forms.Panel();
            this.btnSubNhanVien = new System.Windows.Forms.Button();
            this.btnSubHangHoa = new System.Windows.Forms.Button();
            this.btnSubKhachHang = new System.Windows.Forms.Button();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlSidebar.SuspendLayout();
            this.pnlSubBaoCao.SuspendLayout();
            this.pnlSubNghiepVu.SuspendLayout();
            this.pnlSubDanhMuc.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlSidebar
            // 
            this.pnlSidebar.AutoScroll = true;
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.pnlSubBaoCao);
            this.pnlSidebar.Controls.Add(this.btnBaoCao);
            this.pnlSidebar.Controls.Add(this.pnlSubNghiepVu);
            this.pnlSidebar.Controls.Add(this.btnNghiepVu);
            this.pnlSidebar.Controls.Add(this.pnlSubDanhMuc);
            this.pnlSidebar.Controls.Add(this.btnDanhMuc);
            this.pnlSidebar.Controls.Add(this.pnlLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(250, 720);
            this.pnlSidebar.TabIndex = 0;

            // 
            // pnlSubBaoCao
            // 
            this.pnlSubBaoCao.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.pnlSubBaoCao.Controls.Add(this.btnSubBaoCaoLuong);
            this.pnlSubBaoCao.Controls.Add(this.btnSubBaoCaoTon);
            this.pnlSubBaoCao.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubBaoCao.Location = new System.Drawing.Point(0, 465);
            this.pnlSubBaoCao.Name = "pnlSubBaoCao";
            this.pnlSubBaoCao.Size = new System.Drawing.Size(250, 90);
            this.pnlSubBaoCao.TabIndex = 6;
            this.pnlSubBaoCao.Visible = false;

            // 
            // btnSubBaoCaoLuong
            // 
            this.btnSubBaoCaoLuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubBaoCaoLuong.FlatAppearance.BorderSize = 0;
            this.btnSubBaoCaoLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubBaoCaoLuong.ForeColor = System.Drawing.Color.Silver;
            this.btnSubBaoCaoLuong.Location = new System.Drawing.Point(0, 40);
            this.btnSubBaoCaoLuong.Name = "btnSubBaoCaoLuong";
            this.btnSubBaoCaoLuong.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubBaoCaoLuong.Size = new System.Drawing.Size(250, 40);
            this.btnSubBaoCaoLuong.TabIndex = 1;
            this.btnSubBaoCaoLuong.Text = "Báo cáo Lương";
            this.btnSubBaoCaoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubBaoCaoLuong.UseVisualStyleBackColor = true;

            // 
            // btnSubBaoCaoTon
            // 
            this.btnSubBaoCaoTon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubBaoCaoTon.FlatAppearance.BorderSize = 0;
            this.btnSubBaoCaoTon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubBaoCaoTon.ForeColor = System.Drawing.Color.Silver;
            this.btnSubBaoCaoTon.Location = new System.Drawing.Point(0, 0);
            this.btnSubBaoCaoTon.Name = "btnSubBaoCaoTon";
            this.btnSubBaoCaoTon.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubBaoCaoTon.Size = new System.Drawing.Size(250, 40);
            this.btnSubBaoCaoTon.TabIndex = 0;
            this.btnSubBaoCaoTon.Text = "Báo cáo Tồn kho";
            this.btnSubBaoCaoTon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubBaoCaoTon.UseVisualStyleBackColor = true;

            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaoCao.FlatAppearance.BorderSize = 0;
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnBaoCao.Location = new System.Drawing.Point(0, 415);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBaoCao.Size = new System.Drawing.Size(250, 50);
            this.btnBaoCao.TabIndex = 5;
            this.btnBaoCao.Text = "BÁO CÁO";
            this.btnBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCao.UseVisualStyleBackColor = true;

            // 
            // pnlSubNghiepVu
            // 
            this.pnlSubNghiepVu.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.pnlSubNghiepVu.Controls.Add(this.btnSubBanHang);
            this.pnlSubNghiepVu.Controls.Add(this.btnSubNhapHang);
            this.pnlSubNghiepVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubNghiepVu.Location = new System.Drawing.Point(0, 325);
            this.pnlSubNghiepVu.Name = "pnlSubNghiepVu";
            this.pnlSubNghiepVu.Size = new System.Drawing.Size(250, 90);
            this.pnlSubNghiepVu.TabIndex = 4;
            this.pnlSubNghiepVu.Visible = false;

            // 
            // btnSubBanHang
            // 
            this.btnSubBanHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubBanHang.FlatAppearance.BorderSize = 0;
            this.btnSubBanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubBanHang.ForeColor = System.Drawing.Color.Silver;
            this.btnSubBanHang.Location = new System.Drawing.Point(0, 40);
            this.btnSubBanHang.Name = "btnSubBanHang";
            this.btnSubBanHang.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubBanHang.Size = new System.Drawing.Size(250, 40);
            this.btnSubBanHang.TabIndex = 1;
            this.btnSubBanHang.Text = "Xuất hàng / Bán hàng";
            this.btnSubBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubBanHang.UseVisualStyleBackColor = true;

            // 
            // btnSubNhapHang
            // 
            this.btnSubNhapHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubNhapHang.FlatAppearance.BorderSize = 0;
            this.btnSubNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubNhapHang.ForeColor = System.Drawing.Color.Silver;
            this.btnSubNhapHang.Location = new System.Drawing.Point(0, 0);
            this.btnSubNhapHang.Name = "btnSubNhapHang";
            this.btnSubNhapHang.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubNhapHang.Size = new System.Drawing.Size(250, 40);
            this.btnSubNhapHang.TabIndex = 0;
            this.btnSubNhapHang.Text = "Nhập hàng";
            this.btnSubNhapHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubNhapHang.UseVisualStyleBackColor = true;

            // 
            // btnNghiepVu
            // 
            this.btnNghiepVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNghiepVu.FlatAppearance.BorderSize = 0;
            this.btnNghiepVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNghiepVu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNghiepVu.ForeColor = System.Drawing.Color.White;
            this.btnNghiepVu.Location = new System.Drawing.Point(0, 275);
            this.btnNghiepVu.Name = "btnNghiepVu";
            this.btnNghiepVu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNghiepVu.Size = new System.Drawing.Size(250, 50);
            this.btnNghiepVu.TabIndex = 3;
            this.btnNghiepVu.Text = "NGHIỆP VỤ";
            this.btnNghiepVu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNghiepVu.UseVisualStyleBackColor = true;

            // 
            // pnlSubDanhMuc
            // 
            this.pnlSubDanhMuc.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.pnlSubDanhMuc.Controls.Add(this.btnSubNhanVien);
            this.pnlSubDanhMuc.Controls.Add(this.btnSubHangHoa);
            this.pnlSubDanhMuc.Controls.Add(this.btnSubKhachHang);
            this.pnlSubDanhMuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubDanhMuc.Location = new System.Drawing.Point(0, 150);
            this.pnlSubDanhMuc.Name = "pnlSubDanhMuc";
            this.pnlSubDanhMuc.Size = new System.Drawing.Size(250, 125);
            this.pnlSubDanhMuc.TabIndex = 2;
            this.pnlSubDanhMuc.Visible = false;

            // 
            // btnSubNhanVien
            // 
            this.btnSubNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubNhanVien.FlatAppearance.BorderSize = 0;
            this.btnSubNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubNhanVien.ForeColor = System.Drawing.Color.Silver;
            this.btnSubNhanVien.Location = new System.Drawing.Point(0, 80);
            this.btnSubNhanVien.Name = "btnSubNhanVien";
            this.btnSubNhanVien.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubNhanVien.Size = new System.Drawing.Size(250, 40);
            this.btnSubNhanVien.TabIndex = 2;
            this.btnSubNhanVien.Text = "Nhân viên";
            this.btnSubNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubNhanVien.UseVisualStyleBackColor = true;

            // 
            // btnSubHangHoa
            // 
            this.btnSubHangHoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubHangHoa.FlatAppearance.BorderSize = 0;
            this.btnSubHangHoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubHangHoa.ForeColor = System.Drawing.Color.Silver;
            this.btnSubHangHoa.Location = new System.Drawing.Point(0, 40);
            this.btnSubHangHoa.Name = "btnSubHangHoa";
            this.btnSubHangHoa.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubHangHoa.Size = new System.Drawing.Size(250, 40);
            this.btnSubHangHoa.TabIndex = 1;
            this.btnSubHangHoa.Text = "Hàng hóa";
            this.btnSubHangHoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubHangHoa.UseVisualStyleBackColor = true;

            // 
            // btnSubKhachHang
            // 
            this.btnSubKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubKhachHang.FlatAppearance.BorderSize = 0;
            this.btnSubKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubKhachHang.ForeColor = System.Drawing.Color.Silver;
            this.btnSubKhachHang.Location = new System.Drawing.Point(0, 0);
            this.btnSubKhachHang.Name = "btnSubKhachHang";
            this.btnSubKhachHang.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubKhachHang.Size = new System.Drawing.Size(250, 40);
            this.btnSubKhachHang.TabIndex = 0;
            this.btnSubKhachHang.Text = "Khách hàng";
            this.btnSubKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubKhachHang.UseVisualStyleBackColor = true;

            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDanhMuc.FlatAppearance.BorderSize = 0;
            this.btnDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhMuc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDanhMuc.ForeColor = System.Drawing.Color.White;
            this.btnDanhMuc.Location = new System.Drawing.Point(0, 100);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDanhMuc.Size = new System.Drawing.Size(250, 50);
            this.btnDanhMuc.TabIndex = 1;
            this.btnDanhMuc.Text = "DANH MỤC";
            this.btnDanhMuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhMuc.UseVisualStyleBackColor = true;

            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.pnlLogo.Controls.Add(this.lblLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(250, 100);
            this.pnlLogo.TabIndex = 0;

            // 
            // lblLogo
            // 
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(0, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(250, 100);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "QUẢN LÝ\r\nBÁN HÀNG";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(250, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1030, 60);
            this.pnlHeader.TabIndex = 1;

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(117, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Trang chính";

            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(250, 60);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1030, 660);
            this.pnlContent.TabIndex = 2;

            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.Salmon;
            this.btnLogout.Location = new System.Drawing.Point(0, 670);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(250, 50);
            this.btnLogout.TabIndex = 99;
            this.btnLogout.Text = "THOÁT";
            this.btnLogout.UseVisualStyleBackColor = true;

            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Quản Lý Bán Hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSubBaoCao.ResumeLayout(false);
            this.pnlSubNghiepVu.ResumeLayout(false);
            this.pnlSubDanhMuc.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblTitle;

        // Danh mục
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Panel pnlSubDanhMuc;
        private System.Windows.Forms.Button btnSubKhachHang;
        private System.Windows.Forms.Button btnSubHangHoa;
        private System.Windows.Forms.Button btnSubNhanVien;

        // Nghiệp vụ
        private System.Windows.Forms.Button btnNghiepVu;
        private System.Windows.Forms.Panel pnlSubNghiepVu;
        private System.Windows.Forms.Button btnSubNhapHang;
        private System.Windows.Forms.Button btnSubBanHang;

        // Báo cáo
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Panel pnlSubBaoCao;
        private System.Windows.Forms.Button btnSubBaoCaoTon;
        private System.Windows.Forms.Button btnSubBaoCaoLuong;

        private System.Windows.Forms.Button btnLogout;
    }
}