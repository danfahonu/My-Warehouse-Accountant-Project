namespace DoAnLapTrinhQuanLy.GuiLayer
{
    partial class FormYeuCauNhapKho
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

        private void InitializeComponent()
        {
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.cboNhanVienYeuCau = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLyDo = new DoAnLapTrinhQuanLy.Controls.MaterialTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgayYeuCau = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new DoAnLapTrinhQuanLy.Controls.MaterialTextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.grpAction = new System.Windows.Forms.GroupBox(); // Approval inputs
            this.btnTuChoi = new DoAnLapTrinhQuanLy.Controls.ModernButton();
            this.btnDuyet = new DoAnLapTrinhQuanLy.Controls.ModernButton();
            this.txtGhiChuDuyet = new DoAnLapTrinhQuanLy.Controls.MaterialTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.dgvDanhSach = new DoAnLapTrinhQuanLy.Controls.ModernDataGrid();
            this.dgvChiTiet = new DoAnLapTrinhQuanLy.Controls.ModernDataGrid();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnThoat = new DoAnLapTrinhQuanLy.Controls.ModernButton();
            this.btnHuy = new DoAnLapTrinhQuanLy.Controls.ModernButton();
            this.btnLuu = new DoAnLapTrinhQuanLy.Controls.ModernButton();
            this.btnXoa = new DoAnLapTrinhQuanLy.Controls.ModernButton();
            this.btnThem = new DoAnLapTrinhQuanLy.Controls.ModernButton();

            this.tableLayoutPanelMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.grpAction.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();

            // tableLayoutPanelMain
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.pnlHeader, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.pnlCenter, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.pnlFooter, 0, 2);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1200, 700);
            this.tableLayoutPanelMain.TabIndex = 0;

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.grpAction);
            this.pnlHeader.Controls.Add(this.grpInfo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1194, 194);
            this.pnlHeader.TabIndex = 0;

            // grpInfo
            this.grpInfo.Controls.Add(this.cboNhanVienYeuCau);
            this.grpInfo.Controls.Add(this.label2);
            this.grpInfo.Controls.Add(this.txtLyDo);
            this.grpInfo.Controls.Add(this.label3);
            this.grpInfo.Controls.Add(this.dtpNgayYeuCau);
            this.grpInfo.Controls.Add(this.label1);
            this.grpInfo.Controls.Add(this.txtID);
            this.grpInfo.Controls.Add(this.labelID);
            this.grpInfo.Location = new System.Drawing.Point(9, 9);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(550, 175);
            this.grpInfo.TabIndex = 0;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Thông tin phiếu";

            // fields in grpInfo
            this.labelID.Location = new System.Drawing.Point(20, 30);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(80, 23);
            this.labelID.Text = "Số Phiếu:";

            this.txtID.Location = new System.Drawing.Point(110, 23);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(150, 25);
            this.txtID.BackColor = System.Drawing.Color.FromArgb(238, 238, 238);

            this.label1.Location = new System.Drawing.Point(280, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.Text = "Ngày YC:";

            this.dtpNgayYeuCau.Location = new System.Drawing.Point(360, 27);
            this.dtpNgayYeuCau.Name = "dtpNgayYeuCau";
            this.dtpNgayYeuCau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayYeuCau.Size = new System.Drawing.Size(150, 20);

            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.Text = "Người YC:";

            this.cboNhanVienYeuCau.Location = new System.Drawing.Point(110, 67);
            this.cboNhanVienYeuCau.Name = "cboNhanVienYeuCau";
            this.cboNhanVienYeuCau.Size = new System.Drawing.Size(400, 21);
            this.cboNhanVienYeuCau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.label3.Location = new System.Drawing.Point(20, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.Text = "Lý do:";

            this.txtLyDo.Location = new System.Drawing.Point(110, 103);
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(400, 25);

            // grpAction (Approval)
            this.grpAction.Controls.Add(this.btnTuChoi);
            this.grpAction.Controls.Add(this.btnDuyet);
            this.grpAction.Controls.Add(this.txtGhiChuDuyet);
            this.grpAction.Controls.Add(this.label4);
            this.grpAction.Location = new System.Drawing.Point(580, 9);
            this.grpAction.Name = "grpAction";
            this.grpAction.Size = new System.Drawing.Size(600, 175);
            this.grpAction.TabIndex = 1;
            this.grpAction.TabStop = false;
            this.grpAction.Text = "Phê Duyệt (Dành cho Quản lý)";

            this.label4.Location = new System.Drawing.Point(20, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.Text = "Ghi chú:";

            this.txtGhiChuDuyet.Location = new System.Drawing.Point(100, 23);
            this.txtGhiChuDuyet.Name = "txtGhiChuDuyet";
            this.txtGhiChuDuyet.Multiline = true;
            this.txtGhiChuDuyet.Size = new System.Drawing.Size(480, 60);

            this.btnDuyet.Location = new System.Drawing.Point(360, 110);
            this.btnDuyet.Name = "btnDuyet";
            this.btnDuyet.Size = new System.Drawing.Size(100, 40);
            this.btnDuyet.Text = "DUYỆT";
            this.btnDuyet.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDuyet.ForeColor = System.Drawing.Color.White;
            this.btnDuyet.Click += new System.EventHandler(this.btnDuyet_Click);

            this.btnTuChoi.Location = new System.Drawing.Point(480, 110);
            this.btnTuChoi.Name = "btnTuChoi";
            this.btnTuChoi.Size = new System.Drawing.Size(100, 40);
            this.btnTuChoi.Text = "TỪ CHỐI";
            this.btnTuChoi.BackColor = System.Drawing.Color.Firebrick;
            this.btnTuChoi.ForeColor = System.Drawing.Color.White;
            this.btnTuChoi.Click += new System.EventHandler(this.btnTuChoi_Click);

            // pnlCenter
            this.pnlCenter.Controls.Add(this.splitContainer);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(3, 203);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(1194, 434);
            this.pnlCenter.TabIndex = 1;

            // splitContainer
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // Panel 1: List
            this.splitContainer.Panel1.Controls.Add(this.dgvDanhSach);
            // Panel 2: Details
            this.splitContainer.Panel2.Controls.Add(this.dgvChiTiet);
            this.splitContainer.Size = new System.Drawing.Size(1194, 434);
            this.splitContainer.SplitterDistance = 400;
            this.splitContainer.TabIndex = 0;

            // dgvDanhSach
            this.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.RowHeadersVisible = false;
            this.dgvDanhSach.SelectionChanged += new System.EventHandler(this.dgvDanhSach_SelectionChanged);

            // dgvChiTiet
            this.dgvChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTiet.RowHeadersVisible = false;

            // pnlFooter (Actions)
            this.pnlFooter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlFooter.Controls.Add(this.btnThoat);
            this.pnlFooter.Controls.Add(this.btnHuy);
            this.pnlFooter.Controls.Add(this.btnLuu);
            this.pnlFooter.Controls.Add(this.btnXoa);
            this.pnlFooter.Controls.Add(this.btnThem);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooter.Location = new System.Drawing.Point(3, 643);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1194, 54);
            this.pnlFooter.TabIndex = 2;

            // Buttons
            this.btnThem.Location = new System.Drawing.Point(10, 10);
            this.btnThem.Text = "Tạo Mới";
            this.btnThem.Size = new System.Drawing.Size(100, 35);
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnXoa.Location = new System.Drawing.Point(120, 10);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Size = new System.Drawing.Size(100, 35);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.btnLuu.Location = new System.Drawing.Point(230, 10);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Size = new System.Drawing.Size(100, 35);
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);

            this.btnHuy.Location = new System.Drawing.Point(340, 10);
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Size = new System.Drawing.Size(100, 35);
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);

            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Top;
            this.btnThoat.Location = new System.Drawing.Point(1080, 10);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Size = new System.Drawing.Size(100, 35);
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "FormYeuCauNhapKho";
            this.Text = "Quản Lý Yêu Cầu Nhập Kho";
            this.Load += new System.EventHandler(this.FormYeuCauNhapKho_Load);

            this.tableLayoutPanelMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.grpAction.ResumeLayout(false);
            this.grpAction.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label labelID;
        private DoAnLapTrinhQuanLy.Controls.MaterialTextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayYeuCau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboNhanVienYeuCau;
        private System.Windows.Forms.Label label3;
        private DoAnLapTrinhQuanLy.Controls.MaterialTextBox txtLyDo;
        private System.Windows.Forms.GroupBox grpAction;
        private System.Windows.Forms.Label label4;
        private DoAnLapTrinhQuanLy.Controls.MaterialTextBox txtGhiChuDuyet;
        private DoAnLapTrinhQuanLy.Controls.ModernButton btnDuyet;
        private DoAnLapTrinhQuanLy.Controls.ModernButton btnTuChoi;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.SplitContainer splitContainer;
        private DoAnLapTrinhQuanLy.Controls.ModernDataGrid dgvDanhSach;
        private DoAnLapTrinhQuanLy.Controls.ModernDataGrid dgvChiTiet;
        private System.Windows.Forms.Panel pnlFooter;
        private DoAnLapTrinhQuanLy.Controls.ModernButton btnThem;
        private DoAnLapTrinhQuanLy.Controls.ModernButton btnXoa;
        private DoAnLapTrinhQuanLy.Controls.ModernButton btnLuu;
        private DoAnLapTrinhQuanLy.Controls.ModernButton btnHuy;
        private DoAnLapTrinhQuanLy.Controls.ModernButton btnThoat;
    }
}