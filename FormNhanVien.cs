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
        private byte[] _currentImageBytes = null; // Biến giữ ảnh

        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
            SetMode("view");
        }

        private void LoadData()
        {
            try
            {
                dgvDanhSach.DataSource = _service.GetAll();

                // Map tên cột chuẩn
                if (dgvDanhSach.Columns.Contains("MANV")) dgvDanhSach.Columns["MANV"].HeaderText = "Mã NV";
                if (dgvDanhSach.Columns.Contains("HOTEN"))
                {
                    dgvDanhSach.Columns["HOTEN"].HeaderText = "Họ Tên";
                    dgvDanhSach.Columns["HOTEN"].Width = 150;
                }
                if (dgvDanhSach.Columns.Contains("CHUCVU")) dgvDanhSach.Columns["CHUCVU"].HeaderText = "Chức vụ";
                if (dgvDanhSach.Columns.Contains("SDT")) dgvDanhSach.Columns["SDT"].HeaderText = "SĐT";

                // Ẩn cột không cần
                if (dgvDanhSach.Columns.Contains("DIACHI")) dgvDanhSach.Columns["DIACHI"].Visible = false;
                if (dgvDanhSach.Columns.Contains("EMAIL")) dgvDanhSach.Columns["EMAIL"].Visible = false;
                if (dgvDanhSach.Columns.Contains("ANH")) dgvDanhSach.Columns["ANH"].Visible = false;
                if (dgvDanhSach.Columns.Contains("HOATDONG")) dgvDanhSach.Columns["HOATDONG"].Visible = false;
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message); }
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
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            txtChucVu.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            picAvatar.Image = null;
            _currentImageBytes = null;
        }

        private void DisplayDetail(DataGridViewRow row)
        {
            try
            {
                txtMaNV.Text = row.Cells["MANV"].Value.ToString();
                txtHoTen.Text = row.Cells["HOTEN"].Value.ToString();
                txtChucVu.Text = row.Cells["CHUCVU"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtEmail.Text = row.Cells["EMAIL"].Value.ToString();
                txtDiaChi.Text = row.Cells["DIACHI"].Value.ToString();

                // Hiển thị ảnh
                if (row.Cells["ANH"].Value != DBNull.Value)
                {
                    _currentImageBytes = (byte[])row.Cells["ANH"].Value;
                    using (MemoryStream ms = new MemoryStream(_currentImageBytes))
                    {
                        picAvatar.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    _currentImageBytes = null;
                    picAvatar.Image = null;
                }
            }
            catch { picAvatar.Image = null; _currentImageBytes = null; }
        }

        // --- EVENTS ---

        private void dgvDanhSach_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDanhSach.CurrentRow != null && _mode == "view")
                DisplayDetail(dgvDanhSach.CurrentRow);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SetMode("add");
            txtMaNV.Text = "NV" + DateTime.Now.ToString("ddHHmm");
            txtHoTen.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SetMode("edit");
            txtMaNV.ReadOnly = true;
            txtHoTen.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    _service.Delete(txtMaNV.Text);
                    LoadData();
                    SetMode("view");
                }
                catch (Exception ex) { MessageBox.Show("Lỗi xóa: " + ex.Message); }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text)) { MessageBox.Show("Chưa nhập họ tên!"); return; }

            try
            {
                string currentMa = txtMaNV.Text;

                if (_mode == "add")
                    _service.Add(currentMa, txtHoTen.Text, txtChucVu.Text, txtDiaChi.Text, txtSDT.Text, txtEmail.Text, _currentImageBytes);
                else if (_mode == "edit")
                    _service.Update(currentMa, txtHoTen.Text, txtChucVu.Text, txtDiaChi.Text, txtSDT.Text, txtEmail.Text, _currentImageBytes);

                MessageBox.Show("Lưu thành công!");
                LoadData();
                SetMode("view");

                // Giữ dòng vừa chọn
                foreach (DataGridViewRow row in dgvDanhSach.Rows)
                {
                    if (row.Cells["MANV"].Value.ToString() == currentMa)
                    {
                        row.Selected = true;
                        dgvDanhSach.CurrentCell = row.Cells[0];
                        DisplayDetail(row);
                        break;
                    }
                }
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
                dt.DefaultView.RowFilter = $"HOTEN LIKE '%{txtTimKiem.Text}%' OR SDT LIKE '%{txtTimKiem.Text}%'";
            }
        }

        // --- XỬ LÝ ẢNH AN TOÀN ---
        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _currentImageBytes = File.ReadAllBytes(ofd.FileName);
                        using (MemoryStream ms = new MemoryStream(_currentImageBytes))
                        {
                            picAvatar.Image = Image.FromStream(ms);
                        }
                    }
                    catch (Exception ex) { MessageBox.Show("Lỗi hình ảnh: " + ex.Message); }
                }
            }
        }

        private void btnXoaHinh_Click(object sender, EventArgs e)
        {
            picAvatar.Image = null;
            _currentImageBytes = null;
        }
    }
}