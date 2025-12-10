using System;
using System.Data;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Services;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormQuanLyHeThong : Form
    {
        private readonly HeThongService _service = new HeThongService();
        private string _mode = "";

        public FormQuanLyHeThong()
        {
            InitializeComponent();
            // 3 DÒNG THẦN THÁNH
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        private void FormQuanLyHeThong_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCombos();
            SetMode("view");
        }

        private void LoadData()
        {
            dgvUsers.DataSource = _service.GetAllUsers();
            if (dgvUsers.Columns.Contains("PASSWORD")) dgvUsers.Columns["PASSWORD"].Visible = false;
            if (dgvUsers.Columns.Contains("USERNAME")) dgvUsers.Columns["USERNAME"].HeaderText = "Tài Khoản";
            if (dgvUsers.Columns.Contains("FULLNAME")) dgvUsers.Columns["FULLNAME"].HeaderText = "Họ Tên";
            if (dgvUsers.Columns.Contains("ROLE")) dgvUsers.Columns["ROLE"].HeaderText = "Quyền";
        }

        private void LoadCombos()
        {
            cboNhanVien.DataSource = _service.GetNhanVien();
            cboNhanVien.DisplayMember = "HOTEN";
            cboNhanVien.ValueMember = "MANV";
            cboNhanVien.SelectedIndex = -1;
        }

        private void SetMode(string mode)
        {
            _mode = mode;
            bool isEdit = (mode == "add" || mode == "edit");
            grpDetail.Enabled = isEdit;
            grpList.Enabled = !isEdit;

            btnThem.Visible = !isEdit; btnSua.Visible = !isEdit; btnXoa.Visible = !isEdit;
            btnLuu.Visible = isEdit; btnHuy.Visible = isEdit;

            if (mode == "view" && dgvUsers.CurrentRow != null) DisplayDetail(dgvUsers.CurrentRow);
            else if (mode == "add") ClearInputs();
        }

        private void ClearInputs()
        {
            txtTaiKhoan.Text = ""; txtMatKhau.Text = ""; txtHoTen.Text = "";
            cboQuyen.SelectedIndex = 1;
            cboNhanVien.SelectedIndex = -1;
            chkActive.Checked = true;
        }

        private void DisplayDetail(DataGridViewRow row)
        {
            try
            {
                txtTaiKhoan.Text = row.Cells["USERNAME"].Value.ToString();
                txtMatKhau.Text = ""; // Không hiện pass
                txtHoTen.Text = row.Cells["FULLNAME"].Value.ToString();
                cboQuyen.SelectedItem = row.Cells["ROLE"].Value.ToString();
                cboNhanVien.SelectedValue = row.Cells["MANV"].Value;
                chkActive.Checked = Convert.ToBoolean(row.Cells["ACTIVE"].Value);
            }
            catch { }
        }

        private void btnThem_Click(object sender, EventArgs e) { SetMode("add"); txtTaiKhoan.Focus(); }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SetMode("edit");
            txtTaiKhoan.ReadOnly = true;
            //txtMatKhau.PlaceholderText = "Để trống nếu không đổi";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa tài khoản này?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try { _service.DeleteUser(txtTaiKhoan.Text); LoadData(); SetMode("view"); }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string manv = cboNhanVien.SelectedValue?.ToString();
                _service.SaveUser(txtTaiKhoan.Text, txtMatKhau.Text, txtHoTen.Text,
                    cboQuyen.Text, manv, chkActive.Checked, _mode == "add");

                MessageBox.Show("Lưu thành công!");
                LoadData();
                SetMode("view");
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnHuy_Click(object sender, EventArgs e) => SetMode("view");
        private void dgvUsers_SelectionChanged(object sender, EventArgs e) { if (_mode == "view" && dgvUsers.CurrentRow != null) DisplayDetail(dgvUsers.CurrentRow); }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}