namespace DoAnLapTrinhQuanLy.GuiLayer
{
    partial class FormPhieuNhap
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeader = new DoAnLapTrinhQuanLy.CustomControls.ModernPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMaster = new DoAnLapTrinhQuanLy.CustomControls.ModernPanel();
            this.tlpMaster = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoPhieu = new DoAnLapTrinhQuanLy.CustomControls.MaterialTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cboNhaCungCap = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGhiChu = new DoAnLapTrinhQuanLy.CustomControls.MaterialTextBox();
            this.pnlGrid = new DoAnLapTrinhQuanLy.CustomControls.ModernPanel();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.pnlFooter = new DoAnLapTrinhQuanLy.CustomControls.ModernPanel();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTongCong = new System.Windows.Forms.Label();
            this.btnHuy = new DoAnLapTrinhQuanLy.CustomControls.ModernButton();
            this.btnLuu = new DoAnLapTrinhQuanLy.CustomControls.ModernButton();
            this.btnThem = new DoAnLapTrinhQuanLy.CustomControls.ModernButton();
            this.btnChonYeuCau = new DoAnLapTrinhQuanLy.CustomControls.ModernButton();
            this.tlpMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlMaster.SuspendLayout();
            this.tlpMaster.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.pnlHeader, 0, 0);
            this.tlpMain.Controls.Add(this.pnlMaster, 0, 1);
            this.tlpMain.Controls.Add(this.pnlGrid, 0, 2);
            this.tlpMain.Controls.Add(this.pnlFooter, 0, 3);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 4;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpMain.Size = new System.Drawing.Size(1008, 661);
            this.tlpMain.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.BorderRadius = 0;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.GradientAngle = 90F;
            this.pnlHeader.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pnlHeader.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pnlHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1002, 54);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(223, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PHIẾU NHẬP KHO";
            // 
            // pnlMaster
            // 
            this.pnlMaster.BackColor = System.Drawing.Color.White;
            this.pnlMaster.BorderRadius = 10;
            this.pnlMaster.Controls.Add(this.tlpMaster);
            this.pnlMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMaster.GradientAngle = 90F;
            this.pnlMaster.GradientBottomColor = System.Drawing.Color.White;
            this.pnlMaster.GradientTopColor = System.Drawing.Color.White;
            this.pnlMaster.Location = new System.Drawing.Point(3, 63);
            this.pnlMaster.Name = "pnlMaster";
            this.pnlMaster.Padding = new System.Windows.Forms.Padding(10);
            this.pnlMaster.Size = new System.Drawing.Size(1002, 114);
            this.pnlMaster.TabIndex = 1;
            // 
            // tlpMaster
            // 
            this.tlpMaster.ColumnCount = 4;
            this.tlpMaster.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpMaster.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMaster.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpMaster.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMaster.Controls.Add(this.label1, 0, 0);
            this.tlpMaster.Controls.Add(this.txtSoPhieu, 1, 0);
            this.tlpMaster.Controls.Add(this.label2, 2, 0);
            this.tlpMaster.Controls.Add(this.dtpNgayLap, 3, 0);
            this.tlpMaster.Controls.Add(this.label3, 0, 1);
            this.tlpMaster.Controls.Add(this.cboNhaCungCap, 1, 1);
            this.tlpMaster.Controls.Add(this.label4, 2, 1);
            this.tlpMaster.Controls.Add(this.txtGhiChu, 3, 1);
            this.tlpMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMaster.Location = new System.Drawing.Point(10, 10);
            this.tlpMaster.Name = "tlpMaster";
            this.tlpMaster.RowCount = 2;
            this.tlpMaster.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMaster.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMaster.Size = new System.Drawing.Size(982, 94);
            this.tlpMaster.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số Phiếu:";
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
            this.txtSoPhieu.Location = new System.Drawing.Point(104, 8);
            this.txtSoPhieu.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoPhieu.Multiline = false;
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.Padding = new System.Windows.Forms.Padding(7);
            this.txtSoPhieu.PasswordChar = false;
            this.txtSoPhieu.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSoPhieu.PlaceholderText = "(Tự động)";
            this.txtSoPhieu.Size = new System.Drawing.Size(383, 31);
            this.txtSoPhieu.TabIndex = 1;
            this.txtSoPhieu.Texts = "";
            this.txtSoPhieu.UnderlinedStyle = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(494, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày Lập:";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLap.Location = new System.Drawing.Point(594, 13);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(385, 20);
            this.dtpNgayLap.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhà Cung Cấp:";
            // 
            // cboNhaCungCap
            // 
            this.cboNhaCungCap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboNhaCungCap.FormattingEnabled = true;
            this.cboNhaCungCap.Location = new System.Drawing.Point(104, 60);
            this.cboNhaCungCap.Name = "cboNhaCungCap";
            this.cboNhaCungCap.Size = new System.Drawing.Size(383, 21);
            this.cboNhaCungCap.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(494, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ghi Chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGhiChu.BackColor = System.Drawing.SystemColors.Window;
            this.txtGhiChu.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtGhiChu.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtGhiChu.BorderRadius = 0;
            this.txtGhiChu.BorderSize = 2;
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.ForeColor = System.Drawing.Color.DimGray;
            this.txtGhiChu.Location = new System.Drawing.Point(595, 55);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGhiChu.Multiline = false;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Padding = new System.Windows.Forms.Padding(7);
            this.txtGhiChu.PasswordChar = false;
            this.txtGhiChu.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtGhiChu.PlaceholderText = "";
            this.txtGhiChu.Size = new System.Drawing.Size(383, 31);
            this.txtGhiChu.TabIndex = 7;
            this.txtGhiChu.Texts = "";
            this.txtGhiChu.UnderlinedStyle = true;
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.White;
            this.pnlGrid.BorderRadius = 10;
            this.pnlGrid.Controls.Add(this.dgvChiTiet);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.GradientAngle = 90F;
            this.pnlGrid.GradientBottomColor = System.Drawing.Color.White;
            this.pnlGrid.GradientTopColor = System.Drawing.Color.White;
            this.pnlGrid.Location = new System.Drawing.Point(3, 183);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(10);
            this.pnlGrid.Size = new System.Drawing.Size(1002, 405);
            this.pnlGrid.TabIndex = 2;
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTiet.Location = new System.Drawing.Point(10, 10);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.Size = new System.Drawing.Size(982, 385);
            this.dgvChiTiet.TabIndex = 0;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.BorderRadius = 10;
            this.pnlFooter.Controls.Add(this.lblTongTien);
            this.pnlFooter.Controls.Add(this.lblTongCong);
            this.pnlFooter.Controls.Add(this.btnHuy);
            this.pnlFooter.Controls.Add(this.btnLuu);
            this.pnlFooter.Controls.Add(this.btnThem);
            this.pnlFooter.Controls.Add(this.btnChonYeuCau);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooter.GradientAngle = 90F;
            this.pnlFooter.GradientBottomColor = System.Drawing.Color.WhiteSmoke;
            this.pnlFooter.GradientTopColor = System.Drawing.Color.White;
            this.pnlFooter.Location = new System.Drawing.Point(3, 594);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1002, 64);
            this.pnlFooter.TabIndex = 3;
            // 
            // lblTongTien
            // 
            this.lblTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.BackColor = System.Drawing.Color.Transparent;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(850, 17);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(25, 30);
            this.lblTongTien.TabIndex = 5;
            this.lblTongTien.Text = "0";
            // 
            // lblTongCong
            // 
            this.lblTongCong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTongCong.AutoSize = true;
            this.lblTongCong.BackColor = System.Drawing.Color.Transparent;
            this.lblTongCong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongCong.Location = new System.Drawing.Point(740, 24);
            this.lblTongCong.Name = "lblTongCong";
            this.lblTongCong.Size = new System.Drawing.Size(104, 21);
            this.lblTongCong.TabIndex = 4;
            this.lblTongCong.Text = "TỔNG TIỀN:";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Crimson;
            this.btnHuy.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHuy.BorderRadius = 15;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(368, 14);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 40);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy Bỏ";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.BtnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLuu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLuu.BorderRadius = 15;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(250, 14);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 40);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu Phiếu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThem.BorderRadius = 15;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(132, 14);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 40);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Tạo Mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // btnChonYeuCau
            // 
            this.btnChonYeuCau.BackColor = System.Drawing.Color.Orange;
            this.btnChonYeuCau.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnChonYeuCau.BorderRadius = 15;
            this.btnChonYeuCau.FlatAppearance.BorderSize = 0;
            this.btnChonYeuCau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonYeuCau.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonYeuCau.ForeColor = System.Drawing.Color.White;
            this.btnChonYeuCau.Location = new System.Drawing.Point(14, 14);
            this.btnChonYeuCau.Name = "btnChonYeuCau";
            this.btnChonYeuCau.Size = new System.Drawing.Size(100, 40);
            this.btnChonYeuCau.TabIndex = 0;
            this.btnChonYeuCau.Text = "Chọn YC";
            this.btnChonYeuCau.UseVisualStyleBackColor = false;
            this.btnChonYeuCau.Click += new System.EventHandler(this.BtnChonYeuCau_Click);
            // 
            // FormPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.tlpMain);
            this.Name = "FormPhieuNhap";
            this.Text = "Phiếu Nhập Kho";
            this.Load += new System.EventHandler(this.FormPhieuNhap_Load);
            this.tlpMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMaster.ResumeLayout(false);
            this.tlpMaster.ResumeLayout(false);
            this.tlpMaster.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private DoAnLapTrinhQuanLy.CustomControls.ModernPanel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private DoAnLapTrinhQuanLy.CustomControls.ModernPanel pnlMaster;
        private System.Windows.Forms.TableLayoutPanel tlpMaster;
        private System.Windows.Forms.Label label1;
        private DoAnLapTrinhQuanLy.CustomControls.MaterialTextBox txtSoPhieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboNhaCungCap;
        private System.Windows.Forms.Label label4;
        private DoAnLapTrinhQuanLy.CustomControls.MaterialTextBox txtGhiChu;
        private DoAnLapTrinhQuanLy.CustomControls.ModernPanel pnlGrid;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private DoAnLapTrinhQuanLy.CustomControls.ModernPanel pnlFooter;
        private DoAnLapTrinhQuanLy.CustomControls.ModernButton btnChonYeuCau;
        private DoAnLapTrinhQuanLy.CustomControls.ModernButton btnThem;
        private DoAnLapTrinhQuanLy.CustomControls.ModernButton btnLuu;
        private DoAnLapTrinhQuanLy.CustomControls.ModernButton btnHuy;
        private System.Windows.Forms.Label lblTongCong;
        private System.Windows.Forms.Label lblTongTien;
    }
}