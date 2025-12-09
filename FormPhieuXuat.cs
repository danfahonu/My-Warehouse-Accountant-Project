using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Services;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormPhieuXuat : Form
    {
        private readonly PhieuXuatService _service = new PhieuXuatService();
        private readonly KhachHangService _khachHangService = new KhachHangService();
        private readonly HangHoaService _hangHoaService = new HangHoaService();

        private DataTable _dtHangHoa; // Cache danh sách hàng

        public FormPhieuXuat()
        {
            InitializeComponent();
        }

        private void FormPhieuXuat_Load(object sender, EventArgs e)
        {
            try
            {
                LoadComboBoxes();
                LoadHangHoa();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi tạo: " + ex.Message);
            }
        }

        private void LoadComboBoxes()
        {
            DataTable dtKhach = _khachHangService.GetAll();
            cboKhachHang.DataSource = dtKhach;
            cboKhachHang.DisplayMember = "TENKH";
            cboKhachHang.ValueMember = "MAKH";
            cboKhachHang.SelectedIndex = -1;
        }

        private void LoadHangHoa()
        {
            // Load Hàng Hóa và gán vào Cột ComboBox trên lưới
            _dtHangHoa = _service.LayDanhSachHangHoa(); // Hàm này cần trả về cả TONKHO
            colMaHH.DataSource = _dtHangHoa;
            colMaHH.DisplayMember = "TENHH";
            colMaHH.ValueMember = "MAHH";
        }

        private void ResetForm()
        {
            txtSoPhieu.Text = "(Mới)";
            dtpNgayLap.Value = DateTime.Now;
            cboKhachHang.SelectedIndex = -1;
            txtGhiChu.Text = "";
            chkThanhToan.Checked = false;

            dgvChiTiet.Rows.Clear();
            lblTongTien.Text = "0 đ";

            // Mở khóa nhập liệu
            btnLuu.Enabled = true;
            btnIn.Enabled = false;
            dgvChiTiet.ReadOnly = false;
            dgvChiTiet.AllowUserToAddRows = true;
        }

        // --- GRID LOGIC (QUAN TRỌNG) ---

        // Cho phép gõ tìm kiếm trong ComboBox
        private void DgvChiTiet_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvChiTiet.CurrentCell.ColumnIndex == dgvChiTiet.Columns["colMaHH"].Index && e.Control is ComboBox cb)
            {
                cb.DropDownStyle = ComboBoxStyle.DropDown;
                cb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cb.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            // Chỉ cho nhập số
            if (dgvChiTiet.CurrentCell.ColumnIndex == dgvChiTiet.Columns["colSL"].Index ||
                dgvChiTiet.CurrentCell.ColumnIndex == dgvChiTiet.Columns["colDonGia"].Index)
            {
                e.Control.KeyPress -= (s, k) => {
                    if (!char.IsControl(k.KeyChar) && !char.IsDigit(k.KeyChar)) k.Handled = true;
                };
            }
        }

        // Tự động điền dữ liệu khi chọn hàng hoặc sửa số
        private void DgvChiTiet_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvChiTiet.Rows[e.RowIndex];

            // 1. Chọn Hàng Hóa -> Điền ĐVT, Giá, Tồn
            if (dgvChiTiet.Columns[e.ColumnIndex].Name == "colMaHH")
            {
                string maHH = row.Cells["colMaHH"].Value?.ToString();
                if (!string.IsNullOrEmpty(maHH) && _dtHangHoa != null)
                {
                    DataRow[] found = _dtHangHoa.Select($"MAHH = '{maHH}'");
                    if (found.Length > 0)
                    {
                        var r = found[0];
                        row.Cells["colTenHH"].Value = r["TENHH"];
                        row.Cells["colDVT"].Value = r["DVT"];
                        row.Cells["colDonGia"].Value = r["GIABAN"]; // Giá bán lẻ
                        row.Cells["colTonKho"].Value = r["TONKHO"];

                        // Mặc định SL = 1
                        if (row.Cells["colSL"].Value == null) row.Cells["colSL"].Value = 1;
                    }
                }
            }

            // 2. Tính Thành Tiền = SL * Giá (và check Tồn kho)
            if (dgvChiTiet.Columns[e.ColumnIndex].Name == "colSL" ||
                dgvChiTiet.Columns[e.ColumnIndex].Name == "colDonGia" ||
                dgvChiTiet.Columns[e.ColumnIndex].Name == "colMaHH")
            {
                CalculateRow(row);
                ValidateStock(row);
                CalculateTotal();
            }
        }

        private void CalculateRow(DataGridViewRow row)
        {
            try
            {
                decimal sl = Convert.ToDecimal(row.Cells["colSL"].Value ?? 0);
                decimal gia = Convert.ToDecimal(row.Cells["colDonGia"].Value ?? 0);
                row.Cells["colThanhTien"].Value = sl * gia;
            }
            catch { }
        }

        private void ValidateStock(DataGridViewRow row)
        {
            try
            {
                decimal sl = Convert.ToDecimal(row.Cells["colSL"].Value ?? 0);
                decimal ton = Convert.ToDecimal(row.Cells["colTonKho"].Value ?? 0);
                var cell = row.Cells["colSL"];

                if (sl > ton)
                {
                    cell.Style.BackColor = Color.Salmon; // Cảnh báo đỏ nếu bán lố
                    cell.ToolTipText = $"Vượt quá tồn kho ({ton})!";
                }
                else
                {
                    cell.Style.BackColor = Color.White;
                    cell.ToolTipText = null;
                }
            }
            catch { }
        }

        private void CalculateTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvChiTiet.Rows)
            {
                total += Convert.ToDecimal(row.Cells["colThanhTien"].Value ?? 0);
            }
            lblTongTien.Text = total.ToString("N0") + " đ";
        }

        private void DgvChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xử lý nút Xóa
            if (e.RowIndex >= 0 && dgvChiTiet.Columns[e.ColumnIndex].Name == "colXoa")
            {
                if (!dgvChiTiet.Rows[e.RowIndex].IsNewRow)
                {
                    dgvChiTiet.Rows.RemoveAt(e.RowIndex);
                    CalculateTotal();
                }
            }
        }

        private void DgvChiTiet_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        // --- BUTTON ACTIONS ---

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboKhachHang.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng.");
                return;
            }

            List<PhieuXuatChiTietDTO> items = new List<PhieuXuatChiTietDTO>();
            foreach (DataGridViewRow row in dgvChiTiet.Rows)
            {
                if (row.IsNewRow) continue;
                string maHH = row.Cells["colMaHH"].Value?.ToString();
                if (string.IsNullOrEmpty(maHH)) continue;

                items.Add(new PhieuXuatChiTietDTO
                {
                    MaHH = maHH,
                    TenHH = row.Cells["colTenHH"].Value?.ToString(),
                    SoLuong = Convert.ToInt32(row.Cells["colSL"].Value ?? 0),
                    DonGiaBan = Convert.ToDecimal(row.Cells["colDonGia"].Value ?? 0)
                });
            }

            if (items.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập hàng hóa.");
                return;
            }

            try
            {
                long soPhieu = _service.LuuPhieuXuat(
                    dtpNgayLap.Value,
                    cboKhachHang.SelectedValue.ToString(),
                    txtGhiChu.Text,
                    chkThanhToan.Checked,
                    items
                );

                txtSoPhieu.Text = soPhieu.ToString();
                MessageBox.Show("Lưu phiếu xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Khóa form
                btnLuu.Enabled = false;
                btnIn.Enabled = true;
                dgvChiTiet.ReadOnly = true;
                dgvChiTiet.AllowUserToAddRows = false;

                LoadHangHoa(); // Cập nhật lại tồn kho
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi Lưu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đang in phiếu số: " + txtSoPhieu.Text);
        }

        private void btnThem_Click(object sender, EventArgs e) => ResetForm();
        private void btnHuy_Click(object sender, EventArgs e) => this.Close();
    }
}