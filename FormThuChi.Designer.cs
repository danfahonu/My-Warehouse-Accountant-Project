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

            // --- TRÁI ---
            this.grpList = new System.Windows.Forms.GroupBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.cboFilterLoai = new System.Windows.Forms.ComboBox(); // Lọc xem Thu hay Chi
            this.lblFilter = new System.Windows.Forms.Label();

            // --- PHẢI ---
            this.grpDetail = new System.Windows.Forms.GroupBox();

            // Dòng 1: Số phiếu & Ngày
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.lblSoPhieu = new System.Windows.Forms.Label();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.lblNgay = new System.Windows.Forms.Label();

            // Dòng 2: Loại phiếu & Số tiền
            this.cboLoaiPhieu = new System.Windows.Forms.ComboBox();
            this.lblLoai = new System.Windows.Forms.Label();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.lblSoTien = new System.Windows.Forms.Label();

            // Dòng 3: Chọn đối tượng (KH hay NCC)
            this.radKhachHang = new System.Windows.Forms.RadioButton();
            this.radNhaCungCap = new System.Windows.Forms.RadioButton();
            this.lblDoiTuong = new System.Windows.Forms.Label();
            this.cboDoiTuong = new System.Windows.Forms.ComboBox();

            // Dòng 4: Lý do
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.lblLyDo = new System.Windows.Forms.Label();

            // Dòng 5: Tài khoản kế toán
            this.txtTkNo = new System.Windows.Forms.TextBox();
            this.lblTkNo = new System.Windows.Forms.Label();
            this.txtTkCo = new System.Windows.Forms.TextBox();
            this.lblTkCo = new System.Windows.Forms.Label();

            // BUTTONS
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
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Name = "FormThuChi";
            this.Text = "Quản Lý Thu Chi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
            this.splitContainer.Panel1.Controls.Add(this.grpList);
            this.splitContainer.Panel1.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer.Panel2.Controls.Add(this.grpDetail);
            this.splitContainer.Panel2.Controls.Add(this.pnlButtons);
            this.splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer.Size = new System.Drawing.Size(1100, 550);
            this.splitContainer.SplitterDistance = 500;
            this.splitContainer.TabIndex = 1;

            // --- TRÁI ---
            this.grpList.Controls.Add(this.dgvDanhSach);
            this.grpList.Controls.Add(this.pnlSearch);
            this.grpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpList.Text = "Danh sách phiếu";

            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Height = 50;
            this.pnlSearch.Controls.Add(this.cboFilterLoai);
            this.pnlSearch.Controls.Add(this.lblFilter);

            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(10, 18);
            this.lblFilter.Text = "Lọc theo:";

            this.cboFilterLoai.Location = new System.Drawing.Point(80, 15);
            this.cboFilterLoai.Size = new System.Drawing.Size(200, 25);
            this.cboFilterLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterLoai.Items.AddRange(new object[] { "Tất cả", "Phiếu Thu", "Phiếu Chi" });
            this.cboFilterLoai.SelectedIndexChanged += new System.EventHandler(this.cboFilterLoai_SelectedIndexChanged);

            this.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.AllowUserToAddRows = false;
            this.dgvDanhSach.RowHeadersVisible = false;

            headerStyle.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvDanhSach.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvDanhSach.EnableHeadersVisualStyles = false;

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
            this.grpDetail.Text = "Thông tin chi tiết";

            // Layout Controls (Dùng số cứng)
            int x1 = 20; int x2 = 110; int x3 = 280; int x4 = 360;
            int y = 40; int gap = 45;

            // Dòng 1: Số Phiếu | Ngày
            this.lblSoPhieu.Location = new System.Drawing.Point(x1, y); this.lblSoPhieu.Text = "Số Phiếu:"; this.lblSoPhieu.AutoSize = true;
            this.txtSoPhieu.Location = new System.Drawing.Point(x2, y - 3); this.txtSoPhieu.Size = new System.Drawing.Size(150, 25);

            this.lblNgay.Location = new System.Drawing.Point(x3, y); this.lblNgay.Text = "Ngày:"; this.lblNgay.AutoSize = true;
            this.dtpNgayLap.Location = new System.Drawing.Point(x4, y - 3); this.dtpNgayLap.Size = new System.Drawing.Size(150, 25); this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // Dòng 2: Loại | Số Tiền
            y += gap;
            this.lblLoai.Location = new System.Drawing.Point(x1, y); this.lblLoai.Text = "Loại Phiếu:"; this.lblLoai.AutoSize = true;
            this.cboLoaiPhieu.Location = new System.Drawing.Point(x2, y - 3); this.cboLoaiPhieu.Size = new System.Drawing.Size(150, 25);
            this.cboLoaiPhieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiPhieu.Items.AddRange(new object[] { "Phiếu Thu", "Phiếu Chi" });
            this.cboLoaiPhieu.SelectedIndexChanged += new System.EventHandler(this.cboLoaiPhieu_SelectedIndexChanged);

            this.lblSoTien.Location = new System.Drawing.Point(x3, y); this.lblSoTien.Text = "Số Tiền:"; this.lblSoTien.AutoSize = true;
            this.txtSoTien.Location = new System.Drawing.Point(x4, y - 3); this.txtSoTien.Size = new System.Drawing.Size(150, 25);
            this.txtSoTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right; this.txtSoTien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            // Dòng 3: Chọn Đối Tượng
            y += gap;
            this.lblDoiTuong.Location = new System.Drawing.Point(x1, y); this.lblDoiTuong.Text = "Đối Tượng:"; this.lblDoiTuong.AutoSize = true;

            this.radKhachHang.Location = new System.Drawing.Point(x2, y); this.radKhachHang.Text = "Khách Hàng"; this.radKhachHang.AutoSize = true;
            this.radKhachHang.CheckedChanged += new System.EventHandler(this.radDoiTuong_CheckedChanged);

            this.radNhaCungCap.Location = new System.Drawing.Point(x2 + 110, y); this.radNhaCungCap.Text = "Nhà Cung Cấp"; this.radNhaCungCap.AutoSize = true;
            this.radNhaCungCap.CheckedChanged += new System.EventHandler(this.radDoiTuong_CheckedChanged);

            // Dòng 4: ComboBox Đối Tượng
            y += 35; // Nhích xuống chút
            this.cboDoiTuong.Location = new System.Drawing.Point(x2, y - 3); this.cboDoiTuong.Size = new System.Drawing.Size(400, 25);
            this.cboDoiTuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Dòng 5: Lý Do
            y += gap;
            this.lblLyDo.Location = new System.Drawing.Point(x1, y); this.lblLyDo.Text = "Lý Do:"; this.lblLyDo.AutoSize = true;
            this.txtLyDo.Location = new System.Drawing.Point(x2, y - 3); this.txtLyDo.Size = new System.Drawing.Size(400, 25);

            // Dòng 6: Tài khoản (Nợ/Có)
            y += gap;
            this.lblTkNo.Location = new System.Drawing.Point(x1, y); this.lblTkNo.Text = "TK Nợ:"; this.lblTkNo.AutoSize = true;
            this.txtTkNo.Location = new System.Drawing.Point(x2, y - 3); this.txtTkNo.Size = new System.Drawing.Size(100, 25);

            this.lblTkCo.Location = new System.Drawing.Point(x3, y); this.lblTkCo.Text = "TK Có:"; this.lblTkCo.AutoSize = true;
            this.txtTkCo.Location = new System.Drawing.Point(x4, y - 3); this.txtTkCo.Size = new System.Drawing.Size(100, 25);

            // BUTTONS
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Height = 70;
            this.pnlButtons.Controls.Add(this.flowLayoutPanelBtn);

            this.flowLayoutPanelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelBtn.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelBtn.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanelBtn.Controls.Add(this.btnThoat);
            this.flowLayoutPanelBtn.Controls.Add(this.btnHuy);
            this.flowLayoutPanelBtn.Controls.Add(this.btnLuu);
            this.flowLayoutPanelBtn.Controls.Add(this.btnXoa);
            this.flowLayoutPanelBtn.Controls.Add(this.btnSua);
            this.flowLayoutPanelBtn.Controls.Add(this.btnThem);

            // Style Nút
            this.btnThoat.Text = "Thoát"; this.btnThoat.Size = new System.Drawing.Size(90, 40); this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnThoat.BackColor = System.Drawing.Color.Gray; this.btnThoat.ForeColor = System.Drawing.Color.White; this.btnThoat.Margin = new System.Windows.Forms.Padding(5); this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            this.btnHuy.Text = "Hủy"; this.btnHuy.Size = new System.Drawing.Size(90, 40); this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnHuy.BackColor = System.Drawing.Color.Orange; this.btnHuy.ForeColor = System.Drawing.Color.White; this.btnHuy.Margin = new System.Windows.Forms.Padding(5); this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            this.btnLuu.Text = "Lưu"; this.btnLuu.Size = new System.Drawing.Size(90, 40); this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnLuu.BackColor = System.Drawing.Color.FromArgb(0, 122, 204); this.btnLuu.ForeColor = System.Drawing.Color.White; this.btnLuu.Margin = new System.Windows.Forms.Padding(5); this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            this.btnXoa.Text = "Xóa"; this.btnXoa.Size = new System.Drawing.Size(90, 40); this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnXoa.BackColor = System.Drawing.Color.FromArgb(220, 53, 69); this.btnXoa.ForeColor = System.Drawing.Color.White; this.btnXoa.Margin = new System.Windows.Forms.Padding(5); this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            this.btnSua.Text = "Sửa"; this.btnSua.Size = new System.Drawing.Size(90, 40); this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnSua.BackColor = System.Drawing.Color.Teal; this.btnSua.ForeColor = System.Drawing.Color.White; this.btnSua.Margin = new System.Windows.Forms.Padding(5); this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            this.btnThem.Text = "Thêm"; this.btnThem.Size = new System.Drawing.Size(90, 40); this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnThem.BackColor = System.Drawing.Color.ForestGreen; this.btnThem.ForeColor = System.Drawing.Color.White; this.btnThem.Margin = new System.Windows.Forms.Padding(5); this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

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