namespace DoAnLapTrinhQuanLy.GuiLayer
{
    partial class FormReportCongNo
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
            // Khai báo Style ở đây
            System.Windows.Forms.DataGridViewCellStyle numStyle = new System.Windows.Forms.DataGridViewCellStyle();
            numStyle.Format = "N0";
            numStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();

            // Tab Khách Hàng
            this.tabKhachHang = new System.Windows.Forms.TabPage();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.pnlFilterKH = new System.Windows.Forms.Panel();
            this.btnXemKH = new System.Windows.Forms.Button();
            this.dtpDenKH = new System.Windows.Forms.DateTimePicker();
            this.dtpTuKH = new System.Windows.Forms.DateTimePicker();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();

            // Tab NCC
            this.tabNCC = new System.Windows.Forms.TabPage();
            this.dgvNCC = new System.Windows.Forms.DataGridView();
            this.pnlFilterNCC = new System.Windows.Forms.Panel();
            this.btnXemNCC = new System.Windows.Forms.Button();
            this.dtpDenNCC = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNCC = new System.Windows.Forms.DateTimePicker();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();

            this.pnlHeader.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.pnlFilterKH.SuspendLayout();
            this.tabNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).BeginInit();
            this.pnlFilterNCC.SuspendLayout();
            this.SuspendLayout();

            // 1. Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Name = "FormReportCongNo";
            this.Text = "Báo Cáo Công Nợ";
            this.Load += new System.EventHandler(this.FormReportCongNo_Load);

            // 2. Header
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 50;
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Text = "TỔNG HỢP CÔNG NỢ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.pnlHeader.Controls.Add(this.lblTitle);

            // 3. TabControl
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Controls.Add(this.tabKhachHang);
            this.tabControl.Controls.Add(this.tabNCC);

            // --- TAB 1: KHÁCH HÀNG ---
            this.tabKhachHang.Text = "Phải Thu Khách Hàng";
            this.tabKhachHang.Controls.Add(this.dgvKhachHang);
            this.tabKhachHang.Controls.Add(this.pnlFilterKH);

            this.pnlFilterKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilterKH.Height = 60;
            this.pnlFilterKH.BackColor = System.Drawing.Color.WhiteSmoke;

            this.lbl1.Text = "Từ ngày:"; this.lbl1.Location = new System.Drawing.Point(20, 20); this.lbl1.AutoSize = true;
            this.dtpTuKH.Location = new System.Drawing.Point(80, 17); this.dtpTuKH.Size = new System.Drawing.Size(110, 25); this.dtpTuKH.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.lbl2.Text = "Đến ngày:"; this.lbl2.Location = new System.Drawing.Point(210, 20); this.lbl2.AutoSize = true;
            this.dtpDenKH.Location = new System.Drawing.Point(280, 17); this.dtpDenKH.Size = new System.Drawing.Size(110, 25); this.dtpDenKH.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.btnXemKH.Text = "Xem Báo Cáo"; this.btnXemKH.Location = new System.Drawing.Point(420, 15); this.btnXemKH.Size = new System.Drawing.Size(120, 30);
            this.btnXemKH.BackColor = System.Drawing.Color.RoyalBlue; this.btnXemKH.ForeColor = System.Drawing.Color.White; this.btnXemKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemKH.Click += new System.EventHandler(this.btnXemKH_Click);

            this.pnlFilterKH.Controls.Add(this.lbl1); this.pnlFilterKH.Controls.Add(this.dtpTuKH);
            this.pnlFilterKH.Controls.Add(this.lbl2); this.pnlFilterKH.Controls.Add(this.dtpDenKH);
            this.pnlFilterKH.Controls.Add(this.btnXemKH);

            this.dgvKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.RowHeadersVisible = false;
            this.dgvKhachHang.DefaultCellStyle = numStyle; // Gán style

            // --- TAB 2: NCC ---
            this.tabNCC.Text = "Phải Trả Nhà Cung Cấp";
            this.tabNCC.Controls.Add(this.dgvNCC);
            this.tabNCC.Controls.Add(this.pnlFilterNCC);

            this.pnlFilterNCC.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilterNCC.Height = 60;
            this.pnlFilterNCC.BackColor = System.Drawing.Color.WhiteSmoke;

            this.lbl3.Text = "Từ ngày:"; this.lbl3.Location = new System.Drawing.Point(20, 20); this.lbl3.AutoSize = true;
            this.dtpTuNCC.Location = new System.Drawing.Point(80, 17); this.dtpTuNCC.Size = new System.Drawing.Size(110, 25); this.dtpTuNCC.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.lbl4.Text = "Đến ngày:"; this.lbl4.Location = new System.Drawing.Point(210, 20); this.lbl4.AutoSize = true;
            this.dtpDenNCC.Location = new System.Drawing.Point(280, 17); this.dtpDenNCC.Size = new System.Drawing.Size(110, 25); this.dtpDenNCC.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.btnXemNCC.Text = "Xem Báo Cáo"; this.btnXemNCC.Location = new System.Drawing.Point(420, 15); this.btnXemNCC.Size = new System.Drawing.Size(120, 30);
            this.btnXemNCC.BackColor = System.Drawing.Color.ForestGreen; this.btnXemNCC.ForeColor = System.Drawing.Color.White; this.btnXemNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemNCC.Click += new System.EventHandler(this.btnXemNCC_Click);

            this.pnlFilterNCC.Controls.Add(this.lbl3); this.pnlFilterNCC.Controls.Add(this.dtpTuNCC);
            this.pnlFilterNCC.Controls.Add(this.lbl4); this.pnlFilterNCC.Controls.Add(this.dtpDenNCC);
            this.pnlFilterNCC.Controls.Add(this.btnXemNCC);

            this.dgvNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNCC.BackgroundColor = System.Drawing.Color.White;
            this.dgvNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNCC.ReadOnly = true;
            this.dgvNCC.RowHeadersVisible = false;
            this.dgvNCC.DefaultCellStyle = numStyle; // Gán style

            this.pnlHeader.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabKhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.pnlFilterKH.ResumeLayout(false);
            this.pnlFilterKH.PerformLayout();
            this.tabNCC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).EndInit();
            this.pnlFilterNCC.ResumeLayout(false);
            this.pnlFilterNCC.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader; private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabControl;

        private System.Windows.Forms.TabPage tabKhachHang, tabNCC;
        private System.Windows.Forms.Panel pnlFilterKH, pnlFilterNCC;
        private System.Windows.Forms.DataGridView dgvKhachHang, dgvNCC;
        private System.Windows.Forms.Button btnXemKH, btnXemNCC;
        private System.Windows.Forms.DateTimePicker dtpTuKH, dtpDenKH, dtpTuNCC, dtpDenNCC;
        private System.Windows.Forms.Label lbl1, lbl2, lbl3, lbl4;
    }
}