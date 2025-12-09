namespace DoAnLapTrinhQuanLy.GuiLayer
{
    partial class FormDanhMucHangHoa
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

            // Controls nhập liệu
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.lblMaHH = new System.Windows.Forms.Label();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.lblTenHH = new System.Windows.Forms.Label();
            this.cboNhomHang = new System.Windows.Forms.ComboBox();
            this.lblNhom = new System.Windows.Forms.Label();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.lblDVT = new System.Windows.Forms.Label();
            this.txtGiaVon = new System.Windows.Forms.TextBox();
            this.lblGiaVon = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.txtTonKho = new System.Windows.Forms.TextBox();
            this.lblTonKho = new System.Windows.Forms.Label();

            // Hình ảnh
            this.picHinhAnh = new System.Windows.Forms.PictureBox();
            this.btnChonHinh = new System.Windows.Forms.Button();
            this.btnXoaHinh = new System.Windows.Forms.Button();

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
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.flowLayoutPanelBtn.SuspendLayout();
            this.SuspendLayout();

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Name = "FormDanhMucHangHoa";
            this.Text = "Danh Mục Hàng Hóa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormDanhMucHangHoa_Load);

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
            this.lblTitle.Size = new System.Drawing.Size(1200, 50);
            this.lblTitle.Text = "QUẢN LÝ HÀNG HÓA";
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
            this.splitContainer.Size = new System.Drawing.Size(1200, 650);
            this.splitContainer.SplitterDistance = 500;
            this.splitContainer.TabIndex = 1;

            // --- TRÁI ---
            this.grpList.Controls.Add(this.dgvDanhSach);
            this.grpList.Controls.Add(this.pnlSearch);
            this.grpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpList.Text = "Danh sách hàng hóa";

            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Height = 50;
            this.pnlSearch.Controls.Add(this.txtTimKiem);
            this.pnlSearch.Controls.Add(this.lblTimKiem);

            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(10, 18);
            this.lblTimKiem.Text = "Tìm kiếm:";

            this.txtTimKiem.Location = new System.Drawing.Point(80, 15);
            this.txtTimKiem.Size = new System.Drawing.Size(350, 25);
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
            this.grpDetail.Controls.Add(this.btnXoaHinh);
            this.grpDetail.Controls.Add(this.btnChonHinh);
            this.grpDetail.Controls.Add(this.picHinhAnh);
            this.grpDetail.Controls.Add(this.txtTonKho);
            this.grpDetail.Controls.Add(this.lblTonKho);
            this.grpDetail.Controls.Add(this.cboNhomHang);
            this.grpDetail.Controls.Add(this.lblNhom);
            this.grpDetail.Controls.Add(this.txtGiaBan);
            this.grpDetail.Controls.Add(this.lblGiaBan);
            this.grpDetail.Controls.Add(this.txtGiaVon);
            this.grpDetail.Controls.Add(this.lblGiaVon);
            this.grpDetail.Controls.Add(this.txtDVT);
            this.grpDetail.Controls.Add(this.lblDVT);
            this.grpDetail.Controls.Add(this.txtTenHH);
            this.grpDetail.Controls.Add(this.lblTenHH);
            this.grpDetail.Controls.Add(this.txtMaHH);
            this.grpDetail.Controls.Add(this.lblMaHH);
            this.grpDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDetail.Text = "Thông tin chi tiết";

            // Sắp xếp control (Cột 1: Thông tin - Cột 2: Hình ảnh)
            // (Dùng số cứng, không dùng biến để tránh lỗi Designer)

            // Mã HH
            this.lblMaHH.Location = new System.Drawing.Point(20, 40); this.lblMaHH.Text = "Mã Hàng:"; this.lblMaHH.AutoSize = true;
            this.txtMaHH.Location = new System.Drawing.Point(110, 37); this.txtMaHH.Size = new System.Drawing.Size(150, 25);

            // Tên HH
            this.lblTenHH.Location = new System.Drawing.Point(20, 85); this.lblTenHH.Text = "Tên Hàng:"; this.lblTenHH.AutoSize = true;
            this.txtTenHH.Location = new System.Drawing.Point(110, 82); this.txtTenHH.Size = new System.Drawing.Size(400, 25);

            // Nhóm
            this.lblNhom.Location = new System.Drawing.Point(20, 130); this.lblNhom.Text = "Nhóm:"; this.lblNhom.AutoSize = true;
            this.cboNhomHang.Location = new System.Drawing.Point(110, 127); this.cboNhomHang.Size = new System.Drawing.Size(300, 25); this.cboNhomHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // ĐVT
            this.lblDVT.Location = new System.Drawing.Point(20, 175); this.lblDVT.Text = "ĐVT:"; this.lblDVT.AutoSize = true;
            this.txtDVT.Location = new System.Drawing.Point(110, 172); this.txtDVT.Size = new System.Drawing.Size(150, 25);

            // Giá Vốn
            this.lblGiaVon.Location = new System.Drawing.Point(20, 220); this.lblGiaVon.Text = "Giá Vốn:"; this.lblGiaVon.AutoSize = true;
            this.txtGiaVon.Location = new System.Drawing.Point(110, 217); this.txtGiaVon.Size = new System.Drawing.Size(150, 25); this.txtGiaVon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // Giá Bán
            this.lblGiaBan.Location = new System.Drawing.Point(20, 265); this.lblGiaBan.Text = "Giá Bán:"; this.lblGiaBan.AutoSize = true;
            this.txtGiaBan.Location = new System.Drawing.Point(110, 262); this.txtGiaBan.Size = new System.Drawing.Size(150, 25); this.txtGiaBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // Tồn Kho (Readonly)
            this.lblTonKho.Location = new System.Drawing.Point(20, 310); this.lblTonKho.Text = "Tồn Kho:"; this.lblTonKho.AutoSize = true; this.lblTonKho.ForeColor = System.Drawing.Color.Red;
            this.txtTonKho.Location = new System.Drawing.Point(110, 307); this.txtTonKho.Size = new System.Drawing.Size(100, 25);
            this.txtTonKho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center; this.txtTonKho.ReadOnly = true; this.txtTonKho.BackColor = System.Drawing.Color.LightYellow;

            // Hình Ảnh (Bên phải)
            this.picHinhAnh.Location = new System.Drawing.Point(400, 127);
            this.picHinhAnh.Size = new System.Drawing.Size(200, 200);
            this.picHinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHinhAnh.BackColor = System.Drawing.Color.White;

            // Nút Chọn Hình
            this.btnChonHinh.Text = "Chọn hình...";
            this.btnChonHinh.Location = new System.Drawing.Point(400, 340);
            this.btnChonHinh.Size = new System.Drawing.Size(95, 30);
            this.btnChonHinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonHinh.Click += new System.EventHandler(this.btnChonHinh_Click);

            // Nút Xóa Hình
            this.btnXoaHinh.Text = "Xóa hình";
            this.btnXoaHinh.Location = new System.Drawing.Point(505, 340);
            this.btnXoaHinh.Size = new System.Drawing.Size(95, 30);
            this.btnXoaHinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaHinh.Click += new System.EventHandler(this.btnXoaHinh_Click);

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

            // --- NÚT BẤM ---
            this.btnThoat.Text = "Thoát"; this.btnThoat.Size = new System.Drawing.Size(90, 40);
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnThoat.BackColor = System.Drawing.Color.Gray; this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Margin = new System.Windows.Forms.Padding(5); this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            this.btnHuy.Text = "Hủy"; this.btnHuy.Size = new System.Drawing.Size(90, 40);
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnHuy.BackColor = System.Drawing.Color.Orange; this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Margin = new System.Windows.Forms.Padding(5); this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);

            this.btnLuu.Text = "Lưu"; this.btnLuu.Size = new System.Drawing.Size(90, 40);
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnLuu.BackColor = System.Drawing.Color.FromArgb(0, 122, 204); this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Margin = new System.Windows.Forms.Padding(5); this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);

            this.btnXoa.Text = "Xóa"; this.btnXoa.Size = new System.Drawing.Size(90, 40);
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnXoa.BackColor = System.Drawing.Color.FromArgb(220, 53, 69); this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Margin = new System.Windows.Forms.Padding(5); this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.btnSua.Text = "Sửa"; this.btnSua.Size = new System.Drawing.Size(90, 40);
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnSua.BackColor = System.Drawing.Color.Teal; this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Margin = new System.Windows.Forms.Padding(5); this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

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
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).EndInit();
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

        private System.Windows.Forms.TextBox txtGiaBan, txtGiaVon, txtDVT, txtTenHH, txtMaHH, txtTonKho;
        private System.Windows.Forms.Label lblGiaBan, lblGiaVon, lblDVT, lblTenHH, lblMaHH, lblNhom, lblTonKho;
        private System.Windows.Forms.ComboBox cboNhomHang;

        private System.Windows.Forms.PictureBox picHinhAnh;
        private System.Windows.Forms.Button btnChonHinh, btnXoaHinh;
        private System.Windows.Forms.Button btnThem, btnSua, btnXoa, btnLuu, btnHuy, btnThoat;
    }
}