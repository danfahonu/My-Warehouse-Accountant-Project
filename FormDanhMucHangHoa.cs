using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Services;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormDanhMucHangHoa : Form
    {
        private readonly HangHoaService _service = new HangHoaService();
        private string _mode = "";

        // --- QUAN TRỌNG: Biến này dùng để giữ dữ liệu ảnh gốc ---
        private byte[] _currentImageBytes = null;

        public FormDanhMucHangHoa()
        {
            InitializeComponent();
        }

        private void FormDanhMucHangHoa_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            LoadData();
            SetMode("view");
        }

        private void LoadCombobox()
        {
            cboNhomHang.DataSource = _service.GetNhomHang();
            cboNhomHang.DisplayMember = "TENNHOM";
            cboNhomHang.ValueMember = "MANHOM";
            cboNhomHang.SelectedIndex = -1;
        }

        private void LoadData()
        {
            try
            {
                dgvDanhSach.DataSource = _service.GetAll();

                // Định dạng cột (Giữ nguyên như cũ)
                if (dgvDanhSach.Columns.Contains("MAHH")) dgvDanhSach.Columns["MAHH"].HeaderText = "Mã HH";
                if (dgvDanhSach.Columns.Contains("TENHH"))
                {
                    dgvDanhSach.Columns["TENHH"].HeaderText = "Tên Hàng Hóa";
                    dgvDanhSach.Columns["TENHH"].Width = 200;
                }
                if (dgvDanhSach.Columns.Contains("DVT")) dgvDanhSach.Columns["DVT"].HeaderText = "ĐVT";

                // Ẩn cột kỹ thuật
                if (dgvDanhSach.Columns.Contains("MANHOM")) dgvDanhSach.Columns["MANHOM"].Visible = false;
                if (dgvDanhSach.Columns.Contains("ACTIVE")) dgvDanhSach.Columns["ACTIVE"].Visible = false;
                if (dgvDanhSach.Columns.Contains("ANH")) dgvDanhSach.Columns["ANH"].Visible = false; // Ẩn cột Binary đi
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
            txtMaHH.Text = "";
            txtTenHH.Text = "";
            txtDVT.Text = "";
            txtGiaVon.Text = "0";
            txtGiaBan.Text = "0";
            txtTonKho.Text = "0";
            cboNhomHang.SelectedIndex = -1;

            // Xóa ảnh và biến chứa ảnh
            picHinhAnh.Image = null;
            _currentImageBytes = null;
        }

        private void DisplayDetail(DataGridViewRow row)
        {
            try
            {
                txtMaHH.Text = row.Cells["MAHH"].Value.ToString();
                txtTenHH.Text = row.Cells["TENHH"].Value.ToString();
                txtDVT.Text = row.Cells["DVT"].Value.ToString();

                txtGiaVon.Text = row.Cells["GIAVON"].Value != DBNull.Value ? Convert.ToDecimal(row.Cells["GIAVON"].Value).ToString("N0") : "0";
                txtGiaBan.Text = row.Cells["GIABAN"].Value != DBNull.Value ? Convert.ToDecimal(row.Cells["GIABAN"].Value).ToString("N0") : "0";
                txtTonKho.Text = row.Cells["TONKHO"].Value != DBNull.Value ? Convert.ToDecimal(row.Cells["TONKHO"].Value).ToString("N0") : "0";

                cboNhomHang.SelectedValue = row.Cells["MANHOM"].Value.ToString();

                // --- XỬ LÝ HIỂN THỊ ẢNH ---
                if (row.Cells["ANH"].Value != DBNull.Value)
                {
                    // 1. Lấy dữ liệu từ Grid lưu vào biến nhớ (QUAN TRỌNG: Để khi Sửa ko bị mất ảnh)
                    _currentImageBytes = (byte[])row.Cells["ANH"].Value;

                    // 2. Hiển thị lên PictureBox
                    using (MemoryStream ms = new MemoryStream(_currentImageBytes))
                    {
                        picHinhAnh.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    _currentImageBytes = null;
                    picHinhAnh.Image = null;
                }
            }
            catch
            {
                // Nếu ảnh lỗi thì reset về rỗng để không crash app
                picHinhAnh.Image = null;
                _currentImageBytes = null;
            }
        }

        // --- NÚT CHỌN HÌNH (SỬA LẠI ĐỂ LƯU VÀO BIẾN TOÀN CỤC) ---
        // --- NÚT CHỌN HÌNH (PHIÊN BẢN MỚI: TỰ ĐỘNG NÉN ẢNH) ---
        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // 1. Load ảnh gốc lên
                        using (var originalImage = Image.FromFile(ofd.FileName))
                        {
                            // 2. Resize ảnh nếu quá to (Max chiều rộng/cao là 800px)
                            // Giúp giảm dung lượng từ vài MB xuống vài chục KB -> App chạy nhanh hơn
                            int maxWidth = 800;
                            int maxHeight = 800;
                            var newSize = CalculateResizedDimensions(originalImage, maxWidth, maxHeight);

                            using (var resizedImage = new Bitmap(originalImage, newSize))
                            {
                                // 3. Hiển thị lên PictureBox
                                picHinhAnh.Image = new Bitmap(resizedImage);

                                // 4. Lưu vào biến _currentImageBytes (Dạng JPEG cho nhẹ)
                                using (var ms = new MemoryStream())
                                {
                                    resizedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                                    _currentImageBytes = ms.ToArray();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xử lý ảnh: " + ex.Message);
                    }
                }
            }
        }

        // Hàm phụ trợ để tính kích thước mới (Giữ nguyên tỷ lệ khung hình)
        private Size CalculateResizedDimensions(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            // Nếu ảnh nhỏ hơn kích thước tối đa thì giữ nguyên
            if (ratio > 1) return new Size(image.Width, image.Height);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);
            return new Size(newWidth, newHeight);
        }

        private void btnXoaHinh_Click(object sender, EventArgs e)
        {
            picHinhAnh.Image = null;
            _currentImageBytes = null; // Xóa dữ liệu trong biến nhớ
        }

        // --- CÁC SỰ KIỆN KHÁC ---

        private void dgvDanhSach_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDanhSach.CurrentRow != null && _mode == "view")
                DisplayDetail(dgvDanhSach.CurrentRow);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SetMode("add");
            txtMaHH.Text = "HH" + DateTime.Now.ToString("ddHHmm");
            txtTenHH.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SetMode("edit");
            txtMaHH.ReadOnly = true;
            txtTenHH.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa hàng hóa này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    _service.Delete(txtMaHH.Text);
                    LoadData();
                    SetMode("view");
                }
                catch (Exception ex) { MessageBox.Show("Lỗi xóa: " + ex.Message); }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenHH.Text)) { MessageBox.Show("Chưa nhập tên hàng!"); return; }
            if (cboNhomHang.SelectedValue == null) { MessageBox.Show("Chưa chọn nhóm hàng!"); return; }

            try
            {
                decimal gv = 0, gb = 0;
                decimal.TryParse(txtGiaVon.Text, out gv);
                decimal.TryParse(txtGiaBan.Text, out gb);
                string maNhom = cboNhomHang.SelectedValue.ToString();

                // Lưu lại mã hàng đang thao tác để lát nữa tìm lại
                string currentMaHH = txtMaHH.Text;

                // Lấy dữ liệu ảnh từ biến toàn cục (đã được nén/xử lý ở bước chọn hình)
                // Nếu không chọn hình mới thì biến này vẫn giữ hình cũ hoặc null
                byte[] imgData = _currentImageBytes;

                if (_mode == "add")
                    _service.Add(currentMaHH, txtTenHH.Text, txtDVT.Text, gv, gb, maNhom, imgData);
                else if (_mode == "edit")
                    _service.Update(currentMaHH, txtTenHH.Text, txtDVT.Text, gv, gb, maNhom, imgData);

                MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData(); // Load lại lưới
                SetMode("view");

                // --- ĐOẠN NÀY ĐỂ FIX LỖI MẤT HÌNH ---
                // Tự động tìm và chọn lại dòng vừa lưu để hiện hình lên
                foreach (DataGridViewRow row in dgvDanhSach.Rows)
                {
                    if (row.Cells["MAHH"].Value.ToString() == currentMaHH)
                    {
                        row.Selected = true;
                        dgvDanhSach.CurrentCell = row.Cells[0]; // Kích hoạt sự kiện SelectionChanged
                        DisplayDetail(row); // Gọi hiển thị chi tiết ngay lập tức
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
                dt.DefaultView.RowFilter = $"TENHH LIKE '%{txtTimKiem.Text}%' OR MAHH LIKE '%{txtTimKiem.Text}%'";
            }
        }
    }
}