namespace DoAnLapTrinhQuanLy.GuiLayer
{
    partial class FormPhieuXuat
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new DoAnLapTrinhQuanLy.CustomControls.ModernPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlActions = new DoAnLapTrinhQuanLy.CustomControls.ModernPanel();
            this.btnGhiSo = new DoAnLapTrinhQuanLy.CustomControls.ModernButton();
            this.btnHuy = new DoAnLapTrinhQuanLy.CustomControls.ModernButton();
            this.btnLuu = new DoAnLapTrinhQuanLy.CustomControls.ModernButton();
            this.btnXoa = new DoAnLapTrinhQuanLy.CustomControls.ModernButton();
            this.btnSua = new DoAnLapTrinhQuanLy.CustomControls.ModernButton();
            this.btnThem = new DoAnLapTrinhQuanLy.CustomControls.ModernButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoPhieu = new DoAnLapTrinhQuanLy.CustomControls.MaterialTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGhiChu = new DoAnLapTrinhQuanLy.CustomControls.MaterialTextBox();
            this.panel2 = new DoAnLapTrinhQuanLy.CustomControls.ModernPanel();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvPhieuXuat = new System.Windows.Forms.DataGridView();
            this.MAHH = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.pnlHeader.BorderRadius = 0;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.GradientAngle = 90F;
            this.pnlHeader.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.pnlHeader.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(884, 50);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(12, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(168, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PHIẾU XUẤT KHO";
            // 
            // pnlActions
            // 
            this.pnlActions.BackColor = System.Drawing.Color.White;
            this.pnlActions.BorderRadius = 0;
            this.pnlActions.Controls.Add(this.btnGhiSo);
            this.pnlActions.Controls.Add(this.btnHuy);
            this.pnlActions.Controls.Add(this.btnLuu);
            this.pnlActions.Controls.Add(this.btnXoa);
            this.pnlActions.Controls.Add(this.btnSua);
            this.pnlActions.Controls.Add(this.btnThem);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlActions.GradientAngle = 90F;
            this.pnlActions.GradientBottomColor = System.Drawing.Color.White;
            this.pnlActions.GradientTopColor = System.Drawing.Color.White;
            this.pnlActions.Location = new System.Drawing.Point(0, 50);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.pnlActions.Size = new System.Drawing.Size(884, 60);
            this.pnlActions.TabIndex = 2;
            // 
            // btnGhiSo
            // 
            this.btnGhiSo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGhiSo.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGhiSo.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnGhiSo.BorderRadius = 10;
            this.btnGhiSo.FlatAppearance.BorderSize = 0;
            this.btnGhiSo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGhiSo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGhiSo.ForeColor = System.Drawing.Color.White;
            this.btnGhiSo.Location = new System.Drawing.Point(559, 15);
            this.btnGhiSo.Name = "btnGhiSo";
            this.btnGhiSo.Size = new System.Drawing.Size(100, 30);
            this.btnGhiSo.TabIndex = 6;
            this.btnGhiSo.Text = "Ghi Sổ";
            this.btnGhiSo.UseVisualStyleBackColor = false;
            this.btnGhiSo.Click += new System.EventHandler(this.BtnGhiSo_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.BackColor = System.Drawing.Color.Gray;
            this.btnHuy.BorderColor = System.Drawing.Color.Gray;
            this.btnHuy.BorderRadius = 10;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(771, 15);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 30);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.BtnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLuu.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnLuu.BorderRadius = 10;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(665, 15);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 30);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu Nháp";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.IndianRed;
            this.btnXoa.BorderColor = System.Drawing.Color.IndianRed;
            this.btnXoa.BorderRadius = 10;
            this.btnXoa.Enabled = false;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(180, 15);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Orange;
            this.btnSua.BorderColor = System.Drawing.Color.Orange;
            this.btnSua.BorderRadius = 10;
            this.btnSua.Enabled = false;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(99, 15);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 30);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.BorderRadius = 10;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(18, 15);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm Mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSoPhieu, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboKhachHang, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpNgayLap, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtGhiChu, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 110);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 109);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số phiếu:";
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoPhieu.BackColor = System.Drawing.SystemColors.Window;
            this.txtSoPhieu.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSoPhieu.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSoPhieu.BorderRadius = 0;
            this.txtSoPhieu.BorderSize = 2;
            this.txtSoPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoPhieu.ForeColor = System.Drawing.Color.DimGray;
            this.txtSoPhieu.Location = new System.Drawing.Point(119, 14);
            this.txtSoPhieu.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoPhieu.Multiline = false;
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.Padding = new System.Windows.Forms.Padding(7);
            this.txtSoPhieu.PasswordChar = false;
            this.txtSoPhieu.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSoPhieu.PlaceholderText = "";
            this.txtSoPhieu.ReadOnly = true;
            this.txtSoPhieu.Size = new System.Drawing.Size(320, 31);
            this.txtSoPhieu.TabIndex = 1;
            this.txtSoPhieu.Texts = "";
            this.txtSoPhieu.UnderlinedStyle = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(18, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Khách hàng:";
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.cboKhachHang, 3);
            this.cboKhachHang.FormattingEnabled = true;
            this.cboKhachHang.Location = new System.Drawing.Point(118, 44);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(748, 21);
            this.cboKhachHang.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(446, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày lập:";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLap.Location = new System.Drawing.Point(546, 15);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(320, 20);
            this.dtpNgayLap.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(18, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGhiChu.BackColor = System.Drawing.SystemColors.Window;
            this.txtGhiChu.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtGhiChu.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtGhiChu.BorderRadius = 0;
            this.txtGhiChu.BorderSize = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.txtGhiChu, 3);
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.ForeColor = System.Drawing.Color.DimGray;
            this.txtGhiChu.Location = new System.Drawing.Point(119, 73);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGhiChu.Multiline = false;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Padding = new System.Windows.Forms.Padding(7);
            this.txtGhiChu.PasswordChar = false;
            this.txtGhiChu.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtGhiChu.PlaceholderText = "";
            this.txtGhiChu.ReadOnly = false;
            this.txtGhiChu.Size = new System.Drawing.Size(746, 31);
            this.txtGhiChu.TabIndex = 11;
            this.txtGhiChu.Texts = "";
            this.txtGhiChu.UnderlinedStyle = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderRadius = 0;
            this.panel2.Controls.Add(this.lblTongTien);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.GradientAngle = 90F;
            this.panel2.GradientBottomColor = System.Drawing.Color.White;
            this.panel2.GradientTopColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 411);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 50);
            this.panel2.TabIndex = 4;
            // 
            // lblTongTien
            // 
            this.lblTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTongTien.BackColor = System.Drawing.Color.Transparent;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.Black;
            this.lblTongTien.Location = new System.Drawing.Point(667, 13);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(205, 25);
            this.lblTongTien.TabIndex = 1;
            this.lblTongTien.Text = "0";
            this.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(554, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tổng Tiền:";
            // 
            // dgvPhieuXuat
            // 
            this.dgvPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHH,
            this.SL,
            this.DONGIA,
            this.THANHTIEN});
            this.dgvPhieuXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuXuat.Location = new System.Drawing.Point(0, 219);
            this.dgvPhieuXuat.Name = "dgvPhieuXuat";
            this.dgvPhieuXuat.Size = new System.Drawing.Size(884, 192);
            this.dgvPhieuXuat.TabIndex = 5;
            this.dgvPhieuXuat.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPhieuXuat_CellEndEdit);
            // 
            // MAHH
            // 
            this.MAHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MAHH.DataPropertyName = "MAHH";
            this.MAHH.HeaderText = "Hàng Hóa";
            this.MAHH.Name = "MAHH";
            this.MAHH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MAHH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // SL
            // 
            this.SL.DataPropertyName = "SL";
            this.SL.HeaderText = "Số Lượng";
            this.SL.Name = "SL";
            this.SL.Width = 120;
            // 
            // DONGIA
            // 
            this.DONGIA.DataPropertyName = "DONGIA";
            dataGridViewCellStyle1.Format = "N0";
            this.DONGIA.DefaultCellStyle = dataGridViewCellStyle1;
            this.DONGIA.HeaderText = "Đơn Giá";
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.Width = 150;
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.DataPropertyName = "THANHTIEN";
            dataGridViewCellStyle2.Format = "N0";
            this.THANHTIEN.DefaultCellStyle = dataGridViewCellStyle2;
            this.THANHTIEN.HeaderText = "Thành Tiền";
            this.THANHTIEN.Name = "THANHTIEN";
            this.THANHTIEN.ReadOnly = true;
            this.THANHTIEN.Width = 180;
            // 
            // FormPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.dgvPhieuXuat);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.pnlHeader);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormPhieuXuat";
            this.Text = "Phiếu Xuất Kho";
            this.Load += new System.EventHandler(this.FormPhieuXuat_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuXuat)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private DoAnLapTrinhQuanLy.CustomControls.ModernPanel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private DoAnLapTrinhQuanLy.CustomControls.ModernPanel pnlActions;
        private DoAnLapTrinhQuanLy.CustomControls.ModernButton btnThem;
        private DoAnLapTrinhQuanLy.CustomControls.ModernButton btnSua;
        private DoAnLapTrinhQuanLy.CustomControls.ModernButton btnXoa;
        private DoAnLapTrinhQuanLy.CustomControls.ModernButton btnLuu;
        private DoAnLapTrinhQuanLy.CustomControls.ModernButton btnHuy;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private DoAnLapTrinhQuanLy.CustomControls.MaterialTextBox txtSoPhieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.Label label6;
        private DoAnLapTrinhQuanLy.CustomControls.MaterialTextBox txtGhiChu;
        private DoAnLapTrinhQuanLy.CustomControls.ModernPanel panel2;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvPhieuXuat;
        private DoAnLapTrinhQuanLy.CustomControls.ModernButton btnGhiSo;
        private System.Windows.Forms.DataGridViewComboBoxColumn MAHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
    }
}
