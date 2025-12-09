namespace DoAnLapTrinhQuanLy.GuiLayer
{
    partial class FrmMain
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
            this.pnlSidebar = new System.Windows.Forms.Panel();

            // --- KHAI BÁO CÁC NÚT VÀ PANEL MENU ---
            this.btnLogout = new System.Windows.Forms.Button();

            // Nhóm Báo Cáo
            this.pnlSubBaoCao = new System.Windows.Forms.Panel();
            this.btnSubSoChiTiet = new System.Windows.Forms.Button();
            this.btnSubNhatKyChung = new System.Windows.Forms.Button();
            this.btnSubCongNo = new System.Windows.Forms.Button();
            this.btnSubBaoCaoQuy = new System.Windows.Forms.Button();
            this.btnSubBaoCaoLuong = new System.Windows.Forms.Button();
            this.btnSubBaoCaoTon = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();

            // Nhóm Nghiệp Vụ
            this.pnlSubNghiepVu = new System.Windows.Forms.Panel();
            this.btnSubThuChi = new System.Windows.Forms.Button();
            this.btnSubChamCong = new System.Windows.Forms.Button();
            this.btnSubBaoGia = new System.Windows.Forms.Button();
            this.btnSubYeuCauNhap = new System.Windows.Forms.Button();
            this.btnSubBanHang = new System.Windows.Forms.Button();
            this.btnSubNhapHang = new System.Windows.Forms.Button();
            this.btnNghiepVu = new System.Windows.Forms.Button();

            // Nhóm Danh Mục
            this.pnlSubDanhMuc = new System.Windows.Forms.Panel();
            this.btnSubTaiKhoanKeToan = new System.Windows.Forms.Button();
            this.btnSubNganHang = new System.Windows.Forms.Button();
            this.btnSubNhaCungCap = new System.Windows.Forms.Button();
            this.btnSubNhomHang = new System.Windows.Forms.Button();
            this.btnSubNhanVien = new System.Windows.Forms.Button();
            this.btnSubHangHoa = new System.Windows.Forms.Button();
            this.btnSubKhachHang = new System.Windows.Forms.Button();
            this.btnDanhMuc = new System.Windows.Forms.Button();

            // Nhóm Hệ Thống (Mới thêm)
            this.pnlSubHeThong = new System.Windows.Forms.Panel();
            this.btnSubTroLyAo = new System.Windows.Forms.Button();
            this.btnSubThongTin = new System.Windows.Forms.Button();
            this.btnSubKetNoi = new System.Windows.Forms.Button();
            this.btnSubCaiDat = new System.Windows.Forms.Button();
            this.btnSubQuanLyHeThong = new System.Windows.Forms.Button();
            this.btnSubDoiMatKhau = new System.Windows.Forms.Button();
            this.btnHeThong = new System.Windows.Forms.Button();

            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();

            this.pnlSidebar.SuspendLayout();
            this.pnlSubBaoCao.SuspendLayout();
            this.pnlSubNghiepVu.SuspendLayout();
            this.pnlSubDanhMuc.SuspendLayout();
            this.pnlSubHeThong.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlSidebar
            // 
            this.pnlSidebar.AutoScroll = true;
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(260, 720); // Tăng độ rộng chút
            this.pnlSidebar.TabIndex = 0;

            // Thứ tự Add vào Sidebar: Add ngược từ dưới lên (hoặc dùng BringToFront sau)
            // Tui add xuôi nhưng dùng Dock=Top nên cái nào add SAU sẽ nằm DƯỚI
            this.pnlSidebar.Controls.Add(this.btnLogout);

            this.pnlSidebar.Controls.Add(this.pnlSubBaoCao);
            this.pnlSidebar.Controls.Add(this.btnBaoCao);

            this.pnlSidebar.Controls.Add(this.pnlSubNghiepVu);
            this.pnlSidebar.Controls.Add(this.btnNghiepVu);

            this.pnlSidebar.Controls.Add(this.pnlSubDanhMuc);
            this.pnlSidebar.Controls.Add(this.btnDanhMuc);

            this.pnlSidebar.Controls.Add(this.pnlSubHeThong);
            this.pnlSidebar.Controls.Add(this.btnHeThong);

            this.pnlSidebar.Controls.Add(this.pnlLogo);

            // ---------------------------------------------------------
            // CẤU HÌNH STYLE CHUNG CHO NÚT (Helper style inline)
            // ---------------------------------------------------------
            void StyleMainBtn(System.Windows.Forms.Button btn, string text)
            {
                btn.Dock = System.Windows.Forms.DockStyle.Top;
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
                btn.ForeColor = System.Drawing.Color.White;
                btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
                btn.Height = 50;
                btn.Text = text;
            }

            void StyleSubBtn(System.Windows.Forms.Button btn, string text)
            {
                btn.Dock = System.Windows.Forms.DockStyle.Top;
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new System.Drawing.Font("Segoe UI", 10F);
                btn.ForeColor = System.Drawing.Color.Silver;
                btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                btn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0); // Thụt đầu dòng
                btn.Height = 40;
                btn.Text = text;
            }

            // --- PANEL HỆ THỐNG ---
            this.pnlSubHeThong.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubHeThong.Height = 240; // 6 nút * 40
            this.pnlSubHeThong.BackColor = System.Drawing.Color.FromArgb(55, 55, 55);
            this.pnlSubHeThong.Visible = false;

            StyleSubBtn(this.btnSubTroLyAo, "Trợ lý ảo (AI)");
            StyleSubBtn(this.btnSubThongTin, "Thông tin phần mềm");
            StyleSubBtn(this.btnSubKetNoi, "Kết nối CSDL");
            StyleSubBtn(this.btnSubCaiDat, "Cài đặt chung");
            StyleSubBtn(this.btnSubQuanLyHeThong, "Quản lý người dùng");
            StyleSubBtn(this.btnSubDoiMatKhau, "Đổi mật khẩu");

            // Add nút con vào Panel Hệ thống (Lưu ý: Dock Top nên add ngược)
            this.pnlSubHeThong.Controls.Add(this.btnSubTroLyAo);
            this.pnlSubHeThong.Controls.Add(this.btnSubThongTin);
            this.pnlSubHeThong.Controls.Add(this.btnSubKetNoi);
            this.pnlSubHeThong.Controls.Add(this.btnSubCaiDat);
            this.pnlSubHeThong.Controls.Add(this.btnSubQuanLyHeThong);
            this.pnlSubHeThong.Controls.Add(this.btnSubDoiMatKhau);

            StyleMainBtn(this.btnHeThong, "HỆ THỐNG");

            // --- PANEL DANH MỤC ---
            this.pnlSubDanhMuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubDanhMuc.Height = 280; // 7 nút * 40
            this.pnlSubDanhMuc.BackColor = System.Drawing.Color.FromArgb(55, 55, 55);
            this.pnlSubDanhMuc.Visible = false;

            StyleSubBtn(this.btnSubTaiKhoanKeToan, "Hệ thống TK Kế toán");
            StyleSubBtn(this.btnSubNganHang, "Tài khoản Ngân hàng");
            StyleSubBtn(this.btnSubNhaCungCap, "Nhà cung cấp");
            StyleSubBtn(this.btnSubNhomHang, "Nhóm hàng");
            StyleSubBtn(this.btnSubNhanVien, "Nhân viên");
            StyleSubBtn(this.btnSubHangHoa, "Hàng hóa - Vật tư");
            StyleSubBtn(this.btnSubKhachHang, "Khách hàng");

            this.pnlSubDanhMuc.Controls.Add(this.btnSubTaiKhoanKeToan);
            this.pnlSubDanhMuc.Controls.Add(this.btnSubNganHang);
            this.pnlSubDanhMuc.Controls.Add(this.btnSubNhaCungCap);
            this.pnlSubDanhMuc.Controls.Add(this.btnSubNhomHang);
            this.pnlSubDanhMuc.Controls.Add(this.btnSubNhanVien);
            this.pnlSubDanhMuc.Controls.Add(this.btnSubHangHoa);
            this.pnlSubDanhMuc.Controls.Add(this.btnSubKhachHang);

            StyleMainBtn(this.btnDanhMuc, "DANH MỤC");

            // --- PANEL NGHIỆP VỤ ---
            this.pnlSubNghiepVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubNghiepVu.Height = 240;
            this.pnlSubNghiepVu.BackColor = System.Drawing.Color.FromArgb(55, 55, 55);
            this.pnlSubNghiepVu.Visible = false;

            StyleSubBtn(this.btnSubThuChi, "Quản lý Thu - Chi");
            StyleSubBtn(this.btnSubChamCong, "Tạm ứng - Chấm công");
            StyleSubBtn(this.btnSubBaoGia, "Báo giá");
            StyleSubBtn(this.btnSubYeuCauNhap, "Yêu cầu nhập kho");
            StyleSubBtn(this.btnSubBanHang, "Xuất kho / Bán hàng");
            StyleSubBtn(this.btnSubNhapHang, "Nhập kho / Mua hàng");

            this.pnlSubNghiepVu.Controls.Add(this.btnSubThuChi);
            this.pnlSubNghiepVu.Controls.Add(this.btnSubChamCong);
            this.pnlSubNghiepVu.Controls.Add(this.btnSubBaoGia);
            this.pnlSubNghiepVu.Controls.Add(this.btnSubYeuCauNhap);
            this.pnlSubNghiepVu.Controls.Add(this.btnSubBanHang);
            this.pnlSubNghiepVu.Controls.Add(this.btnSubNhapHang);

            StyleMainBtn(this.btnNghiepVu, "NGHIỆP VỤ");

            // --- PANEL BÁO CÁO ---
            this.pnlSubBaoCao.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubBaoCao.Height = 240;
            this.pnlSubBaoCao.BackColor = System.Drawing.Color.FromArgb(55, 55, 55);
            this.pnlSubBaoCao.Visible = false;

            StyleSubBtn(this.btnSubSoChiTiet, "Sổ chi tiết Tài khoản");
            StyleSubBtn(this.btnSubNhatKyChung, "Sổ Nhật ký chung");
            StyleSubBtn(this.btnSubCongNo, "Báo cáo Công nợ");
            StyleSubBtn(this.btnSubBaoCaoQuy, "Báo cáo Quỹ");
            StyleSubBtn(this.btnSubBaoCaoLuong, "Báo cáo Lương");
            StyleSubBtn(this.btnSubBaoCaoTon, "Tổng hợp Tồn kho");

            this.pnlSubBaoCao.Controls.Add(this.btnSubSoChiTiet);
            this.pnlSubBaoCao.Controls.Add(this.btnSubNhatKyChung);
            this.pnlSubBaoCao.Controls.Add(this.btnSubCongNo);
            this.pnlSubBaoCao.Controls.Add(this.btnSubBaoCaoQuy);
            this.pnlSubBaoCao.Controls.Add(this.btnSubBaoCaoLuong);
            this.pnlSubBaoCao.Controls.Add(this.btnSubBaoCaoTon);

            StyleMainBtn(this.btnBaoCao, "BÁO CÁO");

            // --- LOGO & HEADER ---
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Height = 80;
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.pnlLogo.Controls.Add(this.lblLogo);

            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLogo.Text = "SALE GEAR VN";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;

            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 60;
            this.pnlHeader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlHeader.Controls.Add(this.lblTitle);

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Text = "Trang chủ";

            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.BackColor = System.Drawing.Color.White;

            // --- NÚT LOGOUT ---
            StyleMainBtn(this.btnLogout, "ĐĂNG XUẤT");
            this.btnLogout.ForeColor = System.Drawing.Color.Salmon;

            // --- ADD VÀO FORM ---
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Text = "PHẦN MỀM QUẢN LÝ BÁN HÀNG";

            this.pnlSidebar.ResumeLayout(false);
            this.pnlSubBaoCao.ResumeLayout(false);
            this.pnlSubNghiepVu.ResumeLayout(false);
            this.pnlSubDanhMuc.ResumeLayout(false);
            this.pnlSubHeThong.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        // Biến controls
        private System.Windows.Forms.Panel pnlSidebar, pnlHeader, pnlContent, pnlLogo;
        private System.Windows.Forms.Label lblLogo, lblTitle;
        private System.Windows.Forms.Button btnLogout;

        // Hệ thống
        private System.Windows.Forms.Button btnHeThong;
        private System.Windows.Forms.Panel pnlSubHeThong;
        private System.Windows.Forms.Button btnSubDoiMatKhau, btnSubQuanLyHeThong, btnSubCaiDat, btnSubKetNoi, btnSubThongTin, btnSubTroLyAo;

        // Danh mục
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Panel pnlSubDanhMuc;
        private System.Windows.Forms.Button btnSubKhachHang, btnSubHangHoa, btnSubNhanVien, btnSubNhomHang, btnSubNhaCungCap, btnSubNganHang, btnSubTaiKhoanKeToan;

        // Nghiệp vụ
        private System.Windows.Forms.Button btnNghiepVu;
        private System.Windows.Forms.Panel pnlSubNghiepVu;
        private System.Windows.Forms.Button btnSubNhapHang, btnSubBanHang, btnSubYeuCauNhap, btnSubBaoGia, btnSubChamCong, btnSubThuChi;

        // Báo cáo
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Panel pnlSubBaoCao;
        private System.Windows.Forms.Button btnSubBaoCaoTon, btnSubBaoCaoLuong, btnSubBaoCaoQuy, btnSubCongNo, btnSubNhatKyChung, btnSubSoChiTiet;
    }
}