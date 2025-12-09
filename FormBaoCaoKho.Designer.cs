namespace DoAnLapTrinhQuanLy.GuiLayer
{
    partial class FormBaoCaoKho
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
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblTuNgay = new System.Windows.Forms.Label();

            this.dgvBaoCao = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTongTon = new System.Windows.Forms.ToolStripStatusLabel();

            this.pnlHeader.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.dgvBaoCao);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Name = "FormBaoCaoKho";
            this.Text = "Báo Cáo Nhập Xuất Tồn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormBaoCaoKho_Load);

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
            this.lblTitle.Text = "BÁO CÁO NHẬP - XUẤT - TỒN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Filter Panel
            this.pnlFilter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlFilter.Controls.Add(this.btnThoat);
            this.pnlFilter.Controls.Add(this.btnXem);
            this.pnlFilter.Controls.Add(this.dtpDenNgay);
            this.pnlFilter.Controls.Add(this.lblDenNgay);
            this.pnlFilter.Controls.Add(this.dtpTuNgay);
            this.pnlFilter.Controls.Add(this.lblTuNgay);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Height = 60;

            // Controls Filter (Số cứng)
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Location = new System.Drawing.Point(20, 22);
            this.lblTuNgay.Text = "Từ ngày:";

            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(85, 18);
            this.dtpTuNgay.Size = new System.Drawing.Size(120, 25);

            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Location = new System.Drawing.Point(230, 22);
            this.lblDenNgay.Text = "Đến ngày:";

            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(300, 18);
            this.dtpDenNgay.Size = new System.Drawing.Size(120, 25);

            // Nút Xem
            this.btnXem.Text = "Xem Báo Cáo";
            this.btnXem.Location = new System.Drawing.Point(450, 15);
            this.btnXem.Size = new System.Drawing.Size(120, 32);
            this.btnXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXem.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);

            // Nút Thoát
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Location = new System.Drawing.Point(580, 15);
            this.btnThoat.Size = new System.Drawing.Size(90, 32);
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.BackColor = System.Drawing.Color.Gray;
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            // GridView
            this.dgvBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBaoCao.BackgroundColor = System.Drawing.Color.White;
            this.dgvBaoCao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBaoCao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBaoCao.ReadOnly = true;
            this.dgvBaoCao.AllowUserToAddRows = false;
            this.dgvBaoCao.RowHeadersVisible = false;
            this.dgvBaoCao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            headerStyle.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvBaoCao.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvBaoCao.EnableHeadersVisualStyles = false;

            // Status Strip
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.lblTongTon });
            this.statusStrip1.Location = new System.Drawing.Point(0, 578);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1100, 22);
            this.statusStrip1.TabIndex = 4;

            this.lblTongTon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTongTon.ForeColor = System.Drawing.Color.Red;
            this.lblTongTon.Name = "lblTongTon";
            this.lblTongTon.Text = "Tổng số lượng tồn kho: 0";

            this.pnlHeader.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.DateTimePicker dtpTuNgay, dtpDenNgay;
        private System.Windows.Forms.Label lblTuNgay, lblDenNgay;
        private System.Windows.Forms.Button btnXem, btnThoat;
        private System.Windows.Forms.DataGridView dgvBaoCao;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTongTon;
    }
}