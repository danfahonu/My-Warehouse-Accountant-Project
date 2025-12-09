using System;
using System.Data;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Services;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormNhaCungCap : Form
    {
        private readonly NhaCungCapService _service = new NhaCungCapService();
        private string _mode = "";

        public FormNhaCungCap()
        {
            InitializeComponent();
            // --- 3 DÒNG THẦN THÁNH ---
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        private void FormNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadData();
            SetMode("view");
        }

        private void LoadData()
        {
            try
            {
                dgvDanhSach.DataSource = _service.GetAll();
                // Map cột
                if (dgvDanhSach.Columns.Contains("MA_NCC")) dgvDanhSach.Columns["MA_NCC"].HeaderText = "Mã NCC";
                if (dgvDanhSach.Columns.Contains("TEN_NCC")) dgvDanhSach.Columns["TEN_NCC"].HeaderText = "Tên NCC";
                if (dgvDanhSach.Columns.Contains("SDT")) dgvDanhSach.Columns["SDT"].HeaderText = "SĐT";
                if (dgvDanhSach.Columns.Contains("DIACHI_NCC")) dgvDanhSach.Columns["DIACHI_NCC"].HeaderText = "Địa chỉ";
                if (dgvDanhSach.Columns.Contains("EMAIL")) dgvDanhSach.Columns["EMAIL"].HeaderText = "Email";
                if (dgvDanhSach.Columns.Contains("MSTHUE")) dgvDanhSach.Columns["MSTHUE"].HeaderText = "Mã Số Thuế";
                // Ẩn bớt
                if (dgvDanhSach.Columns.Contains("GHICHU")) dgvDanhSach.Columns["GHICHU"].Visible = false;
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải: " + ex.Message); }
        }

        private void SetMode(string mode)
        {
            _mode = mode;
            bool isEditing = (_mode == "add" || _mode == "edit");

            grpDetail.Enabled = isEditing;
            grpList.Enabled = !isEditing;

            btnThem.Visible = !isEditing;
            btnSua.Visible = !isEditing && dgvDanhSach.Rows.Count > 0;
            btnXoa.Visible = !isEditing && dgvDanhSach.Rows.Count > 0;
            btnLuu.Visible = isEditing;
            btnHuy.Visible = isEditing;

            if (_mode == "view" && dgvDanhSach.CurrentRow != null) DisplayDetail(dgvDanhSach.CurrentRow);
            else if (_mode == "add") ClearInputs();
        }

        private void ClearInputs()
        {
            txtMaNCC.Text = ""; txtTenNCC.Text = ""; txtSDT.Text = "";
            txtDiaChi.Text = ""; txtEmail.Text = ""; txtMST.Text = ""; txtGhiChu.Text = "";
        }

        private void DisplayDetail(DataGridViewRow row)
        {
            try
            {
                txtMaNCC.Text = row.Cells["MA_NCC"].Value?.ToString();
                txtTenNCC.Text = row.Cells["TEN_NCC"].Value?.ToString();
                txtSDT.Text = row.Cells["SDT"].Value?.ToString();
                txtDiaChi.Text = row.Cells["DIACHI_NCC"].Value?.ToString();
                txtEmail.Text = row.Cells["EMAIL"].Value?.ToString();
                txtMST.Text = row.Cells["MSTHUE"].Value?.ToString();
                txtGhiChu.Text = row.Cells["GHICHU"].Value?.ToString();
            }
            catch { }
        }

        private void dgvDanhSach_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDanhSach.CurrentRow != null && _mode == "view") DisplayDetail(dgvDanhSach.CurrentRow);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearInputs();
            txtMaNCC.Text = "NCC" + DateTime.Now.ToString("ddHHmmss");
            SetMode("add");
            txtTenNCC.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SetMode("edit");
            txtMaNCC.ReadOnly = true;
            txtTenNCC.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa NCC này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    _service.Delete(txtMaNCC.Text);
                    LoadData();
                    SetMode("view");
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (_mode == "add")
                    _service.Add(txtMaNCC.Text, txtTenNCC.Text, txtSDT.Text, txtDiaChi.Text, txtEmail.Text, txtMST.Text, txtGhiChu.Text);
                else if (_mode == "edit")
                    _service.Update(txtMaNCC.Text, txtTenNCC.Text, txtSDT.Text, txtDiaChi.Text, txtEmail.Text, txtMST.Text, txtGhiChu.Text);

                LoadData();
                SetMode("view");
                MessageBox.Show("Lưu thành công!");
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetMode("view");
            dgvDanhSach_SelectionChanged(null, null);
        }

        private void btnThoat_Click(object sender, EventArgs e) => this.Close();

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (dgvDanhSach.DataSource is DataTable dt)
                dt.DefaultView.RowFilter = $"TEN_NCC LIKE '%{txtTimKiem.Text}%' OR SDT LIKE '%{txtTimKiem.Text}%'";
        }
    }
}