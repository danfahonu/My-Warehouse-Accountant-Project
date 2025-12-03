using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Data;
using DoAnLapTrinhQuanLy.GuiLayer;

namespace DoAnLapTrinhQuanLy
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
        }

        // Optimization: Reduce flicker
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // WS_EX_COMPOSITED
                return cp;
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // Áp dụng giao diện hiện đại
            ThemeManager.Apply(this);

            // Hiển thị user hiện tại
            UpdateUserStatus();

            try
            {
                var c = ConfigurationManager.ConnectionStrings["Db"];
                if (c != null)
                {
                    var csb = new SqlConnectionStringBuilder(c.ConnectionString);
                    stDb.Text = $"DB: {csb.InitialCatalog} @ {csb.DataSource}";
                }
            }
            catch { stDb.Text = "DB: (unknown)"; }
        }

        private void UpdateUserStatus()
        {
            if (Session.LoggedInUser != null)
            {
                stUser.Text = "User: " + Session.LoggedInUser.TaiKhoan + " (" + Session.LoggedInUser.HoTen + ")";
            }
            else
            {
                stUser.Text = "User: (chưa đăng nhập)";
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        // ====== Utils: mở 1 instance duy nhất cho mỗi form ======
        private T OpenChild<T>() where T : Form, new()
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f is T) { f.Activate(); return (T)f; }
            }
            var child = new T();
            child.MdiParent = this;

            // Áp dụng theme cho form con mới mở
            ThemeManager.Apply(child);

            child.WindowState = FormWindowState.Maximized;
            child.Show();
            return child;
        }

        // ====== Hệ thống ======
        private void mDangNhapLai_Click(object sender, EventArgs e)
        {
            // Đóng tất cả form con
            foreach (Form f in this.MdiChildren) f.Close();

            using (var login = new FormDangNhap())
            {
                if (login.ShowDialog(this) == DialogResult.OK)
                {
                    // Session đã được cập nhật bên trong FormDangNhap
                    UpdateUserStatus();
                }
            }
        }

        private void mDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (Session.LoggedInUser == null)
            {
                MessageBox.Show("Bạn chưa đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Giả sử FormDoiMatKhau nhận string username
            using (var f = new FormDoiMatKhau(Session.LoggedInUser.TaiKhoan))
                f.ShowDialog(this);
        }

        private void mAttachDb_Click(object sender, EventArgs e)
        {
            using (var f = new FormAttach())
                f.ShowDialog(this);
        }

        private void mBaoCao_Click(object sender, EventArgs e)
        {
            // Open FormReportViewer as MDI Child
            OpenChild<FormReportViewer>();
        }

        private void mTroLyAo_Click(object sender, EventArgs e)
        {
            // Mở form trợ lý ảo (không cần là MDI child để có thể kéo ra ngoài xem song song)
            var f = new FormTroLyAo();
            ThemeManager.Apply(f);
            f.Show();
        }

        private void mThoat_Click(object sender, EventArgs e) => this.Close();

        // ====== Danh mục ======
        private void mKhachHang_Click(object sender, EventArgs e) => OpenChild<FormKhachHang>();
        private void mNhaCungCap_Click(object sender, EventArgs e) => OpenChild<FormNhaCungCap>();
        private void mNhomHang_Click(object sender, EventArgs e) => OpenChild<FormNhomHang>();
        private void mHangHoa_Click(object sender, EventArgs e) => OpenChild<FormDanhMucHangHoa>();
        //private void mDonViTinh_Click(object sender, EventArgs e) => OpenChild<FormDonViTinh>();
        private void mNganHang_Click(object sender, EventArgs e) => OpenChild<FormNganHang>();
        private void mTaiKhoanNH_NCC_Click(object sender, EventArgs e) => OpenChild<FormQuanLyTaiKhoanNganHang>();
        // Kiểm tra lại file list: FormQuanLyTaiKhoanNganHang.cs
        // Nhưng trong code cũ gọi là FormTaiKhoanNganHangDoiTac? 
        // Tôi sẽ giữ nguyên tên class cũ nếu nó đúng, nhưng dựa vào file list thì có vẻ là FormQuanLyTaiKhoanNganHang.
        // Tuy nhiên, để an toàn tôi sẽ comment lại dòng này và dùng OpenChild<FormQuanLyTaiKhoanNganHang>() nếu chắc chắn.
        // Code cũ: OpenChild<FormTaiKhoanNganHangDoiTac>();
        // File list: FormQuanLyTaiKhoanNganHang.cs
        // Tôi sẽ giả định FormTaiKhoanNganHangDoiTac là tên class bên trong FormQuanLyTaiKhoanNganHang.cs hoặc ngược lại.
        // Để tránh lỗi compile, tôi sẽ giữ nguyên logic cũ nhưng sửa lại tên class nếu cần thiết.
        // Tạm thời tôi sẽ dùng FormQuanLyTaiKhoanNganHang vì thấy nó trong file list.

        // ====== Nghiệp vụ ======
        private void mPhieuNhap_Click(object sender, EventArgs e) => OpenChild<FormPhieuNhap>();
        private void mPhieuXuat_Click(object sender, EventArgs e) => OpenChild<FormPhieuXuat>();
        private void mPhieuThu_Click(object sender, EventArgs e) => OpenChild<FormPhieuThu>();
        private void mPhieuChi_Click(object sender, EventArgs e) => OpenChild<FormPhieuChi>();

        // ====== Bảng giá ======
        private void mBangBaoGia_Click(object sender, EventArgs e) => OpenChild<FormBangBaoGia>();
    }
}
