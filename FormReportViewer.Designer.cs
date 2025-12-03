using DoAnLapTrinhQuanLy.CustomControls;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    partial class FormReportViewer
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ModernPanel pnlSidebar;
        private ModernPanel pnlContent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblReportType;
        private System.Windows.Forms.ComboBox cboLoaiBaoCao;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label lblFilter;
        private MaterialTextBox txtFilter;
        private ModernButton btnXemBaoCao;
        private ModernButton btnXuatExcel;
        private System.Windows.Forms.DataGridView dgvBaoCao;
        private System.Windows.Forms.Label lblStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSidebar = new DoAnLapTrinhQuanLy.CustomControls.ModernPanel();
            this.btnXuatExcel = new DoAnLapTrinhQuanLy.CustomControls.ModernButton();
            this.btnXemBaoCao = new DoAnLapTrinhQuanLy.CustomControls.ModernButton();
            this.txtFilter = new DoAnLapTrinhQuanLy.CustomControls.MaterialTextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lblToDate = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.cboLoaiBaoCao = new System.Windows.Forms.ComboBox();
            this.lblReportType = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlContent = new DoAnLapTrinhQuanLy.CustomControls.ModernPanel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dgvBaoCao = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pnlSidebar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlContent, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 661);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.Controls.Add(this.btnXuatExcel);
            this.pnlSidebar.Controls.Add(this.btnXemBaoCao);
            this.pnlSidebar.Controls.Add(this.txtFilter);
            this.pnlSidebar.Controls.Add(this.lblFilter);
            this.pnlSidebar.Controls.Add(this.dtpDenNgay);
            this.pnlSidebar.Controls.Add(this.lblToDate);
            this.pnlSidebar.Controls.Add(this.dtpTuNgay);
            this.pnlSidebar.Controls.Add(this.lblFromDate);
            this.pnlSidebar.Controls.Add(this.cboLoaiBaoCao);
            this.pnlSidebar.Controls.Add(this.lblReportType);
            this.pnlSidebar.Controls.Add(this.lblTitle);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSidebar.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlSidebar.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pnlSidebar.Location = new System.Drawing.Point(3, 3);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(294, 655);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BackColor = System.Drawing.Color.SeaGreen;
            this.btnXuatExcel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXuatExcel.BorderRadius = 20;
            this.btnXuatExcel.FlatAppearance.BorderSize = 0;
            this.btnXuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcel.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.Location = new System.Drawing.Point(20, 420);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(250, 40);
            this.btnXuatExcel.TabIndex = 10;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.BtnXuatExcel_Click);
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnXemBaoCao.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXemBaoCao.BorderRadius = 20;
            this.btnXemBaoCao.FlatAppearance.BorderSize = 0;
            this.btnXemBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnXemBaoCao.Location = new System.Drawing.Point(20, 360);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(250, 40);
            this.btnXemBaoCao.TabIndex = 9;
            this.btnXemBaoCao.Text = "Xem Báo Cáo";
            this.btnXemBaoCao.UseVisualStyleBackColor = false;
            this.btnXemBaoCao.Click += new System.EventHandler(this.BtnXemBaoCao_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.BackColor = System.Drawing.SystemColors.Window;
            this.txtFilter.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtFilter.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtFilter.BorderSize = 2;
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.ForeColor = System.Drawing.Color.DimGray;
            this.txtFilter.Location = new System.Drawing.Point(20, 300);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilter.Multiline = false;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Padding = new System.Windows.Forms.Padding(7);
            this.txtFilter.PasswordChar = false;
            this.txtFilter.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFilter.PlaceholderText = "Nhập mã hàng (nếu cần)...";
            this.txtFilter.ReadOnly = false;
            this.txtFilter.Size = new System.Drawing.Size(250, 31);
            this.txtFilter.TabIndex = 8;
            this.txtFilter.Texts = "";
            this.txtFilter.UnderlinedStyle = true;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.BackColor = System.Drawing.Color.Transparent;
            this.lblFilter.ForeColor = System.Drawing.Color.White;
            this.lblFilter.Location = new System.Drawing.Point(20, 280);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(103, 13);
            this.lblFilter.TabIndex = 7;
            this.lblFilter.Text = "Lọc theo Mã Hàng:";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(20, 230);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(250, 20);
            this.dtpDenNgay.TabIndex = 6;
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.BackColor = System.Drawing.Color.Transparent;
            this.lblToDate.ForeColor = System.Drawing.Color.White;
            this.lblToDate.Location = new System.Drawing.Point(20, 210);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(58, 13);
            this.lblToDate.TabIndex = 5;
            this.lblToDate.Text = "Đến ngày:";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(20, 160);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(250, 20);
            this.dtpTuNgay.TabIndex = 4;
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.BackColor = System.Drawing.Color.Transparent;
            this.lblFromDate.ForeColor = System.Drawing.Color.White;
            this.lblFromDate.Location = new System.Drawing.Point(20, 140);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(51, 13);
            this.lblFromDate.TabIndex = 3;
            this.lblFromDate.Text = "Từ ngày:";
            // 
            // cboLoaiBaoCao
            // 
            this.cboLoaiBaoCao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiBaoCao.FormattingEnabled = true;
            this.cboLoaiBaoCao.Location = new System.Drawing.Point(20, 90);
            this.cboLoaiBaoCao.Name = "cboLoaiBaoCao";
            this.cboLoaiBaoCao.Size = new System.Drawing.Size(250, 21);
            this.cboLoaiBaoCao.TabIndex = 2;
            // 
            // lblReportType
            // 
            this.lblReportType.AutoSize = true;
            this.lblReportType.BackColor = System.Drawing.Color.Transparent;
            this.lblReportType.ForeColor = System.Drawing.Color.White;
            this.lblReportType.Location = new System.Drawing.Point(20, 70);
            this.lblReportType.Name = "lblReportType";
            this.lblReportType.Size = new System.Drawing.Size(76, 13);
            this.lblReportType.TabIndex = 1;
            this.lblReportType.Text = "Loại Báo Cáo:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(193, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BÁO CÁO THÔNG MINH";
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.lblStatus);
            this.pnlContent.Controls.Add(this.dgvBaoCao);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.GradientBottomColor = System.Drawing.Color.White;
            this.pnlContent.GradientTopColor = System.Drawing.Color.White;
            this.pnlContent.Location = new System.Drawing.Point(303, 3);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(878, 655);
            this.pnlContent.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.ForeColor = System.Drawing.Color.DimGray;
            this.lblStatus.Location = new System.Drawing.Point(20, 630);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(116, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Trạng thái: Sẵn sàng...";
            // 
            // dgvBaoCao
            // 
            this.dgvBaoCao.AllowUserToAddRows = false;
            this.dgvBaoCao.AllowUserToDeleteRows = false;
            this.dgvBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBaoCao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBaoCao.BackgroundColor = System.Drawing.Color.White;
            this.dgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCao.Location = new System.Drawing.Point(20, 20);
            this.dgvBaoCao.Name = "dgvBaoCao";
            this.dgvBaoCao.ReadOnly = true;
            this.dgvBaoCao.Size = new System.Drawing.Size(840, 600);
            this.dgvBaoCao.TabIndex = 0;
            // 
            // FormReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormReportViewer";
            this.Text = "Hệ Thống Báo Cáo";
            this.Load += new System.EventHandler(this.FormReportViewer_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
