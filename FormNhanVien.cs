using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Services;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormNhanVien : Form
    {
        private readonly NhanVienService _service = new NhanVienService();
        private string _mode = "";
        private byte[] _currentImageBytes = null;

        public FormNhanVien()
        {
            InitializeComponent();
            // --- 3 DÒNG THẦN THÁNH ---
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            LoadComboBoxChucVu(); // Load chức vụ trước
            LoadData();
            SetMode("view");
        }

        private void LoadComboBoxChucVu()
        {
            try
            {
                cboChucVu.DataSource = _service.GetChucVu();
                cboChucVu.DisplayMember = "CHUCVU";
                cboChucVu.ValueMember = "CHUCVU";
                cboChucVu.SelectedIndex = -1;
            }
            catch { }
        }

        private void LoadData()
        {
            try
            {
                dgvDanhSach.DataSource = _service.GetAll();

                if (dgvDanhSach.Columns.Contains("MANV")) dgvDanhSach.Columns["MANV"].HeaderText = "Mã NV";
                if (dgvDanhSach.Columns.Contains("HOTEN")) dgvDanhSach.Columns["HOTEN"].HeaderText = "Họ Tên";
                if (dgvDanhSach.Columns.Contains("CHUCVU")) dgvDanhSach.Columns["CHUCVU"].HeaderText = "Chức vụ";
                if (dgvDanhSach.Columns.Contains("SDT")) dgvDanhSach.Columns["SDT"].HeaderText = "SĐT";

                // Ẩn bớt
                string[] hidden = { "DIACHI", "EMAIL", "ANH", "HOATDONG" };
                foreach (var c in hidden)
                    if (dgvDanhSach.Columns.Contains(c)) dgvDanhSach.Columns[c].Visible = false;
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
            btnChonHinh.Visible = isEditing;
            btnXoaHinh.Visible = isEditing;

            if (_mode == "view" && dgvDanhSach.CurrentRow != null) DisplayDetail(dgvDanhSach.CurrentRow);
            else if (_mode == "add") ClearInputs();
        }

        private void ClearInputs()
        {
            txtMaNV.Text = "NV" + DateTime.Now.ToString("ddHHmm");
            txtHoTen.Text = "";
            cboChucVu.SelectedIndex = -1; // Reset combobox
            txtSDT.Text = ""; txtEmail.Text = ""; txtDiaChi.Text = "";
            picAvatar.Image = null; _currentImageBytes = null;
        }

        private void DisplayDetail(DataGridViewRow row)
        {
            try
            {
                txtMaNV.Text = row.Cells["MANV"].Value?.ToString();
                txtHoTen.Text = row.Cells["HOTEN"].Value?.ToString();
                cboChucVu.SelectedValue = row.Cells["CHUCVU"].Value?.ToString(); // Chọn đúng chức vụ
                txtSDT.Text = row.Cells["SDT"].Value?.ToString();
                txtEmail.Text = row.Cells["EMAIL"].Value?.ToString();
                txtDiaChi.Text = row.Cells["DIACHI"].Value?.ToString();

                if (row.Cells["ANH"].Value != DBNull.Value)
                {
                    _currentImageBytes = (byte[])row.Cells["ANH"].Value;
                    using (MemoryStream ms = new MemoryStream(_currentImageBytes)) picAvatar.Image = Image.FromStream(ms);
                }
                else
                {
                    _currentImageBytes = null; picAvatar.Image = null;
                }
            }
            catch { }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text)) { MessageBox.Show("Chưa nhập tên!"); return; }
            if (cboChucVu.SelectedIndex == -1) { MessageBox.Show("Chưa chọn chức vụ!"); return; } // Bắt lỗi chưa chọn

            try
            {
                string chucVu = cboChucVu.SelectedValue.ToString(); // Lấy giá trị từ Combo

                if (_mode == "add")
                    _service.Add(txtMaNV.Text, txtHoTen.Text, chucVu, txtDiaChi.Text, txtSDT.Text, txtEmail.Text, _currentImageBytes);
                else if (_mode == "edit")
                    _service.Update(txtMaNV.Text, txtHoTen.Text, chucVu, txtDiaChi.Text, txtSDT.Text, txtEmail.Text, _currentImageBytes);

                MessageBox.Show("Lưu thành công!");
                LoadData();
                SetMode("view");
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        // Các nút khác giữ nguyên
        private void dgvDanhSach_SelectionChanged(object sender, EventArgs e) { if (dgvDanhSach.CurrentRow != null && _mode == "view") DisplayDetail(dgvDanhSach.CurrentRow); }
        private void btnThem_Click(object sender, EventArgs e) { ClearInputs(); SetMode("add"); txtHoTen.Focus(); }
        private void btnSua_Click(object sender, EventArgs e) { SetMode("edit"); txtMaNV.ReadOnly = true; txtHoTen.Focus(); }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _service.Delete(txtMaNV.Text); LoadData(); SetMode("view");
            }
        }
        private void btnHuy_Click(object sender, EventArgs e) { SetMode("view"); dgvDanhSach_SelectionChanged(null, null); }
        private void btnThoat_Click(object sender, EventArgs e) => this.Close();

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image|*.jpg;*.png" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _currentImageBytes = File.ReadAllBytes(ofd.FileName);
                    picAvatar.Image = Image.FromFile(ofd.FileName);
                }
            }
        }
        private void btnXoaHinh_Click(object sender, EventArgs e) { picAvatar.Image = null; _currentImageBytes = null; }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            (dgvDanhSach.DataSource as DataTable).DefaultView.RowFilter = $"HOTEN LIKE '%{txtTimKiem.Text}%'";
        }
    }
}