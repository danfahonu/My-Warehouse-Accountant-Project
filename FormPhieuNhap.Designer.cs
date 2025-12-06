namespace DoAnLapTrinhQuanLy.GuiLayer
{
    partial class FormPhieuNhap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.tableLayoutPanelHeader = new System.Windows.Forms.TableLayoutPanel();
            this.lblNhaCungCap = new System.Windows.Forms.Label();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.cboNhaCungCap = new System.Windows.Forms.ComboBox();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.panelTopRight = new System.Windows.Forms.Panel();
            this.lblSoPhieu = new System.Windows.Forms.Label();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.btnChonPhieuYeuCau = new DoAnLapTrinhQuanLy.Controls.ModernButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.chkThanhToan = new System.Windows.Forms.CheckBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.btnHuy = new DoAnLapTrinhQuanLy.Controls.ModernButton();
            this.btnIn = new DoAnLapTrinhQuanLy.Controls.ModernButton();
            this.btnLuu = new DoAnLapTrinhQuanLy.Controls.ModernButton();
            this.btnThem = new DoAnLapTrinhQuanLy.Controls.ModernButton();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvChiTiet = new DoAnLapTrinhQuanLy.Controls.ModernDataGrid();
            this.pnlHeader.SuspendLayout();
            this.tableLayoutPanelHeader.SuspendLayout();
            this.panelTopRight.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.tableLayoutPanelHeader);
            this.pnlHeader.Controls.Add(this.panelTopRight);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1800, 246);
            this.pnlHeader.TabIndex = 0;
            // 
            // tableLayoutPanelHeader
            // 
            this.tableLayoutPanelHeader.ColumnCount = 2;
            this.tableLayoutPanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHeader.Controls.Add(this.lblNhaCungCap, 0, 0);
            this.tableLayoutPanelHeader.Controls.Add(this.lblNgayNhap, 0, 1);
            this.tableLayoutPanelHeader.Controls.Add(this.lblGhiChu, 0, 2);
            this.tableLayoutPanelHeader.Controls.Add(this.cboNhaCungCap, 1, 0);
            this.tableLayoutPanelHeader.Controls.Add(this.dtpNgayNhap, 1, 1);
            this.tableLayoutPanelHeader.Controls.Add(this.txtGhiChu, 1, 2);
            this.tableLayoutPanelHeader.Location = new System.Drawing.Point(45, 77);
            this.tableLayoutPanelHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanelHeader.Name = "tableLayoutPanelHeader";
            this.tableLayoutPanelHeader.RowCount = 3;
            this.tableLayoutPanelHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanelHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanelHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanelHeader.Size = new System.Drawing.Size(825, 162);
            this.tableLayoutPanelHeader.TabIndex = 1;
            // 
            // lblNhaCungCap
            // 
            this.lblNhaCungCap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNhaCungCap.AutoSize = true;
            this.lblNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNhaCungCap.ForeColor = System.Drawing.Color.DimGray;
            this.lblNhaCungCap.Location = new System.Drawing.Point(4, 13);
            this.lblNhaCungCap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhaCungCap.Name = "lblNhaCungCap";
            this.lblNhaCungCap.Size = new System.Drawing.Size(136, 28);
            this.lblNhaCungCap.TabIndex = 0;
            this.lblNhaCungCap.Text = "Nhà cung cấp:";
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNgayNhap.ForeColor = System.Drawing.Color.DimGray;
            this.lblNgayNhap.Location = new System.Drawing.Point(4, 67);
            this.lblNgayNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(112, 28);
            this.lblNgayNhap.TabIndex = 1;
            this.lblNgayNhap.Text = "Ngày nhập:";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGhiChu.ForeColor = System.Drawing.Color.DimGray;
            this.lblGhiChu.Location = new System.Drawing.Point(4, 121);
            this.lblGhiChu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(82, 28);
            this.lblGhiChu.TabIndex = 2;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // cboNhaCungCap
            // 
            this.cboNhaCungCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboNhaCungCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboNhaCungCap.FormattingEnabled = true;
            this.cboNhaCungCap.Location = new System.Drawing.Point(184, 5);
            this.cboNhaCungCap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboNhaCungCap.Name = "cboNhaCungCap";
            this.cboNhaCungCap.Size = new System.Drawing.Size(637, 36);
            this.cboNhaCungCap.TabIndex = 3;
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpNgayNhap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location = new System.Drawing.Point(184, 59);
            this.dtpNgayNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(637, 34);
            this.dtpNgayNhap.TabIndex = 4;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGhiChu.Location = new System.Drawing.Point(184, 113);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(637, 34);
            this.txtGhiChu.TabIndex = 5;
            // 
            // panelTopRight
            // 
            this.panelTopRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTopRight.Controls.Add(this.lblSoPhieu);
            this.panelTopRight.Controls.Add(this.txtSoPhieu);
            this.panelTopRight.Controls.Add(this.btnChonPhieuYeuCau);
            this.panelTopRight.Location = new System.Drawing.Point(1200, 77);
            this.panelTopRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTopRight.Name = "panelTopRight";
            this.panelTopRight.Size = new System.Drawing.Size(570, 154);
            this.panelTopRight.TabIndex = 2;
            // 
            // lblSoPhieu
            // 
            this.lblSoPhieu.AutoSize = true;
            this.lblSoPhieu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSoPhieu.ForeColor = System.Drawing.Color.DimGray;
            this.lblSoPhieu.Location = new System.Drawing.Point(22, 23);
            this.lblSoPhieu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoPhieu.Name = "lblSoPhieu";
            this.lblSoPhieu.Size = new System.Drawing.Size(92, 28);
            this.lblSoPhieu.TabIndex = 2;
            this.lblSoPhieu.Text = "Số Phiếu:";
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtSoPhieu.Location = new System.Drawing.Point(135, 18);
            this.txtSoPhieu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.ReadOnly = true;
            this.txtSoPhieu.Size = new System.Drawing.Size(223, 34);
            this.txtSoPhieu.TabIndex = 1;
            // 
            // btnChonPhieuYeuCau
            // 
            this.btnChonPhieuYeuCau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnChonPhieuYeuCau.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnChonPhieuYeuCau.BorderRadius = 20;
            this.btnChonPhieuYeuCau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonPhieuYeuCau.ForeColor = System.Drawing.Color.Black;
            this.btnChonPhieuYeuCau.Location = new System.Drawing.Point(135, 77);
            this.btnChonPhieuYeuCau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChonPhieuYeuCau.Name = "btnChonPhieuYeuCau";
            this.btnChonPhieuYeuCau.Size = new System.Drawing.Size(300, 54);
            this.btnChonPhieuYeuCau.TabIndex = 0;
            this.btnChonPhieuYeuCau.Text = "Chọn Phiếu Yêu Cầu";
            this.btnChonPhieuYeuCau.UseVisualStyleBackColor = false;
            this.btnChonPhieuYeuCau.Click += new System.EventHandler(this.btnChonPhieuYeuCau_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTitle.Location = new System.Drawing.Point(36, 14);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(327, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PHIẾU NHẬP KHO";
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlFooter.Controls.Add(this.chkThanhToan);
            this.pnlFooter.Controls.Add(this.lblTongTien);
            this.pnlFooter.Controls.Add(this.labelTotal);
            this.pnlFooter.Controls.Add(this.btnHuy);
            this.pnlFooter.Controls.Add(this.btnIn);
            this.pnlFooter.Controls.Add(this.btnLuu);
            this.pnlFooter.Controls.Add(this.btnThem);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 1046);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1800, 123);
            this.pnlFooter.TabIndex = 1;
            // 
            // chkThanhToan
            // 
            this.chkThanhToan.AutoSize = true;
            this.chkThanhToan.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.chkThanhToan.Location = new System.Drawing.Point(600, 43);
            this.chkThanhToan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkThanhToan.Name = "chkThanhToan";
            this.chkThanhToan.Size = new System.Drawing.Size(200, 34);
            this.chkThanhToan.TabIndex = 4;
            this.chkThanhToan.Text = "Thanh toán ngay";
            this.chkThanhToan.UseVisualStyleBackColor = true;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblTongTien.Location = new System.Drawing.Point(270, 31);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(46, 54);
            this.lblTongTien.TabIndex = 3;
            this.lblTongTien.Text = "0";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelTotal.Location = new System.Drawing.Point(45, 43);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(164, 38);
            this.labelTotal.TabIndex = 2;
            this.labelTotal.Text = "TỔNG TIỀN:";
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.BackColor = System.Drawing.Color.White;
            this.btnHuy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnHuy.BorderRadius = 20;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.ForeColor = System.Drawing.Color.Black;
            this.btnHuy.Location = new System.Drawing.Point(1605, 31);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(150, 62);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnIn
            // 
            this.btnIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIn.BackColor = System.Drawing.Color.White;
            this.btnIn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnIn.BorderRadius = 20;
            this.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIn.ForeColor = System.Drawing.Color.Black;
            this.btnIn.Location = new System.Drawing.Point(1440, 31);
            this.btnIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(150, 62);
            this.btnIn.TabIndex = 5;
            this.btnIn.Text = "In Phiếu";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnLuu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnLuu.BorderRadius = 20;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(1230, 31);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(195, 62);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu Phiếu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnThem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnThem.BorderRadius = 20;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(1020, 31);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(195, 62);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Tạo Mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.dgvChiTiet);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 246);
            this.pnlGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(15);
            this.pnlGrid.Size = new System.Drawing.Size(1800, 800);
            this.pnlGrid.TabIndex = 2;
            // 
            // dgvChiTiet
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvChiTiet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTiet.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTiet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChiTiet.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvChiTiet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(79)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChiTiet.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTiet.EnableHeadersVisualStyles = false;
            this.dgvChiTiet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.dgvChiTiet.Location = new System.Drawing.Point(15, 15);
            this.dgvChiTiet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.RowHeadersVisible = false;
            this.dgvChiTiet.RowHeadersWidth = 62;
            this.dgvChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTiet.Size = new System.Drawing.Size(1770, 770);
            this.dgvChiTiet.TabIndex = 0;
            // 
            // FormPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1800, 1169);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPhieuNhap";
            this.Text = "Lập Phiếu Nhập Kho";
            this.Load += new System.EventHandler(this.FormPhieuNhap_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tableLayoutPanelHeader.ResumeLayout(false);
            this.tableLayoutPanelHeader.PerformLayout();
            this.panelTopRight.ResumeLayout(false);
            this.panelTopRight.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHeader;
        private System.Windows.Forms.Label lblNhaCungCap;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.ComboBox cboNhaCungCap;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Panel panelTopRight;
        private DoAnLapTrinhQuanLy.Controls.ModernButton btnChonPhieuYeuCau;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.CheckBox chkThanhToan;
        private DoAnLapTrinhQuanLy.Controls.ModernButton btnHuy;
        private DoAnLapTrinhQuanLy.Controls.ModernButton btnLuu;
        private DoAnLapTrinhQuanLy.Controls.ModernButton btnIn;
        private DoAnLapTrinhQuanLy.Controls.ModernButton btnThem;
        private System.Windows.Forms.Panel pnlGrid;
        private DoAnLapTrinhQuanLy.Controls.ModernDataGrid dgvChiTiet;
        private System.Windows.Forms.Label lblSoPhieu;
        private System.Windows.Forms.TextBox txtSoPhieu;
    }
}