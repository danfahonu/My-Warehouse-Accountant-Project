using System;
using System.Drawing;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Core;
// Lưu ý: Nếu các Form của bà nằm trong namespace khác (ví dụ DoAnLapTrinhQuanLy.GuiLayer.DanhMuc),
// bà hãy thêm "using" tương ứng vào đây.

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FrmMain : Form
    {
        private Form _activeForm = null;

        public FrmMain()
        {
            InitializeComponent();
            SetupEvents();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            // Mở cái này lên đầu tiên để lấp trống cái màn hình
            OpenForm(new FormDashboard());
        }
        private void SetupEvents()
        {
            // --- 1. SỰ KIỆN MENU CHÍNH ---
            btnHeThong.Click += (s, e) => ToggleMenu(pnlSubHeThong);
            btnDanhMuc.Click += (s, e) => ToggleMenu(pnlSubDanhMuc);
            btnNghiepVu.Click += (s, e) => ToggleMenu(pnlSubNghiepVu);
            btnBaoCao.Click += (s, e) => ToggleMenu(pnlSubBaoCao);
            btnLogout.Click += (s, e) => Application.Exit();

            // --- 2. SỰ KIỆN MỞ FORM (NỐI DÂY ĐIỆN) ---

            // == HỆ THỐNG ==
            btnSubDoiMatKhau.Click += (s, e) => OpenForm(new FormDoiMatKhau());
            btnSubQuanLyHeThong.Click += (s, e) => OpenForm(new FormQuanLyHeThong());
            btnSubCaiDat.Click += (s, e) => OpenForm(new FormCaiDatHeThong());
            // Form kết nối và Thông tin thường là Dialog, nên dùng ShowDialog() thay vì OpenForm
            btnSubKetNoi.Click += (s, e) => new FormKetNoiCSDL().ShowDialog();
            btnSubThongTin.Click += (s, e) => new FormThongTinPhanMem().ShowDialog();
            btnSubTroLyAo.Click += (s, e) => OpenForm(new FormTroLyAo());

            // == DANH MỤC ==
            btnSubKhachHang.Click += (s, e) => OpenForm(new FormKhachHang());
            btnSubHangHoa.Click += (s, e) => OpenForm(new FormDanhMucHangHoa());
            btnSubNhanVien.Click += (s, e) => OpenForm(new FormNhanVien());
            btnSubNhomHang.Click += (s, e) => OpenForm(new FormNhomHang());
            btnSubNhaCungCap.Click += (s, e) => OpenForm(new FormNhaCungCap());
            // Có 2 form ngân hàng, tui ưu tiên form Quản Lý
            btnSubNganHang.Click += (s, e) => OpenForm(new FormQuanLyTaiKhoanNganHang());
            btnSubTaiKhoanKeToan.Click += (s, e) => OpenForm(new FormHeThongTaiKhoanKeToan());

            // == NGHIỆP VỤ ==
            btnSubNhapHang.Click += (s, e) => OpenForm(new FormPhieuNhap());
            btnSubBanHang.Click += (s, e) => OpenForm(new FormPhieuXuat());
            btnSubYeuCauNhap.Click += (s, e) => OpenForm(new FormYeuCauNhapKho());
            btnSubBaoGia.Click += (s, e) => OpenForm(new FormBangBaoGia());
            btnSubChamCong.Click += (s, e) => OpenForm(new FormTamUngChamCong());
            btnSubThuChi.Click += (s, e) => OpenForm(new FormThuChi());

            // == BÁO CÁO ==
            btnSubBaoCaoTon.Click += (s, e) => OpenForm(new FormBaoCaoTonKho());
            btnSubBaoCaoLuong.Click += (s, e) => OpenForm(new FormTinhLuong());
            btnSubBaoCaoQuy.Click += (s, e) => OpenForm(new FormBaoCaoQuy());
            btnSubCongNo.Click += (s, e) => OpenForm(new FormReportCongNo());
            btnSubNhatKyChung.Click += (s, e) => OpenForm(new FormSoNhatKyChung());
            btnSubSoChiTiet.Click += (s, e) => OpenForm(new FormSoChiTietTaiKhoan());
        }

        private void ToggleMenu(Panel subMenu)
        {
            if (subMenu.Visible)
            {
                subMenu.Visible = false;
            }
            else
            {
                pnlSubHeThong.Visible = false;
                pnlSubDanhMuc.Visible = false;
                pnlSubNghiepVu.Visible = false;
                pnlSubBaoCao.Visible = false;
                subMenu.Visible = true;
            }
        }

        private void OpenForm(Form childForm)
        {
            if (_activeForm != null) _activeForm.Close();

            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(childForm);
            pnlContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            lblTitle.Text = childForm.Text;
        }

        public void SetLoggedInUser(UserData user)
        {
            // Logic phân quyền (ẩn hiện nút) bà thêm vào đây sau nhé
        }
    }
}