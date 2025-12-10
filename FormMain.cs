using System;
using System.Drawing;
using System.Windows.Forms;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormMain : Form
    {
        private Form _currentChildForm;
        private Button _currentButton;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Mở Dashboard đầu tiên
            OpenChildForm(new FormDashboard(), btnDashboard);
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (_currentChildForm != null)
            {
                _currentChildForm.Close();
            }

            ActivateButton(btnSender);

            _currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlBody.Controls.Add(childForm);
            pnlBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            lblTitle.Text = childForm.Text.ToUpper();
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (_currentButton != null)
                {
                    // Trả lại màu cũ cho nút trước đó
                    _currentButton.BackColor = Color.FromArgb(26, 32, 40);
                }

                _currentButton = (Button)btnSender;
                // Highlight nút đang chọn
                _currentButton.BackColor = Color.FromArgb(0, 102, 204);
            }
        }

        // --- EVENTS MENU ---
        private void btnDashboard_Click(object sender, EventArgs e) => OpenChildForm(new FormDashboard(), sender);

        // Nhóm Danh Mục (Nếu bà muốn làm menu con thì tính sau, giờ mở Form Hàng Hóa đại diện)
        private void btnHangHoa_Click(object sender, EventArgs e) => OpenChildForm(new FormDanhMucHangHoa(), sender);

        // Nhóm Kho
        private void btnYeuCau_Click(object sender, EventArgs e) => OpenChildForm(new FormYeuCauNhapKho(), sender);
        private void btnNhapKho_Click(object sender, EventArgs e) => OpenChildForm(new FormPhieuNhap(), sender);
        private void btnXuatKho_Click(object sender, EventArgs e) => OpenChildForm(new FormPhieuXuat(), sender);
        private void btnTonKho_Click(object sender, EventArgs e) => OpenChildForm(new FormTongHopKho(), sender); // Form Tổng Hợp Kho

        // Nhóm Tiền
        private void btnThuChi_Click(object sender, EventArgs e) => OpenChildForm(new FormThuChi(), sender);
        private void btnCongNo_Click(object sender, EventArgs e) => OpenChildForm(new FormReportCongNo(), sender);

        // Nhóm Hệ Thống
        private void btnTaiKhoan_Click(object sender, EventArgs e) => OpenChildForm(new FormQuanLyHeThong(), sender);

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close(); // Đóng Main để Program.cs mở lại Login
            }
        }
    }
}