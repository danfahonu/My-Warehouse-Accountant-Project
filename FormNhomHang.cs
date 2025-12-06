using System;
using System.Drawing;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Services;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    /// <summary>
    /// Màn hình Quản Lý Nhóm Hàng.
    /// Kế thừa trực tiếp Form, sử dụng Service và Custom Controls.
    /// </summary>
    public partial class FormNhomHang : Form
    {
        private readonly NhomHangService _service = new NhomHangService();
        private bool _isAdding = false; // Cờ xác định đang Thêm hay Sửa

        public FormNhomHang()
        {
            InitializeComponent();
            ApplyInitialState();
        }

        private void ApplyInitialState()
        {
            // Cài đặt trạng thái ban đầu
            SetInputMode(false);
        }

        private void FormNhomHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        /// <summary>
        /// Tải dữ liệu từ Service và binding vào Grid.
        /// </summary>
        private void LoadData()
        {
            try
            {
                dgvNhomHang.DataSource = _service.LayDanhSach();

                // Đặt tên Header tiếng Việt
                if (dgvNhomHang.Columns["MANHOM"] != null) dgvNhomHang.Columns["MANHOM"].HeaderText = "Mã Nhóm";
                if (dgvNhomHang.Columns["TENNHOM"] != null) dgvNhomHang.Columns["TENNHOM"].HeaderText = "Tên Nhóm";
                if (dgvNhomHang.Columns["GHICHU"] != null) dgvNhomHang.Columns["GHICHU"].HeaderText = "Ghi Chú";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}", "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // LOGIC TRẠNG THÁI GIAO DIỆN
        // =========================================================

        private void SetInputMode(bool enable)
        {
            // Các nút Hành động chính (Thêm/Sửa/Xóa) bị ẩn khi đang Nhập liệu
            btnThem.Enabled = !enable;
            btnSua.Enabled = !enable;
            btnXoa.Enabled = !enable;

            // Các nút Ghi (Lưu/Hủy) chỉ hiện khi đang Nhập liệu
            btnLuu.Enabled = enable;
            btnHuy.Enabled = enable;

            // Textbox
            txtMaNhom.ReadOnly = !_isAdding; // Mã chỉ nhập được khi đang Thêm
            txtTenNhom.ReadOnly = !enable;
            txtGhiChu.ReadOnly = !enable;
        }

        private void ClearInputs()
        {
            txtMaNhom.Text = "";
            txtTenNhom.Text = "";
            txtGhiChu.Text = "";
        }

        // =========================================================
        // XỬ LÝ SỰ KIỆN NÚT BẤM (HANDLERS)
        // =========================================================

        private void btnThem_Click(object sender, EventArgs e)
        {
            _isAdding = true;
            SetInputMode(true);
            ClearInputs();
            txtMaNhom.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNhom.Text))
            {
                MessageBox.Show("Vui lòng chọn nhóm hàng cần sửa!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _isAdding = false;
            SetInputMode(true);
            txtTenNhom.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaNhom.Text;
            if (string.IsNullOrWhiteSpace(ma))
            {
                MessageBox.Show("Vui lòng chọn nhóm hàng cần xóa!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show($"Bạn chắc chắn muốn xóa nhóm: {txtTenNhom.Text}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (_service.Xoa(ma))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo");
                        LoadData();
                        ClearInputs();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi Nghiệp Vụ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // 1. Validation Logic UI
            if (string.IsNullOrWhiteSpace(txtMaNhom.Text) || string.IsNullOrWhiteSpace(txtTenNhom.Text))
            {
                MessageBox.Show("Mã và Tên nhóm không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool success = false;
                // 2. Gọi Service
                if (_isAdding)
                {
                    success = _service.Them(txtMaNhom.Text.Trim(), txtTenNhom.Text.Trim(), txtGhiChu.Text.Trim());
                }
                else
                {
                    success = _service.Sua(txtMaNhom.Text.Trim(), txtTenNhom.Text.Trim(), txtGhiChu.Text.Trim());
                }

                if (success)
                {
                    MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo");
                    LoadData();
                    SetInputMode(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi Nghiệp Vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetInputMode(false);
            _isAdding = false;
            if (dgvNhomHang.CurrentRow != null)
                dgvNhomHang_SelectionChanged(null, null);
            else
                ClearInputs();
        }

        private void dgvNhomHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNhomHang.CurrentRow != null && dgvNhomHang.CurrentRow.Index >= 0)
            {
                var row = dgvNhomHang.CurrentRow;
                txtMaNhom.Text = row.Cells["MANHOM"].Value?.ToString();
                txtTenNhom.Text = row.Cells["TENNHOM"].Value?.ToString();
                txtGhiChu.Text = row.Cells["GHICHU"].Value?.ToString();
            }
        }
    }
}