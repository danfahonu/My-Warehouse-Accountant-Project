using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Services;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormPhieuNhap : Form
    {
        private readonly PhieuNhapService _service = new PhieuNhapService();
        private DataTable _dtHangHoa;
        private long _idYeuCau = 0;

        public FormPhieuNhap()
        {
            InitializeComponent();
        }

        private void FormPhieuNhap_Load(object sender, EventArgs e)
        {
            LoadData();
            InitGrid();
            ClearInputs();
        }

        private void LoadData()
        {
            // Load Suppliers
            cboNhaCungCap.DataSource = _service.LayDanhSachNhaCungCap();
            cboNhaCungCap.DisplayMember = "TEN_NCC";
            cboNhaCungCap.ValueMember = "MA_NCC";
            cboNhaCungCap.SelectedIndex = -1;

            // Cache Products for Grid ComboBox
            _dtHangHoa = _service.LayDanhSachHangHoa();
        }

        private void InitGrid()
        {
            dgvChiTiet.AutoGenerateColumns = false;
            dgvChiTiet.Columns.Clear(); // Avoid duplication

            // Col 1: Product (ComboBox)
            var colMaHH = new DataGridViewComboBoxColumn();
            colMaHH.HeaderText = "Hàng hóa";
            colMaHH.Name = "colMaHH";
            colMaHH.DataPropertyName = "MAHH";
            colMaHH.DataSource = _dtHangHoa;
            colMaHH.DisplayMember = "TENHH";
            colMaHH.ValueMember = "MAHH";
            colMaHH.Width = 300;
            colMaHH.FlatStyle = FlatStyle.Flat;
            dgvChiTiet.Columns.Add(colMaHH);

            // Col 2: Unit
            var colDVT = new DataGridViewTextBoxColumn();
            colDVT.HeaderText = "ĐVT";
            colDVT.Name = "colDVT";
            colDVT.ReadOnly = true;
            colDVT.Width = 80;
            dgvChiTiet.Columns.Add(colDVT);

            // Col 3: Quantity
            var colSL = new DataGridViewTextBoxColumn();
            colSL.HeaderText = "Số Lượng";
            colSL.Name = "colSL";
            colSL.DataPropertyName = "SL";
            colSL.Width = 100;
            colSL.DefaultCellStyle.Format = "N0";
            colSL.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvChiTiet.Columns.Add(colSL);

            // Col 4: Price
            var colGia = new DataGridViewTextBoxColumn();
            colGia.HeaderText = "Đơn Giá";
            colGia.Name = "colGia";
            colGia.DataPropertyName = "DONGIA";
            colGia.Width = 120;
            colGia.DefaultCellStyle.Format = "N0";
            colGia.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvChiTiet.Columns.Add(colGia);

            // Col 5: Amount (ReadOnly)
            var colThanhTien = new DataGridViewTextBoxColumn();
            colThanhTien.HeaderText = "Thành Tiền";
            colThanhTien.Name = "colThanhTien";
            colThanhTien.ReadOnly = true;
            colThanhTien.Width = 150;
            colThanhTien.DefaultCellStyle.Format = "N0";
            colThanhTien.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colThanhTien.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvChiTiet.Columns.Add(colThanhTien);

            // Col 6: Notes (GhiChu)
            var colGhiChu = new DataGridViewTextBoxColumn();
            colGhiChu.HeaderText = "Ghi Chú";
            colGhiChu.Name = "colGhiChu";
            colGhiChu.DataPropertyName = "GHICHU";
            colGhiChu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvChiTiet.Columns.Add(colGhiChu);

            // Events
            dgvChiTiet.EditingControlShowing += DgvChiTiet_EditingControlShowing;
            dgvChiTiet.CellValueChanged += DgvChiTiet_CellValueChanged;
            dgvChiTiet.RowsAdded += (s, e) => TinhTongTien();
            dgvChiTiet.RowsRemoved += (s, e) => TinhTongTien();
        }

        private void ClearInputs()
        {
            txtSoPhieu.Text = "";
            dtpNgayNhap.Value = DateTime.Now;
            cboNhaCungCap.SelectedIndex = -1;
            txtGhiChu.Text = "";
            dgvChiTiet.Rows.Clear();
            lblTongTien.Text = "0 đ";
            chkThanhToan.Checked = false;
            _idYeuCau = 0;

            // Reset UI State
            dgvChiTiet.Columns["colMaHH"].ReadOnly = false;
            btnLuu.Enabled = true;
            btnIn.Enabled = false;
        }

        // --- GRID LOGIC ---

        private void DgvChiTiet_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            // Smart Combo Box behavior
            if (dgvChiTiet.CurrentCell.ColumnIndex == dgvChiTiet.Columns["colMaHH"].Index && e.Control is ComboBox comboBox)
            {
                comboBox.DropDownStyle = ComboBoxStyle.DropDown;
                comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            // Number validation
            if (dgvChiTiet.CurrentCell.ColumnIndex == dgvChiTiet.Columns["colSL"].Index ||
                dgvChiTiet.CurrentCell.ColumnIndex == dgvChiTiet.Columns["colGia"].Index)
            {
                e.Control.KeyPress -= Numeric_KeyPress;
                e.Control.KeyPress += Numeric_KeyPress;
            }
        }

        private void Numeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void DgvChiTiet_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Auto-fill Unit & Price when Product selected
            if (dgvChiTiet.Columns[e.ColumnIndex].Name == "colMaHH")
            {
                string maHH = dgvChiTiet.Rows[e.RowIndex].Cells["colMaHH"].Value?.ToString();
                if (!string.IsNullOrEmpty(maHH))
                {
                    DataRow[] rows = _dtHangHoa.Select($"MAHH = '{maHH}'");
                    if (rows.Length > 0)
                    {
                        dgvChiTiet.Rows[e.RowIndex].Cells["colDVT"].Value = rows[0]["DVT"];
                        // Only auto-fill price/qty if empty (to avoid overwriting loaded data)
                        if (DBNull.Value.Equals(dgvChiTiet.Rows[e.RowIndex].Cells["colGia"].Value))
                            dgvChiTiet.Rows[e.RowIndex].Cells["colGia"].Value = rows[0]["GIAVON"];

                        if (DBNull.Value.Equals(dgvChiTiet.Rows[e.RowIndex].Cells["colSL"].Value))
                            dgvChiTiet.Rows[e.RowIndex].Cells["colSL"].Value = 1;
                    }
                }
            }

            // Calculate Row Total
            if (dgvChiTiet.Columns[e.ColumnIndex].Name == "colSL" ||
                dgvChiTiet.Columns[e.ColumnIndex].Name == "colGia" ||
                dgvChiTiet.Columns[e.ColumnIndex].Name == "colMaHH")
            {
                decimal sl = 0;
                decimal gia = 0;
                var cellSL = dgvChiTiet.Rows[e.RowIndex].Cells["colSL"].Value;
                var cellGia = dgvChiTiet.Rows[e.RowIndex].Cells["colGia"].Value;

                if (cellSL != null) decimal.TryParse(cellSL.ToString(), out sl);
                if (cellGia != null) decimal.TryParse(cellGia.ToString(), out gia);

                dgvChiTiet.Rows[e.RowIndex].Cells["colThanhTien"].Value = sl * gia;
                TinhTongTien();
            }
        }

        private void TinhTongTien()
        {
            decimal tong = 0;
            foreach (DataGridViewRow row in dgvChiTiet.Rows)
            {
                if (row.Cells["colThanhTien"].Value != null)
                    tong += Convert.ToDecimal(row.Cells["colThanhTien"].Value);
            }
            lblTongTien.Text = tong.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + " đ";
        }

        // --- SMART IMPORT LOGIC ---

        private void btnChonPhieuYeuCau_Click(object sender, EventArgs e)
        {
            using (var f = new FormChonPhieuYeuCau())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    _idYeuCau = f.SelectedYeuCauID;
                    LoadPhieuYeuCauDetails(_idYeuCau);
                }
            }
        }

        private void LoadPhieuYeuCauDetails(long idYeuCau)
        {
            try
            {
                ClearInputs(); // Reset form
                _idYeuCau = idYeuCau; // Set ID back

                DataTable dt = _service.GetChiTietYeuCau(idYeuCau);
                bool hasItems = false;

                foreach (DataRow row in dt.Rows)
                {
                    decimal slConLai = Convert.ToDecimal(row["SL_CON_LAI"]);
                    if (slConLai <= 0) continue;

                    hasItems = true;
                    int idx = dgvChiTiet.Rows.Add();
                    var gridRow = dgvChiTiet.Rows[idx];

                    gridRow.Cells["colMaHH"].Value = row["MAHH"].ToString();
                    gridRow.Cells["colDVT"].Value = row["DVT"].ToString();
                    gridRow.Cells["colSL"].Value = slConLai; // Load remaining
                    gridRow.Cells["colGia"].Value = row["GIAVON"];

                    // Lock Product Column
                    gridRow.Cells["colMaHH"].ReadOnly = true;
                }

                if (hasItems)
                {
                    MessageBox.Show($"Đã tải dữ liệu từ Phiếu Yêu Cầu #{idYeuCau}", "Thông báo");
                }
                else
                {
                    MessageBox.Show($"Phiếu yêu cầu #{idYeuCau} đã được nhập đủ!", "Thông báo");
                    _idYeuCau = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải phiếu yêu cầu: " + ex.Message);
            }
        }

        // --- ACTIONS ---

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboNhaCungCap.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Nhà cung cấp!", "Cảnh báo");
                return;
            }

            var listChiTiet = new List<PhieuNhapChiTietDTO>();
            foreach (DataGridViewRow row in dgvChiTiet.Rows)
            {
                if (row.IsNewRow) continue;
                var maHH = row.Cells["colMaHH"].Value?.ToString();
                if (string.IsNullOrEmpty(maHH)) continue;

                decimal sl = 0;
                decimal gia = 0;
                if (row.Cells["colSL"].Value != null) decimal.TryParse(row.Cells["colSL"].Value.ToString(), out sl);
                if (row.Cells["colGia"].Value != null) decimal.TryParse(row.Cells["colGia"].Value.ToString(), out gia);

                listChiTiet.Add(new PhieuNhapChiTietDTO
                {
                    MaHH = maHH,
                    SoLuong = (int)sl,
                    DonGia = gia,
                    DVT = row.Cells["colDVT"].Value?.ToString()
                });
            }

            if (listChiTiet.Count == 0)
            {
                MessageBox.Show("Chưa có mặt hàng nào.", "Cảnh báo");
                return;
            }

            try
            {
                string maNCC = cboNhaCungCap.SelectedValue.ToString();
                long soPhieu = _service.LuuPhieuNhap(
                    dtpNgayNhap.Value,
                    maNCC,
                    txtGhiChu.Text,
                    _idYeuCau,
                    chkThanhToan.Checked,
                    listChiTiet
                );

                MessageBox.Show("Lưu phiếu nhập thành công!", "Thông báo");
                txtSoPhieu.Text = soPhieu.ToString();

                btnLuu.Enabled = false;
                btnIn.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (long.TryParse(txtSoPhieu.Text, out long soPhieu))
            {
                DataTable dt = _service.GetPhieuPrintInfo(soPhieu);
                if (dt.Rows.Count > 0)
                {
                    DataRow r = dt.Rows[0];
                    string msg = $"--- IN PHIẾU NHẬP ---\n" +
                                 $"Số: {r["SOPHIEU"]}\n" +
                                 $"NCC: {r["TEN_NCC"]}\n" +
                                 $"Ngày: {Convert.ToDateTime(r["NGAYLAP"]):dd/MM/yyyy}\n" +
                                 $"Tổng tiền: {Convert.ToDecimal(r["TONGTIEN"]):N0}";
                    MessageBox.Show(msg, "Print Preview");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}