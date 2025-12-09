using System;
using System.Data;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Services;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormKhachHang : Form
    {
        // Service của bà (giữ nguyên logic)
        private readonly KhachHangService _service = new KhachHangService();
        private string _mode = ""; // "add", "edit", "view"

        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
            SetMode("view");
        }

        private void LoadData()
        {
            try
            {
                // Hàm GetAll() của Service bà đã có
                dgvDanhSach.DataSource = _service.GetAll();

                // Định dạng cột Grid (nếu cần)
                if (dgvDanhSach.Columns.Contains("MAKH")) dgvDanhSach.Columns["MAKH"].HeaderText = "Mã KH";
                if (dgvDanhSach.Columns.Contains("TENKH")) dgvDanhSach.Columns["TENKH"].HeaderText = "Tên Khách Hàng";
                if (dgvDanhSach.Columns.Contains("SDT")) dgvDanhSach.Columns["SDT"].HeaderText = "SĐT";
                if (dgvDanhSach.Columns.Contains("DIACHI")) dgvDanhSach.Columns["DIACHI"].HeaderText = "Địa chỉ";
                if (dgvDanhSach.Columns.Contains("ACTIVE")) dgvDanhSach.Columns["ACTIVE"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        // --- HÀM ĐIỀU KHIỂN TRẠNG THÁI NÚT ---
        private void SetMode(string mode)
        {
            _mode = mode;
            bool isEditing = (_mode == "add" || _mode == "edit"); // Đang nhập liệu?

            // 1. Quản lý vùng nhập liệu (Trái tim của logic)
            grpDetail.Enabled = isEditing; // Chỉ cho nhập khi đang Thêm/Sửa
            grpList.Enabled = !isEditing;  // Khóa danh sách bên trái khi đang nhập (để ko bấm lộn)

            // 2. ẨN / HIỆN NÚT (MAGIC LÀ Ở ĐÂY)
            // Nhóm 1: Khi bình thường (View) -> Hiện Thêm, Sửa, Xóa. Ẩn Lưu, Hủy.
            btnThem.Visible = !isEditing;
            btnSua.Visible = !isEditing && dgvDanhSach.Rows.Count > 0; // Có dòng mới hiện Sửa
            btnXoa.Visible = !isEditing && dgvDanhSach.Rows.Count > 0; // Có dòng mới hiện Xóa

            // Nhóm 2: Khi đang nhập (Add/Edit) -> Hiện Lưu, Hủy. Ẩn đám kia đi.
            btnLuu.Visible = isEditing;
            btnHuy.Visible = isEditing;

            // 3. Xử lý dữ liệu hiển thị
            if (_mode == "view" && dgvDanhSach.CurrentRow != null)
            {
                DisplayDetail(dgvDanhSach.CurrentRow);
            }
            else if (_mode == "add") // Nếu đang thêm thì xóa trắng
            {
                ClearInputs();
            }
        }

        private void ClearInputs()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
        }

        private void DisplayDetail(DataGridViewRow row)
        {
            try
            {
                txtMaKH.Text = row.Cells["MAKH"].Value.ToString();
                txtTenKH.Text = row.Cells["TENKH"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtDiaChi.Text = row.Cells["DIACHI"].Value.ToString();
            }
            catch { }
        }

        // --- CÁC SỰ KIỆN NÚT BẤM (GIỮ NGUYÊN LOGIC) ---

        private void dgvDanhSach_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDanhSach.CurrentRow != null && _mode == "view")
            {
                DisplayDetail(dgvDanhSach.CurrentRow);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearInputs();
            // Tự sinh mã KH theo ngày giờ (hoặc logic của bà)
            txtMaKH.Text = "KH" + DateTime.Now.ToString("ddHHmm");
            SetMode("add");
            txtTenKH.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SetMode("edit");
            txtMaKH.ReadOnly = true; // Khóa mã khi sửa
            txtTenKH.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _service.Delete(txtMaKH.Text); // Gọi Service xóa
                    LoadData();
                    SetMode("view");
                }
                catch (Exception ex) { MessageBox.Show("Lỗi xóa: " + ex.Message); }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!");
                txtTenKH.Focus();
                return;
            }

            try
            {
                if (_mode == "add")
                {
                    _service.Add(txtMaKH.Text, txtTenKH.Text, txtSDT.Text, txtDiaChi.Text);
                }
                else if (_mode == "edit")
                {
                    _service.Update(txtMaKH.Text, txtTenKH.Text, txtSDT.Text, txtDiaChi.Text);
                }

                MessageBox.Show("Lưu thành công!");
                LoadData();
                SetMode("view");
            }
            catch (Exception ex) { MessageBox.Show("Lỗi lưu: " + ex.Message); }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetMode("view"); // Hủy thao tác -> Quay về xem
            dgvDanhSach_SelectionChanged(null, null); // Load lại dòng đang chọn
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            // Tìm kiếm nhanh trên Grid
            if (dgvDanhSach.DataSource is DataTable dt)
            {
                string filter = $"TENKH LIKE '%{txtTimKiem.Text}%' OR SDT LIKE '%{txtTimKiem.Text}%'";
                dt.DefaultView.RowFilter = filter;
            }
        }
    }
}