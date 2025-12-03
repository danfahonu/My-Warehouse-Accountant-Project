namespace DoAnLapTrinhQuanLy.GuiLayer
{
    partial class FormDanhMucHangHoa
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
            this.pnlHeader = new DoAnLapTrinhQuanLy.CustomControls.ModernPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlActions = new DoAnLapTrinhQuanLy.CustomControls.ModernPanel();
            this.btnIn = new DoAnLapTrinhQuanLy.CustomControls.ModernButton();
            this.btnHuy = new DoAnLapTrinhQuanLy.CustomControls.ModernButton();
            this.btnLuu = new DoAnLapTrinhQuanLy.CustomControls.ModernButton();
            this.btnXoa = new DoAnLapTrinhQuanLy.CustomControls.ModernButton();
            this.btnSua = new DoAnLapTrinhQuanLy.CustomControls.ModernButton();
            this.btnThem = new DoAnLapTrinhQuanLy.CustomControls.ModernButton();
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHH = new DoAnLapTrinhQuanLy.CustomControls.MaterialTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenHH = new DoAnLapTrinhQuanLy.CustomControls.MaterialTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboNhomHang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiaVon = new DoAnLapTrinhQuanLy.CustomControls.MaterialTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGiaBan = new DoAnLapTrinhQuanLy.CustomControls.MaterialTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDVT = new DoAnLapTrinhQuanLy.CustomControls.MaterialTextBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picHinhAnh = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new DoAnLapTrinhQuanLy.CustomControls.ModernButton();
            this.pnlHeader.SuspendLayout();
            this.pnlActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).BeginInit();
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
            this.pnlHeader.Size = new System.Drawing.Size(984, 50);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(12, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(225, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DANH MỤC HÀNG HÓA";
            // 
            // pnlActions
            // 
            this.pnlActions.BackColor = System.Drawing.Color.White;
            this.pnlActions.BorderRadius = 0;
            this.pnlActions.Controls.Add(this.btnIn);
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
            this.pnlActions.Size = new System.Drawing.Size(984, 60);
            this.pnlActions.TabIndex = 1;
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.Gray;
            this.btnIn.BorderColor = System.Drawing.Color.Gray;
            this.btnIn.BorderRadius = 10;
            this.btnIn.FlatAppearance.BorderSize = 0;
            this.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnIn.ForeColor = System.Drawing.Color.White;
            this.btnIn.Location = new System.Drawing.Point(261, 15);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 30);
            this.btnIn.TabIndex = 5;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = false;
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
            this.btnHuy.Location = new System.Drawing.Point(871, 15);
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
            this.btnLuu.Location = new System.Drawing.Point(765, 15);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 30);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.IndianRed;
            this.btnXoa.BorderColor = System.Drawing.Color.IndianRed;
            this.btnXoa.BorderRadius = 10;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(180, 15);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Orange;
            this.btnSua.BorderColor = System.Drawing.Color.Orange;
            this.btnSua.BorderRadius = 10;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(99, 15);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 30);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);
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
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.AllowUserToAddRows = false;
            this.dgvHangHoa.AllowUserToDeleteRows = false;
            this.dgvHangHoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHangHoa.Location = new System.Drawing.Point(0, 259);
            this.dgvHangHoa.MultiSelect = false;
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.ReadOnly = true;
            this.dgvHangHoa.RowHeadersVisible = false;
            this.dgvHangHoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHangHoa.Size = new System.Drawing.Size(984, 202);
            this.dgvHangHoa.TabIndex = 3;
            this.dgvHangHoa.SelectionChanged += new System.EventHandler(this.DgvHangHoa_SelectionChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtMaHH, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTenHH, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cboNhomHang, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtGiaVon, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtGiaBan, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtDVT, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.chkActive, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 110);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 149);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hàng hóa:";
            // 
            // txtMaHH
            // 
            this.txtMaHH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaHH.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaHH.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMaHH.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMaHH.BorderRadius = 0;
            this.txtMaHH.BorderSize = 2;
            this.txtMaHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHH.ForeColor = System.Drawing.Color.DimGray;
            this.txtMaHH.Location = new System.Drawing.Point(119, 14);
            this.txtMaHH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHH.Multiline = false;
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Padding = new System.Windows.Forms.Padding(7);
            this.txtMaHH.PasswordChar = false;
            this.txtMaHH.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaHH.PlaceholderText = "";
            this.txtMaHH.ReadOnly = false;
            this.txtMaHH.Size = new System.Drawing.Size(300, 31);
            this.txtMaHH.TabIndex = 1;
            this.txtMaHH.Texts = "";
            this.txtMaHH.UnderlinedStyle = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(18, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên hàng hóa:";
            // 
            // txtTenHH
            // 
            this.txtTenHH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenHH.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenHH.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTenHH.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTenHH.BorderRadius = 0;
            this.txtTenHH.BorderSize = 2;
            this.txtTenHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHH.ForeColor = System.Drawing.Color.DimGray;
            this.txtTenHH.Location = new System.Drawing.Point(119, 46);
            this.txtTenHH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenHH.Multiline = false;
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.Padding = new System.Windows.Forms.Padding(7);
            this.txtTenHH.PasswordChar = false;
            this.txtTenHH.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenHH.PlaceholderText = "";
            this.txtTenHH.ReadOnly = false;
            this.txtTenHH.Size = new System.Drawing.Size(300, 31);
            this.txtTenHH.TabIndex = 3;
            this.txtTenHH.Texts = "";
            this.txtTenHH.UnderlinedStyle = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(18, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nhóm hàng:";
            // 
            // cboNhomHang
            // 
            this.cboNhomHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboNhomHang.FormattingEnabled = true;
            this.cboNhomHang.Location = new System.Drawing.Point(118, 79);
            this.cboNhomHang.Name = "cboNhomHang";
            this.cboNhomHang.Size = new System.Drawing.Size(302, 21);
            this.cboNhomHang.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(426, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giá vốn:";
            // 
            // txtGiaVon
            // 
            this.txtGiaVon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGiaVon.BackColor = System.Drawing.SystemColors.Window;
            this.txtGiaVon.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtGiaVon.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtGiaVon.BorderRadius = 0;
            this.txtGiaVon.BorderSize = 2;
            this.txtGiaVon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaVon.ForeColor = System.Drawing.Color.DimGray;
            this.txtGiaVon.Location = new System.Drawing.Point(527, 14);
            this.txtGiaVon.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaVon.Multiline = false;
            this.txtGiaVon.Name = "txtGiaVon";
            this.txtGiaVon.Padding = new System.Windows.Forms.Padding(7);
            this.txtGiaVon.PasswordChar = false;
            this.txtGiaVon.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtGiaVon.PlaceholderText = "";
            this.txtGiaVon.ReadOnly = false;
            this.txtGiaVon.Size = new System.Drawing.Size(300, 31);
            this.txtGiaVon.TabIndex = 7;
            this.txtGiaVon.Texts = "";
            this.txtGiaVon.UnderlinedStyle = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(426, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Giá bán:";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGiaBan.BackColor = System.Drawing.SystemColors.Window;
            this.txtGiaBan.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtGiaBan.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtGiaBan.BorderRadius = 0;
            this.txtGiaBan.BorderSize = 2;
            this.txtGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBan.ForeColor = System.Drawing.Color.DimGray;
            this.txtGiaBan.Location = new System.Drawing.Point(527, 46);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaBan.Multiline = false;
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Padding = new System.Windows.Forms.Padding(7);
            this.txtGiaBan.PasswordChar = false;
            this.txtGiaBan.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtGiaBan.PlaceholderText = "";
            this.txtGiaBan.ReadOnly = false;
            this.txtGiaBan.Size = new System.Drawing.Size(300, 31);
            this.txtGiaBan.TabIndex = 9;
            this.txtGiaBan.Texts = "";
            this.txtGiaBan.UnderlinedStyle = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(426, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đơn vị tính:";
            // 
            // txtDVT
            // 
            this.txtDVT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDVT.BackColor = System.Drawing.SystemColors.Window;
            this.txtDVT.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDVT.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDVT.BorderRadius = 0;
            this.txtDVT.BorderSize = 2;
            this.txtDVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDVT.ForeColor = System.Drawing.Color.DimGray;
            this.txtDVT.Location = new System.Drawing.Point(527, 78);
            this.txtDVT.Margin = new System.Windows.Forms.Padding(4);
            this.txtDVT.Multiline = false;
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Padding = new System.Windows.Forms.Padding(7);
            this.txtDVT.PasswordChar = false;
            this.txtDVT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDVT.PlaceholderText = "";
            this.txtDVT.ReadOnly = false;
            this.txtDVT.Size = new System.Drawing.Size(300, 31);
            this.txtDVT.TabIndex = 5;
            this.txtDVT.Texts = "";
            this.txtDVT.UnderlinedStyle = true;
            // 
            // chkActive
            // 
            this.chkActive.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkActive.AutoSize = true;
            this.chkActive.ForeColor = System.Drawing.Color.Gainsboro;
            this.chkActive.Location = new System.Drawing.Point(118, 114);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(77, 17);
            this.chkActive.TabIndex = 12;
            this.chkActive.Text = "Hoạt động";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picHinhAnh);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(834, 13);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 4);
            this.panel1.Size = new System.Drawing.Size(132, 123);
            this.panel1.TabIndex = 13;
            // 
            // picHinhAnh
            // 
            this.picHinhAnh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picHinhAnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.picHinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHinhAnh.Location = new System.Drawing.Point(3, 3);
            this.picHinhAnh.Name = "picHinhAnh";
            this.picHinhAnh.Size = new System.Drawing.Size(126, 88);
            this.picHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHinhAnh.TabIndex = 0;
            this.picHinhAnh.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBrowse.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnBrowse.BorderRadius = 10;
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(3, 97);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(126, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Chọn ảnh...";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // FormDanhMucHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.dgvHangHoa);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.pnlHeader);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormDanhMucHangHoa";
            this.Text = "FormDanhMucHangHoa";
            this.Load += new System.EventHandler(this.FormDanhMucHangHoa_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).EndInit();
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
        private DoAnLapTrinhQuanLy.CustomControls.ModernButton btnIn;
        private System.Windows.Forms.DataGridView dgvHangHoa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private DoAnLapTrinhQuanLy.CustomControls.MaterialTextBox txtMaHH;
        private System.Windows.Forms.Label label3;
        private DoAnLapTrinhQuanLy.CustomControls.MaterialTextBox txtDVT;
        private System.Windows.Forms.Label label2;
        private DoAnLapTrinhQuanLy.CustomControls.MaterialTextBox txtTenHH;
        private System.Windows.Forms.Label label4;
        private DoAnLapTrinhQuanLy.CustomControls.MaterialTextBox txtGiaVon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboNhomHang;
        private System.Windows.Forms.Label label5;
        private DoAnLapTrinhQuanLy.CustomControls.MaterialTextBox txtGiaBan;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picHinhAnh;
        private DoAnLapTrinhQuanLy.CustomControls.ModernButton btnBrowse;
    }
}