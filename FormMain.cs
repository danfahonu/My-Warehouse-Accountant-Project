using DoAnLapTrinhQuanLy.Data;
using DoAnLapTrinhQuanLy.GuiLayer; // Namespace chứa các form của bà (sửa nếu khác)
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DoAnLapTrinhQuanLy
{
    public partial class FormMain : Form // Hoặc BaseForm
    {
        // Form hiện tại đang mở
        private Form activeForm;
        private Button currentButton;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // 1. Phân quyền người dùng khi mở form
            PhanQuyen();

            // 2. Mặc định mở Dashboard
            OpenChildForm(new FormDashboard(), btnDashboard);
        }

        // ==========================================
        // LOGIC PHÂN QUYỀN (QUAN TRỌNG NÈ BÀ)
        // ==========================================
        private void PhanQuyen()
        {
            // Giả sử bà lưu quyền trong Session.MaQuyen (int) hoặc Session.TenQuyen (string)
            // Ví dụ: 1 = Admin, 2 = Thủ kho, 3 = Kế toán, 4 = Nhân viên

            int quyen = Session.LoggedInUser.MaQuyen; // ĐÚNG (Truy cập vào User đang login)

            // Mặc định ẩn hết các nút nhạy cảm trước cho an toàn
            btnQuanLyHeThong.Visible = false;
            btnKetNoiCSDL.Visible = false;
            btnThuChi.Visible = false;
            btnSoNhatKy.Visible = false;

            // --- ADMIN (Toàn quyền) ---
            if (quyen == 1)
            {
                btnQuanLyHeThong.Visible = true;
                btnKetNoiCSDL.Visible = true;
                btnThuChi.Visible = true;
                btnSoNhatKy.Visible = true;
            }
            // --- THỦ KHO (Chỉ làm kho) ---
            else if (quyen == 2)
            {
                // Ẩn tài chính & hệ thống
                lblCatFinance.Visible = false;
                // Có thể ẩn thêm nếu muốn
            }
            // --- KẾ TOÁN (Làm tiền & Báo cáo) ---
            else if (quyen == 3)
            {
                btnThuChi.Visible = true;
                btnSoNhatKy.Visible = true;
                // Ẩn nhập xuất kho thực tế nếu cần
            }
        }

        // ==========================================
        // LOGIC MỞ FORM CON
        // ==========================================
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();

            HighlightButton(btnSender);

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            this.pnlDesktop.Controls.Add(childForm);
            this.pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            lblTitle.Text = childForm.Text.ToUpper();
        }

        private void HighlightButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(0, 150, 136); // Màu xanh nổi bật
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in pnlMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                }
            }
        }

        // ==========================================
        // SỰ KIỆN CLICK MENU (Xử lý chung)
        // ==========================================
        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // Dùng switch case dựa trên tên nút để mở form tương ứng
            switch (btn.Name)
            {
                case "btnDashboard": OpenChildForm(new FormDashboard(), sender); break;

                // --- DANH MỤC ---
                case "btnHangHoa": OpenChildForm(new FormDanhMucHangHoa(), sender); break;
                case "btnNhomHang": OpenChildForm(new FormNhomHang(), sender); break;
                case "btnKhachHang": OpenChildForm(new FormKhachHang(), sender); break;
                case "btnNhaCungCap": OpenChildForm(new FormNhaCungCap(), sender); break;
                case "btnNhanVien": OpenChildForm(new FormNhanVien(), sender); break;

                // --- KHO VẬN ---
                case "btnPhieuNhap": OpenChildForm(new FormPhieuNhap(), sender); break;
                case "btnPhieuXuat": OpenChildForm(new FormPhieuXuat(), sender); break;
                case "btnYeuCauNhap": OpenChildForm(new FormYeuCauNhapKho(), sender); break;

                // --- TÀI CHÍNH ---
                case "btnThuChi": OpenChildForm(new FormThuChi(), sender); break;
                case "btnSoNhatKy": OpenChildForm(new FormSoNhatKyChung(), sender); break;

                // --- BÁO CÁO ---
                case "btnBaoCaoKho": OpenChildForm(new FormBaoCaoKho(), sender); break;
                case "btnTongHopKho": OpenChildForm(new FormTongHopKho(), sender); break;
                case "btnReportCongNo": OpenChildForm(new FormReportCongNo(), sender); break;

                // --- HỆ THỐNG & AI ---
                case "btnHoiDapAI": OpenChildForm(new FormHoiDap(), sender); break; // Form AI nè
                case "btnQuanLyHeThong": OpenChildForm(new FormQuanLyHeThong(), sender); break;
                case "btnKetNoiCSDL": OpenChildForm(new FormKetNoiCSDL(), sender); break;
                case "btnDoiMatKhau": OpenChildForm(new FormDoiMatKhau(), sender); break;

                case "btnDangXuat":
                    if (MessageBox.Show("Bà có chắc muốn đăng xuất hông?", "Hỏi nhỏ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.Hide();
                        FormDangNhap login = new FormDangNhap();
                        login.ShowDialog();
                        this.Close(); // Đóng Main sau khi Login đóng
                    }
                    break;
            }
        }
    }
}