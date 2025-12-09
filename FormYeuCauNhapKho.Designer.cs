namespace DoAnLapTrinhQuanLy.GuiLayer
{
    partial class FormYeuCauNhapKho
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
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.flowLayoutPanelActions = new System.Windows.Forms.FlowLayoutPanel();

            // Các nút bấm
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();

            this.splitContainer = new System.Windows.Forms.SplitContainer();

            // --- TRÁI ---
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayYC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThaiVal = new System.Windows.Forms.DataGridViewTextBoxColumn();

            // --- PHẢI ---
            this.pnlRight = new System.Windows.Forms.Panel();
            this.grpDuyet = new System.Windows.Forms.GroupBox();
            this.btnTuChoi = new System.Windows.Forms.Button();
            this.btnDuyet = new System.Windows.Forms.Button();
            this.txtGhiChuDuyet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboNhanVienYeuCau = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayYeuCau = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.grpChiTiet = new System.Windows.Forms.GroupBox();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.colMaHH = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXoa = new System.Windows.Forms.DataGridViewButtonColumn();

            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.flowLayoutPanelActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.grpDuyet.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.grpChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.SuspendLayout();

            // 
            // FormYeuCauNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Name = "FormYeuCauNhapKho";
            this.Text = "Quản Lý Yêu Cầu Nhập Kho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormYeuCauNhapKho_Load);

            // --- HEADER ---
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 50;

            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1200, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PHIẾU YÊU CẦU NHẬP KHO";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // --- FOOTER ---
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.Controls.Add(this.flowLayoutPanelActions);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Height = 60;

            this.flowLayoutPanelActions.Controls.Add(this.btnThoat);
            this.flowLayoutPanelActions.Controls.Add(this.btnHuy);
            this.flowLayoutPanelActions.Controls.Add(this.btnLuu);
            this.flowLayoutPanelActions.Controls.Add(this.btnXoa);
            this.flowLayoutPanelActions.Controls.Add(this.btnThem);
            this.flowLayoutPanelActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelActions.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelActions.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanelActions.TabIndex = 0;

            // --- CẤU HÌNH CÁC NÚT (VIẾT TƯỜNG MINH RA ĐỂ KHÔNG LỖI) ---

            // btnThoat (Xám)
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Size = new System.Drawing.Size(100, 40);
            this.btnThoat.BackColor = System.Drawing.Color.Gray;
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(5);
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            // btnHuy (Cam)
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Size = new System.Drawing.Size(100, 40);
            this.btnHuy.BackColor = System.Drawing.Color.Orange;
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(5);
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);

            // btnLuu (Xanh Dương)
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Size = new System.Drawing.Size(100, 40);
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(5);
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);

            // btnXoa (Đỏ)
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Size = new System.Drawing.Size(100, 40);
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(5);
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // btnThem (Xanh Lá)
            this.btnThem.Text = "Tạo Mới";
            this.btnThem.Size = new System.Drawing.Size(100, 40);
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnThem.Margin = new System.Windows.Forms.Padding(5);
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // --- SPLIT CONTAINER ---
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 50);
            this.splitContainer.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer.Panel1.Controls.Add(this.grpDanhSach);
            this.splitContainer.Panel2.Controls.Add(this.pnlRight);
            this.splitContainer.Size = new System.Drawing.Size(1200, 640);
            this.splitContainer.SplitterDistance = 400;
            this.splitContainer.TabIndex = 1;

            // --- LEFT: DANH SÁCH ---
            this.grpDanhSach.Controls.Add(this.dgvDanhSach);
            this.grpDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDanhSach.Text = "Danh sách yêu cầu";

            this.dgvDanhSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colID, this.colNgayYC, this.colTrangThai, this.colTrangThaiVal
            });
            this.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSach.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dgvDanhSach.RowHeadersVisible = false;
            this.dgvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.AllowUserToAddRows = false;
            this.dgvDanhSach.SelectionChanged += new System.EventHandler(this.dgvDanhSach_SelectionChanged);

            this.colID.Name = "colID";
            this.colID.HeaderText = "Mã"; this.colID.DataPropertyName = "ID"; this.colID.Width = 60;

            this.colNgayYC.Name = "colNgayYC";
            this.colNgayYC.HeaderText = "Ngày"; this.colNgayYC.DataPropertyName = "NGAY_YEUCAU"; this.colNgayYC.Width = 100;

            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.HeaderText = "Trạng Thái"; this.colTrangThai.DataPropertyName = "TRANGTHAI_TEXT"; this.colTrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

            this.colTrangThaiVal.Name = "colTrangThaiVal";
            this.colTrangThaiVal.DataPropertyName = "TRANGTHAI"; this.colTrangThaiVal.Visible = false;

            // --- RIGHT: CHI TIẾT ---
            this.pnlRight.Controls.Add(this.grpChiTiet);
            this.pnlRight.Controls.Add(this.grpDuyet);
            this.pnlRight.Controls.Add(this.grpInfo);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;

            // 1. Group Info
            this.grpInfo.Controls.Add(this.txtLyDo);
            this.grpInfo.Controls.Add(this.label3);
            this.grpInfo.Controls.Add(this.cboNhanVienYeuCau);
            this.grpInfo.Controls.Add(this.label2);
            this.grpInfo.Controls.Add(this.dtpNgayYeuCau);
            this.grpInfo.Controls.Add(this.label1);
            this.grpInfo.Controls.Add(this.txtID);
            this.grpInfo.Controls.Add(this.labelID);
            this.grpInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpInfo.Height = 150;
            this.grpInfo.Text = "Thông tin chung";

            this.labelID.Location = new System.Drawing.Point(20, 30); this.labelID.Text = "Số Phiếu:"; this.labelID.AutoSize = true;
            this.txtID.Location = new System.Drawing.Point(100, 27); this.txtID.Size = new System.Drawing.Size(150, 25); this.txtID.ReadOnly = true;

            this.label1.Location = new System.Drawing.Point(300, 30); this.label1.Text = "Ngày YC:"; this.label1.AutoSize = true;
            this.dtpNgayYeuCau.Location = new System.Drawing.Point(370, 27); this.dtpNgayYeuCau.Format = System.Windows.Forms.DateTimePickerFormat.Short; this.dtpNgayYeuCau.Size = new System.Drawing.Size(150, 25);

            this.label2.Location = new System.Drawing.Point(20, 70); this.label2.Text = "Người YC:"; this.label2.AutoSize = true;
            this.cboNhanVienYeuCau.Location = new System.Drawing.Point(100, 67); this.cboNhanVienYeuCau.Size = new System.Drawing.Size(420, 25); this.cboNhanVienYeuCau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.label3.Location = new System.Drawing.Point(20, 110); this.label3.Text = "Lý do:"; this.label3.AutoSize = true;
            this.txtLyDo.Location = new System.Drawing.Point(100, 107); this.txtLyDo.Size = new System.Drawing.Size(420, 25);

            // 2. Group Duyệt (Tên biến: grpDuyet)
            this.grpDuyet.Controls.Add(this.btnTuChoi);
            this.grpDuyet.Controls.Add(this.btnDuyet);
            this.grpDuyet.Controls.Add(this.txtGhiChuDuyet);
            this.grpDuyet.Controls.Add(this.label4);
            this.grpDuyet.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDuyet.Height = 100;
            this.grpDuyet.Text = "Phê duyệt (Dành cho Quản lý)";
            this.grpDuyet.Name = "grpDuyet";

            this.label4.Location = new System.Drawing.Point(20, 30); this.label4.Text = "Ghi chú:"; this.label4.AutoSize = true;
            this.txtGhiChuDuyet.Location = new System.Drawing.Point(100, 27); this.txtGhiChuDuyet.Multiline = true; this.txtGhiChuDuyet.Size = new System.Drawing.Size(420, 50);

            // btnDuyet
            this.btnDuyet.Text = "DUYỆT";
            this.btnDuyet.Size = new System.Drawing.Size(90, 35);
            this.btnDuyet.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDuyet.ForeColor = System.Drawing.Color.White;
            this.btnDuyet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuyet.Location = new System.Drawing.Point(540, 25);
            this.btnDuyet.Click += new System.EventHandler(this.btnDuyet_Click);

            // btnTuChoi
            this.btnTuChoi.Text = "TỪ CHỐI";
            this.btnTuChoi.Size = new System.Drawing.Size(90, 35);
            this.btnTuChoi.BackColor = System.Drawing.Color.Firebrick;
            this.btnTuChoi.ForeColor = System.Drawing.Color.White;
            this.btnTuChoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTuChoi.Location = new System.Drawing.Point(650, 25);
            this.btnTuChoi.Click += new System.EventHandler(this.btnTuChoi_Click);

            // 3. Group Chi tiết
            this.grpChiTiet.Controls.Add(this.dgvChiTiet);
            this.grpChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpChiTiet.Text = "Chi tiết hàng hóa";

            this.dgvChiTiet.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTiet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colMaHH, this.colDVT, this.colSL, this.colGhiChu, this.colXoa
            });
            this.dgvChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTiet.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvChiTiet.AllowUserToAddRows = true;

            // Events
            this.dgvChiTiet.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DgvChiTiet_EditingControlShowing);
            this.dgvChiTiet.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvChiTiet_CellValueChanged);
            this.dgvChiTiet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvChiTiet_CellContentClick);
            this.dgvChiTiet.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DgvChiTiet_DataError);

            this.colMaHH.Name = "colMaHH";
            this.colMaHH.HeaderText = "Hàng Hóa";
            this.colMaHH.Width = 200;
            this.colMaHH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colMaHH.AutoComplete = true;

            this.colDVT.Name = "colDVT";
            this.colDVT.HeaderText = "ĐVT";
            this.colDVT.ReadOnly = true;
            this.colDVT.Width = 80;
            this.colDVT.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;

            this.colSL.Name = "colSL";
            this.colSL.HeaderText = "Số Lượng";
            this.colSL.Width = 100;
            this.colSL.DefaultCellStyle.Format = "N0";
            this.colSL.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;

            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.HeaderText = "Ghi Chú";
            this.colGhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

            this.colXoa.Name = "colXoa";
            this.colXoa.HeaderText = "";
            this.colXoa.Text = "X";
            this.colXoa.UseColumnTextForButtonValue = true;
            this.colXoa.Width = 40;
            this.colXoa.DefaultCellStyle.ForeColor = System.Drawing.Color.Red;

            this.pnlHeader.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.flowLayoutPanelActions.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.grpDuyet.ResumeLayout(false);
            this.grpDuyet.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.grpChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        // Controls
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelActions;
        private System.Windows.Forms.Button btnThoat, btnHuy, btnLuu, btnXoa, btnThem;

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID, colNgayYC, colTrangThai, colTrangThaiVal;

        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.TextBox txtID, txtLyDo;
        private System.Windows.Forms.Label labelID, label1, label2, label3;
        private System.Windows.Forms.DateTimePicker dtpNgayYeuCau;
        private System.Windows.Forms.ComboBox cboNhanVienYeuCau;

        private System.Windows.Forms.GroupBox grpDuyet;
        private System.Windows.Forms.Button btnDuyet, btnTuChoi;
        private System.Windows.Forms.TextBox txtGhiChuDuyet;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.GroupBox grpChiTiet;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDVT, colSL, colGhiChu;
        private System.Windows.Forms.DataGridViewButtonColumn colXoa;
    }
}