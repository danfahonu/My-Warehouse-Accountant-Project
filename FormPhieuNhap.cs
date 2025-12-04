using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Transactions;
using DoAnLapTrinhQuanLy.Data;
using DoAnLapTrinhQuanLy.Core;
using System.Data.SqlClient;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormPhieuNhap : BaseForm
    {
        private long _idYeuCau = 0;
        private DataTable _dtHangHoa;

        public FormPhieuNhap()
        {
            InitializeComponent();

            // 1. FORCE NATIVE WINDOWS STYLE
            this.FormBorderStyle = FormBorderStyle.Sizable; // Standard Resizable Window
            this.ControlBox = true;  // Show Standard Minimize/Maximize/Close
            this.Text = "Phiếu Nhập Kho"; // Show Title on Window Frame
            this.Padding = new Padding(0); // Remove padding used for custom bar

            // 2. HIDE INHERITED CUSTOM CONTROLS (Crucial)
            if (this.pnlTitleBar != null)
            {
                this.pnlTitleBar.Visible = false; // Hide the custom bar
                this.pnlTitleBar.Height = 0;      // Collapse space
                this.pnlTitleBar.SendToBack();    // Send to back just in case
            }

            // Hide buttons if they are accessible
            if (this.btnClose != null) this.btnClose.Visible = false;
            if (this.btnMaximize != null) this.btnMaximize.Visible = false;
            if (this.btnMinimize != null) this.btnMinimize.Visible = false;
        }

        private void FormPhieuNhap_Load(object sender, EventArgs e)
        {
            // 2. Apply Standard Dark Theme
            ApplyStandardDarkTheme();

            LoadNhaCungCap();
            LoadHangHoa();
            ClearInputs();
            StyleDataGridView();
        }

        private void ApplyStandardDarkTheme()
        {
            // Form Background
            this.BackColor = ColorTranslator.FromHtml("#0F1626");

            // Panels
            Color panelColor = ColorTranslator.FromHtml("#1A2238");
            if (this.pnlHeader != null) this.pnlHeader.BackColor = panelColor;
            if (this.pnlFooter != null) this.pnlFooter.BackColor = panelColor;

            // Labels
            Color textColor = Color.Gainsboro;
            if (this.lblTongTienTitle != null) this.lblTongTienTitle.ForeColor = textColor;
            if (this.lblTongTien != null) this.lblTongTien.ForeColor = Color.Red; // Keep total red
            if (this.chkThanhToan != null) this.chkThanhToan.ForeColor = textColor;

            foreach (Control c in this.pnlHeader.Controls)
            {
                if (c is Label lbl) lbl.ForeColor = textColor;
            }

            // Inputs (TextBox, ComboBox, DateTimePicker)
            Color inputBack = ColorTranslator.FromHtml("#1F2940");
            Color inputFore = Color.White;

            foreach (Control c in this.pnlHeader.Controls)
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
            StyleButton(btnLuu, Color.SeaGreen);
            StyleButton(btnThem, Color.DodgerBlue);
            StyleButton(btnIn, Color.MediumSlateBlue);
            StyleButton(btnHuy, Color.DimGray);
            StyleButton(btnChonPhieuYeuCau, Color.Orange); // Custom color for this button
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
            dgvChiTiet.BackgroundColor = ColorTranslator.FromHtml("#0F1626");
            dgvChiTiet.GridColor = ColorTranslator.FromHtml("#2D3B55");
            dgvChiTiet.BorderStyle = BorderStyle.None;
            dgvChiTiet.EnableHeadersVisualStyles = false;

            // Header Style
            dgvChiTiet.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#1A2238");
            dgvChiTiet.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvChiTiet.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvChiTiet.ColumnHeadersHeight = 35;

            // Row Style
            dgvChiTiet.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#0F1626");
            dgvChiTiet.DefaultCellStyle.ForeColor = Color.White;
            dgvChiTiet.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvChiTiet.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#2D3B55");
            dgvChiTiet.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvChiTiet.RowTemplate.Height = 30;

            dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Format Currency Columns
            if (dgvChiTiet.Columns.Contains("colDONGIA"))
            {
                dgvChiTiet.Columns["colDONGIA"].DefaultCellStyle.Format = "N0";
                dgvChiTiet.Columns["colDONGIA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dgvChiTiet.Columns.Contains("colTHANHTIEN"))
            {
                dgvChiTiet.Columns["colTHANHTIEN"].DefaultCellStyle.Format = "N0";
                dgvChiTiet.Columns["colTHANHTIEN"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            // Format Quantity Column
            if (dgvChiTiet.Columns.Contains("colSL"))
            {
                dgvChiTiet.Columns["colSL"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void LoadNhaCungCap()
        {
            try
            {
                DataTable dt = DbHelper.Query("SELECT MA_NCC, TEN_NCC FROM DM_NHACUNGCAP");
                cboNhaCungCap.DataSource = dt;
                cboNhaCungCap.DisplayMember = "TEN_NCC";
                cboNhaCungCap.ValueMember = "MA_NCC";
                cboNhaCungCap.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải nhà cung cấp: " + ex.Message);
            }
        }

        private void LoadHangHoa()
        {
            try
            {
                _dtHangHoa = DbHelper.Query("SELECT MAHH, TENHH, DVT, GIAVON FROM DM_HANGHOA");

                // Setup ComboBox Column
                colMAHH.DataSource = _dtHangHoa;
                colMAHH.DisplayMember = "TENHH";
                colMAHH.ValueMember = "MAHH";
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
            cboNhaCungCap.SelectedIndex = -1;
            txtGhiChu.Text = "";
            dgvChiTiet.Rows.Clear();
            lblTongTien.Text = "0";
            chkThanhToan.Checked = false;
            _idYeuCau = 0;

            // Allow editing product column by default (Free Import Mode)
            colMAHH.ReadOnly = false;
            // Button States
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnIn.Enabled = false;

            // Focus
            cboNhaCungCap.Focus();
        }

        // --- Smart ComboBox Logic ---
        private void DgvChiTiet_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvChiTiet.CurrentCell.ColumnIndex == colMAHH.Index && e.Control is ComboBox comboBox)
            {
                comboBox.DropDownStyle = ComboBoxStyle.DropDown;
                comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
        }

        private void DgvChiTiet_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // When Product changes -> Auto-fill Unit and Price
            if (e.ColumnIndex == colMAHH.Index)
            {
                var maHH = dgvChiTiet.Rows[e.RowIndex].Cells[colMAHH.Index].Value?.ToString();
                if (!string.IsNullOrEmpty(maHH))
                {
                    DataRow[] rows = _dtHangHoa.Select($"MAHH = '{maHH}'");
                    if (rows.Length > 0)
                    {
                        dgvChiTiet.Rows[e.RowIndex].Cells[colDVT.Index].Value = rows[0]["DVT"];
                        // Default price is Cost Price (GIAVON)
                        dgvChiTiet.Rows[e.RowIndex].Cells[colDONGIA.Index].Value = rows[0]["GIAVON"];

                        // Only set default SL if it's null or 0 (don't overwrite if loaded from Request)
                        var currentSL = dgvChiTiet.Rows[e.RowIndex].Cells[colSL.Index].Value;
                        if (currentSL == null || Convert.ToDecimal(currentSL) == 0)
                        {
                            dgvChiTiet.Rows[e.RowIndex].Cells[colSL.Index].Value = 1;
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
                var cellSL = dgvChiTiet.Rows[rowIndex].Cells[colSL.Index].Value;
                var cellDonGia = dgvChiTiet.Rows[rowIndex].Cells[colDONGIA.Index].Value;

                if (cellSL != null && cellDonGia != null)
                {
                    decimal sl = Convert.ToDecimal(cellSL);
                    decimal donGia = Convert.ToDecimal(cellDonGia);
                    dgvChiTiet.Rows[rowIndex].Cells[colTHANHTIEN.Index].Value = sl * donGia;
                }
            }
            catch { /* Ignore parsing errors */ }
        }

        private void CalculateTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvChiTiet.Rows)
            {
                if (row.Cells[colTHANHTIEN.Index].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells[colTHANHTIEN.Index].Value);
                }
            }
            lblTongTien.Text = total.ToString("N0");
        }

        // --- Request Selection Logic (Smart Load) ---
        private void BtnChonPhieuYeuCau_Click(object sender, EventArgs e)
        {
            using var f = new FormChonPhieuYeuCau();
            if (f.ShowDialog() == DialogResult.OK)
            {
                _idYeuCau = f.SelectedYeuCauID;
                LoadPhieuYeuCauDetails(_idYeuCau);
            }
        }

        private void LoadPhieuYeuCauDetails(long idYeuCau)
        {
            try
            {
                ClearInputs(); // Clear current data first
                _idYeuCau = idYeuCau; // Restore ID after clear

                // Smart Query: Calculate Remaining Quantity
                // FIXED: Changed SL -> SOLUONG_YEUCAU as per Lead Dev feedback
                string sql = @"
                    SELECT 
                       YC.MAHH, 
                       YC.SOLUONG_YEUCAU AS SL_GOC, 
                       (YC.SOLUONG_YEUCAU - ISNULL((SELECT SUM(CT.SL) 
                                        FROM PHIEU P JOIN PHIEU_CT CT ON P.SOPHIEU = CT.SOPHIEU 
                                        WHERE P.ID_YEUCAU = YC.ID_YEUCAU AND CT.MAHH = YC.MAHH AND P.TRANGTHAI = 1), 0)) AS SL_CON_LAI,
                       HH.DVT, HH.GIAVON
                    FROM PHIEU_YEUCAU_NHAPKHO_CT YC
                    JOIN DM_HANGHOA HH ON YC.MAHH = HH.MAHH
                    WHERE YC.ID_YEUCAU = @Id";

                DataTable dt = DbHelper.Query(sql, DbHelper.Param("@Id", idYeuCau));

                bool hasItems = false;
                foreach (DataRow row in dt.Rows)
                {
                    decimal slConLai = Convert.ToDecimal(row["SL_CON_LAI"]);

                    if (slConLai <= 0) continue; // Skip fully imported items

                    hasItems = true;
                    int idx = dgvChiTiet.Rows.Add();
                    DataGridViewRow gridRow = dgvChiTiet.Rows[idx];

                    gridRow.Cells[colMAHH.Index].Value = row["MAHH"].ToString();
                    gridRow.Cells[colDVT.Index].Value = row["DVT"].ToString();
                    gridRow.Cells[colSL.Index].Value = slConLai; // Load remaining quantity
                    gridRow.Cells[colDONGIA.Index].Value = row["GIAVON"];

                    // Lock Product Column to prevent changing item for Request-based imports
                    gridRow.Cells[colMAHH.Index].ReadOnly = true;
                }

                CalculateTotal();

                if (hasItems)
                {
                    MessageBox.Show($"Đã tải các mặt hàng còn thiếu từ Phiếu Yêu Cầu #{idYeuCau}", "Thông báo");
                }
                else
                {
                    MessageBox.Show($"Phiếu Yêu Cầu #{idYeuCau} đã được nhập đủ hàng!", "Thông báo");
                    _idYeuCau = 0; // Reset if nothing to import
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải chi tiết phiếu yêu cầu: " + ex.Message);
            }
        }

        // --- Save Logic (Core Transaction) ---
        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (cboNhaCungCap.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Nhà cung cấp.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvChiTiet.Rows.Count <= 1)
            {
                MessageBox.Show("Vui lòng nhập chi tiết hàng hóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using TransactionScope scope = new TransactionScope();

                // 1. Insert PHIEU Header
                string sqlPhieu = @"
                    INSERT INTO PHIEU (NGAYLAP, LOAI, MA_NCC, GHICHU, TRANGTHAI, ID_YEUCAU)
                    OUTPUT INSERTED.SOPHIEU
                    VALUES (@NgayLap, 'N', @MaNCC, @GhiChu, 1, @IdYeuCau)";

                object idYeuCauParam = _idYeuCau > 0 ? (object)_idYeuCau : DBNull.Value;

                long soPhieu = Convert.ToInt64(DbHelper.Scalar(sqlPhieu,
                    DbHelper.Param("@NgayLap", dtpNgayLap.Value),
                    DbHelper.Param("@MaNCC", cboNhaCungCap.SelectedValue),
                    DbHelper.Param("@GhiChu", txtGhiChu.Text),
                    DbHelper.Param("@IdYeuCau", idYeuCauParam)
                ));

                // 2. Insert Details & Inventory
                decimal tongTien = 0;

                foreach (DataGridViewRow row in dgvChiTiet.Rows)
                {
                    if (row.IsNewRow) continue;

                    string maHH = row.Cells[colMAHH.Index].Value?.ToString();
                    if (string.IsNullOrEmpty(maHH)) continue;

                    int sl = Convert.ToInt32(row.Cells[colSL.Index].Value);
                    decimal donGia = Convert.ToDecimal(row.Cells[colDONGIA.Index].Value);
                    decimal thanhTien = sl * donGia;
                    tongTien += thanhTien;

                    // a. Insert PHIEU_CT (No THANHTIEN)
                    string sqlCT = @"INSERT INTO PHIEU_CT (SOPHIEU, MAHH, SL, DONGIA) 
                                        VALUES (@SoPhieu, @MaHH, @SL, @DonGia);
                                        SELECT SCOPE_IDENTITY();";

                    long idPhieuCT = Convert.ToInt64(DbHelper.Scalar(sqlCT,
                        DbHelper.Param("@SoPhieu", soPhieu),
                        DbHelper.Param("@MaHH", maHH),
                        DbHelper.Param("@SL", sl),
                        DbHelper.Param("@DonGia", donGia)
                    ));

                    // b. Insert KHO_CHITIET_TONKHO (FIFO Batch)
                    string sqlKho = @"INSERT INTO KHO_CHITIET_TONKHO 
                                        (ID_PHIEUNHAP_CT, MAHH, NGAY_NHAP, SO_LUONG_NHAP, DON_GIA_NHAP, SO_LUONG_TON)
                                        VALUES 
                                        (@IdPhieuCT, @MaHH, @NgayNhap, @SL, @DonGia, @SL)";

                    DbHelper.Execute(sqlKho,
                        DbHelper.Param("@IdPhieuCT", idPhieuCT),
                        DbHelper.Param("@MaHH", maHH),
                        DbHelper.Param("@NgayNhap", dtpNgayLap.Value),
                        DbHelper.Param("@SL", sl),
                        DbHelper.Param("@DonGia", donGia)
                    );
                }

                // 3. Update Request Status (Only if Request exists)
                if (_idYeuCau > 0)
                {
                    // Update to 'Processing' (2) to indicate partial or ongoing import.
                    DbHelper.Execute("UPDATE PHIEU_YEUCAU_NHAPKHO SET TRANGTHAI = 2 WHERE ID = @Id AND TRANGTHAI = 1",
                        DbHelper.Param("@Id", _idYeuCau));
                }

                // 4. Payment Processing
                if (chkThanhToan.Checked)
                {
                    // Create Payment Voucher (PHIEUTHUCHI)
                    string sqlChi = @"INSERT INTO PHIEUTHUCHI (NGAYLAP, LOAI, MA_NCC, SOTIEN, LYDO)
                                        VALUES (@NgayLap, 'C', @MaNCC, @SoTien, @LyDo)";

                    DbHelper.Execute(sqlChi,
                        DbHelper.Param("@NgayLap", dtpNgayLap.Value),
                        DbHelper.Param("@MaNCC", cboNhaCungCap.SelectedValue),
                        DbHelper.Param("@SoTien", tongTien),
                        DbHelper.Param("@LyDo", $"Chi trả tiền nhập hàng phiếu #{soPhieu}")
                    );

                    // Accounting Entry (Nợ 331 / Có 111)
                    // FIXED: NGAY -> NGAY_HT, DIENGIAI -> DIEN_GIAI
                    string sqlButToan = @"INSERT INTO BUTTOAN_KETOAN (NGAY_HT, TK_NO, TK_CO, SOTIEN, DIEN_GIAI)
                                            VALUES (@Ngay, '331', '1111', @SoTien, @DienGiai)";

                    DbHelper.Execute(sqlButToan,
                        DbHelper.Param("@Ngay", dtpNgayLap.Value),
                        DbHelper.Param("@SoTien", tongTien),
                        DbHelper.Param("@DienGiai", $"Thanh toán ngay phiếu nhập #{soPhieu}")
                    );
                }
                else
                {
                    // Credit (Cong No) - Nợ 156 / Có 331
                    // FIXED: NGAY -> NGAY_HT, DIENGIAI -> DIEN_GIAI
                    string sqlButToan = @"INSERT INTO BUTTOAN_KETOAN (NGAY_HT, TK_NO, TK_CO, SOTIEN, DIEN_GIAI)
                                            VALUES (@Ngay, '156', '331', @SoTien, @DienGiai)";

                    DbHelper.Execute(sqlButToan,
                        DbHelper.Param("@Ngay", dtpNgayLap.Value),
                        DbHelper.Param("@SoTien", tongTien),
                        DbHelper.Param("@DienGiai", $"Nhập kho phiếu #{soPhieu} (Chưa thanh toán)")
                    );
                }

                scope.Complete();
                MessageBox.Show($"Lưu phiếu nhập #{soPhieu} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtSoPhieu.Text = soPhieu.ToString();
                // Button States after Save
                btnLuu.Enabled = false; // Prevent double save
                btnThem.Enabled = true; // Allow creating next
                btnIn.Enabled = true;   // Allow printing

                // Focus
                btnThem.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu phiếu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            ClearInputs();
            // Ensure full reset for new entry
            txtSoPhieu.Text = "";
            _idYeuCau = 0;
            btnLuu.Enabled = true;
            colMAHH.ReadOnly = false; // Unlock for free import

            MessageBox.Show("Đã sẵn sàng nhập phiếu mới.", "Thông báo");
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
                string sql = @"SELECT P.SOPHIEU, NCC.TEN_NCC, P.NGAYLAP, SUM(CT.SL * CT.DONGIA) as TONGTIEN
                               FROM PHIEU P
                               JOIN DM_NHACUNGCAP NCC ON P.MA_NCC = NCC.MA_NCC
                               JOIN PHIEU_CT CT ON P.SOPHIEU = CT.SOPHIEU
                               WHERE P.SOPHIEU = @SoPhieu
                               GROUP BY P.SOPHIEU, NCC.TEN_NCC, P.NGAYLAP";

                DataTable dt = DbHelper.Query(sql, DbHelper.Param("@SoPhieu", soPhieu));

                if (dt.Rows.Count > 0)
                {
                    DataRow r = dt.Rows[0];
                    string msg = $"--- THÔNG TIN IN PHIẾU ---\n" +
                                 $"Số Phiếu: {r["SOPHIEU"]}\n" +
                                 $"Nhà Cung Cấp: {r["TEN_NCC"]}\n" +
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
                btnLuu.Enabled = true;
            }
        }
    }
}