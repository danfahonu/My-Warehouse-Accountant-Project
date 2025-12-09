namespace DoAnLapTrinhQuanLy.GuiLayer
{
    partial class FormNhanVien
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

            // --- LEFT ---
            this.grpList = new System.Windows.Forms.GroupBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();

            // --- RIGHT ---
            this.grpDetail = new System.Windows.Forms.GroupBox();

            // Controls Detail
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();

            // Thay TextBox bằng ComboBox Chức Vụ
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.lblChucVu = new System.Windows.Forms.Label();

            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();

            // Hình ảnh
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.btnChonHinh = new System.Windows.Forms.Button();
            this.btnXoaHinh = new System.Windows.Forms.Button();

            // Buttons
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
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
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
            this.Name = "FormNhanVien";
            this.Text = "Danh Mục Nhân Viên";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormNhanVien_Load);

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
            this.lblTitle.Text = "QUẢN LÝ NHÂN VIÊN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // SplitContainer
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 50);
            this.splitContainer.Name = "splitContainer";
            // Panel 1
            this.splitContainer.Panel1.Controls.Add(this.grpList);
            this.splitContainer.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // Panel 2
            this.splitContainer.Panel2.Controls.Add(this.grpDetail);
            this.splitContainer.Panel2.Controls.Add(this.pnlButtons);
            this.splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer.Size = new System.Drawing.Size(1100, 550);
            this.splitContainer.SplitterDistance = 450;
            this.splitContainer.TabIndex = 1;

            // Left
            this.grpList.Controls.Add(this.dgvDanhSach);
            this.grpList.Controls.Add(this.pnlSearch);
            this.grpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpList.Text = "Danh sách nhân viên";

            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Height = 50;
            this.pnlSearch.Controls.Add(this.txtTimKiem);
            this.pnlSearch.Controls.Add(this.lblTimKiem);

            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(10, 18);
            this.lblTimKiem.Text = "Tìm kiếm:";

            this.txtTimKiem.Location = new System.Drawing.Point(80, 15);
            this.txtTimKiem.Size = new System.Drawing.Size(320, 25);
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);

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

            // Right: Detail
            this.grpDetail.Controls.Add(this.btnXoaHinh);
            this.grpDetail.Controls.Add(this.btnChonHinh);
            this.grpDetail.Controls.Add(this.picAvatar);
            this.grpDetail.Controls.Add(this.txtDiaChi);
            this.grpDetail.Controls.Add(this.lblDiaChi);
            this.grpDetail.Controls.Add(this.txtEmail);
            this.grpDetail.Controls.Add(this.lblEmail);
            this.grpDetail.Controls.Add(this.txtSDT);
            this.grpDetail.Controls.Add(this.lblSDT);
            this.grpDetail.Controls.Add(this.cboChucVu); // ComboBox
            this.grpDetail.Controls.Add(this.lblChucVu);
            this.grpDetail.Controls.Add(this.txtHoTen);
            this.grpDetail.Controls.Add(this.lblHoTen);
            this.grpDetail.Controls.Add(this.txtMaNV);
            this.grpDetail.Controls.Add(this.lblMaNV);
            this.grpDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDetail.Text = "Thông tin chi tiết";

            // --- TỌA ĐỘ CỨNG ---

            // Mã NV (y=40)
            this.lblMaNV.Location = new System.Drawing.Point(20, 40); this.lblMaNV.Text = "Mã NV:"; this.lblMaNV.AutoSize = true;
            this.txtMaNV.Location = new System.Drawing.Point(110, 37); this.txtMaNV.Size = new System.Drawing.Size(150, 25);

            // Họ Tên (y=85)
            this.lblHoTen.Location = new System.Drawing.Point(20, 85); this.lblHoTen.Text = "Họ Tên:"; this.lblHoTen.AutoSize = true;
            this.txtHoTen.Location = new System.Drawing.Point(110, 82); this.txtHoTen.Size = new System.Drawing.Size(250, 25);

            // Chức vụ (y=130) - ComboBox
            this.lblChucVu.Location = new System.Drawing.Point(20, 130); this.lblChucVu.Text = "Chức vụ:"; this.lblChucVu.AutoSize = true;
            this.cboChucVu.Location = new System.Drawing.Point(110, 127); this.cboChucVu.Size = new System.Drawing.Size(250, 25);
            this.cboChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; // Chỉ cho chọn

            // SĐT (y=175)
            this.lblSDT.Location = new System.Drawing.Point(20, 175); this.lblSDT.Text = "Điện thoại:"; this.lblSDT.AutoSize = true;
            this.txtSDT.Location = new System.Drawing.Point(110, 172); this.txtSDT.Size = new System.Drawing.Size(250, 25);

            // Email (y=220)
            this.lblEmail.Location = new System.Drawing.Point(20, 220); this.lblEmail.Text = "Email:"; this.lblEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(110, 217); this.txtEmail.Size = new System.Drawing.Size(250, 25);

            // Địa chỉ (y=265)
            this.lblDiaChi.Location = new System.Drawing.Point(20, 265); this.lblDiaChi.Text = "Địa chỉ:"; this.lblDiaChi.AutoSize = true;
            this.txtDiaChi.Location = new System.Drawing.Point(110, 262); this.txtDiaChi.Size = new System.Drawing.Size(480, 25);

            // Ảnh (y=37, x=400)
            this.picAvatar.Location = new System.Drawing.Point(400, 37);
            this.picAvatar.Size = new System.Drawing.Size(150, 150);
            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.btnChonHinh.Text = "Chọn...";
            this.btnChonHinh.Location = new System.Drawing.Point(400, 195);
            this.btnChonHinh.Size = new System.Drawing.Size(70, 30);
            this.btnChonHinh.Click += new System.EventHandler(this.btnChonHinh_Click);

            this.btnXoaHinh.Text = "Xóa";
            this.btnXoaHinh.Location = new System.Drawing.Point(480, 195);
            this.btnXoaHinh.Size = new System.Drawing.Size(70, 30);
            this.btnXoaHinh.Click += new System.EventHandler(this.btnXoaHinh_Click);

            // Buttons
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
            this.btnThoat.Text = "Thoát"; this.btnThoat.Size = new System.Drawing.Size(80, 40); this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnThoat.BackColor = System.Drawing.Color.Gray; this.btnThoat.ForeColor = System.Drawing.Color.White; this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            this.btnHuy.Text = "Hủy"; this.btnHuy.Size = new System.Drawing.Size(80, 40); this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnHuy.BackColor = System.Drawing.Color.Orange; this.btnHuy.ForeColor = System.Drawing.Color.White; this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
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
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.GroupBox grpDetail;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBtn;

        private System.Windows.Forms.TextBox txtMaNV, txtHoTen, txtSDT, txtEmail, txtDiaChi;
        private System.Windows.Forms.Label lblMaNV, lblHoTen, lblSDT, lblChucVu, lblEmail, lblDiaChi;
        private System.Windows.Forms.ComboBox cboChucVu; // ĐÃ ĐỔI

        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Button btnChonHinh, btnXoaHinh;
        private System.Windows.Forms.Button btnThem, btnSua, btnXoa, btnLuu, btnHuy, btnThoat;
    }
}