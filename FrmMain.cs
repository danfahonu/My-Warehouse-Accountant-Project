using System;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using DoAnLapTrinhQuanLy.Controls;
using DoAnLapTrinhQuanLy.Core;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FrmMain : BaseForm
    {
        private UserData _loggedInUser;
        private Form _currentForm;

        // UI Layout Controls
        private Panel pnlSidebar;
        private FlowLayoutPanel flpSidebarButtons;
        private Panel pnlSubMenuContainer;
        private Panel pnlContent;
        private Panel pnlHeader;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel staUser;
        private ToolStripStatusLabel staDb;
        private ToolStripStatusLabel staTime;

        // Header Controls
        private Label lblAppTitle;
        private MaterialTextBox txtGlobalSearch;

        // Sidebar Buttons
        private ModernButton btnDashboard;
        private ModernButton btnHeThong;
        private ModernButton btnDanhMuc;
        private ModernButton btnNghiepVu;
        private ModernButton btnBaoCao;
        private ModernButton btnLogout;

        // SubMenu Panels
        private Panel pnlHeThongSub;
        private Panel pnlDanhMucSub;
        private Panel pnlNghiepVuSub;
        private Panel pnlBaoCaoSub;

        // SubMenu Buttons - HeThong
        private ModernButton btnQuanLyHeThong;
        private ModernButton btnCaiDat;
        private ModernButton btnKetNoiCSDL;
        private ModernButton btnAbout;

        // SubMenu Buttons - DanhMuc
        private ModernButton btnHangHoa;
        private ModernButton btnNhomHang;
        private ModernButton btnKhachHang;
        private ModernButton btnNhaCungCap;
        private ModernButton btnNhanVien;
        private ModernButton btnTaiKhoanNganHang;
        private ModernButton btnHeThongTKKeToan;

        // SubMenu Buttons - NghiepVu
        private ModernButton btnNhapKho;
        private ModernButton btnXuatKho;
        private ModernButton btnPhieuThu;
        private ModernButton btnPhieuChi;
        private ModernButton btnBaoGia;
        private ModernButton btnChamCong;
        private ModernButton btnYeuCauNhapKho;

        // SubMenu Buttons - BaoCao
        private ModernButton btnBaoCaoNhapKho;
        private ModernButton btnBaoCaoXuatKho;
        private ModernButton btnBaoCaoTonKho;
        private ModernButton btnBaoCaoQuy;
        private ModernButton btnBaoCaoNhatKyChung;
        private ModernButton btnBaoCaoSoChiTietTK;
        private ModernButton btnBaoCaoCongNo;
        private ModernButton btnBaoCaoLuong;

        public FrmMain()
        {
            InitializeComponent();
            InitializeCustomUI();
        }

        private void InitializeCustomUI()
        {
            this.Size = new Size(1280, 720);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "SALEGEARVN - QUẢN LÝ BÁN HÀNG";
            this.Font = ThemeManager.BaseFont;

            // 1. Sidebar (Left, 250px)
            pnlSidebar = new Panel
            {
                Dock = DockStyle.Left,
                Width = 250,
                BackColor = ThemeManager.SecondaryColor,
                Padding = new Padding(0, 0, 0, 0)
            };

            // Sidebar Content: FlowLayoutPanel
            flpSidebarButtons = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                AutoScroll = true,
                BackColor = ThemeManager.SecondaryColor,
                Padding = new Padding(10, 20, 10, 10)
            };
            pnlSidebar.Controls.Add(flpSidebarButtons);

            // 2. SubMenu Container (Left, after Sidebar)
            pnlSubMenuContainer = new Panel
            {
                Dock = DockStyle.Left,
                Width = 220,
                BackColor = Color.FromArgb(35, 35, 38), // Slightly lighter than secondary
                Visible = false
            };

            // 3. Header (Top, 60px)
            pnlHeader = new Panel
            {
                Dock = DockStyle.Top,
                Height = 60,
                BackColor = ThemeManager.SecondaryColor,
                Padding = new Padding(10)
            };
            InitializeHeader();

            // 4. Status Strip (Bottom)
            statusStrip = new StatusStrip
            {
                BackColor = ThemeManager.AccentColor,
                ForeColor = Color.White,
                Dock = DockStyle.Bottom
            };
            staUser = new ToolStripStatusLabel { Text = "User: ..." };
            staDb = new ToolStripStatusLabel { Text = "DB: ..." };
            staTime = new ToolStripStatusLabel { Text = "Time: ..." };
            statusStrip.Items.AddRange(new ToolStripItem[] { staUser, staDb, staTime });

            // 5. Content Panel (Fill)
            pnlContent = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = ThemeManager.PrimaryColor,
                Padding = new Padding(10)
            };

            // Add Controls to Form
            this.Controls.Add(pnlContent);
            this.Controls.Add(statusStrip);
            this.Controls.Add(pnlSubMenuContainer);
            this.Controls.Add(pnlHeader);
            this.Controls.Add(pnlSidebar);

            // Correct Z-Order for Docking Priority:
            // 1. Sidebar (Index 0, Topmost) -> Left Full Height
            // 2. Header (Index 1) -> Top of Remaining (Right of Sidebar)
            // 3. SubMenu (Index 2) -> Left of Remaining (Below Header, Right of Sidebar)
            // 4. StatusStrip (Index 3) -> Bottom of Remaining
            // 5. Content (Index 4) -> Fill Remaining

            pnlContent.SendToBack(); // Puts it at the very bottom
            statusStrip.BringToFront(); // Becomes Top
            pnlSubMenuContainer.BringToFront(); // Becomes Top (Status pushed down)
            pnlHeader.BringToFront(); // Becomes Top (SubMenu pushed down)
            pnlSidebar.BringToFront(); // Becomes Top (Header pushed down)

            // Initialize Buttons
            InitializeSidebarButtons();
            InitializeSubMenus();
        }

        private void InitializeHeader()
        {
            lblAppTitle = new Label
            {
                Text = "SALEGEARVN",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = ThemeManager.AccentColor,
                AutoSize = true,
                Location = new Point(20, 15) // Relative to pnlHeader
            };
            pnlHeader.Controls.Add(lblAppTitle);

            // Global Search Bar
            txtGlobalSearch = new MaterialTextBox
            {
                PlaceholderText = "🔍 Search (Ctrl+P)",
                Size = new Size(400, 35),
                Location = new Point(300, 12),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right, // Fixed: Stretches with window
                BackColor = ThemeManager.TextBoxBackground,
                BorderColor = ThemeManager.BorderColor
            };
            pnlHeader.Controls.Add(txtGlobalSearch);
        }

        private void InitializeSidebarButtons()
        {
            // Helper to create Sidebar buttons
            ModernButton CreateSidebarBtn(string text, string iconText)
            {
                var btn = new ModernButton
                {
                    Text = "  " + text,
                    Width = 230, // Fit inside 250px sidebar with padding
                    Height = 45,
                    BackColor = Color.Transparent,
                    ForeColor = ThemeManager.TextColor,
                    TextAlign = ContentAlignment.MiddleLeft,
                    BorderRadius = 8,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Margin = new Padding(0, 0, 0, 10),
                    Padding = new Padding(10, 0, 0, 0)
                };

                btn.FlatAppearance.BorderSize = 0;

                // Hover effect
                btn.MouseEnter += (s, e) =>
                {
                    btn.BackColor = Color.FromArgb(50, 60, 60, 60);
                };
                btn.MouseLeave += (s, e) =>
                {
                    btn.BackColor = Color.Transparent; // Restore
                };

                return btn;
            }

            // Dashboard
            btnDashboard = CreateSidebarBtn("Dashboard", "DB");
            btnDashboard.Image = null; // Add icon if available
            btnDashboard.Click += (s, e) => { ShowForm<FormDashboard>(); HideSubMenu(); };
            flpSidebarButtons.Controls.Add(btnDashboard);

            // He Thong
            btnHeThong = CreateSidebarBtn("Hệ Thống", "HT");
            btnHeThong.Click += (s, e) => ToggleSubMenu(pnlHeThongSub);
            flpSidebarButtons.Controls.Add(btnHeThong);

            // Danh Muc
            btnDanhMuc = CreateSidebarBtn("Danh Mục", "DM");
            btnDanhMuc.Click += (s, e) => ToggleSubMenu(pnlDanhMucSub);
            flpSidebarButtons.Controls.Add(btnDanhMuc);

            // Nghiep Vu
            btnNghiepVu = CreateSidebarBtn("Nghiệp Vụ", "NV");
            btnNghiepVu.Click += (s, e) => ToggleSubMenu(pnlNghiepVuSub);
            flpSidebarButtons.Controls.Add(btnNghiepVu);

            // Bao Cao
            btnBaoCao = CreateSidebarBtn("Báo Cáo", "BC");
            btnBaoCao.Click += (s, e) => ToggleSubMenu(pnlBaoCaoSub);
            flpSidebarButtons.Controls.Add(btnBaoCao);

            // Logout
            btnLogout = CreateSidebarBtn("Đăng xuất", "EXIT");
            btnLogout.BackColor = Color.FromArgb(100, ThemeManager.DangerColor);
            btnLogout.ForeColor = Color.White;
            btnLogout.Click += (s, e) => Application.Exit();
            btnLogout.Margin = new Padding(0, 50, 0, 0); // Margin top to separate

            // Override hover for Logout
            btnLogout.MouseEnter += (s, e) => btnLogout.BackColor = ThemeManager.DangerColor;
            btnLogout.MouseLeave += (s, e) => btnLogout.BackColor = Color.FromArgb(100, ThemeManager.DangerColor);

            flpSidebarButtons.Controls.Add(btnLogout);
        }

        private void InitializeSubMenus()
        {
            // Helper to create sub-menu buttons
            ModernButton CreateSubBtn(string text, EventHandler onClick)
            {
                var btn = new ModernButton
                {
                    Text = text,
                    Dock = DockStyle.Top,
                    Height = 40,
                    BackColor = Color.Transparent,
                    ForeColor = ThemeManager.TextColor,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Padding = new Padding(20, 0, 0, 0), // Indent
                    BorderRadius = 0,
                    Font = new Font("Segoe UI", 9, FontStyle.Regular)
                };

                btn.FlatAppearance.BorderSize = 0;
                btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(40, 40, 40);
                btn.MouseLeave += (s, e) => btn.BackColor = Color.Transparent;

                btn.Click += onClick;
                return btn;
            }

            // 1. HeThong SubMenu
            pnlHeThongSub = new Panel { Dock = DockStyle.Fill, Visible = false };

            btnQuanLyHeThong = CreateSubBtn("Quản lý Hệ thống", (s, e) => ShowForm<FormQuanLyHeThong>());
            btnCaiDat = CreateSubBtn("Cài đặt chung", (s, e) => ShowForm<FormCaiDatHeThong>());
            btnKetNoiCSDL = CreateSubBtn("Kết nối CSDL", (s, e) => new FormKetNoiCSDL().ShowDialog(this));
            btnAbout = CreateSubBtn("Thông tin phần mềm", (s, e) => new FormThongTinPhanMem().ShowDialog(this));

            // Add in Normal Order (Top to Bottom) - Dock=Top stacks, but we rely on correct addition order or BringToFront if needed. 
            // Standard Controls.Add appends to end. Index 0 is Topmost Z-order.
            pnlHeThongSub.Controls.Add(btnQuanLyHeThong);
            pnlHeThongSub.Controls.Add(btnCaiDat);
            pnlHeThongSub.Controls.Add(btnKetNoiCSDL);
            pnlHeThongSub.Controls.Add(btnAbout);

            pnlSubMenuContainer.Controls.Add(pnlHeThongSub);

            // 2. DanhMuc SubMenu
            pnlDanhMucSub = new Panel { Dock = DockStyle.Fill, Visible = false };

            btnHeThongTKKeToan = CreateSubBtn("Hệ thống TK Kế toán", (s, e) => ShowForm<FormHeThongTaiKhoanKeToan>());
            btnTaiKhoanNganHang = CreateSubBtn("Tài khoản Ngân hàng", (s, e) => ShowForm<FormQuanLyTaiKhoanNganHang>());
            btnNhanVien = CreateSubBtn("Nhân viên", (s, e) => ShowForm<FormNhanVien>());
            btnNhaCungCap = CreateSubBtn("Nhà cung cấp", (s, e) => ShowForm<FormNhaCungCap>());
            btnKhachHang = CreateSubBtn("Khách hàng", (s, e) => ShowForm<FormKhachHang>());
            btnNhomHang = CreateSubBtn("Nhóm hàng", (s, e) => ShowForm<FormNhomHang>());
            btnHangHoa = CreateSubBtn("Hàng hóa - Vật tư", (s, e) => ShowForm<FormDanhMucHangHoa>());

            pnlDanhMucSub.Controls.Add(btnHeThongTKKeToan);
            pnlDanhMucSub.Controls.Add(btnTaiKhoanNganHang);
            pnlDanhMucSub.Controls.Add(btnNhanVien);
            pnlDanhMucSub.Controls.Add(btnNhaCungCap);
            pnlDanhMucSub.Controls.Add(btnKhachHang);
            pnlDanhMucSub.Controls.Add(btnNhomHang);
            pnlDanhMucSub.Controls.Add(btnHangHoa);

            pnlSubMenuContainer.Controls.Add(pnlDanhMucSub);

            // 3. NghiepVu SubMenu
            pnlNghiepVuSub = new Panel { Dock = DockStyle.Fill, Visible = false };

            btnYeuCauNhapKho = CreateSubBtn("Yêu cầu Nhập kho", (s, e) => ShowForm<FormYeuCauNhapKho>());
            btnChamCong = CreateSubBtn("Chấm công", (s, e) => ShowForm<FormTamUngChamCong>());
            btnBaoGia = CreateSubBtn("Báo giá", (s, e) => ShowForm<FormBangBaoGia>());
            btnPhieuChi = CreateSubBtn("Phiếu chi", (s, e) => ShowForm<FormPhieuChi>());
            btnPhieuThu = CreateSubBtn("Phiếu thu", (s, e) => ShowForm<FormPhieuThu>());
            btnXuatKho = CreateSubBtn("Phiếu Xuất kho", (s, e) => ShowForm<FormPhieuXuat>());
            btnNhapKho = CreateSubBtn("Phiếu Nhập kho", (s, e) => ShowForm<FormPhieuNhap>());

            pnlNghiepVuSub.Controls.Add(btnYeuCauNhapKho);
            pnlNghiepVuSub.Controls.Add(btnChamCong);
            pnlNghiepVuSub.Controls.Add(btnBaoGia);
            pnlNghiepVuSub.Controls.Add(btnPhieuChi);
            pnlNghiepVuSub.Controls.Add(btnPhieuThu);
            pnlNghiepVuSub.Controls.Add(btnXuatKho);
            pnlNghiepVuSub.Controls.Add(btnNhapKho);

            pnlSubMenuContainer.Controls.Add(pnlNghiepVuSub);

            // 4. BaoCao SubMenu
            pnlBaoCaoSub = new Panel { Dock = DockStyle.Fill, Visible = false };

            btnBaoCaoLuong = CreateSubBtn("Báo cáo Lương", (s, e) => ShowForm<FormTinhLuong>());
            btnBaoCaoCongNo = CreateSubBtn("Báo cáo Công nợ", (s, e) => ShowForm<FormReportCongNo>());
            btnBaoCaoSoChiTietTK = CreateSubBtn("Sổ chi tiết tài khoản", (s, e) => ShowForm<FormSoChiTietTaiKhoan>());
            btnBaoCaoNhatKyChung = CreateSubBtn("Sổ nhật ký chung", (s, e) => ShowForm<FormSoNhatKyChung>());
            btnBaoCaoQuy = CreateSubBtn("Báo cáo Quỹ", (s, e) => ShowForm<FormBaoCaoQuy>());
            btnBaoCaoTonKho = CreateSubBtn("Tổng hợp tồn kho", (s, e) => ShowForm<FormBaoCaoTonKho>());
            btnBaoCaoXuatKho = CreateSubBtn("Báo cáo Xuất kho", (s, e) => ShowBaoCaoKho());
            btnBaoCaoNhapKho = CreateSubBtn("Báo cáo Nhập kho", (s, e) => ShowBaoCaoKho());

            pnlBaoCaoSub.Controls.Add(btnBaoCaoLuong);
            pnlBaoCaoSub.Controls.Add(btnBaoCaoCongNo);
            pnlBaoCaoSub.Controls.Add(btnBaoCaoSoChiTietTK);
            pnlBaoCaoSub.Controls.Add(btnBaoCaoNhatKyChung);
            pnlBaoCaoSub.Controls.Add(btnBaoCaoQuy);
            pnlBaoCaoSub.Controls.Add(btnBaoCaoTonKho);
            pnlBaoCaoSub.Controls.Add(btnBaoCaoXuatKho);
            pnlBaoCaoSub.Controls.Add(btnBaoCaoNhapKho);

            pnlSubMenuContainer.Controls.Add(pnlBaoCaoSub);
        }

        private void ToggleSubMenu(Panel subMenu)
        {
            if (pnlSubMenuContainer.Visible && subMenu.Visible)
            {
                // Toggle off
                pnlSubMenuContainer.Visible = false;
                subMenu.Visible = false;
            }
            else
            {
                // Show container and switch sub-menu
                pnlSubMenuContainer.Visible = true;
                pnlHeThongSub.Visible = false;
                pnlDanhMucSub.Visible = false;
                pnlNghiepVuSub.Visible = false;
                pnlBaoCaoSub.Visible = false;

                subMenu.Visible = true;
                subMenu.BringToFront();
            }
        }

        private void HideSubMenu()
        {
            pnlSubMenuContainer.Visible = false;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // Status Strip Logic
            try
            {
                var cs = ConfigurationManager.ConnectionStrings["Db"]?.ConnectionString ?? "(chưa cấu hình)";
                staDb.Text = " | DB: " + new System.Data.SqlClient.SqlConnectionStringBuilder(cs).InitialCatalog;
            }
            catch { staDb.Text = " | DB: (lỗi cấu hình)"; }

            staTime.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
            var timer = new Timer { Interval = 1000 };
            timer.Tick += (s, a) => staTime.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
            timer.Start();

            // Open Dashboard
            ShowForm<FormDashboard>();
        }

        public void SetLoggedInUser(UserData user)
        {
            _loggedInUser = user;
            staUser.Text = "User: " + (_loggedInUser != null ? $"{_loggedInUser.HoTen} ({_loggedInUser.TenQuyen})" : "(chưa đăng nhập)");
            ApplyNavigationPermissions();
        }

        private void ApplyNavigationPermissions()
        {
            if (_loggedInUser == null) return;
            string userRole = _loggedInUser.TenQuyen;

            // Main Categories
            bool isAdmin = userRole == "Administrator";
            bool isKeToan = userRole == "Kế toán";
            bool isSale = userRole == "Nhân viên Kinh doanh";
            bool isKho = userRole == "Nhân viên Kho";

            btnHeThong.Visible = isAdmin;
            btnDanhMuc.Visible = true;
            btnNghiepVu.Visible = true;
            btnBaoCao.Visible = true;

            // Sub Items - HeThong
            btnQuanLyHeThong.Visible = isAdmin;
            btnCaiDat.Visible = isAdmin;
            btnKetNoiCSDL.Visible = isAdmin;

            // Sub Items - DanhMuc
            btnHangHoa.Visible = isAdmin || isKeToan || isSale || isKho;
            btnNhomHang.Visible = isAdmin || isKeToan || isSale || isKho;
            btnKhachHang.Visible = isAdmin || isKeToan || isSale;
            btnNhaCungCap.Visible = isAdmin || isKeToan || isKho;
            btnNhanVien.Visible = isAdmin;
            btnTaiKhoanNganHang.Visible = isAdmin || isKeToan;
            btnHeThongTKKeToan.Visible = isAdmin || isKeToan;

            // Sub Items - NghiepVu
            btnNhapKho.Visible = isAdmin || isKeToan || isKho;
            btnXuatKho.Visible = isAdmin || isKeToan || isSale;
            btnYeuCauNhapKho.Visible = isAdmin || isKeToan || isKho;
            btnBaoGia.Visible = isAdmin || isKeToan || isSale;
            btnPhieuThu.Visible = isAdmin || isKeToan;
            btnPhieuChi.Visible = isAdmin || isKeToan;
            btnChamCong.Visible = isAdmin || isKeToan;

            // Sub Items - BaoCao
            btnBaoCaoNhapKho.Visible = isAdmin || isKeToan || isKho;
            btnBaoCaoXuatKho.Visible = isAdmin || isKeToan || isKho;
            btnBaoCaoTonKho.Visible = isAdmin || isKeToan || isKho;
            btnBaoCaoQuy.Visible = isAdmin || isKeToan;
            btnBaoCaoNhatKyChung.Visible = isAdmin || isKeToan;
            btnBaoCaoSoChiTietTK.Visible = isAdmin || isKeToan;
            btnBaoCaoCongNo.Visible = isAdmin || isKeToan;
            btnBaoCaoLuong.Visible = isAdmin || isKeToan;
        }

        private void ShowForm<T>() where T : Form, new()
        {
            if (_currentForm != null && _currentForm.GetType() == typeof(T)) { _currentForm.BringToFront(); return; }
            _currentForm?.Close();
            var newForm = new T { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            pnlContent.Controls.Add(newForm);
            _currentForm = newForm;
            newForm.Show();
        }

        private void ShowBaoCaoKho()
        {
            _currentForm?.Close();
            MessageBox.Show("Chức năng đang phát triển.", "Thông báo");
        }
    }
}