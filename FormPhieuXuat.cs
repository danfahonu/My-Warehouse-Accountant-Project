using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Transactions;
using DoAnLapTrinhQuanLy.Data;
using DoAnLapTrinhQuanLy.Core;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormPhieuXuat : BaseForm
    {
        private DataTable _dtHangHoa;

        public FormPhieuXuat()
        {
            InitializeComponent();

            // Designer Fix: Only apply runtime layout changes if NOT in Design Mode
            if (!this.DesignMode)
            {
                this.Padding = new Padding(0, 40, 0, 0); // Adjust for TitleBar
            }
        }

        private void FormPhieuXuat_Load(object sender, EventArgs e)
        {
            // Apply Standard Dark Theme
            ApplyTheme();

            // Ensure TitleBar is visible and at the top
            if (this.pnlTitleBar != null)
            {
                this.pnlTitleBar.BringToFront();
            }

            LoadKhachHang();
            LoadHangHoa();
            ClearInputs();
            StyleDataGridView();
        }

        private void ApplyTheme()
        {
            // Form Background
            this.BackColor = ColorTranslator.FromHtml("#0F1626");

            // Panels
            Color panelColor = ColorTranslator.FromHtml("#1A2238");
            if (this.pnlHeader != null) this.pnlHeader.BackColor = panelColor;
            if (this.pnlInput != null) this.pnlInput.BackColor = panelColor;
            if (this.pnlFooter != null) this.pnlFooter.BackColor = panelColor;

            // Labels
            Color textColor = Color.Gainsboro;
            if (this.lblHeaderTitle != null) this.lblHeaderTitle.ForeColor = Color.White;
            if (this.lblTongTien != null) this.lblTongTien.ForeColor = textColor;
            if (this.label7 != null) this.label7.ForeColor = textColor;
            if (this.chkThanhToan != null) this.chkThanhToan.ForeColor = textColor;

            foreach (Control c in this.tableLayoutPanel1.Controls)
            {
                if (c is Label lbl) lbl.ForeColor = textColor;
            }

            // Inputs (TextBox, ComboBox, DateTimePicker)
            Color inputBack = ColorTranslator.FromHtml("#1F2940");
            Color inputFore = Color.White;

            foreach (Control c in this.tableLayoutPanel1.Controls)
            {
                if (c is TextBox txt)
                {
                    txt.BackColor = inputBack;
                    txt.ForeColor = inputFore;
                    txt.BorderStyle = BorderStyle.FixedSingle;
                }
                else if (c is ComboBox cbo)
                {
                    cbo.BackColor = inputBack;
                    cbo.ForeColor = inputFore;
                    cbo.FlatStyle = FlatStyle.Flat;
                }
                else if (c is DateTimePicker dtp)
                {
                    dtp.CalendarMonthBackground = inputBack;
                    dtp.CalendarForeColor = inputFore;
                }
            }

            // Buttons
            StyleButton(btnThem, Color.DodgerBlue);
            StyleButton(btnLuu, Color.SeaGreen);
            StyleButton(btnIn, Color.MediumSlateBlue);
            StyleButton(btnHuy, Color.DimGray);
        }

        private void StyleButton(Button btn, Color backColor)
        {
            if (btn == null) return;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = backColor;
            btn.ForeColor = Color.White;
            btn.Cursor = Cursors.Hand;
        }

        private void StyleDataGridView()
        {
            dgvPhieuXuat.BackgroundColor = ColorTranslator.FromHtml("#0F1626");
            dgvPhieuXuat.GridColor = ColorTranslator.FromHtml("#2D3B55");
            dgvPhieuXuat.BorderStyle = BorderStyle.None;
            dgvPhieuXuat.EnableHeadersVisualStyles = false;

            // Header Style
            dgvPhieuXuat.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#1A2238");
            dgvPhieuXuat.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPhieuXuat.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvPhieuXuat.ColumnHeadersHeight = 35;

            // Row Style
            dgvPhieuXuat.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#0F1626");
            dgvPhieuXuat.DefaultCellStyle.ForeColor = Color.White;
            dgvPhieuXuat.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvPhieuXuat.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#2D3B55");
            dgvPhieuXuat.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvPhieuXuat.RowTemplate.Height = 30;

            dgvPhieuXuat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Format Currency Columns
            if (dgvPhieuXuat.Columns.Contains("DONGIA"))
            {
                dgvPhieuXuat.Columns["DONGIA"].DefaultCellStyle.Format = "N0";
                dgvPhieuXuat.Columns["DONGIA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dgvPhieuXuat.Columns.Contains("THANHTIEN"))
            {
                dgvPhieuXuat.Columns["THANHTIEN"].DefaultCellStyle.Format = "N0";
                dgvPhieuXuat.Columns["THANHTIEN"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            // Format Quantity Column
            if (dgvPhieuXuat.Columns.Contains("SL"))
            {
                dgvPhieuXuat.Columns["SL"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void LoadKhachHang()
        {
            try
            {
                DataTable dt = DbHelper.Query("SELECT MAKH, TENKH FROM DANHMUCKHACHHANG");
                cboKhachHang.DataSource = dt;
                cboKhachHang.DisplayMember = "TENKH";
                cboKhachHang.ValueMember = "MAKH";
                cboKhachHang.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải khách hàng: " + ex.Message);
            }
        }

        private void LoadHangHoa()
        {
            try
            {
                // Load GIAVON for reference, but FIFO will calculate real COGS
                _dtHangHoa = DbHelper.Query("SELECT MAHH, TENHH, DVT, GIABAN, GIAVON, TONKHO FROM DM_HANGHOA");

                // Setup ComboBox Column
                DataGridViewComboBoxColumn colMAHH = dgvPhieuXuat.Columns["MAHH"] as DataGridViewComboBoxColumn;

                if (colMAHH != null)
                {
                    colMAHH.DataSource = _dtHangHoa;
                    colMAHH.DisplayMember = "TENHH";
                    colMAHH.ValueMember = "MAHH";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải hàng hóa: " + ex.Message);
            }
        }

        private void ClearInputs()
        {
            txtSoPhieu.Text = "";
            dtpNgayLap.Value = DateTime.Now;
            cboKhachHang.SelectedIndex = -1;
            txtGhiChu.Text = "";
            dgvPhieuXuat.Rows.Clear();
            lblTongTien.Text = "0";

            // Button States
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            if (btnIn != null) btnIn.Enabled = false;

            // Focus
            cboKhachHang.Focus();
        }

        // --- Smart ComboBox Logic ---
        private void DgvPhieuXuat_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var colMAHH = dgvPhieuXuat.Columns["MAHH"];
            if (colMAHH != null && dgvPhieuXuat.CurrentCell.ColumnIndex == colMAHH.Index && e.Control is ComboBox comboBox)
            {
                comboBox.DropDownStyle = ComboBoxStyle.DropDown;
                comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
        }

        private void DgvPhieuXuat_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var colMAHH = dgvPhieuXuat.Columns["MAHH"];
            var colDONGIA = dgvPhieuXuat.Columns["DONGIA"];
            var colSL = dgvPhieuXuat.Columns["SL"];
            var colTHANHTIEN = dgvPhieuXuat.Columns["THANHTIEN"];

            // When Product changes -> Auto-fill Unit and Price
            if (colMAHH != null && e.ColumnIndex == colMAHH.Index)
            {
                var maHH = dgvPhieuXuat.Rows[e.RowIndex].Cells[colMAHH.Index].Value?.ToString();
                if (!string.IsNullOrEmpty(maHH))
                {
                    DataRow[] rows = _dtHangHoa.Select($"MAHH = '{maHH}'");
                    if (rows.Length > 0)
                    {
                        // Default price is Selling Price (GIABAN)
                        if (colDONGIA != null) dgvPhieuXuat.Rows[e.RowIndex].Cells[colDONGIA.Index].Value = rows[0]["GIABAN"];

                        // Default SL = 1
                        if (colSL != null)
                        {
                            var currentSL = dgvPhieuXuat.Rows[e.RowIndex].Cells[colSL.Index].Value;
                            if (currentSL == null || Convert.ToDecimal(currentSL) == 0)
                            {
                                dgvPhieuXuat.Rows[e.RowIndex].Cells[colSL.Index].Value = 1;
                            }
                        }
                    }
                }
            }

            // Calculate Total Amount
            CalculateRowAmount(e.RowIndex);
            CalculateTotal();
        }

        private void CalculateRowAmount(int rowIndex)
        {
            try
            {
                var colSL = dgvPhieuXuat.Columns["SL"];
                var colDONGIA = dgvPhieuXuat.Columns["DONGIA"];
                var colTHANHTIEN = dgvPhieuXuat.Columns["THANHTIEN"];

                if (colSL == null || colDONGIA == null || colTHANHTIEN == null) return;

                var cellSL = dgvPhieuXuat.Rows[rowIndex].Cells[colSL.Index].Value;
                var cellDonGia = dgvPhieuXuat.Rows[rowIndex].Cells[colDONGIA.Index].Value;

                if (cellSL != null && cellDonGia != null)
                {
                    decimal sl = Convert.ToDecimal(cellSL);
                    decimal donGia = Convert.ToDecimal(cellDonGia);
                    dgvPhieuXuat.Rows[rowIndex].Cells[colTHANHTIEN.Index].Value = sl * donGia;
                }
            }
            catch { /* Ignore parsing errors */ }
        }

        private void CalculateTotal()
        {
            decimal total = 0;
            var colTHANHTIEN = dgvPhieuXuat.Columns["THANHTIEN"];

            if (colTHANHTIEN == null) return;

            foreach (DataGridViewRow row in dgvPhieuXuat.Rows)
            {
                if (row.Cells[colTHANHTIEN.Index].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells[colTHANHTIEN.Index].Value);
                }
            }
            lblTongTien.Text = total.ToString("N0");
        }

        // --- FIFO LOGIC IMPLEMENTATION ---
        private decimal CalculateCOGS_FIFO(string maHH, int slCanXuat)
        {
            decimal totalCOGS = 0;
            int remainingQty = slCanXuat;

            // 1. Get batches with stock > 0, ordered by Oldest First
            string sql = "SELECT ID, SO_LUONG_TON, DON_GIA_NHAP FROM KHO_CHITIET_TONKHO WHERE MAHH = @MaHH AND SO_LUONG_TON > 0 ORDER BY NGAY_NHAP ASC";
            DataTable dtBatches = DbHelper.Query(sql, DbHelper.Param("@MaHH", maHH));

            foreach (DataRow row in dtBatches.Rows)
            {
                if (remainingQty <= 0) break;

                long batchId = Convert.ToInt64(row["ID"]);
                int batchStock = Convert.ToInt32(row["SO_LUONG_TON"]);
                decimal importPrice = Convert.ToDecimal(row["DON_GIA_NHAP"]);

                int quantityToTake = Math.Min(remainingQty, batchStock);

                // Accumulate Cost
                totalCOGS += (quantityToTake * importPrice);

                // Update Database immediately (We are in a TransactionScope)
                string updateSql = "UPDATE KHO_CHITIET_TONKHO SET SO_LUONG_TON = SO_LUONG_TON - @Qty WHERE ID = @Id";
                DbHelper.Execute(updateSql,
                    DbHelper.Param("@Qty", quantityToTake),
                    DbHelper.Param("@Id", batchId));

                remainingQty -= quantityToTake;
            }

            if (remainingQty > 0)
            {
                throw new Exception($"Hàng hóa {maHH} không đủ tồn kho theo lô (Thiếu {remainingQty}). Vui lòng kiểm tra lại dữ liệu kho.");
            }

            return totalCOGS;
        }

        // --- Save Logic (Core Transaction) ---
        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (cboKhachHang.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Khách hàng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvPhieuXuat.Rows.Count <= 1)
            {
                MessageBox.Show("Vui lòng nhập chi tiết hàng hóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Column References
            var colMAHH = dgvPhieuXuat.Columns["MAHH"];
            var colSL = dgvPhieuXuat.Columns["SL"];
            var colDONGIA = dgvPhieuXuat.Columns["DONGIA"];

            if (colMAHH == null || colSL == null || colDONGIA == null)
            {
                MessageBox.Show("Lỗi cấu hình cột DataGridView.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    // 1. Insert PHIEU Header
                    string sqlPhieu = @"
                        INSERT INTO PHIEU (NGAYLAP, LOAI, MAKH, GHICHU, TRANGTHAI)
                        OUTPUT INSERTED.SOPHIEU
                        VALUES (@NgayLap, 'X', @MaKH, @GhiChu, 1)";

                    long soPhieu = Convert.ToInt64(DbHelper.Scalar(sqlPhieu,
                        DbHelper.Param("@NgayLap", dtpNgayLap.Value),
                        DbHelper.Param("@MaKH", cboKhachHang.SelectedValue),
                        DbHelper.Param("@GhiChu", txtGhiChu.Text)
                    ));

                    // 2. Insert Details & Inventory (FIFO) & Accounting
                    decimal tongTien = 0;
                    decimal tongGiaVon = 0;

                    foreach (DataGridViewRow row in dgvPhieuXuat.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string maHH = row.Cells[colMAHH.Index].Value?.ToString();
                        if (string.IsNullOrEmpty(maHH)) continue;

                        int sl = Convert.ToInt32(row.Cells[colSL.Index].Value);
                        decimal donGia = Convert.ToDecimal(row.Cells[colDONGIA.Index].Value);
                        decimal thanhTien = sl * donGia;
                        tongTien += thanhTien;

                        // --- FIFO CALCULATION ---
                        // This updates KHO_CHITIET_TONKHO and returns total COGS for this item
                        decimal itemCOGS = CalculateCOGS_FIFO(maHH, sl);
                        tongGiaVon += itemCOGS;

                        // Insert PHIEU_CT with the calculated COGS (Average for this line)
                        // Note: GIAVON column in PHIEU_CT is useful for profit reporting
                        decimal unitCOGS = sl > 0 ? itemCOGS / sl : 0;

                        string sqlCT = @"INSERT INTO PHIEU_CT (SOPHIEU, MAHH, SL, DONGIA, GIAVON) 
                                            VALUES (@SoPhieu, @MaHH, @SL, @DonGia, @GiaVon)";

                        DbHelper.Execute(sqlCT,
                            DbHelper.Param("@SoPhieu", soPhieu),
                            DbHelper.Param("@MaHH", maHH),
                            DbHelper.Param("@SL", sl),
                            DbHelper.Param("@DonGia", donGia),
                            DbHelper.Param("@GiaVon", unitCOGS)
                        );

                        // Update DM_HANGHOA total stock (Optional but good for quick lookup)
                        DbHelper.Execute("UPDATE DM_HANGHOA SET TONKHO = TONKHO - @SL WHERE MAHH = @MaHH",
                            DbHelper.Param("@SL", sl),
                            DbHelper.Param("@MaHH", maHH));
                    }

                    // 3. Accounting Entries
                    // Entry 1: Revenue (Doanh thu) - Credit 511, Debit 131/1111
                    string tkNo = (chkThanhToan != null && chkThanhToan.Checked) ? "1111" : "131";
                    string sqlDoanhThu = @"INSERT INTO BUTTOAN_KETOAN (NGAY_HT, TK_NO, TK_CO, SOTIEN, DIEN_GIAI)
                                            VALUES (@Ngay, @TkNo, '511', @SoTien, @DienGiai)";

                    DbHelper.Execute(sqlDoanhThu,
                        DbHelper.Param("@Ngay", dtpNgayLap.Value),
                        DbHelper.Param("@TkNo", tkNo),
                        DbHelper.Param("@SoTien", tongTien),
                        DbHelper.Param("@DienGiai", $"Doanh thu bán hàng phiếu #{soPhieu}")
                    );

                    // Entry 2: COGS (Giá vốn) - Credit 156, Debit 632
                    // Use the REAL FIFO Calculated Value
                    string sqlGiaVon = @"INSERT INTO BUTTOAN_KETOAN (NGAY_HT, TK_NO, TK_CO, SOTIEN, DIEN_GIAI)
                                            VALUES (@Ngay, '632', '156', @SoTien, @DienGiai)";

                    DbHelper.Execute(sqlGiaVon,
                        DbHelper.Param("@Ngay", dtpNgayLap.Value),
                        DbHelper.Param("@SoTien", tongGiaVon),
                        DbHelper.Param("@DienGiai", $"Giá vốn hàng bán phiếu #{soPhieu} (FIFO)")
                    );

                    scope.Complete();
                    MessageBox.Show($"Lưu phiếu xuất #{soPhieu} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtSoPhieu.Text = soPhieu.ToString();

                    // Button States after Save
                    btnLuu.Enabled = false;
                    btnThem.Enabled = true;
                    if (btnIn != null) btnIn.Enabled = true;

                    // Focus
                    btnThem.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu phiếu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            ClearInputs();
            MessageBox.Show("Đã sẵn sàng xuất phiếu mới.", "Thông báo");
        }

        private void BtnIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoPhieu.Text))
            {
                MessageBox.Show("Vui lòng lưu phiếu trước khi in.");
                return;
            }

            if (long.TryParse(txtSoPhieu.Text, out long soPhieu))
            {
                PrintPhieu(soPhieu);
            }
        }

        private void PrintPhieu(long soPhieu)
        {
            try
            {
                string sql = @"SELECT P.SOPHIEU, KH.TENKH, P.NGAYLAP, SUM(CT.SL * CT.DONGIA) as TONGTIEN
                               FROM PHIEU P
                               JOIN DANHMUCKHACHHANG KH ON P.MAKH = KH.MAKH
                               JOIN PHIEU_CT CT ON P.SOPHIEU = CT.SOPHIEU
                               WHERE P.SOPHIEU = @SoPhieu
                               GROUP BY P.SOPHIEU, KH.TENKH, P.NGAYLAP";

                DataTable dt = DbHelper.Query(sql, DbHelper.Param("@SoPhieu", soPhieu));

                if (dt.Rows.Count > 0)
                {
                    DataRow r = dt.Rows[0];
                    string msg = $"--- THÔNG TIN IN PHIẾU XUẤT ---\n" +
                                 $"Số Phiếu: {r["SOPHIEU"]}\n" +
                                 $"Khách Hàng: {r["TENKH"]}\n" +
                                 $"Ngày Lập: {Convert.ToDateTime(r["NGAYLAP"]):dd/MM/yyyy}\n" +
                                 $"Tổng Tiền: {Convert.ToDecimal(r["TONGTIEN"]):N0} VNĐ";

                    MessageBox.Show(msg, "Print Preview", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu phiếu.", "Lỗi in");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi in: " + ex.Message);
            }
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn hủy nhập liệu?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ClearInputs();
            }
        }
    }
}
