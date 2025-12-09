namespace DoAnLapTrinhQuanLy.GuiLayer
{
    partial class FormPhieuXuat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.lblKhach = new System.Windows.Forms.Label();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.lblNgay = new System.Windows.Forms.Label();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.lblSoPhieu = new System.Windows.Forms.Label();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.colMaHH = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colTenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTonKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.flowLayoutPanelBtn = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTongTienLabel = new System.Windows.Forms.Label();
            this.chkThanhToan = new System.Windows.Forms.CheckBox();
            this.pnlHeader.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.grpInfo.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(1200, 50);
            this.pnlHeader.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1200, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PHIẾU XUẤT KHO (BÁN HÀNG)";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.White;
            this.pnlInfo.Controls.Add(this.grpInfo);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfo.Location = new System.Drawing.Point(0, 50);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Padding = new System.Windows.Forms.Padding(10);
            this.pnlInfo.Size = new System.Drawing.Size(1200, 110);
            this.pnlInfo.TabIndex = 1;
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.txtGhiChu);
            this.grpInfo.Controls.Add(this.lblGhiChu);
            this.grpInfo.Controls.Add(this.cboKhachHang);
            this.grpInfo.Controls.Add(this.lblKhach);
            this.grpInfo.Controls.Add(this.dtpNgayLap);
            this.grpInfo.Controls.Add(this.lblNgay);
            this.grpInfo.Controls.Add(this.txtSoPhieu);
            this.grpInfo.Controls.Add(this.lblSoPhieu);
            this.grpInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpInfo.Location = new System.Drawing.Point(10, 10);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(1180, 90);
            this.grpInfo.TabIndex = 0;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Thông tin chung";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGhiChu.Location = new System.Drawing.Point(100, 57);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(770, 34);
            this.txtGhiChu.TabIndex = 0;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGhiChu.Location = new System.Drawing.Point(30, 60);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(82, 28);
            this.lblGhiChu.TabIndex = 1;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboKhachHang.Location = new System.Drawing.Point(570, 27);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(300, 36);
            this.cboKhachHang.TabIndex = 2;
            // 
            // lblKhach
            // 
            this.lblKhach.AutoSize = true;
            this.lblKhach.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblKhach.Location = new System.Drawing.Point(480, 30);
            this.lblKhach.Name = "lblKhach";
            this.lblKhach.Size = new System.Drawing.Size(118, 28);
            this.lblKhach.TabIndex = 3;
            this.lblKhach.Text = "Khách hàng:";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLap.Location = new System.Drawing.Point(330, 27);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(120, 34);
            this.dtpNgayLap.TabIndex = 4;
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNgay.Location = new System.Drawing.Point(280, 30);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(63, 28);
            this.lblNgay.TabIndex = 5;
            this.lblNgay.Text = "Ngày:";
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSoPhieu.Location = new System.Drawing.Point(100, 27);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.ReadOnly = true;
            this.txtSoPhieu.Size = new System.Drawing.Size(150, 34);
            this.txtSoPhieu.TabIndex = 6;
            // 
            // lblSoPhieu
            // 
            this.lblSoPhieu.AutoSize = true;
            this.lblSoPhieu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSoPhieu.Location = new System.Drawing.Point(30, 30);
            this.lblSoPhieu.Name = "lblSoPhieu";
            this.lblSoPhieu.Size = new System.Drawing.Size(92, 28);
            this.lblSoPhieu.TabIndex = 7;
            this.lblSoPhieu.Text = "Số Phiếu:";
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.dgvChiTiet);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 160);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(10);
            this.pnlGrid.Size = new System.Drawing.Size(1200, 520);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvChiTiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChiTiet.ColumnHeadersHeight = 35;
            this.dgvChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHH,
            this.colTenHH,
            this.colDVT,
            this.colTonKho,
            this.colSL,
            this.colDonGia,
            this.colThanhTien,
            this.colXoa});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChiTiet.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTiet.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvChiTiet.EnableHeadersVisualStyles = false;
            this.dgvChiTiet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvChiTiet.Location = new System.Drawing.Point(10, 10);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.RowHeadersWidth = 62;
            this.dgvChiTiet.RowTemplate.Height = 30;
            this.dgvChiTiet.Size = new System.Drawing.Size(1180, 500);
            this.dgvChiTiet.TabIndex = 0;
            this.dgvChiTiet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvChiTiet_CellContentClick);
            this.dgvChiTiet.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvChiTiet_CellValueChanged);
            this.dgvChiTiet.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DgvChiTiet_DataError);
            this.dgvChiTiet.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DgvChiTiet_EditingControlShowing);
            // 
            // colMaHH
            // 
            this.colMaHH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colMaHH.HeaderText = "Hàng hóa (Chọn)";
            this.colMaHH.MinimumWidth = 8;
            this.colMaHH.Name = "colMaHH";
            // 
            // colTenHH
            // 
            this.colTenHH.HeaderText = "Tên Hàng";
            this.colTenHH.MinimumWidth = 8;
            this.colTenHH.Name = "colTenHH";
            this.colTenHH.ReadOnly = true;
            // 
            // colDVT
            // 
            this.colDVT.HeaderText = "ĐVT";
            this.colDVT.MinimumWidth = 8;
            this.colDVT.Name = "colDVT";
            this.colDVT.ReadOnly = true;
            // 
            // colTonKho
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            this.colTonKho.DefaultCellStyle = dataGridViewCellStyle2;
            this.colTonKho.HeaderText = "Tồn";
            this.colTonKho.MinimumWidth = 8;
            this.colTonKho.Name = "colTonKho";
            this.colTonKho.ReadOnly = true;
            // 
            // colSL
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.Format = "N0";
            this.colSL.DefaultCellStyle = dataGridViewCellStyle3;
            this.colSL.HeaderText = "SL Xuất";
            this.colSL.MinimumWidth = 8;
            this.colSL.Name = "colSL";
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
            // colXoa
            // 
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
            this.pnlFooter.Location = new System.Drawing.Point(0, 680);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(10);
            this.pnlFooter.Size = new System.Drawing.Size(1200, 70);
            this.pnlFooter.TabIndex = 2;
            // 
            // flowLayoutPanelBtn
            // 
            this.flowLayoutPanelBtn.Controls.Add(this.btnThoat);
            this.flowLayoutPanelBtn.Controls.Add(this.btnIn);
            this.flowLayoutPanelBtn.Controls.Add(this.btnTaoMoi);
            this.flowLayoutPanelBtn.Controls.Add(this.btnLuu);
            this.flowLayoutPanelBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanelBtn.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelBtn.Location = new System.Drawing.Point(711, 10);
            this.flowLayoutPanelBtn.Name = "flowLayoutPanelBtn";
            this.flowLayoutPanelBtn.Size = new System.Drawing.Size(479, 50);
            this.flowLayoutPanelBtn.TabIndex = 10;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Gray;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(374, 5);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 40);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.White;
            this.btnIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIn.Enabled = false;
            this.btnIn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnIn.ForeColor = System.Drawing.Color.Black;
            this.btnIn.Location = new System.Drawing.Point(264, 5);
            this.btnIn.Margin = new System.Windows.Forms.Padding(5);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(100, 40);
            this.btnIn.TabIndex = 1;
            this.btnIn.Text = "In phiếu";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.BackColor = System.Drawing.Color.Orange;
            this.btnTaoMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaoMoi.FlatAppearance.BorderSize = 0;
            this.btnTaoMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoMoi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTaoMoi.ForeColor = System.Drawing.Color.White;
            this.btnTaoMoi.Location = new System.Drawing.Point(154, 5);
            this.btnTaoMoi.Margin = new System.Windows.Forms.Padding(5);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(100, 40);
            this.btnTaoMoi.TabIndex = 2;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = false;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(14, 5);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(130, 40);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "LƯU & XUẤT";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(140, 20);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(67, 45);
            this.lblTongTien.TabIndex = 11;
            this.lblTongTien.Text = "0 đ";
            // 
            // lblTongTienLabel
            // 
            this.lblTongTienLabel.AutoSize = true;
            this.lblTongTienLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTongTienLabel.Location = new System.Drawing.Point(30, 25);
            this.lblTongTienLabel.Name = "lblTongTienLabel";
            this.lblTongTienLabel.Size = new System.Drawing.Size(158, 32);
            this.lblTongTienLabel.TabIndex = 12;
            this.lblTongTienLabel.Text = "TỔNG CỘNG:";
            // 
            // chkThanhToan
            // 
            this.chkThanhToan.AutoSize = true;
            this.chkThanhToan.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.chkThanhToan.Location = new System.Drawing.Point(350, 26);
            this.chkThanhToan.Name = "chkThanhToan";
            this.chkThanhToan.Size = new System.Drawing.Size(200, 34);
            this.chkThanhToan.TabIndex = 13;
            this.chkThanhToan.Text = "Thanh toán ngay";
            // 
            // FormPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Name = "FormPhieuXuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập Phiếu Xuất Kho";
            this.Load += new System.EventHandler(this.FormPhieuXuat_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.flowLayoutPanelBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        // Controls
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblSoPhieu;
        private System.Windows.Forms.TextBox txtSoPhieu;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Label lblKhach;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;

        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvChiTiet;

        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBtn;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblTongTienLabel;
        private System.Windows.Forms.CheckBox chkThanhToan;

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnHuy; // btnThoat biến thành btnHuy trong code logic

        // Grid Columns
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTonKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.DataGridViewButtonColumn colXoa;
        private System.Windows.Forms.Button btnThoat; // Biến này dùng cho nút Thoát
    }
}