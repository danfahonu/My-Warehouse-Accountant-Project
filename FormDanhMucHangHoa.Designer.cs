namespace DoAnLapTrinhQuanLy.GuiLayer
{
    partial class FormDanhMucHangHoa
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.btnChonAnh = new DoAnLapTrinhQuanLy.Controls.ModernButton();
            this.picAnhDaiDien = new System.Windows.Forms.PictureBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.numGiaBan = new System.Windows.Forms.NumericUpDown();
            this.numGiaVon = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboNhomHang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnHuy = new DoAnLapTrinhQuanLy.Controls.ModernButton();
            this.btnLuu = new DoAnLapTrinhQuanLy.Controls.ModernButton();
            this.btnXoa = new DoAnLapTrinhQuanLy.Controls.ModernButton();
            this.btnSua = new DoAnLapTrinhQuanLy.Controls.ModernButton();
            this.btnThem = new DoAnLapTrinhQuanLy.Controls.ModernButton();
            this.dgvHangHoa = new DoAnLapTrinhQuanLy.Controls.ModernDataGrid();
            this.pnlTop.SuspendLayout();
            this.pnlInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhDaiDien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaVon)).BeginInit();
            this.pnlActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1650, 92);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 23);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(386, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DANH MỤC HÀNG HÓA";
            // 
            // pnlInput
            // 
            this.pnlInput.BackColor = System.Drawing.Color.White;
            this.pnlInput.Controls.Add(this.btnChonAnh);
            this.pnlInput.Controls.Add(this.picAnhDaiDien);
            this.pnlInput.Controls.Add(this.chkActive);
            this.pnlInput.Controls.Add(this.numGiaBan);
            this.pnlInput.Controls.Add(this.numGiaVon);
            this.pnlInput.Controls.Add(this.label7);
            this.pnlInput.Controls.Add(this.label6);
            this.pnlInput.Controls.Add(this.txtDVT);
            this.pnlInput.Controls.Add(this.label5);
            this.pnlInput.Controls.Add(this.cboNhomHang);
            this.pnlInput.Controls.Add(this.label4);
            this.pnlInput.Controls.Add(this.txtTenHH);
            this.pnlInput.Controls.Add(this.label2);
            this.pnlInput.Controls.Add(this.txtMaHH);
            this.pnlInput.Controls.Add(this.label1);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInput.Location = new System.Drawing.Point(0, 92);
            this.pnlInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(1650, 277);
            this.pnlInput.TabIndex = 1;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnChonAnh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnChonAnh.BorderRadius = 20;
            this.btnChonAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonAnh.ForeColor = System.Drawing.Color.Black;
            this.btnChonAnh.Location = new System.Drawing.Point(825, 208);
            this.btnChonAnh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(180, 46);
            this.btnChonAnh.TabIndex = 14;
            this.btnChonAnh.Text = "Chọn Ảnh...";
            this.btnChonAnh.UseVisualStyleBackColor = false;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // picAnhDaiDien
            // 
            this.picAnhDaiDien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnhDaiDien.Location = new System.Drawing.Point(825, 14);
            this.picAnhDaiDien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picAnhDaiDien.Name = "picAnhDaiDien";
            this.picAnhDaiDien.Size = new System.Drawing.Size(179, 184);
            this.picAnhDaiDien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnhDaiDien.TabIndex = 13;
            this.picAnhDaiDien.TabStop = false;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Checked = true;
            this.chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActive.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkActive.Location = new System.Drawing.Point(570, 215);
            this.chkActive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(188, 32);
            this.chkActive.TabIndex = 12;
            this.chkActive.Text = "Đang kinh doanh";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // numGiaBan
            // 
            this.numGiaBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numGiaBan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numGiaBan.Location = new System.Drawing.Point(570, 165);
            this.numGiaBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numGiaBan.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numGiaBan.Name = "numGiaBan";
            this.numGiaBan.Size = new System.Drawing.Size(210, 34);
            this.numGiaBan.TabIndex = 11;
            this.numGiaBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numGiaBan.ThousandsSeparator = true;
            // 
            // numGiaVon
            // 
            this.numGiaVon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numGiaVon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numGiaVon.Location = new System.Drawing.Point(180, 165);
            this.numGiaVon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numGiaVon.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numGiaVon.Name = "numGiaVon";
            this.numGiaVon.Size = new System.Drawing.Size(210, 34);
            this.numGiaVon.TabIndex = 10;
            this.numGiaVon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numGiaVon.ThousandsSeparator = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(435, 168);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 28);
            this.label7.TabIndex = 9;
            this.label7.Text = "Giá bán:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(45, 168);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 28);
            this.label6.TabIndex = 8;
            this.label6.Text = "Giá vốn:";
            // 
            // txtDVT
            // 
            this.txtDVT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDVT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDVT.Location = new System.Drawing.Point(570, 115);
            this.txtDVT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(209, 34);
            this.txtDVT.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(435, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Đơn vị tính:";
            // 
            // cboNhomHang
            // 
            this.cboNhomHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhomHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboNhomHang.FormattingEnabled = true;
            this.cboNhomHang.Location = new System.Drawing.Point(570, 65);
            this.cboNhomHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboNhomHang.Name = "cboNhomHang";
            this.cboNhomHang.Size = new System.Drawing.Size(209, 36);
            this.cboNhomHang.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(435, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nhóm hàng:";
            // 
            // txtTenHH
            // 
            this.txtTenHH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenHH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenHH.Location = new System.Drawing.Point(180, 66);
            this.txtTenHH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.Size = new System.Drawing.Size(209, 34);
            this.txtTenHH.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(45, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên hàng:";
            // 
            // txtMaHH
            // 
            this.txtMaHH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaHH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaHH.Location = new System.Drawing.Point(180, 17);
            this.txtMaHH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(209, 34);
            this.txtMaHH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(45, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hàng:";
            // 
            // pnlActions
            // 
            this.pnlActions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlActions.Controls.Add(this.btnHuy);
            this.pnlActions.Controls.Add(this.btnLuu);
            this.pnlActions.Controls.Add(this.btnXoa);
            this.pnlActions.Controls.Add(this.btnSua);
            this.pnlActions.Controls.Add(this.btnThem);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlActions.Location = new System.Drawing.Point(0, 369);
            this.pnlActions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(1650, 92);
            this.pnlActions.TabIndex = 2;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.BackColor = System.Drawing.Color.White;
            this.btnHuy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnHuy.BorderRadius = 20;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.ForeColor = System.Drawing.Color.Black;
            this.btnHuy.Location = new System.Drawing.Point(1455, 15);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(150, 62);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnLuu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnLuu.BorderRadius = 20;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(1290, 15);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(150, 62);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu dữ liệu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnXoa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnXoa.BorderRadius = 20;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(360, 15);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(150, 62);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnSua.BorderRadius = 20;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(195, 15);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(150, 62);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnThem.BorderRadius = 20;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Location = new System.Drawing.Point(30, 15);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(150, 62);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.AllowUserToAddRows = false;
            this.dgvHangHoa.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvHangHoa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHangHoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHangHoa.BackgroundColor = System.Drawing.Color.White;
            this.dgvHangHoa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHangHoa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHangHoa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHangHoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(79)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHangHoa.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHangHoa.EnableHeadersVisualStyles = false;
            this.dgvHangHoa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.dgvHangHoa.Location = new System.Drawing.Point(0, 461);
            this.dgvHangHoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.ReadOnly = true;
            this.dgvHangHoa.RowHeadersVisible = false;
            this.dgvHangHoa.RowHeadersWidth = 62;
            this.dgvHangHoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHangHoa.Size = new System.Drawing.Size(1650, 616);
            this.dgvHangHoa.TabIndex = 3;
            this.dgvHangHoa.SelectionChanged += new System.EventHandler(this.dgvHangHoa_SelectionChanged);
            // 
            // FormDanhMucHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1650, 1077);
            this.Controls.Add(this.dgvHangHoa);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.pnlTop);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormDanhMucHangHoa";
            this.Text = "Quản Lý Hàng Hóa";
            this.Load += new System.EventHandler(this.FormDanhMucHangHoa_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhDaiDien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaVon)).EndInit();
            this.pnlActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Panel pnlActions;
        private DoAnLapTrinhQuanLy.Controls.ModernDataGrid dgvHangHoa;

        // Input Controls
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboNhomHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numGiaVon;
        private System.Windows.Forms.NumericUpDown numGiaBan;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.PictureBox picAnhDaiDien;
        private DoAnLapTrinhQuanLy.Controls.ModernButton btnChonAnh;

        // Action Buttons
        private DoAnLapTrinhQuanLy.Controls.ModernButton btnThem;
        private DoAnLapTrinhQuanLy.Controls.ModernButton btnSua;
        private DoAnLapTrinhQuanLy.Controls.ModernButton btnXoa;
        private DoAnLapTrinhQuanLy.Controls.ModernButton btnLuu;
        private DoAnLapTrinhQuanLy.Controls.ModernButton btnHuy;
    }
}