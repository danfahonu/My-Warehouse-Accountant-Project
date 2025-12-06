using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Services;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    /// <summary>
    /// Màn hình Quản lý Danh mục Hàng hóa.
    /// Refactored: 3-Layer, Modern UI, Custom Controls.
    /// </summary>
    public partial class FormDanhMucHangHoa : Form
    {
        private readonly HangHoaService _service = new HangHoaService();
        private bool _isAdding = false;
        private string _selectedImagePath = null; // Lưu đường dẫn ảnh tạm thời

        public FormDanhMucHangHoa()
        {
            InitializeComponent();
            ApplyInitialState();
        }

        private void ApplyInitialState()
        {
            // Set default view state
            SetInputMode(false);
            picAnhDaiDien.Image = null;
        }

        private void FormDanhMucHangHoa_Load(object sender, EventArgs e)
        {
            LoadComboBoxNhomHang();
            LoadDataGrid();
        }

        // ===================================
        // DATA LOADING
        // ===================================

        private void LoadComboBoxNhomHang()
        {
            try
            {
                DataTable dt = _service.LayDanhSachNhomHang();
                cboNhomHang.DataSource = dt;
                cboNhomHang.DisplayMember = "TENNHOM";
                cboNhomHang.ValueMember = "MANHOM";
                cboNhomHang.SelectedIndex = -1; // Clear selection
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải nhóm hàng: " + ex.Message);
            }
        }

        private void LoadDataGrid()
        {
            try
            {
                DataTable dt = _service.LayDanhSach();
                dgvHangHoa.DataSource = dt;

                // Format Columns
                FormatGridColumn("MAHH", "Mã Hàng", 100);
                FormatGridColumn("TENHH", "Tên Hàng Hóa", 250);
                FormatGridColumn("TENNHOM", "Nhóm Hàng", 150);
                FormatGridColumn("DVT", "ĐVT", 80);
                FormatGridColumn("TONKHO", "Tồn Kho", 80, true);
                FormatGridColumn("GIAVON", "Giá Vốn", 120, true);
                FormatGridColumn("GIABAN", "Giá Bán", 120, true);

                // Hide Internal Columns
                if (dgvHangHoa.Columns["MANHOM"] != null) dgvHangHoa.Columns["MANHOM"].Visible = false;
                if (dgvHangHoa.Columns["ANH"] != null) dgvHangHoa.Columns["ANH"].Visible = false;
                if (dgvHangHoa.Columns["ACTIVE"] != null) dgvHangHoa.Columns["ACTIVE"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách hàng hóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatGridColumn(string colName, string headerText, int width, bool isNumber = false)
        {
            if (dgvHangHoa.Columns[colName] != null)
            {
                dgvHangHoa.Columns[colName].HeaderText = headerText;
                dgvHangHoa.Columns[colName].Width = width;

                if (isNumber)
                {
                    dgvHangHoa.Columns[colName].DefaultCellStyle.Format = "N0";
                    dgvHangHoa.Columns[colName].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
        }

        // ===================================
        // UI STATES & LOGIC
        // ===================================

        private void SetInputMode(bool enable)
        {
            // Inputs
            txtMaHH.ReadOnly = !_isAdding;
            txtTenHH.ReadOnly = !enable;
            txtDVT.ReadOnly = !enable;
            numGiaVon.Enabled = enable;
            numGiaBan.Enabled = enable;
            cboNhomHang.Enabled = enable;
            chkActive.Enabled = enable;
            btnChonAnh.Enabled = enable;

            // Actions
            btnLuu.Enabled = enable;
            btnHuy.Enabled = enable;

            btnThem.Enabled = !enable;
            btnSua.Enabled = !enable;
            btnXoa.Enabled = !enable;
        }

        private void ClearInputs()
        {
            txtMaHH.Text = "";
            txtTenHH.Text = "";
            txtDVT.Text = "";
            numGiaVon.Value = 0;
            numGiaBan.Value = 0;
            cboNhomHang.SelectedIndex = -1;
            chkActive.Checked = true;
            picAnhDaiDien.Image = null;
            _selectedImagePath = null;
        }

        // ===================================
        // EVENT HANDLERS
        // ===================================

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _selectedImagePath = ofd.FileName;
                    picAnhDaiDien.Image = Image.FromFile(_selectedImagePath);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _isAdding = true;
            ClearInputs();
            SetInputMode(true);
            txtMaHH.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHH.Text))
            {
                MessageBox.Show("Vui lòng chọn hàng hóa cần sửa!");
                return;
            }
            _isAdding = false;
            SetInputMode(true);
            txtTenHH.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHH.Text))
            {
                MessageBox.Show("Vui lòng chọn hàng hóa cần xóa!");
                return;
            }

            if (MessageBox.Show($"Bạn có chắc chắn xóa hàng '{txtTenHH.Text}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (_service.Xoa(txtMaHH.Text))
                    {
                        MessageBox.Show("Xóa thành công!");
                        LoadDataGrid();
                        ClearInputs();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi nghiệp vụ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(txtMaHH.Text) || string.IsNullOrWhiteSpace(txtTenHH.Text))
            {
                MessageBox.Show("Mã và Tên hàng không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboNhomHang.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Nhóm hàng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string maNhom = cboNhomHang.SelectedValue.ToString();

                // TODO: Xử lý lưu ảnh chuyên sâu (Copy vào folder / Convert Base64). 
                // Ở đây tạm lưu đường dẫn hoặc chuỗi rỗng.
                string pathAnh = _selectedImagePath ?? "";

                bool result = false;

                if (_isAdding)
                {
                    result = _service.Them(
                        txtMaHH.Text.Trim(),
                        txtTenHH.Text.Trim(),
                        maNhom,
                        txtDVT.Text.Trim(),
                        numGiaVon.Value,
                        numGiaBan.Value,
                        pathAnh,
                        chkActive.Checked);
                }
                else
                {
                    result = _service.Sua(
                        txtMaHH.Text.Trim(),
                        txtTenHH.Text.Trim(),
                        maNhom,
                        txtDVT.Text.Trim(),
                        numGiaVon.Value,
                        numGiaBan.Value,
                        pathAnh,
                        chkActive.Checked);
                }

                if (result)
                {
                    MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo");
                    LoadDataGrid();
                    SetInputMode(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetInputMode(false);
            _isAdding = false;
            // Load lại dòng đang chọn
            if (dgvHangHoa.CurrentRow != null)
                dgvHangHoa_SelectionChanged(null, null);
            else
                ClearInputs();
        }

        private void dgvHangHoa_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHangHoa.CurrentRow != null && dgvHangHoa.CurrentRow.Index >= 0)
            {
                var row = dgvHangHoa.CurrentRow;

                txtMaHH.Text = row.Cells["MAHH"].Value?.ToString();
                txtTenHH.Text = row.Cells["TENHH"].Value?.ToString();
                txtDVT.Text = row.Cells["DVT"].Value?.ToString();

                // Numeric Up Down safe set
                if (decimal.TryParse(row.Cells["GIAVON"].Value?.ToString(), out decimal giaVon))
                    numGiaVon.Value = giaVon;

                if (decimal.TryParse(row.Cells["GIABAN"].Value?.ToString(), out decimal giaBan))
                    numGiaBan.Value = giaBan;

                // ComboBox safe set
                string maNhom = row.Cells["MANHOM"].Value?.ToString();
                if (!string.IsNullOrEmpty(maNhom))
                    cboNhomHang.SelectedValue = maNhom;

                // Checkbox
                if (row.Cells["ACTIVE"].Value != DBNull.Value)
                    chkActive.Checked = Convert.ToBoolean(row.Cells["ACTIVE"].Value);

                // Image loading logic (Simple check)
                string imgPath = row.Cells["ANH"].Value?.ToString();
                if (!string.IsNullOrEmpty(imgPath) && File.Exists(imgPath))
                {
                    picAnhDaiDien.Image = Image.FromFile(imgPath);
                    _selectedImagePath = imgPath;
                }
                else
                {
                    picAnhDaiDien.Image = null;
                }
            }
        }
    }
}