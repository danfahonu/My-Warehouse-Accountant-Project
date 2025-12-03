namespace DoAnLapTrinhQuanLy.GuiLayer
{
    partial class FormPhieuThu
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
            this.pnlHeader = new DoAnLapTrinhQuanLy.CustomControls.ModernPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlActions = new DoAnLapTrinhQuanLy.CustomControls.ModernPanel();
            this.btnGhiSo = new DoAnLapTrinhQuanLy.CustomControls.ModernButton();
            this.btnHuy = new DoAnLapTrinhQuanLy.CustomControls.ModernButton();
            this.btnLuu = new DoAnLapTrinhQuanLy.CustomControls.ModernButton();
            this.btnXoa = new DoAnLapTrinhQuanLy.CustomControls.ModernButton();
            this.btnSua = new DoAnLapTrinhQuanLy.CustomControls.ModernButton();
            this.btnThem = new DoAnLapTrinhQuanLy.CustomControls.ModernButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoPhieu = new DoAnLapTrinhQuanLy.CustomControls.MaterialTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoTien = new DoAnLapTrinhQuanLy.CustomControls.MaterialTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTaiKhoan = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLyDo = new DoAnLapTrinhQuanLy.CustomControls.MaterialTextBox();
            this.pnlHeader.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.pnlHeader.BorderRadius = 0;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.GradientAngle = 90F;
            this.pnlHeader.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.pnlHeader.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(884, 50);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(12, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(160, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PHIẾU THU TIỀN";
            // 
            // pnlActions
            // 
            this.pnlActions.BackColor = System.Drawing.Color.White;
            this.pnlActions.BorderRadius = 0;
            this.pnlActions.Controls.Add(this.btnGhiSo);
            this.pnlActions.Controls.Add(this.btnHuy);
            this.pnlActions.Controls.Add(this.btnLuu);
            this.pnlActions.Controls.Add(this.btnXoa);
            this.pnlActions.Controls.Add(this.btnSua);
            this.pnlActions.Controls.Add(this.btnThem);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlActions.GradientAngle = 90F;
            this.pnlActions.GradientBottomColor = System.Drawing.Color.White;
            this.pnlActions.GradientTopColor = System.Drawing.Color.White;
            this.pnlActions.Location = new System.Drawing.Point(0, 50);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.pnlActions.Size = new System.Drawing.Size(884, 60);
            this.pnlActions.TabIndex = 2;
            // 
            // btnGhiSo
            // 
            this.btnGhiSo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGhiSo.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGhiSo.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnGhiSo.BorderRadius = 10;
            this.btnGhiSo.FlatAppearance.BorderSize = 0;
            this.btnGhiSo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGhiSo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGhiSo.ForeColor = System.Drawing.Color.White;
            this.btnGhiSo.Location = new System.Drawing.Point(559, 15);
            this.btnGhiSo.Name = "btnGhiSo";
            this.btnGhiSo.Size = new System.Drawing.Size(100, 30);
            this.btnGhiSo.TabIndex = 6;
            this.btnGhiSo.Text = "Ghi Sổ";
            this.btnGhiSo.UseVisualStyleBackColor = false;
            this.btnGhiSo.Click += new System.EventHandler(this.BtnGhiSo_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.BackColor = System.Drawing.Color.Gray;
            this.btnHuy.BorderColor = System.Drawing.Color.Gray;
            this.btnHuy.BorderRadius = 10;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(771, 15);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 30);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.BtnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLuu.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnLuu.BorderRadius = 10;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(665, 15);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 30);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu Nháp";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.IndianRed;
            this.btnXoa.BorderColor = System.Drawing.Color.IndianRed;
            this.btnXoa.BorderRadius = 10;
            this.btnXoa.Enabled = false;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(234, 15);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 30);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xem Danh Sách";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Visible = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Orange;
            this.btnSua.BorderColor = System.Drawing.Color.Orange;
            this.btnSua.BorderRadius = 10;
            this.btnSua.Enabled = false;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(128, 15);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 30);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa Phiếu";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Visible = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.BorderRadius = 10;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(18, 15);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 30);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Lập Phiếu Mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSoPhieu, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cboKhachHang, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpNgayLap, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtSoTien, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cboTaiKhoan, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtLyDo, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 110);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(50, 20, 50, 20);
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 351);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(53, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số phiếu:";
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoPhieu.BackColor = System.Drawing.SystemColors.Window;
            this.txtSoPhieu.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSoPhieu.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSoPhieu.BorderRadius = 0;
            this.txtSoPhieu.BorderSize = 2;
            this.txtSoPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoPhieu.ForeColor = System.Drawing.Color.DimGray;
            this.txtSoPhieu.Location = new System.Drawing.Point(154, 30);
            this.txtSoPhieu.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoPhieu.Multiline = false;
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.Padding = new System.Windows.Forms.Padding(7);
            this.txtSoPhieu.PasswordChar = false;
            this.txtSoPhieu.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSoPhieu.PlaceholderText = "";
            this.txtSoPhieu.ReadOnly = true;
            this.txtSoPhieu.Size = new System.Drawing.Size(661, 31);
            this.txtSoPhieu.TabIndex = 1;
            this.txtSoPhieu.Texts = "";
            this.txtSoPhieu.UnderlinedStyle = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(53, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Khách hàng:";
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboKhachHang.FormattingEnabled = true;
            this.cboKhachHang.Location = new System.Drawing.Point(153, 138);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(663, 21);
            this.cboKhachHang.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(53, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày lập:";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLap.Location = new System.Drawing.Point(153, 87);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(663, 20);
            this.dtpNgayLap.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(53, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số tiền:";
            // 
            // txtSoTien
            // 
            this.txtSoTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoTien.BackColor = System.Drawing.SystemColors.Window;
            this.txtSoTien.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSoTien.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSoTien.BorderRadius = 0;
            this.txtSoTien.BorderSize = 2;
            this.txtSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTien.ForeColor = System.Drawing.Color.DimGray;
            this.txtSoTien.Location = new System.Drawing.Point(154, 236);
            this.txtSoTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoTien.Multiline = false;
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Padding = new System.Windows.Forms.Padding(7);
            this.txtSoTien.PasswordChar = false;
            this.txtSoTien.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSoTien.PlaceholderText = "";
            this.txtSoTien.ReadOnly = false;
            this.txtSoTien.Size = new System.Drawing.Size(661, 31);
            this.txtSoTien.TabIndex = 7;
            this.txtSoTien.Texts = "";
            this.txtSoTien.UnderlinedStyle = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(53, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Thu vào tài khoản:";
            // 
            // cboTaiKhoan
            // 
            this.cboTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTaiKhoan.FormattingEnabled = true;
            this.cboTaiKhoan.Location = new System.Drawing.Point(153, 189);
            this.cboTaiKhoan.Name = "cboTaiKhoan";
            this.cboTaiKhoan.Size = new System.Drawing.Size(663, 21);
            this.cboTaiKhoan.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(53, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Lý do thu:";
            // 
            // txtLyDo
            // 
            this.txtLyDo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLyDo.BackColor = System.Drawing.SystemColors.Window;
            this.txtLyDo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtLyDo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtLyDo.BorderRadius = 0;
            this.txtLyDo.BorderSize = 2;
            this.txtLyDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLyDo.ForeColor = System.Drawing.Color.DimGray;
            this.txtLyDo.Location = new System.Drawing.Point(154, 292);
            this.txtLyDo.Margin = new System.Windows.Forms.Padding(4);
            this.txtLyDo.Multiline = true;
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Padding = new System.Windows.Forms.Padding(7);
            this.txtLyDo.PasswordChar = false;
            this.txtLyDo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtLyDo.PlaceholderText = "";
            this.txtLyDo.ReadOnly = false;
            this.txtLyDo.Size = new System.Drawing.Size(661, 26);
            this.txtLyDo.TabIndex = 11;
            this.txtLyDo.Texts = "";
            this.txtLyDo.UnderlinedStyle = true;
            // 
            // FormPhieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FormPhieuThu";
            this.Text = "Phiếu Thu Tiền";
            this.Load += new System.EventHandler(this.FormPhieuThu_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DoAnLapTrinhQuanLy.CustomControls.ModernPanel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private DoAnLapTrinhQuanLy.CustomControls.ModernPanel pnlActions;
        private DoAnLapTrinhQuanLy.CustomControls.ModernButton btnThem;
        private DoAnLapTrinhQuanLy.CustomControls.ModernButton btnSua;
        private DoAnLapTrinhQuanLy.CustomControls.ModernButton btnXoa;
        private DoAnLapTrinhQuanLy.CustomControls.ModernButton btnLuu;
        private DoAnLapTrinhQuanLy.CustomControls.ModernButton btnHuy;
        private DoAnLapTrinhQuanLy.CustomControls.ModernButton btnGhiSo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private DoAnLapTrinhQuanLy.CustomControls.MaterialTextBox txtSoPhieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Label label6;
        private DoAnLapTrinhQuanLy.CustomControls.MaterialTextBox txtLyDo;
        private System.Windows.Forms.Label label4;
        private DoAnLapTrinhQuanLy.CustomControls.MaterialTextBox txtSoTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTaiKhoan;
    }
}
