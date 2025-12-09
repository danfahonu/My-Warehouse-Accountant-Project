namespace DoAnLapTrinhQuanLy.GuiLayer
{
    partial class FormThuChi
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();

            // Khai báo controls
            this.grpList = new System.Windows.Forms.GroupBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.cboFilterLoai = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();

            this.grpDetail = new System.Windows.Forms.GroupBox();
            // Các textbox chi tiết
            this.txtTkCo = new System.Windows.Forms.TextBox();
            this.lblTkCo = new System.Windows.Forms.Label();
            this.txtTkNo = new System.Windows.Forms.TextBox();
            this.lblTkNo = new System.Windows.Forms.Label();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.lblLyDo = new System.Windows.Forms.Label();
            this.cboDoiTuong = new System.Windows.Forms.ComboBox();
            this.lblDoiTuong = new System.Windows.Forms.Label();
            this.radNhaCungCap = new System.Windows.Forms.RadioButton();
            this.radKhachHang = new System.Windows.Forms.RadioButton();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.lblSoTien = new System.Windows.Forms.Label();
            this.cboLoaiPhieu = new System.Windows.Forms.ComboBox();
            this.lblLoai = new System.Windows.Forms.Label();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.lblNgay = new System.Windows.Forms.Label();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.lblSoPhieu = new System.Windows.Forms.Label();

            this.pnlButtons = new System.Windows.Forms.Panel();
            this.flowLayoutPanelBtn = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.grpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.grpDetail.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.flowLayoutPanelBtn.SuspendLayout();
            this.SuspendLayout();

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Name = "FormThuChi";
            this.Text = "Quản Lý Thu Chi";
            this.Load += new System.EventHandler(this.FormThuChi_Load);

            // Header
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 50;

            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1100, 50);
            this.lblTitle.Text = "QUẢN LÝ PHIẾU THU - CHI";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // SplitContainer
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 50);
            this.splitContainer.Name = "splitContainer";

            // Panel 1 (List)
            this.splitContainer.Panel1.Controls.Add(this.grpList);
            this.splitContainer.Panel1.Padding = new System.Windows.Forms.Padding(10);

            // Panel 2 (Detail)
            this.splitContainer.Panel2.Controls.Add(this.grpDetail);
            this.splitContainer.Panel2.Controls.Add(this.pnlButtons);
            this.splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer.Size = new System.Drawing.Size(1100, 600);
            this.splitContainer.SplitterDistance = 600;
            this.splitContainer.TabIndex = 1;

            // --- TRÁI ---
            this.grpList.Controls.Add(this.dgvDanhSach);
            this.grpList.Controls.Add(this.pnlSearch);
            this.grpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpList.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpList.Location = new System.Drawing.Point(10, 10);
            this.grpList.Name = "grpList";
            this.grpList.Size = new System.Drawing.Size(580, 580);
            this.grpList.TabIndex = 0;
            this.grpList.TabStop = false;
            this.grpList.Text = "Danh sách phiếu";

            // Search
            this.pnlSearch.Controls.Add(this.cboFilterLoai);
            this.pnlSearch.Controls.Add(this.lblFilter);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Height = 50;

            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFilter.Location = new System.Drawing.Point(15, 18);
            this.lblFilter.Text = "Lọc theo:";

            this.cboFilterLoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboFilterLoai.Location = new System.Drawing.Point(90, 15);
            this.cboFilterLoai.Size = new System.Drawing.Size(200, 25);
            this.cboFilterLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterLoai.Items.AddRange(new object[] { "Tất cả", "Phiếu Thu", "Phiếu Chi" });
            this.cboFilterLoai.SelectedIndexChanged += new System.EventHandler(this.cboFilterLoai_SelectedIndexChanged);

            // Grid
            this.dgvDanhSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSach.AllowUserToAddRows = false;
            this.dgvDanhSach.RowHeadersVisible = false;

            headerStyle.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvDanhSach.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvDanhSach.EnableHeadersVisualStyles = false;
            this.dgvDanhSach.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvDanhSach.Location = new System.Drawing.Point(3, 71);
            this.dgvDanhSach.Size = new System.Drawing.Size(574, 506);
            this.dgvDanhSach.SelectionChanged += new System.EventHandler(this.dgvDanhSach_SelectionChanged);

            // --- PHẢI ---
            this.grpDetail.Controls.Add(this.txtTkCo);
            this.grpDetail.Controls.Add(this.lblTkCo);
            this.grpDetail.Controls.Add(this.txtTkNo);
            this.grpDetail.Controls.Add(this.lblTkNo);
            this.grpDetail.Controls.Add(this.txtLyDo);
            this.grpDetail.Controls.Add(this.lblLyDo);
            this.grpDetail.Controls.Add(this.cboDoiTuong);
            this.grpDetail.Controls.Add(this.radNhaCungCap);
            this.grpDetail.Controls.Add(this.radKhachHang);
            this.grpDetail.Controls.Add(this.lblDoiTuong);
            this.grpDetail.Controls.Add(this.txtSoTien);
            this.grpDetail.Controls.Add(this.lblSoTien);
            this.grpDetail.Controls.Add(this.cboLoaiPhieu);
            this.grpDetail.Controls.Add(this.lblLoai);
            this.grpDetail.Controls.Add(this.dtpNgayLap);
            this.grpDetail.Controls.Add(this.lblNgay);
            this.grpDetail.Controls.Add(this.txtSoPhieu);
            this.grpDetail.Controls.Add(this.lblSoPhieu);
            this.grpDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDetail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDetail.Location = new System.Drawing.Point(10, 10);
            this.grpDetail.Name = "grpDetail";
            this.grpDetail.Size = new System.Drawing.Size(476, 510);
            this.grpDetail.TabIndex = 0;
            this.grpDetail.TabStop = false;
            this.grpDetail.Text = "Thông tin chi tiết";

            // --- TỌA ĐỘ CỨNG (SỬA LỖI Ở ĐÂY) ---

            // Dòng 1: Số phiếu | Ngày
            this.lblSoPhieu.AutoSize = true; this.lblSoPhieu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSoPhieu.Location = new System.Drawing.Point(20, 40); this.lblSoPhieu.Text = "Số Phiếu:";
            this.txtSoPhieu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSoPhieu.Location = new System.Drawing.Point(100, 37); this.txtSoPhieu.Size = new System.Drawing.Size(130, 25);

            this.lblNgay.AutoSize = true; this.lblNgay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNgay.Location = new System.Drawing.Point(250, 40); this.lblNgay.Text = "Ngày:";
            this.dtpNgayLap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpNgayLap.Location = new System.Drawing.Point(300, 37); this.dtpNgayLap.Size = new System.Drawing.Size(150, 25);
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // Dòng 2: Loại | Số tiền
            this.lblLoai.AutoSize = true; this.lblLoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLoai.Location = new System.Drawing.Point(20, 90); this.lblLoai.Text = "Loại:";
            this.cboLoaiPhieu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLoaiPhieu.Location = new System.Drawing.Point(100, 87); this.cboLoaiPhieu.Size = new System.Drawing.Size(130, 25);
            this.cboLoaiPhieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiPhieu.Items.AddRange(new object[] { "Phiếu Thu", "Phiếu Chi" });
            this.cboLoaiPhieu.SelectedIndexChanged += new System.EventHandler(this.cboLoaiPhieu_SelectedIndexChanged);

            this.lblSoTien.AutoSize = true; this.lblSoTien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSoTien.Location = new System.Drawing.Point(250, 90); this.lblSoTien.Text = "Số Tiền:";
            this.txtSoTien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtSoTien.Location = new System.Drawing.Point(320, 87); this.txtSoTien.Size = new System.Drawing.Size(130, 25);
            this.txtSoTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // Dòng 3: Đối tượng (Radio Buttons)
            this.lblDoiTuong.AutoSize = true; this.lblDoiTuong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDoiTuong.Location = new System.Drawing.Point(20, 140); this.lblDoiTuong.Text = "Đối tượng:";

            this.radKhachHang.AutoSize = true; this.radKhachHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radKhachHang.Location = new System.Drawing.Point(100, 138); this.radKhachHang.Text = "Khách hàng";
            this.radKhachHang.CheckedChanged += new System.EventHandler(this.radDoiTuong_CheckedChanged);

            this.radNhaCungCap.AutoSize = true; this.radNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radNhaCungCap.Location = new System.Drawing.Point(220, 138); this.radNhaCungCap.Text = "Nhà cung cấp";
            this.radNhaCungCap.CheckedChanged += new System.EventHandler(this.radDoiTuong_CheckedChanged);

            // Dòng 4: ComboBox Đối Tượng
            this.cboDoiTuong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboDoiTuong.Location = new System.Drawing.Point(100, 170); this.cboDoiTuong.Size = new System.Drawing.Size(350, 25);
            this.cboDoiTuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Dòng 5: Lý do
            this.lblLyDo.AutoSize = true; this.lblLyDo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLyDo.Location = new System.Drawing.Point(20, 220); this.lblLyDo.Text = "Lý do:";
            this.txtLyDo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLyDo.Location = new System.Drawing.Point(100, 217); this.txtLyDo.Size = new System.Drawing.Size(350, 60);
            this.txtLyDo.Multiline = true;

            // Dòng 6: Tài khoản (Nợ/Có)
            this.lblTkNo.AutoSize = true; this.lblTkNo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTkNo.Location = new System.Drawing.Point(20, 300); this.lblTkNo.Text = "TK Nợ:";
            this.txtTkNo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTkNo.Location = new System.Drawing.Point(100, 297); this.txtTkNo.Size = new System.Drawing.Size(100, 25);

            this.lblTkCo.AutoSize = true; this.lblTkCo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTkCo.Location = new System.Drawing.Point(250, 300); this.lblTkCo.Text = "TK Có:";
            this.txtTkCo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTkCo.Location = new System.Drawing.Point(320, 297); this.txtTkCo.Size = new System.Drawing.Size(100, 25);

            // Buttons Panel
            this.pnlButtons.Controls.Add(this.flowLayoutPanelBtn);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Height = 70;

            this.flowLayoutPanelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelBtn.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelBtn.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanelBtn.Controls.Add(this.btnThoat);
            this.flowLayoutPanelBtn.Controls.Add(this.btnHuy);
            this.flowLayoutPanelBtn.Controls.Add(this.btnLuu);
            this.flowLayoutPanelBtn.Controls.Add(this.btnXoa);
            this.flowLayoutPanelBtn.Controls.Add(this.btnSua);
            this.flowLayoutPanelBtn.Controls.Add(this.btnThem);

            // Buttons
            this.btnThoat.Text = "Thoát"; this.btnThoat.Size = new System.Drawing.Size(80, 40); this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnThoat.BackColor = System.Drawing.Color.Gray; this.btnThoat.ForeColor = System.Drawing.Color.White; this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            this.btnHuy.Text = "Hủy"; this.btnHuy.Size = new System.Drawing.Size(80, 40); this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnHuy.BackColor = System.Drawing.Color.OrangeRed; this.btnHuy.ForeColor = System.Drawing.Color.White; this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            this.btnLuu.Text = "Lưu"; this.btnLuu.Size = new System.Drawing.Size(80, 40); this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnLuu.BackColor = System.Drawing.Color.RoyalBlue; this.btnLuu.ForeColor = System.Drawing.Color.White; this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            this.btnXoa.Text = "Xóa"; this.btnXoa.Size = new System.Drawing.Size(80, 40); this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnXoa.BackColor = System.Drawing.Color.Crimson; this.btnXoa.ForeColor = System.Drawing.Color.White; this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            this.btnSua.Text = "Sửa"; this.btnSua.Size = new System.Drawing.Size(80, 40); this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnSua.BackColor = System.Drawing.Color.DeepSkyBlue; this.btnSua.ForeColor = System.Drawing.Color.White; this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            this.btnThem.Text = "Thêm"; this.btnThem.Size = new System.Drawing.Size(80, 40); this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnThem.BackColor = System.Drawing.Color.LimeGreen; this.btnThem.ForeColor = System.Drawing.Color.White; this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.pnlHeader.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.grpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.grpDetail.ResumeLayout(false);
            this.grpDetail.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.flowLayoutPanelBtn.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cboFilterLoai;
        private System.Windows.Forms.GroupBox grpDetail;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBtn;

        private System.Windows.Forms.TextBox txtSoPhieu, txtSoTien, txtLyDo, txtTkNo, txtTkCo;
        private System.Windows.Forms.Label lblSoPhieu, lblNgay, lblLoai, lblSoTien, lblLyDo, lblTkNo, lblTkCo, lblDoiTuong;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.ComboBox cboLoaiPhieu, cboDoiTuong;
        private System.Windows.Forms.RadioButton radKhachHang, radNhaCungCap;

        private System.Windows.Forms.Button btnThem, btnSua, btnXoa, btnLuu, btnHuy, btnThoat;
    }
}