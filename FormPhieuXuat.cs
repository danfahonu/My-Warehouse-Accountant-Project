using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Services;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormPhieuXuat : System.Windows.Forms.Form
    {
        private readonly PhieuXuatService _service = new PhieuXuatService();
        private DataTable _dtHangHoa;

        public FormPhieuXuat()
        {
            InitializeComponent();
            this.Load += FormPhieuXuat_Load;

            btnLuu.Click += BtnLuu_Click;
            btnHuy.Click += (s, e) => this.Close();
            btnThem.Click += (s, e) => ResetForm();
            btnIn.Click += BtnIn_Click;

            dgvChiTiet.EditingControlShowing += DgvChiTiet_EditingControlShowing;
            dgvChiTiet.CellValueChanged += DgvChiTiet_CellValueChanged;
            dgvChiTiet.DataError += (s, e) => { };
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
            DataTable dtKhach = _service.LayDanhSachKhachHang();
            cboKhachHang.DataSource = dtKhach;
            cboKhachHang.DisplayMember = "TENKH";
            cboKhachHang.ValueMember = "MAKH";
            cboKhachHang.SelectedIndex = -1;
        }

        private void LoadHangHoa()
        {
            _dtHangHoa = _service.LayDanhSachHangHoa();
            if (dgvChiTiet.Columns["colMaHH"] is DataGridViewComboBoxColumn col)
            {
                col.DataSource = _dtHangHoa;
                col.DisplayMember = "TENHH";
                col.ValueMember = "MAHH";
            }
        }

        private void ResetForm()
        {
            txtSoPhieu.Text = "(Mới)";
            dtpNgayLap.Value = DateTime.Now;
            cboKhachHang.SelectedIndex = -1;
            txtGhiChu.Text = "";
            chkThanhToan.Checked = false;

            dgvChiTiet.Rows.Clear();
            lblTongTien.Text = "0";

            btnLuu.Enabled = true;
            btnIn.Enabled = false;
        }

        // --- Grid Logic ---
        private void DgvChiTiet_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvChiTiet.CurrentCell.ColumnIndex == dgvChiTiet.Columns["colMaHH"].Index && e.Control is ComboBox cb)
            {
                cb.DropDownStyle = ComboBoxStyle.DropDown;
                cb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cb.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
        }

        private void DgvChiTiet_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string colName = dgvChiTiet.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = dgvChiTiet.Rows[e.RowIndex];

            // 1. Select Product
            if (colName == "colMaHH")
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
                        row.Cells["colDonGia"].Value = r["GIABAN"]; // Auto-Fill Selling Price
                        row.Cells["colTonKho"].Value = r["TONKHO"];

                        if (row.Cells["colSL"].Value == null) row.Cells["colSL"].Value = 1;
                    }
                }
            }

            // 2. Calc Line Total
            if (colName == "colSL" || colName == "colDonGia" || colName == "colMaHH")
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
                    cell.Style.BackColor = Color.Salmon;
                    cell.ToolTipText = "Vượt quá tồn kho!";
                }
                else
                {
                    cell.Style.BackColor = Color.Ivory;
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
            lblTongTien.Text = total.ToString("N0");
        }

        private void BtnLuu_Click(object sender, EventArgs e)
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

                var item = new PhieuXuatChiTietDTO
                {
                    MaHH = maHH,
                    TenHH = row.Cells["colTenHH"].Value?.ToString(),
                    SoLuong = Convert.ToInt32(row.Cells["colSL"].Value ?? 0),
                    DonGiaBan = Convert.ToDecimal(row.Cells["colDonGia"].Value ?? 0)
                };
                items.Add(item);
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
                btnLuu.Enabled = false;
                btnIn.Enabled = true;
                LoadHangHoa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi Lưu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng in đang cập nhật.");
        }
    }
}