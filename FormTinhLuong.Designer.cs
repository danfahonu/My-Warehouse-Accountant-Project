namespace DoAnLapTrinhQuanLy.GuiLayer
{
    partial class FormTinhLuong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnXemBangLuong = new System.Windows.Forms.Button();
            this.txtLuongCoBan = new System.Windows.Forms.TextBox();
            this.lblLuongCoBan = new System.Windows.Forms.Label();
            this.dtpThangNam = new System.Windows.Forms.DateTimePicker();
            this.lblChonThang = new System.Windows.Forms.Label();
            this.gridBangLuong = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBangLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnXemBangLuong);
            this.panelTop.Controls.Add(this.txtLuongCoBan);
            this.panelTop.Controls.Add(this.lblLuongCoBan);
            this.panelTop.Controls.Add(this.dtpThangNam);
            this.panelTop.Controls.Add(this.lblChonThang);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1184, 80);
            this.panelTop.TabIndex = 0;
            // 
            // btnXemBangLuong
            // 
            this.btnXemBangLuong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemBangLuong.Location = new System.Drawing.Point(630, 22);
            this.btnXemBangLuong.Name = "btnXemBangLuong";
            this.btnXemBangLuong.Size = new System.Drawing.Size(160, 36);
            this.btnXemBangLuong.TabIndex = 4;
            this.btnXemBangLuong.Text = "Xem Bảng Lương";
            this.btnXemBangLuong.UseVisualStyleBackColor = true;
            this.btnXemBangLuong.Click += new System.EventHandler(this.btnXemBangLuong_Click);
            // 
            // txtLuongCoBan
            // 
            this.txtLuongCoBan.Location = new System.Drawing.Point(408, 29);
            this.txtLuongCoBan.Name = "txtLuongCoBan";
            this.txtLuongCoBan.Size = new System.Drawing.Size(180, 23);
            this.txtLuongCoBan.TabIndex = 3;
            this.txtLuongCoBan.Text = "4500000";
            this.txtLuongCoBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblLuongCoBan
            // 
            this.lblLuongCoBan.AutoSize = true;
            this.lblLuongCoBan.Location = new System.Drawing.Point(312, 32);
            this.lblLuongCoBan.Name = "lblLuongCoBan";
            this.lblLuongCoBan.Size = new System.Drawing.Size(90, 15);
            this.lblLuongCoBan.TabIndex = 2;
            this.lblLuongCoBan.Text = "Lương cơ bản:";
            // 
            // dtpThangNam
            // 
            this.dtpThangNam.CustomFormat = "MM / yyyy";
            this.dtpThangNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThangNam.Location = new System.Drawing.Point(111, 29);
            this.dtpThangNam.Name = "dtpThangNam";
            this.dtpThangNam.ShowUpDown = true;
            this.dtpThangNam.Size = new System.Drawing.Size(158, 23);
            this.dtpThangNam.TabIndex = 1;
            // 
            // lblChonThang
            // 
            this.lblChonThang.AutoSize = true;
            this.lblChonThang.Location = new System.Drawing.Point(23, 32);
            this.lblChonThang.Name = "lblChonThang";
            this.lblChonThang.Size = new System.Drawing.Size(82, 15);
            this.lblChonThang.TabIndex = 0;
            this.lblChonThang.Text = "Chọn kỳ lương:";
            // 
            // gridBangLuong
            // 
            this.gridBangLuong.AllowUserToAddRows = false;
            this.gridBangLuong.AllowUserToDeleteRows = false;
            this.gridBangLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBangLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBangLuong.Location = new System.Drawing.Point(0, 80);
            this.gridBangLuong.Name = "gridBangLuong";
            this.gridBangLuong.ReadOnly = true;
            this.gridBangLuong.RowTemplate.Height = 25;
            this.gridBangLuong.Size = new System.Drawing.Size(1184, 581);
            this.gridBangLuong.TabIndex = 1;
            // 
            // FormTinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.gridBangLuong);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormTinhLuong";
            this.Text = "Tính Lương Nhân Viên";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBangLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnXemBangLuong;
        private System.Windows.Forms.TextBox txtLuongCoBan;
        private System.Windows.Forms.Label lblLuongCoBan;
        private System.Windows.Forms.DateTimePicker dtpThangNam;
        private System.Windows.Forms.Label lblChonThang;
        private System.Windows.Forms.DataGridView gridBangLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLuongGross;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTamUng;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThucLanh;
    }
}