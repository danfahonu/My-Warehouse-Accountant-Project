namespace DoAnLapTrinhQuanLy.GuiLayer
{
    partial class FormPhieuXuat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyleHeader = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle styleTonKho = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle styleSL = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle styleDonGia = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle styleThanhTien = new System.Windows.Forms.DataGridViewCellStyle();

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();

            this.pnlInput = new System.Windows.Forms.Panel();
            this.lblSoPhieu = new System.Windows.Forms.Label();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.lblNgay = new System.Windows.Forms.Label();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.lblKhach = new System.Windows.Forms.Label();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();

            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblTongTienLabel = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.chkThanhToan = new System.Windows.Forms.CheckBox();
            this.btnThem = new DoAnLapTrinhQuanLy.Controls.ModernButton();
            this.btnIn = new DoAnLapTrinhQuanLy.Controls.ModernButton();
            this.btnLuu = new DoAnLapTrinhQuanLy.Controls.ModernButton();
            this.btnHuy = new DoAnLapTrinhQuanLy.Controls.ModernButton();

            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvChiTiet = new DoAnLapTrinhQuanLy.Controls.ModernDataGrid();
            this.colMaHH = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colTenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTonKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlHeader.SuspendLayout();
            this.pnlInput.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.SuspendLayout();

            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 60;
            this.pnlHeader.Name = "pnlHeader";

            // lblTitle
            this.lblTitle.Text = "PHIẾU XUẤT KHO";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.AutoSize = true;

            // 
            // pnlInput
            // 
            this.pnlInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInput.Height = 140;
            this.pnlInput.Name = "pnlInput";

            this.lblSoPhieu.Text = "Số Phiếu:";
            this.lblSoPhieu.ForeColor = System.Drawing.Color.White;
            this.lblSoPhieu.Location = new System.Drawing.Point(30, 20);
            this.lblSoPhieu.AutoSize = true;

            this.txtSoPhieu.Location = new System.Drawing.Point(110, 15);
            this.txtSoPhieu.Size = new System.Drawing.Size(200, 30);
            this.txtSoPhieu.ReadOnly = true;

            this.lblNgay.Text = "Ngày Lập:";
            this.lblNgay.ForeColor = System.Drawing.Color.White;
            this.lblNgay.Location = new System.Drawing.Point(350, 20);
            this.lblNgay.AutoSize = true;

            this.dtpNgayLap.Location = new System.Drawing.Point(430, 15);
            this.dtpNgayLap.Size = new System.Drawing.Size(200, 30);
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.lblKhach.Text = "Khách Hàng:";
            this.lblKhach.ForeColor = System.Drawing.Color.White;
            this.lblKhach.Location = new System.Drawing.Point(30, 70);
            this.lblKhach.AutoSize = true;

            this.cboKhachHang.Location = new System.Drawing.Point(140, 65);
            this.cboKhachHang.Size = new System.Drawing.Size(400, 30);
            this.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.lblGhiChu.Text = "Ghi Chú:";
            this.lblGhiChu.ForeColor = System.Drawing.Color.White;
            this.lblGhiChu.Location = new System.Drawing.Point(580, 70);
            this.lblGhiChu.AutoSize = true;

            this.txtGhiChu.Location = new System.Drawing.Point(650, 65);
            this.txtGhiChu.Size = new System.Drawing.Size(400, 30);

            this.pnlInput.Controls.Add(this.lblSoPhieu);
            this.pnlInput.Controls.Add(this.txtSoPhieu);
            this.pnlInput.Controls.Add(this.lblNgay);
            this.pnlInput.Controls.Add(this.dtpNgayLap);
            this.pnlInput.Controls.Add(this.lblKhach);
            this.pnlInput.Controls.Add(this.cboKhachHang);
            this.pnlInput.Controls.Add(this.lblGhiChu);
            this.pnlInput.Controls.Add(this.txtGhiChu);

            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Height = 80;
            this.pnlFooter.Name = "pnlFooter";

            this.lblTongTienLabel.Text = "TỔNG THANH TOÁN:";
            this.lblTongTienLabel.ForeColor = System.Drawing.Color.White;
            this.lblTongTienLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTongTienLabel.Location = new System.Drawing.Point(30, 25);
            this.lblTongTienLabel.AutoSize = true;

            this.lblTongTien.Text = "0";
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(230, 15);
            this.lblTongTien.AutoSize = true;

            this.chkThanhToan.Text = "Thanh toán ngay";
            this.chkThanhToan.ForeColor = System.Drawing.Color.White;
            this.chkThanhToan.Location = new System.Drawing.Point(450, 30);
            this.chkThanhToan.AutoSize = true;

            // Buttons
            this.btnThem.Text = "Tạo Phiếu Mới";
            this.btnThem.Location = new System.Drawing.Point(650, 15);
            this.btnThem.Size = new System.Drawing.Size(120, 45); // Adjusted width
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.BorderRadius = 4;
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Right;

            this.btnIn.Text = "In Phiếu";
            this.btnIn.Location = new System.Drawing.Point(780, 15);
            this.btnIn.Size = new System.Drawing.Size(110, 45);
            this.btnIn.BackColor = System.Drawing.Color.SlateBlue;
            this.btnIn.ForeColor = System.Drawing.Color.White;
            this.btnIn.BorderRadius = 4;
            this.btnIn.Enabled = false;
            this.btnIn.Anchor = System.Windows.Forms.AnchorStyles.Right;

            this.btnLuu.Text = "Lưu";
            this.btnLuu.Location = new System.Drawing.Point(900, 15);
            this.btnLuu.Size = new System.Drawing.Size(110, 45);
            this.btnLuu.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.BorderRadius = 4;
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Right;

            this.btnHuy.Text = "Thoát";
            this.btnHuy.Location = new System.Drawing.Point(1020, 15);
            this.btnHuy.Size = new System.Drawing.Size(100, 45);
            this.btnHuy.BackColor = System.Drawing.Color.White;
            this.btnHuy.ForeColor = System.Drawing.Color.Black;
            this.btnHuy.BorderRadius = 4;
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Right;

            this.pnlFooter.Controls.Add(this.lblTongTienLabel);
            this.pnlFooter.Controls.Add(this.lblTongTien);
            this.pnlFooter.Controls.Add(this.chkThanhToan);
            this.pnlFooter.Controls.Add(this.btnThem);
            this.pnlFooter.Controls.Add(this.btnIn);
            this.pnlFooter.Controls.Add(this.btnLuu);
            this.pnlFooter.Controls.Add(this.btnHuy);

            // 
            // pnlGrid
            // 
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.BackColor = System.Drawing.Color.White;
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(10);
            this.pnlGrid.Controls.Add(this.dgvChiTiet);

            this.dgvChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTiet.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTiet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChiTiet.AutoGenerateColumns = false;

            dataGridViewCellStyleHeader.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            dataGridViewCellStyleHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvChiTiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyleHeader;
            this.dgvChiTiet.ColumnHeadersHeight = 35;
            this.dgvChiTiet.EnableHeadersVisualStyles = false;

            this.colMaHH.HeaderText = "Hàng Hóa";
            this.colMaHH.Name = "colMaHH";
            this.colMaHH.Width = 250;
            this.colMaHH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.colTenHH.HeaderText = "Tên Hàng";
            this.colTenHH.Name = "colTenHH";
            this.colTenHH.ReadOnly = true;
            this.colTenHH.Width = 200;

            this.colDVT.HeaderText = "ĐVT";
            this.colDVT.Name = "colDVT";
            this.colDVT.ReadOnly = true;
            this.colDVT.Width = 80;

            this.colTonKho.HeaderText = "Tồn";
            this.colTonKho.Name = "colTonKho";
            this.colTonKho.ReadOnly = true;
            this.colTonKho.Width = 80;
            styleTonKho.ForeColor = System.Drawing.Color.Red;
            this.colTonKho.DefaultCellStyle = styleTonKho;

            this.colSL.HeaderText = "SL";
            this.colSL.Name = "colSL";
            this.colSL.Width = 80;
            styleSL.BackColor = System.Drawing.Color.Ivory;
            this.colSL.DefaultCellStyle = styleSL;

            this.colDonGia.HeaderText = "Đơn Giá";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.Width = 120;
            styleDonGia.Format = "N0";
            this.colDonGia.DefaultCellStyle = styleDonGia;

            this.colThanhTien.HeaderText = "Thành Tiền";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.ReadOnly = true;
            this.colThanhTien.Width = 150;
            styleThanhTien.Format = "N0";
            styleThanhTien.ForeColor = System.Drawing.Color.DarkBlue;
            styleThanhTien.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.colThanhTien.DefaultCellStyle = styleThanhTien;

            this.dgvChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colMaHH, this.colTenHH, this.colDVT, this.colTonKho, this.colSL, this.colDonGia, this.colThanhTien
            });

            // 
            // FormPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);

            // CORRECT Z-ORDER FOR DOCKING:
            // Controls added last are at the "bottom" of the stack?
            // "The Z-order of the controls is determined by the order in which they are added... The first control added is at the top of the Z-order."
            // "Docking prioritizes controls at the top of the Z-order." (Wait, is it?)
            // Actually, if I add Fill first, it fills everything. Then Bottom tries to squeeze in? No.
            // Docking works best if we add Edges (Top, Bottom) first, then Fill last.
            // But User requested: 
            // "this.Controls.Add(this.pnlGrid); (Fill - Added Last or Sent to Back)"
            // "this.Controls.Add(this.pnlFooter); (Bottom - Added First or Brought to Front)"

            // Let's rely on BringToFront post-add if needed, but standard logic:
            // Add Grid (Fill)
            // Add Footer (Bottom)
            // Add Input (Top)
            // Add Header (Top)
            // This means Header is at Index 3 (if append)? No, Index 0 if Add inserts?
            // List<Control>.Add typically appends. 
            // So collection = [Grid, Footer, Input, Header].
            // If Docking processes reversed: Header(Top), Input(Top), Footer(Bottom), Grid(Fill).
            // This works!

            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.pnlHeader);

            this.Name = "FormPhieuXuat";
            this.Text = "LẬP PHIẾU XUẤT";

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlGrid;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSoPhieu;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label lblKhach;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Label lblTongTienLabel;
        private System.Windows.Forms.Label lblTongTien;

        private System.Windows.Forms.TextBox txtSoPhieu;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.CheckBox chkThanhToan;

        private DoAnLapTrinhQuanLy.Controls.ModernButton btnThem;
        private DoAnLapTrinhQuanLy.Controls.ModernButton btnIn;
        private DoAnLapTrinhQuanLy.Controls.ModernButton btnLuu;
        private DoAnLapTrinhQuanLy.Controls.ModernButton btnHuy;

        private DoAnLapTrinhQuanLy.Controls.ModernDataGrid dgvChiTiet;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTonKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
    }
}
