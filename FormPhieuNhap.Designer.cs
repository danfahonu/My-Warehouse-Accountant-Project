namespace DoAnLapTrinhQuanLy.GuiLayer
{
    partial class FormPhieuNhap
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.btnChonPhieuYeuCau = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.cboNhaCungCap = new System.Windows.Forms.ComboBox();
            this.lblNhaCungCap = new System.Windows.Forms.Label();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.lblSoPhieu = new System.Windows.Forms.Label();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.colMaHH = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChuHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.flowLayoutPanelBtn = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTongTienLabel = new System.Windows.Forms.Label();
            this.chkThanhToan = new System.Windows.Forms.CheckBox();
            this.pnlHeader.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.flowLayoutPanelBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.pnlHeader.Size = new System.Drawing.Size(1200, 50);
            this.pnlHeader.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1180, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PHIẾU NHẬP KHO";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.grpThongTin);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 50);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(10);
            this.pnlTop.Size = new System.Drawing.Size(1200, 130);
            this.pnlTop.TabIndex = 2;
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.btnChonPhieuYeuCau);
            this.grpThongTin.Controls.Add(this.txtGhiChu);
            this.grpThongTin.Controls.Add(this.lblGhiChu);
            this.grpThongTin.Controls.Add(this.cboNhaCungCap);
            this.grpThongTin.Controls.Add(this.lblNhaCungCap);
            this.grpThongTin.Controls.Add(this.dtpNgayNhap);
            this.grpThongTin.Controls.Add(this.lblNgayNhap);
            this.grpThongTin.Controls.Add(this.txtSoPhieu);
            this.grpThongTin.Controls.Add(this.lblSoPhieu);
            this.grpThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.Location = new System.Drawing.Point(10, 10);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(1180, 110);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin chung";
            // 
            // btnChonPhieuYeuCau
            // 
            this.btnChonPhieuYeuCau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnChonPhieuYeuCau.FlatAppearance.BorderSize = 0;
            this.btnChonPhieuYeuCau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonPhieuYeuCau.Location = new System.Drawing.Point(930, 30);
            this.btnChonPhieuYeuCau.Name = "btnChonPhieuYeuCau";
            this.btnChonPhieuYeuCau.Size = new System.Drawing.Size(140, 28);
            this.btnChonPhieuYeuCau.TabIndex = 0;
            this.btnChonPhieuYeuCau.Text = "Chọn từ Yêu Cầu";
            this.btnChonPhieuYeuCau.UseVisualStyleBackColor = false;
            this.btnChonPhieuYeuCau.Click += new System.EventHandler(this.btnChonPhieuYeuCau_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGhiChu.Location = new System.Drawing.Point(100, 72);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(800, 34);
            this.txtGhiChu.TabIndex = 1;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGhiChu.Location = new System.Drawing.Point(30, 75);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(82, 28);
            this.lblGhiChu.TabIndex = 2;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // cboNhaCungCap
            // 
            this.cboNhaCungCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhaCungCap.Location = new System.Drawing.Point(550, 32);
            this.cboNhaCungCap.Name = "cboNhaCungCap";
            this.cboNhaCungCap.Size = new System.Drawing.Size(350, 36);
            this.cboNhaCungCap.TabIndex = 3;
            // 
            // lblNhaCungCap
            // 
            this.lblNhaCungCap.AutoSize = true;
            this.lblNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNhaCungCap.Location = new System.Drawing.Point(480, 35);
            this.lblNhaCungCap.Name = "lblNhaCungCap";
            this.lblNhaCungCap.Size = new System.Drawing.Size(80, 28);
            this.lblNhaCungCap.TabIndex = 4;
            this.lblNhaCungCap.Text = "Nhà CC:";
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location = new System.Drawing.Point(330, 32);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(120, 34);
            this.dtpNgayNhap.TabIndex = 5;
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNgayNhap.Location = new System.Drawing.Point(280, 35);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(63, 28);
            this.lblNgayNhap.TabIndex = 6;
            this.lblNgayNhap.Text = "Ngày:";
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Location = new System.Drawing.Point(100, 32);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.ReadOnly = true;
            this.txtSoPhieu.Size = new System.Drawing.Size(150, 34);
            this.txtSoPhieu.TabIndex = 7;
            // 
            // lblSoPhieu
            // 
            this.lblSoPhieu.AutoSize = true;
            this.lblSoPhieu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSoPhieu.Location = new System.Drawing.Point(30, 35);
            this.lblSoPhieu.Name = "lblSoPhieu";
            this.lblSoPhieu.Size = new System.Drawing.Size(92, 28);
            this.lblSoPhieu.TabIndex = 8;
            this.lblSoPhieu.Text = "Số Phiếu:";
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.dgvChiTiet);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 180);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(10);
            this.pnlGrid.Size = new System.Drawing.Size(1200, 440);
            this.pnlGrid.TabIndex = 0;
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTiet.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTiet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChiTiet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvChiTiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChiTiet.ColumnHeadersHeight = 35;
            this.dgvChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHH,
            this.colDVT,
            this.colSoLuong,
            this.colDonGia,
            this.colThanhTien,
            this.colGhiChuHang,
            this.colXoa});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChiTiet.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTiet.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvChiTiet.EnableHeadersVisualStyles = false;
            this.dgvChiTiet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvChiTiet.Location = new System.Drawing.Point(10, 10);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.RowHeadersWidth = 62;
            this.dgvChiTiet.RowTemplate.Height = 30;
            this.dgvChiTiet.Size = new System.Drawing.Size(1180, 420);
            this.dgvChiTiet.TabIndex = 0;
            this.dgvChiTiet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTiet_CellContentClick);
            this.dgvChiTiet.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTiet_CellValueChanged);
            this.dgvChiTiet.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvChiTiet_DataError);
            this.dgvChiTiet.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvChiTiet_EditingControlShowing);
            // 
            // colMaHH
            // 
            this.colMaHH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colMaHH.HeaderText = "Hàng hóa (Chọn)";
            this.colMaHH.MinimumWidth = 8;
            this.colMaHH.Name = "colMaHH";
            // 
            // colDVT
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colDVT.DefaultCellStyle = dataGridViewCellStyle2;
            this.colDVT.HeaderText = "ĐVT";
            this.colDVT.MinimumWidth = 8;
            this.colDVT.Name = "colDVT";
            this.colDVT.ReadOnly = true;
            // 
            // colSoLuong
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.Format = "N0";
            this.colSoLuong.DefaultCellStyle = dataGridViewCellStyle3;
            this.colSoLuong.HeaderText = "Số Lượng";
            this.colSoLuong.MinimumWidth = 8;
            this.colSoLuong.Name = "colSoLuong";
            // 
            // colDonGia
            // 
            this.colDonGia.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDonGia.HeaderText = "Đơn Giá";
            this.colDonGia.MinimumWidth = 8;
            this.colDonGia.Name = "colDonGia";
            // 
            // colThanhTien
            // 
            this.colThanhTien.DefaultCellStyle = dataGridViewCellStyle3;
            this.colThanhTien.HeaderText = "Thành Tiền";
            this.colThanhTien.MinimumWidth = 8;
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.ReadOnly = true;
            // 
            // colGhiChuHang
            // 
            this.colGhiChuHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGhiChuHang.HeaderText = "Ghi Chú";
            this.colGhiChuHang.MinimumWidth = 8;
            this.colGhiChuHang.Name = "colGhiChuHang";
            // 
            // colXoa
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            this.colXoa.DefaultCellStyle = dataGridViewCellStyle4;
            this.colXoa.HeaderText = "";
            this.colXoa.MinimumWidth = 8;
            this.colXoa.Name = "colXoa";
            this.colXoa.Text = "X";
            this.colXoa.UseColumnTextForButtonValue = true;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.Controls.Add(this.flowLayoutPanelBtn);
            this.pnlFooter.Controls.Add(this.lblTongTien);
            this.pnlFooter.Controls.Add(this.lblTongTienLabel);
            this.pnlFooter.Controls.Add(this.chkThanhToan);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 620);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(10);
            this.pnlFooter.Size = new System.Drawing.Size(1200, 80);
            this.pnlFooter.TabIndex = 1;
            // 
            // flowLayoutPanelBtn
            // 
            this.flowLayoutPanelBtn.Controls.Add(this.btnHuy);
            this.flowLayoutPanelBtn.Controls.Add(this.btnIn);
            this.flowLayoutPanelBtn.Controls.Add(this.btnThem);
            this.flowLayoutPanelBtn.Controls.Add(this.btnLuu);
            this.flowLayoutPanelBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanelBtn.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelBtn.Location = new System.Drawing.Point(705, 10);
            this.flowLayoutPanelBtn.Name = "flowLayoutPanelBtn";
            this.flowLayoutPanelBtn.Size = new System.Drawing.Size(485, 60);
            this.flowLayoutPanelBtn.TabIndex = 10;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Location = new System.Drawing.Point(380, 5);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 45);
            this.btnHuy.TabIndex = 0;
            this.btnHuy.Text = "Thoát";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnIn
            // 
            this.btnIn.Enabled = false;
            this.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIn.Location = new System.Drawing.Point(270, 5);
            this.btnIn.Margin = new System.Windows.Forms.Padding(5);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(100, 45);
            this.btnIn.TabIndex = 1;
            this.btnIn.Text = "In phiếu";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnThem
            // 
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(160, 5);
            this.btnThem.Margin = new System.Windows.Forms.Padding(5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 45);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Tạo mới";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(20, 5);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(130, 45);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "LƯU PHIẾU";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(140, 25);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(67, 45);
            this.lblTongTien.TabIndex = 11;
            this.lblTongTien.Text = "0 đ";
            // 
            // lblTongTienLabel
            // 
            this.lblTongTienLabel.AutoSize = true;
            this.lblTongTienLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTongTienLabel.Location = new System.Drawing.Point(30, 30);
            this.lblTongTienLabel.Name = "lblTongTienLabel";
            this.lblTongTienLabel.Size = new System.Drawing.Size(158, 32);
            this.lblTongTienLabel.TabIndex = 12;
            this.lblTongTienLabel.Text = "TỔNG CỘNG:";
            // 
            // chkThanhToan
            // 
            this.chkThanhToan.AutoSize = true;
            this.chkThanhToan.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.chkThanhToan.Location = new System.Drawing.Point(350, 31);
            this.chkThanhToan.Name = "chkThanhToan";
            this.chkThanhToan.Size = new System.Drawing.Size(200, 34);
            this.chkThanhToan.TabIndex = 13;
            this.chkThanhToan.Text = "Thanh toán ngay";
            // 
            // FormPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập Phiếu Nhập Kho";
            this.Load += new System.EventHandler(this.FormPhieuNhap_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.flowLayoutPanelBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblSoPhieu;
        private System.Windows.Forms.TextBox txtSoPhieu;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Label lblNhaCungCap;
        private System.Windows.Forms.ComboBox cboNhaCungCap;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnChonPhieuYeuCau;

        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvChiTiet;

        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBtn; // MỚI
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblTongTienLabel;
        private System.Windows.Forms.CheckBox chkThanhToan;

        // Buttons chuẩn logic cũ
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnHuy;

        // Grid Columns
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChuHang;
        private System.Windows.Forms.DataGridViewButtonColumn colXoa;
    }
}