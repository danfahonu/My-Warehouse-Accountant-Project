using System;
using System.Data;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Services;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormNhaCungCap : Form
    {
        private readonly NhaCungCapService _service = new NhaCungCapService();
        private string _mode = ""; // "add", "edit", "view"

        public FormNhaCungCap()
        {
            InitializeComponent();
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

                // Format tên cột hiển thị (cho đẹp)
                if (dgvDanhSach.Columns.Contains("MANCC")) dgvDanhSach.Columns["MANCC"].HeaderText = "Mã NCC";
                if (dgvDanhSach.Columns.Contains("TENNCC"))
                {
                    dgvDanhSach.Columns["TENNCC"].HeaderText = "Tên Nhà Cung Cấp";
                    dgvDanhSach.Columns["TENNCC"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                if (dgvDanhSach.Columns.Contains("SDT")) dgvDanhSach.Columns["SDT"].HeaderText = "SĐT";
                if (dgvDanhSach.Columns.Contains("DIACHI")) dgvDanhSach.Columns["DIACHI"].HeaderText = "Địa chỉ";
                if (dgvDanhSach.Columns.Contains("ACTIVE")) dgvDanhSach.Columns["ACTIVE"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void SetMode(string mode)
        {
            _mode = mode;
            bool isEditing = (_mode == "add" || _mode == "edit");

            grpDetail.Enabled = isEditing; // Khóa/Mở vùng nhập liệu
            grpList.Enabled = !isEditing;  // Khóa danh sách

            // Ẩn/Hiện nút thông minh
            btnThem.Visible = !isEditing;
            btnSua.Visible = !isEditing && dgvDanhSach.Rows.Count > 0;
            btnXoa.Visible = !isEditing && dgvDanhSach.Rows.Count > 0;

            btnLuu.Visible = isEditing;
            btnHuy.Visible = isEditing;

            if (_mode == "view" && dgvDanhSach.CurrentRow != null)
            {
                DisplayDetail(dgvDanhSach.CurrentRow);
            }
            else if (_mode == "add")
            {
                ClearInputs();
            }
        }

        private void ClearInputs()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
        }

        private void DisplayDetail(DataGridViewRow row)
        {
            try
            {
                txtMaNCC.Text = row.Cells["MANCC"].Value.ToString();
                txtTenNCC.Text = row.Cells["TENNCC"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtDiaChi.Text = row.Cells["DIACHI"].Value.ToString();
            }
            catch { }
        }

        // --- SỰ KIỆN NÚT BẤM ---

        private void dgvDanhSach_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDanhSach.CurrentRow != null && _mode == "view")
            {
                DisplayDetail(dgvDanhSach.CurrentRow);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SetMode("add");
            txtMaNCC.Text = "NCC" + DateTime.Now.ToString("ddHHmm");
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
            if (MessageBox.Show("Xóa nhà cung cấp này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    _service.Delete(txtMaNCC.Text);
                    LoadData();
                    SetMode("view");
                }
                catch (Exception ex) { MessageBox.Show("Lỗi xóa: " + ex.Message); }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNCC.Text)) { MessageBox.Show("Chưa nhập tên!"); return; }

            try
            {
                if (_mode == "add")
                    _service.Add(txtMaNCC.Text, txtTenNCC.Text, txtSDT.Text, txtDiaChi.Text);
                else if (_mode == "edit")
                    _service.Update(txtMaNCC.Text, txtTenNCC.Text, txtSDT.Text, txtDiaChi.Text);

                MessageBox.Show("Lưu thành công!");
                LoadData();
                SetMode("view");
            }
            catch (Exception ex) { MessageBox.Show("Lỗi lưu: " + ex.Message); }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetMode("view");
            dgvDanhSach_SelectionChanged(null, null);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (dgvDanhSach.DataSource is DataTable dt)
            {
                dt.DefaultView.RowFilter = $"TENNCC LIKE '%{txtTimKiem.Text}%' OR SDT LIKE '%{txtTimKiem.Text}%'";
            }
        }
    }
}