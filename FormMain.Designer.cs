using System.Windows.Forms;
using System.Configuration;

namespace DoAnLapTrinhQuanLy
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menu;
        private ToolStripMenuItem mHeThong;
        private ToolStripMenuItem mDangNhapLai;
        private ToolStripMenuItem mDoiMatKhau;
        private ToolStripMenuItem mAttachDb;
        private ToolStripMenuItem mTroLyAo;
        private ToolStripMenuItem mBaoCao;
        private ToolStripMenuItem mThoat;
        private ToolStripMenuItem mDanhMuc;
        private ToolStripMenuItem mKhachHang;
        private ToolStripMenuItem mNhaCungCap;
        private ToolStripMenuItem mNhomHang;
        private ToolStripMenuItem mHangHoa;
        private ToolStripMenuItem mDonViTinh;
        private ToolStripMenuItem mNganHang;
        private ToolStripMenuItem mTaiKhoanNH_NCC;
        private ToolStripMenuItem mNghiepVu;
        private ToolStripMenuItem mPhieuNhap;
        private ToolStripMenuItem mPhieuXuat;
        private ToolStripMenuItem mPhieuThu;
        private ToolStripMenuItem mPhieuChi;
        private ToolStripMenuItem mBangBaoGia;
        private StatusStrip status;
        private ToolStripStatusLabel stUser;
        private ToolStripStatusLabel stDb;
        private ToolStrip tool;
        private ToolStripButton tKhachHang;
        private ToolStripButton tNhaCungCap;
        private ToolStripButton tHangHoa;
        private ToolStripButton tPhieuNhap;
        private ToolStripButton tPhieuXuat;

        /// <inheritdoc/>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.mHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mDangNhapLai = new System.Windows.Forms.ToolStripMenuItem();
            this.mDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.mAttachDb = new System.Windows.Forms.ToolStripMenuItem();
            this.mThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mNhaCungCap = new System.Windows.Forms.ToolStripMenuItem();
            this.mNhomHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mHangHoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mDonViTinh = new System.Windows.Forms.ToolStripMenuItem();
            this.mNganHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mTaiKhoanNH_NCC = new System.Windows.Forms.ToolStripMenuItem();
            this.mNghiepVu = new System.Windows.Forms.ToolStripMenuItem();
            this.mPhieuNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mPhieuXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mPhieuThu = new System.Windows.Forms.ToolStripMenuItem();
            this.mPhieuChi = new System.Windows.Forms.ToolStripMenuItem();
            this.mBangBaoGia = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.stUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.stDb = new System.Windows.Forms.ToolStripStatusLabel();
            this.tool = new System.Windows.Forms.ToolStrip();
            this.tKhachHang = new System.Windows.Forms.ToolStripButton();
            this.tNhaCungCap = new System.Windows.Forms.ToolStripButton();
            this.tHangHoa = new System.Windows.Forms.ToolStripButton();
            this.tPhieuNhap = new System.Windows.Forms.ToolStripButton();
            this.tPhieuXuat = new System.Windows.Forms.ToolStripButton();
            this.menu.SuspendLayout();
            this.status.SuspendLayout();
            this.tool.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mHeThong, this.mDanhMuc, this.mNghiepVu, this.mBangBaoGia});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1180, 24);
            this.menu.TabIndex = 0;
            // 
            // mHeThong
            // 
            this.mHeThong.Text = "Hệ thống";
            this.mHeThong.DropDownItems.AddRange(new ToolStripItem[] {
                this.mDangNhapLai, this.mDoiMatKhau, new ToolStripSeparator(),
                this.mDangNhapLai, this.mDoiMatKhau, new ToolStripSeparator(),
                this.mAttachDb, new ToolStripSeparator(), this.mTroLyAo, new ToolStripSeparator(), this.mBaoCao, new ToolStripSeparator(), this.mThoat
            });
            // 
            // mBaoCao
            // 
            this.mBaoCao.Text = "Báo Cáo";
            this.mBaoCao.Click += new System.EventHandler(this.mBaoCao_Click);
            // 
            // mTroLyAo
            // 
            this.mTroLyAo.Text = "Trợ lý ảo AI";
            this.mTroLyAo.Click += new System.EventHandler(this.mTroLyAo_Click);
            // 
            // mDangNhapLai
            // 
            this.mDangNhapLai.Text = "Đăng nhập lại";
            this.mDangNhapLai.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.mDangNhapLai.Click += new System.EventHandler(this.mDangNhapLai_Click);
            // 
            // mDoiMatKhau
            // 
            this.mDoiMatKhau.Text = "Đổi mật khẩu";
            this.mDoiMatKhau.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mDoiMatKhau.Click += new System.EventHandler(this.mDoiMatKhau_Click);
            // 
            // mAttachDb
            // 
            this.mAttachDb.Text = "Attach CSDL (.mdf)";
            this.mAttachDb.Click += new System.EventHandler(this.mAttachDb_Click);
            // 
            // mThoat
            // 
            this.mThoat.Text = "Thoát";
            this.mThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mThoat.Click += new System.EventHandler(this.mThoat_Click);
            // 
            // mDanhMuc
            // 
            this.mDanhMuc.Text = "Danh mục";
            this.mDanhMuc.DropDownItems.AddRange(new ToolStripItem[] {
                this.mKhachHang, this.mNhaCungCap, this.mNhomHang, this.mHangHoa, this.mDonViTinh, new ToolStripSeparator(),
                this.mNganHang, this.mTaiKhoanNH_NCC
            });
            // 
            // mKhachHang
            // 
            this.mKhachHang.Text = "Khách hàng";
            this.mKhachHang.Click += new System.EventHandler(this.mKhachHang_Click);
            // 
            // mNhaCungCap
            // 
            this.mNhaCungCap.Text = "Nhà cung cấp";
            this.mNhaCungCap.Click += new System.EventHandler(this.mNhaCungCap_Click);
            // 
            // mNhomHang
            // 
            this.mNhomHang.Text = "Nhóm hàng";
            this.mNhomHang.Click += new System.EventHandler(this.mNhomHang_Click);
            // 
            // mHangHoa
            // 
            this.mHangHoa.Text = "Hàng hóa";
            this.mHangHoa.Click += new System.EventHandler(this.mHangHoa_Click);
            // 
            // mDonViTinh
            // 
            this.mDonViTinh.Text = "Đơn vị tính";
            //this.mDonViTinh.Click += new System.EventHandler(this.mDonViTinh_Click);
            // 
            // mNganHang
            // 
            this.mNganHang.Text = "Ngân hàng";
            this.mNganHang.Click += new System.EventHandler(this.mNganHang_Click);
            // 
            // mTaiKhoanNH_NCC
            // 
            this.mTaiKhoanNH_NCC.Text = "Tài khoản NH (NCC)";
            this.mTaiKhoanNH_NCC.Click += new System.EventHandler(this.mTaiKhoanNH_NCC_Click);
            // 
            // mNghiepVu
            // 
            this.mNghiepVu.Text = "Nghiệp vụ";
            this.mNghiepVu.DropDownItems.AddRange(new ToolStripItem[] {
                this.mPhieuNhap, this.mPhieuXuat, new ToolStripSeparator(), this.mPhieuThu, this.mPhieuChi
            });
            // 
            // mPhieuNhap
            // 
            this.mPhieuNhap.Text = "Phiếu nhập";
            this.mPhieuNhap.ShortcutKeys = Keys.F5;
            this.mPhieuNhap.Click += new System.EventHandler(this.mPhieuNhap_Click);
            // 
            // mPhieuXuat
            // 
            this.mPhieuXuat.Text = "Phiếu xuất";
            this.mPhieuXuat.ShortcutKeys = Keys.F6;
            this.mPhieuXuat.Click += new System.EventHandler(this.mPhieuXuat_Click);
            // 
            // mPhieuThu
            // 
            this.mPhieuThu.Text = "Phiếu thu";
            this.mPhieuThu.ShortcutKeys = Keys.F7;
            this.mPhieuThu.Click += new System.EventHandler(this.mPhieuThu_Click);
            // 
            // mPhieuChi
            // 
            this.mPhieuChi.Text = "Phiếu chi";
            this.mPhieuChi.ShortcutKeys = Keys.F8;
            this.mPhieuChi.Click += new System.EventHandler(this.mPhieuChi_Click);
            // 
            // mBangBaoGia
            // 
            this.mBangBaoGia.Text = "Bảng báo giá";
            this.mBangBaoGia.Click += new System.EventHandler(this.mBangBaoGia_Click);
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stUser, this.stDb});
            this.status.Location = new System.Drawing.Point(0, 629);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(1180, 22);
            this.status.TabIndex = 2;
            // 
            // stUser
            // 
            this.stUser.Text = "User: ---";
            // 
            // stDb
            // 
            this.stDb.Spring = true;
            this.stDb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.stDb.Text = "DB: ---";
            // 
            // tool
            // 
            this.tool.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tKhachHang, this.tNhaCungCap, this.tHangHoa, new ToolStripSeparator(), this.tPhieuNhap, this.tPhieuXuat});
            this.tool.Location = new System.Drawing.Point(0, 24);
            this.tool.Name = "tool";
            this.tool.Size = new System.Drawing.Size(1180, 27);
            this.tool.TabIndex = 1;
            // 
            // tKhachHang
            // 
            this.tKhachHang.Text = "Khách hàng";
            this.tKhachHang.Click += new System.EventHandler(this.mKhachHang_Click);
            // 
            // tNhaCungCap
            // 
            this.tNhaCungCap.Text = "Nhà CC";
            this.tNhaCungCap.Click += new System.EventHandler(this.mNhaCungCap_Click);
            // 
            // tHangHoa
            // 
            this.tHangHoa.Text = "Hàng hóa";
            this.tHangHoa.Click += new System.EventHandler(this.mHangHoa_Click);
            // 
            // tPhieuNhap
            // 
            this.tPhieuNhap.Text = "PN (F5)";
            this.tPhieuNhap.Click += new System.EventHandler(this.mPhieuNhap_Click);
            // 
            // tPhieuXuat
            // 
            this.tPhieuXuat.Text = "PX (F6)";
            this.tPhieuXuat.Click += new System.EventHandler(this.mPhieuXuat_Click);
            // 
            // FrmMain
            // 
            this.IsMdiContainer = true;
            this.ClientSize = new System.Drawing.Size(1180, 651);
            this.Controls.Add(this.tool);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "FrmMain";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "SaleGearVN - Quản lý bán hàng & kế toán";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.tool.ResumeLayout(false);
            this.tool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}
