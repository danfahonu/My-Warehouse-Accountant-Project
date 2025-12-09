using System;
using System.Data;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Services;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormNhomHang : Form
    {
        private readonly NhomHangService _service = new NhomHangService();
        private string _mode = ""; // "add", "edit", "view"

        public FormNhomHang()
        {
            InitializeComponent();
        }

        private void FormNhomHang_Load(object sender, EventArgs e)
        {
            LoadData();
            SetMode("view");
        }

        private void LoadData()
        {
            try
            {
                dgvDanhSach.DataSource = _service.GetAll();

                // Format cột
                if (dgvDanhSach.Columns.Contains("MANHOM")) dgvDanhSach.Columns["MANHOM"].HeaderText = "Mã Nhóm";
                if (dgvDanhSach.Columns.Contains("TENNHOM"))
                {
                    dgvDanhSach.Columns["TENNHOM"].HeaderText = "Tên Nhóm Hàng";
                    dgvDanhSach.Columns["TENNHOM"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                if (dgvDanhSach.Columns.Contains("GHICHU")) dgvDanhSach.Columns["GHICHU"].HeaderText = "Ghi Chú";
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

            grpDetail.Enabled = isEditing;
            grpList.Enabled = !isEditing;

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
            txtMaNhom.Text = "";
            txtTenNhom.Text = "";
            txtGhiChu.Text = "";
        }

        private void DisplayDetail(DataGridViewRow row)
        {
            try
            {
                txtMaNhom.Text = row.Cells["MANHOM"].Value.ToString();
                txtTenNhom.Text = row.Cells["TENNHOM"].Value.ToString();
                txtGhiChu.Text = row.Cells["GHICHU"].Value.ToString();
            }
            catch { }
        }

        // --- EVENTS ---

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
            txtMaNhom.Text = "NH" + DateTime.Now.ToString("ddHHmm");
            txtTenNhom.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SetMode("edit");
            txtMaNhom.ReadOnly = true;
            txtTenNhom.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa nhóm hàng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    _service.Delete(txtMaNhom.Text);
                    LoadData();
                    SetMode("view");
                }
                catch (Exception ex) { MessageBox.Show("Lỗi xóa: " + ex.Message); }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNhom.Text)) { MessageBox.Show("Chưa nhập tên nhóm!"); return; }

            try
            {
                if (_mode == "add")
                    _service.Add(txtMaNhom.Text, txtTenNhom.Text, txtGhiChu.Text);
                else if (_mode == "edit")
                    _service.Update(txtMaNhom.Text, txtTenNhom.Text, txtGhiChu.Text);

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
                dt.DefaultView.RowFilter = $"TENNHOM LIKE '%{txtTimKiem.Text}%'";
            }
        }
    }
}