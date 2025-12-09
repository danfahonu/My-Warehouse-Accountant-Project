namespace DoAnLapTrinhQuanLy.GuiLayer
{
    partial class FormNhaCungCap
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
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();

            // --- PHẢI ---
            this.grpDetail = new System.Windows.Forms.GroupBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.lblTenNCC = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.lblMaNCC = new System.Windows.Forms.Label();

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
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Name = "FormNhaCungCap";
            this.Text = "Danh Mục Nhà Cung Cấp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormNhaCungCap_Load);

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
            this.lblTitle.Size = new System.Drawing.Size(1000, 50);
            this.lblTitle.Text = "QUẢN LÝ NHÀ CUNG CẤP";
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
            this.splitContainer.Size = new System.Drawing.Size(1000, 550);
            this.splitContainer.SplitterDistance = 450;
            this.splitContainer.TabIndex = 1;

            // --- TRÁI ---
            this.grpList.Controls.Add(this.dgvDanhSach);
            this.grpList.Controls.Add(this.pnlSearch);
            this.grpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpList.Text = "Danh sách nhà cung cấp";

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

            // --- PHẢI ---
            this.grpDetail.Controls.Add(this.txtDiaChi);
            this.grpDetail.Controls.Add(this.lblDiaChi);
            this.grpDetail.Controls.Add(this.txtSDT);
            this.grpDetail.Controls.Add(this.lblSDT);
            this.grpDetail.Controls.Add(this.txtTenNCC);
            this.grpDetail.Controls.Add(this.lblTenNCC);
            this.grpDetail.Controls.Add(this.txtMaNCC);
            this.grpDetail.Controls.Add(this.lblMaNCC);
            this.grpDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDetail.Text = "Thông tin chi tiết";

            int y = 40; int gap = 50;
            this.lblMaNCC.Location = new System.Drawing.Point(20, y); this.lblMaNCC.Text = "Mã NCC:"; this.lblMaNCC.AutoSize = true;
            this.txtMaNCC.Location = new System.Drawing.Point(100, y - 3); this.txtMaNCC.Size = new System.Drawing.Size(150, 25);

            y += gap;
            this.lblTenNCC.Location = new System.Drawing.Point(20, y); this.lblTenNCC.Text = "Tên NCC:"; this.lblTenNCC.AutoSize = true;
            this.txtTenNCC.Location = new System.Drawing.Point(100, y - 3); this.txtTenNCC.Size = new System.Drawing.Size(400, 25);

            y += gap;
            this.lblSDT.Location = new System.Drawing.Point(20, y); this.lblSDT.Text = "Điện thoại:"; this.lblSDT.AutoSize = true;
            this.txtSDT.Location = new System.Drawing.Point(100, y - 3); this.txtSDT.Size = new System.Drawing.Size(200, 25);

            y += gap;
            this.lblDiaChi.Location = new System.Drawing.Point(20, y); this.lblDiaChi.Text = "Địa chỉ:"; this.lblDiaChi.AutoSize = true;
            this.txtDiaChi.Location = new System.Drawing.Point(100, y - 3); this.txtDiaChi.Size = new System.Drawing.Size(400, 25);

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

            // --- NÚT BẤM (CẤU HÌNH CHI TIẾT) ---

            // btnThoat
            this.btnThoat.Text = "Thoát"; this.btnThoat.Size = new System.Drawing.Size(90, 40);
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnThoat.BackColor = System.Drawing.Color.Gray; this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Margin = new System.Windows.Forms.Padding(5); this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            // btnHuy
            this.btnHuy.Text = "Hủy"; this.btnHuy.Size = new System.Drawing.Size(90, 40);
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnHuy.BackColor = System.Drawing.Color.Orange; this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Margin = new System.Windows.Forms.Padding(5); this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);

            // btnLuu
            this.btnLuu.Text = "Lưu"; this.btnLuu.Size = new System.Drawing.Size(90, 40);
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnLuu.BackColor = System.Drawing.Color.FromArgb(0, 122, 204); this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Margin = new System.Windows.Forms.Padding(5); this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);

            // btnXoa
            this.btnXoa.Text = "Xóa"; this.btnXoa.Size = new System.Drawing.Size(90, 40);
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnXoa.BackColor = System.Drawing.Color.FromArgb(220, 53, 69); this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Margin = new System.Windows.Forms.Padding(5); this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // btnSua
            this.btnSua.Text = "Sửa"; this.btnSua.Size = new System.Drawing.Size(90, 40);
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnSua.BackColor = System.Drawing.Color.Teal; this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Margin = new System.Windows.Forms.Padding(5); this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // btnThem
            this.btnThem.Text = "Thêm"; this.btnThem.Size = new System.Drawing.Size(90, 40);
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnThem.BackColor = System.Drawing.Color.ForestGreen; this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Margin = new System.Windows.Forms.Padding(5); this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

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
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.GroupBox grpDetail;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBtn;

        private System.Windows.Forms.TextBox txtDiaChi, txtSDT, txtTenNCC, txtMaNCC;
        private System.Windows.Forms.Label lblDiaChi, lblSDT, lblTenNCC, lblMaNCC;

        private System.Windows.Forms.Button btnThem, btnSua, btnXoa, btnLuu, btnHuy, btnThoat;
    }
}