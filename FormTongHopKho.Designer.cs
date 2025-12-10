namespace DoAnLapTrinhQuanLy.GuiLayer
{
    partial class FormTongHopKho
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
            this.tabControl = new System.Windows.Forms.TabControl();

            // --- TAB 1: TỔNG HỢP TỒN ---
            this.tabTongHop = new System.Windows.Forms.TabPage();
            this.dgvTongHop = new System.Windows.Forms.DataGridView();
            this.pnlFilterTH = new System.Windows.Forms.Panel();
            this.btnInTH = new System.Windows.Forms.Button();
            this.btnXemTH = new System.Windows.Forms.Button();
            this.cboNhomHang = new System.Windows.Forms.ComboBox();
            this.lblNhomHang = new System.Windows.Forms.Label();
            this.dtpDenTH = new System.Windows.Forms.DateTimePicker();
            this.lblDenTH = new System.Windows.Forms.Label();
            this.dtpTuTH = new System.Windows.Forms.DateTimePicker();
            this.lblTuTH = new System.Windows.Forms.Label();
            this.pnlFooterTH = new System.Windows.Forms.Panel();
            this.lblTongGiaTri = new System.Windows.Forms.Label();

            // --- TAB 2: BẢNG KÊ NHẬP XUẤT ---
            this.tabChiTiet = new System.Windows.Forms.TabPage();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.pnlFilterCT = new System.Windows.Forms.Panel();
            this.btnXemCT = new System.Windows.Forms.Button();
            this.cboLoaiPhieu = new System.Windows.Forms.ComboBox();
            this.lblLoai = new System.Windows.Forms.Label();
            this.dtpDenCT = new System.Windows.Forms.DateTimePicker();
            this.lblDenCT = new System.Windows.Forms.Label();
            this.dtpTuCT = new System.Windows.Forms.DateTimePicker();
            this.lblTuCT = new System.Windows.Forms.Label();

            // --- TAB 3: THẺ KHO ---
            this.tabTheKho = new System.Windows.Forms.TabPage();
            this.dgvTheKho = new System.Windows.Forms.DataGridView();
            this.pnlFilterTK = new System.Windows.Forms.Panel();
            this.btnXemTK = new System.Windows.Forms.Button();
            this.cboHangHoa = new System.Windows.Forms.ComboBox();
            this.lblHangHoa = new System.Windows.Forms.Label();
            this.dtpDenTK = new System.Windows.Forms.DateTimePicker();
            this.lblDenTK = new System.Windows.Forms.Label();
            this.dtpTuTK = new System.Windows.Forms.DateTimePicker();
            this.lblTuTK = new System.Windows.Forms.Label();

            this.pnlHeader.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabTongHop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongHop)).BeginInit();
            this.pnlFilterTH.SuspendLayout();
            this.pnlFooterTH.SuspendLayout();
            this.tabChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.pnlFilterCT.SuspendLayout();
            this.tabTheKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheKho)).BeginInit();
            this.pnlFilterTK.SuspendLayout();
            this.SuspendLayout();

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Name = "FormTongHopKho"; // <-- ĐÃ ĐỔI TÊN Ở ĐÂY
            this.Text = "Tổng Hợp Số Liệu Kho";
            this.Load += new System.EventHandler(this.FormTongHopKho_Load);

            // Header
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 50;

            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1100, 50);
            this.lblTitle.Text = "TỔNG HỢP SỐ LIỆU KHO";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // TabControl
            this.tabControl.Controls.Add(this.tabTongHop);
            this.tabControl.Controls.Add(this.tabChiTiet);
            this.tabControl.Controls.Add(this.tabTheKho);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 50);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1100, 600);
            this.tabControl.ItemSize = new System.Drawing.Size(150, 30);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;

            // ================== TAB 1 ==================
            this.tabTongHop.Controls.Add(this.dgvTongHop);
            this.tabTongHop.Controls.Add(this.pnlFooterTH);
            this.tabTongHop.Controls.Add(this.pnlFilterTH);
            this.tabTongHop.Location = new System.Drawing.Point(4, 34);
            this.tabTongHop.Name = "tabTongHop";
            this.tabTongHop.Padding = new System.Windows.Forms.Padding(3);
            this.tabTongHop.Text = "Tổng Hợp Nhập Xuất Tồn";
            this.tabTongHop.UseVisualStyleBackColor = true;

            // Filter TH (Dùng số cứng)
            this.pnlFilterTH.Dock = System.Windows.Forms.DockStyle.Top; this.pnlFilterTH.Height = 60;
            this.pnlFilterTH.BackColor = System.Drawing.Color.WhiteSmoke;

            this.lblTuTH.Location = new System.Drawing.Point(20, 20); this.lblTuTH.Text = "Từ ngày:"; this.lblTuTH.AutoSize = true;
            this.dtpTuTH.Format = System.Windows.Forms.DateTimePickerFormat.Short; this.dtpTuTH.Location = new System.Drawing.Point(80, 17); this.dtpTuTH.Size = new System.Drawing.Size(110, 25);

            this.lblDenTH.Location = new System.Drawing.Point(200, 20); this.lblDenTH.Text = "Đến ngày:"; this.lblDenTH.AutoSize = true;
            this.dtpDenTH.Format = System.Windows.Forms.DateTimePickerFormat.Short; this.dtpDenTH.Location = new System.Drawing.Point(270, 17); this.dtpDenTH.Size = new System.Drawing.Size(110, 25);

            this.lblNhomHang.Location = new System.Drawing.Point(400, 20); this.lblNhomHang.Text = "Nhóm:"; this.lblNhomHang.AutoSize = true;
            this.cboNhomHang.Location = new System.Drawing.Point(450, 17); this.cboNhomHang.Size = new System.Drawing.Size(180, 25);
            this.cboNhomHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.btnXemTH.Text = "Xem Báo Cáo"; this.btnXemTH.Location = new System.Drawing.Point(650, 15); this.btnXemTH.Size = new System.Drawing.Size(120, 30);
            this.btnXemTH.BackColor = System.Drawing.Color.RoyalBlue; this.btnXemTH.ForeColor = System.Drawing.Color.White; this.btnXemTH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemTH.Click += new System.EventHandler(this.btnXemTH_Click);

            this.btnInTH.Text = "Xuất Excel"; this.btnInTH.Location = new System.Drawing.Point(780, 15); this.btnInTH.Size = new System.Drawing.Size(100, 30);
            this.btnInTH.BackColor = System.Drawing.Color.ForestGreen; this.btnInTH.ForeColor = System.Drawing.Color.White; this.btnInTH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInTH.Click += new System.EventHandler(this.btnInTH_Click);

            this.pnlFilterTH.Controls.Add(this.lblTuTH); this.pnlFilterTH.Controls.Add(this.dtpTuTH);
            this.pnlFilterTH.Controls.Add(this.lblDenTH); this.pnlFilterTH.Controls.Add(this.dtpDenTH);
            this.pnlFilterTH.Controls.Add(this.lblNhomHang); this.pnlFilterTH.Controls.Add(this.cboNhomHang);
            this.pnlFilterTH.Controls.Add(this.btnXemTH); this.pnlFilterTH.Controls.Add(this.btnInTH);

            // Grid TH
            this.dgvTongHop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTongHop.BackgroundColor = System.Drawing.Color.White;
            this.dgvTongHop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTongHop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTongHop.ReadOnly = true;
            this.dgvTongHop.RowHeadersVisible = false;

            // Footer TH
            this.pnlFooterTH.Dock = System.Windows.Forms.DockStyle.Bottom; this.pnlFooterTH.Height = 40; this.pnlFooterTH.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTongGiaTri.Dock = System.Windows.Forms.DockStyle.Right; this.lblTongGiaTri.Size = new System.Drawing.Size(400, 40);
            this.lblTongGiaTri.TextAlign = System.Drawing.ContentAlignment.MiddleRight; this.lblTongGiaTri.ForeColor = System.Drawing.Color.Red;
            this.lblTongGiaTri.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTongGiaTri.Text = "Tổng Giá Trị Tồn: 0 đ   ";

            // ================== TAB 2 ==================
            this.tabChiTiet.Controls.Add(this.dgvChiTiet);
            this.tabChiTiet.Controls.Add(this.pnlFilterCT);
            this.tabChiTiet.Location = new System.Drawing.Point(4, 34);
            this.tabChiTiet.Name = "tabChiTiet";
            this.tabChiTiet.Padding = new System.Windows.Forms.Padding(3);
            this.tabChiTiet.Text = "Bảng Kê Chi Tiết";
            this.tabChiTiet.UseVisualStyleBackColor = true;

            // Filter CT
            this.pnlFilterCT.Dock = System.Windows.Forms.DockStyle.Top; this.pnlFilterCT.Height = 60;
            this.pnlFilterCT.BackColor = System.Drawing.Color.WhiteSmoke;

            this.lblTuCT.Location = new System.Drawing.Point(20, 20); this.lblTuCT.Text = "Từ ngày:"; this.lblTuCT.AutoSize = true;
            this.dtpTuCT.Format = System.Windows.Forms.DateTimePickerFormat.Short; this.dtpTuCT.Location = new System.Drawing.Point(80, 17); this.dtpTuCT.Size = new System.Drawing.Size(110, 25);

            this.lblDenCT.Location = new System.Drawing.Point(200, 20); this.lblDenCT.Text = "Đến ngày:"; this.lblDenCT.AutoSize = true;
            this.dtpDenCT.Format = System.Windows.Forms.DateTimePickerFormat.Short; this.dtpDenCT.Location = new System.Drawing.Point(270, 17); this.dtpDenCT.Size = new System.Drawing.Size(110, 25);

            this.lblLoai.Location = new System.Drawing.Point(400, 20); this.lblLoai.Text = "Loại phiếu:"; this.lblLoai.AutoSize = true;
            this.cboLoaiPhieu.Location = new System.Drawing.Point(480, 17); this.cboLoaiPhieu.Size = new System.Drawing.Size(150, 25);
            this.cboLoaiPhieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiPhieu.Items.AddRange(new object[] { "Tất cả", "Phiếu Nhập", "Phiếu Xuất" });

            this.btnXemCT.Text = "Xem Dữ Liệu"; this.btnXemCT.Location = new System.Drawing.Point(650, 15); this.btnXemCT.Size = new System.Drawing.Size(120, 30);
            this.btnXemCT.BackColor = System.Drawing.Color.DarkOrange; this.btnXemCT.ForeColor = System.Drawing.Color.White; this.btnXemCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemCT.Click += new System.EventHandler(this.btnXemCT_Click);

            this.pnlFilterCT.Controls.Add(this.lblTuCT); this.pnlFilterCT.Controls.Add(this.dtpTuCT);
            this.pnlFilterCT.Controls.Add(this.lblDenCT); this.pnlFilterCT.Controls.Add(this.dtpDenCT);
            this.pnlFilterCT.Controls.Add(this.lblLoai); this.pnlFilterCT.Controls.Add(this.cboLoaiPhieu);
            this.pnlFilterCT.Controls.Add(this.btnXemCT);

            // Grid CT
            this.dgvChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTiet.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTiet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTiet.ReadOnly = true;
            this.dgvChiTiet.RowHeadersVisible = false;

            // ================== TAB 3 ==================
            this.tabTheKho.Controls.Add(this.dgvTheKho);
            this.tabTheKho.Controls.Add(this.pnlFilterTK);
            this.tabTheKho.Location = new System.Drawing.Point(4, 34);
            this.tabTheKho.Name = "tabTheKho";
            this.tabTheKho.Padding = new System.Windows.Forms.Padding(3);
            this.tabTheKho.Text = "Thẻ Kho / Sổ Chi Tiết";
            this.tabTheKho.UseVisualStyleBackColor = true;

            // Filter TK
            this.pnlFilterTK.Dock = System.Windows.Forms.DockStyle.Top; this.pnlFilterTK.Height = 60;
            this.pnlFilterTK.BackColor = System.Drawing.Color.WhiteSmoke;

            this.lblHangHoa.Location = new System.Drawing.Point(20, 20); this.lblHangHoa.Text = "Chọn Hàng:"; this.lblHangHoa.AutoSize = true;
            this.cboHangHoa.Location = new System.Drawing.Point(100, 17); this.cboHangHoa.Size = new System.Drawing.Size(250, 25);
            this.cboHangHoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.lblTuTK.Location = new System.Drawing.Point(370, 20); this.lblTuTK.Text = "Từ:"; this.lblTuTK.AutoSize = true;
            this.dtpTuTK.Format = System.Windows.Forms.DateTimePickerFormat.Short; this.dtpTuTK.Location = new System.Drawing.Point(400, 17); this.dtpTuTK.Size = new System.Drawing.Size(100, 25);

            this.lblDenTK.Location = new System.Drawing.Point(520, 20); this.lblDenTK.Text = "Đến:"; this.lblDenTK.AutoSize = true;
            this.dtpDenTK.Format = System.Windows.Forms.DateTimePickerFormat.Short; this.dtpDenTK.Location = new System.Drawing.Point(555, 17); this.dtpDenTK.Size = new System.Drawing.Size(100, 25);

            this.btnXemTK.Text = "Xem Thẻ Kho"; this.btnXemTK.Location = new System.Drawing.Point(680, 15); this.btnXemTK.Size = new System.Drawing.Size(120, 30);
            this.btnXemTK.BackColor = System.Drawing.Color.SeaGreen; this.btnXemTK.ForeColor = System.Drawing.Color.White; this.btnXemTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemTK.Click += new System.EventHandler(this.btnXemTK_Click);

            this.pnlFilterTK.Controls.Add(this.lblHangHoa); this.pnlFilterTK.Controls.Add(this.cboHangHoa);
            this.pnlFilterTK.Controls.Add(this.lblTuTK); this.pnlFilterTK.Controls.Add(this.dtpTuTK);
            this.pnlFilterTK.Controls.Add(this.lblDenTK); this.pnlFilterTK.Controls.Add(this.dtpDenTK);
            this.pnlFilterTK.Controls.Add(this.btnXemTK);

            // Grid TK
            this.dgvTheKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTheKho.BackgroundColor = System.Drawing.Color.White;
            this.dgvTheKho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTheKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTheKho.ReadOnly = true;
            this.dgvTheKho.RowHeadersVisible = false;

            this.pnlHeader.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabTongHop.ResumeLayout(false); ((System.ComponentModel.ISupportInitialize)(this.dgvTongHop)).EndInit(); this.pnlFilterTH.ResumeLayout(false); this.pnlFilterTH.PerformLayout(); this.pnlFooterTH.ResumeLayout(false);
            this.tabChiTiet.ResumeLayout(false); ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit(); this.pnlFilterCT.ResumeLayout(false); this.pnlFilterCT.PerformLayout();
            this.tabTheKho.ResumeLayout(false); ((System.ComponentModel.ISupportInitialize)(this.dgvTheKho)).EndInit(); this.pnlFilterTK.ResumeLayout(false); this.pnlFilterTK.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader; private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabControl;

        private System.Windows.Forms.TabPage tabTongHop;
        private System.Windows.Forms.DataGridView dgvTongHop;
        private System.Windows.Forms.Panel pnlFilterTH;
        private System.Windows.Forms.Button btnXemTH, btnInTH;
        private System.Windows.Forms.DateTimePicker dtpTuTH, dtpDenTH;
        private System.Windows.Forms.ComboBox cboNhomHang;
        private System.Windows.Forms.Label lblTuTH, lblDenTH, lblNhomHang;
        private System.Windows.Forms.Panel pnlFooterTH;
        private System.Windows.Forms.Label lblTongGiaTri;

        private System.Windows.Forms.TabPage tabChiTiet;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.Panel pnlFilterCT;
        private System.Windows.Forms.Button btnXemCT;
        private System.Windows.Forms.ComboBox cboLoaiPhieu;
        private System.Windows.Forms.DateTimePicker dtpTuCT, dtpDenCT;
        private System.Windows.Forms.Label lblTuCT, lblDenCT, lblLoai;

        private System.Windows.Forms.TabPage tabTheKho;
        private System.Windows.Forms.DataGridView dgvTheKho;
        private System.Windows.Forms.Panel pnlFilterTK;
        private System.Windows.Forms.Button btnXemTK;
        private System.Windows.Forms.ComboBox cboHangHoa;
        private System.Windows.Forms.DateTimePicker dtpTuTK, dtpDenTK;
        private System.Windows.Forms.Label lblHangHoa, lblTuTK, lblDenTK;
    }
}