using System;
using System.Drawing;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Core;
// Nhớ using namespace chứa form con, ví dụ DoAnLapTrinhQuanLy.GuiLayer.DanhMuc...

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FrmMain : Form
    {
        private Form _activeForm = null;

        public FrmMain()
        {
            InitializeComponent();
            SetupEventHandlers(); // Gán sự kiện click ở đây
        }

        private void SetupEventHandlers()
        {
            // --- 1. SỰ KIỆN CLICK MENU CHA (Xổ menu con) ---
            btnDanhMuc.Click += (s, e) => ToggleSubMenu(pnlSubDanhMuc);
            btnNghiepVu.Click += (s, e) => ToggleSubMenu(pnlSubNghiepVu);
            btnBaoCao.Click += (s, e) => ToggleSubMenu(pnlSubBaoCao);

            // Nút Thoát
            btnLogout.Click += (s, e) => Application.Exit();

            // --- 2. SỰ KIỆN CLICK MỞ FORM CON (Nối dây điện ở đây nè) ---

            // == NHÓM DANH MỤC ==
            btnSubKhachHang.Click += (s, e) => OpenChildForm(new FormKhachHang());
            btnSubNhanVien.Click += (s, e) => OpenChildForm(new FormNhanVien());
            // Lưu ý: Tên form hàng hóa bà gửi lúc đầu là FormDanhMucHangHoa
            btnSubHangHoa.Click += (s, e) => OpenChildForm(new FormDanhMucHangHoa());

            // Nếu bà có mấy nút này trong Designer thì mở comment ra dùng:
            // btnSubNhaCungCap.Click += (s, e) => OpenChildForm(new FormNhaCungCap());
            // btnSubNhomHang.Click += (s, e) => OpenChildForm(new FormNhomHang());
            // btnSubTaiKhoan.Click += (s, e) => OpenChildForm(new FormQuanLyTaiKhoanNganHang());

            // == NHÓM NGHIỆP VỤ ==
            // Giả sử nút Nhập hàng mở FormPhieuNhap
            btnSubNhapHang.Click += (s, e) => OpenChildForm(new FormPhieuNhap());
            // Giả sử nút Bán hàng mở FormPhieuXuat
            btnSubBanHang.Click += (s, e) => OpenChildForm(new FormPhieuXuat());

            // Các nghiệp vụ khác (bà map tương ứng với nút trong Designer nha)
            // btnSubThu.Click += (s, e) => OpenChildForm(new FormPhieuThu());
            // btnSubChi.Click += (s, e) => OpenChildForm(new FormPhieuChi());
            // btnSubChamCong.Click += (s, e) => OpenChildForm(new FormTamUngChamCong());

            // == NHÓM BÁO CÁO ==
            btnSubBaoCaoTon.Click += (s, e) => OpenChildForm(new FormBaoCaoTonKho());
            // btnSubBaoCaoQuy.Click += (s, e) => OpenChildForm(new FormBaoCaoQuy());
            // btnSubBaoCaoCongNo.Click += (s, e) => OpenChildForm(new FormReportCongNo());
            btnSubBaoCaoLuong.Click += (s, e) => OpenChildForm(new FormTinhLuong());
        }

        private void ToggleSubMenu(Panel subMenu)
        {
            if (subMenu.Visible)
            {
                subMenu.Visible = false;
            }
            else
            {
                // Ẩn hết mấy cái kia trước khi hiện cái này
                pnlSubDanhMuc.Visible = false;
                pnlSubNghiepVu.Visible = false;
                pnlSubBaoCao.Visible = false;

                // Hiện cái cần hiện
                subMenu.Visible = true;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (_activeForm != null)
            {
                _activeForm.Close();
            }

            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(childForm);
            pnlContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            lblTitle.Text = childForm.Text; // Cập nhật tiêu đề
        }
    }
}