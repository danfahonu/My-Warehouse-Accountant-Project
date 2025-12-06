namespace DoAnLapTrinhQuanLy.GuiLayer
{
    partial class FormChonPhieuYeuCau
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnTimKiem = new DoAnLapTrinhQuanLy.Controls.ModernButton();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnHuy = new DoAnLapTrinhQuanLy.Controls.ModernButton();
            this.btnChon = new DoAnLapTrinhQuanLy.Controls.ModernButton();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvDanhSach = new DoAnLapTrinhQuanLy.Controls.ModernDataGrid();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.btnTimKiem);
            this.pnlTop.Controls.Add(this.dtpDenNgay);
            this.pnlTop.Controls.Add(this.lblDenNgay);
            this.pnlTop.Controls.Add(this.dtpTuNgay);
            this.pnlTop.Controls.Add(this.lblTuNgay);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(800, 70);
            this.pnlTop.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(520, 18);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(120, 35);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(340, 23);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(140, 25);
            this.dtpDenNgay.TabIndex = 3;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDenNgay.ForeColor = System.Drawing.Color.DimGray;
            this.lblDenNgay.Location = new System.Drawing.Point(265, 26);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(69, 19);
            this.lblDenNgay.TabIndex = 2;
            this.lblDenNgay.Text = "Đến ngày:";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(90, 23);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(140, 25);
            this.dtpTuNgay.TabIndex = 1;
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTuNgay.ForeColor = System.Drawing.Color.DimGray;
            this.lblTuNgay.Location = new System.Drawing.Point(20, 26);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(61, 19);
            this.lblTuNgay.TabIndex = 0;
            this.lblTuNgay.Text = "Từ ngày:";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBottom.Controls.Add(this.btnHuy);
            this.pnlBottom.Controls.Add(this.btnChon);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 490);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(800, 60);
            this.pnlBottom.TabIndex = 2;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.BackColor = System.Drawing.Color.White;
            this.btnHuy.ForeColor = System.Drawing.Color.Black;
            this.btnHuy.Location = new System.Drawing.Point(680, 10);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 40);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnChon
            // 
            this.btnChon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnChon.ForeColor = System.Drawing.Color.Black;
            this.btnChon.Location = new System.Drawing.Point(560, 10);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(100, 40);
            this.btnChon.TabIndex = 0;
            this.btnChon.Text = "Chọn";
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.dgvDanhSach);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 70);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(10);
            this.pnlGrid.Size = new System.Drawing.Size(800, 420);
            this.pnlGrid.TabIndex = 1;
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSach.Location = new System.Drawing.Point(10, 10);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSach.RowHeadersVisible = false;
            this.dgvDanhSach.Size = new System.Drawing.Size(780, 400);
            this.dgvDanhSach.TabIndex = 0;
            this.dgvDanhSach.DoubleClick += new System.EventHandler(this.dgvDanhSach_DoubleClick);
            // 
            // FormChonPhieuYeuCau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChonPhieuYeuCau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chọn Phiếu Yêu Cầu Nhập Kho";
            this.Load += new System.EventHandler(this.FormChonPhieuYeuCau_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private DoAnLapTrinhQuanLy.Controls.ModernButton btnTimKiem;
        private System.Windows.Forms.Panel pnlBottom;
        private DoAnLapTrinhQuanLy.Controls.ModernButton btnHuy;
        private DoAnLapTrinhQuanLy.Controls.ModernButton btnChon;
        private System.Windows.Forms.Panel pnlGrid;
        private DoAnLapTrinhQuanLy.Controls.ModernDataGrid dgvDanhSach;
    }
}