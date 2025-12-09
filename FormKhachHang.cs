using System;
using System.Data;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Services;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormKhachHang : Form
    {
        private readonly KhachHangService _service = new KhachHangService();
        private string _mode = "";

        public FormKhachHang()
        {
            InitializeComponent();
            // --- BẮT BUỘC ĐỂ CHẠY TRONG MAIN ---
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
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
                dgvDanhSach.DataSource = _service.GetAll();
                // Map cột theo CSDL của bà
                if (dgvDanhSach.Columns.Contains("MAKH")) dgvDanhSach.Columns["MAKH"].HeaderText = "Mã KH";
                if (dgvDanhSach.Columns.Contains("TENKH")) dgvDanhSach.Columns["TENKH"].HeaderText = "Tên Khách Hàng";
                if (dgvDanhSach.Columns.Contains("SDT")) dgvDanhSach.Columns["SDT"].HeaderText = "SĐT";
                if (dgvDanhSach.Columns.Contains("DIACHI")) dgvDanhSach.Columns["DIACHI"].HeaderText = "Địa chỉ";
                if (dgvDanhSach.Columns.Contains("EMAIL")) dgvDanhSach.Columns["EMAIL"].HeaderText = "Email";
                // Ẩn mấy cái không cần hiện
                if (dgvDanhSach.Columns.Contains("GHICHU")) dgvDanhSach.Columns["GHICHU"].Visible = false;
                if (dgvDanhSach.Columns.Contains("NGAYTAO")) dgvDanhSach.Columns["NGAYTAO"].Visible = false;
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
            txtMaKH.Text = ""; txtTenKH.Text = ""; txtSDT.Text = "";
            txtDiaChi.Text = ""; txtEmail.Text = ""; txtGhiChu.Text = "";
        }

        private void DisplayDetail(DataGridViewRow row)
        {
            try
            {
                txtMaKH.Text = row.Cells["MAKH"].Value?.ToString();
                txtTenKH.Text = row.Cells["TENKH"].Value?.ToString();
                txtSDT.Text = row.Cells["SDT"].Value?.ToString();
                txtDiaChi.Text = row.Cells["DIACHI"].Value?.ToString();
                txtEmail.Text = row.Cells["EMAIL"].Value?.ToString();
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
            txtMaKH.Text = "KH" + DateTime.Now.ToString("ddHHmmss"); // Tự sinh mã
            SetMode("add");
            txtTenKH.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SetMode("edit");
            txtMaKH.ReadOnly = true;
            txtTenKH.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    _service.Delete(txtMaKH.Text);
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
                    _service.Add(txtMaKH.Text, txtTenKH.Text, txtSDT.Text, txtDiaChi.Text, txtEmail.Text, txtGhiChu.Text);
                else if (_mode == "edit")
                    _service.Update(txtMaKH.Text, txtTenKH.Text, txtSDT.Text, txtDiaChi.Text, txtEmail.Text, txtGhiChu.Text);

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
                dt.DefaultView.RowFilter = $"TENKH LIKE '%{txtTimKiem.Text}%' OR SDT LIKE '%{txtTimKiem.Text}%'";
        }
    }
}