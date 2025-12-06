namespace DoAnLapTrinhQuanLy.GuiLayer
{
    partial class FormNhomHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNhom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenNhom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();

            // Custom Controls Declaration
            this.btnHuy = new DoAnLapTrinhQuanLy.Controls.ModernButton();
            this.btnLuu = new DoAnLapTrinhQuanLy.Controls.ModernButton();
            this.btnXoa = new DoAnLapTrinhQuanLy.Controls.ModernButton();
            this.btnSua = new DoAnLapTrinhQuanLy.Controls.ModernButton();
            this.btnThem = new DoAnLapTrinhQuanLy.Controls.ModernButton();
            this.dgvNhomHang = new DoAnLapTrinhQuanLy.Controls.ModernDataGrid();

            this.pnlHeader.SuspendLayout();
            this.pnlActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomHang)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42))))); // Dark Blue
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(900, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(20, 15);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(288, 30);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "QUẢN LÝ NHÓM HÀNG";
            // 
            // pnlActions
            // 
            this.pnlActions.BackColor = System.Drawing.Color.White;
            this.pnlActions.Controls.Add(this.btnHuy);
            this.pnlActions.Controls.Add(this.btnLuu);
            this.pnlActions.Controls.Add(this.btnXoa);
            this.pnlActions.Controls.Add(this.btnSua);
            this.pnlActions.Controls.Add(this.btnThem);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlActions.Location = new System.Drawing.Point(0, 60);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(900, 60);
            this.pnlActions.TabIndex = 1;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHuy.ForeColor = System.Drawing.Color.Black;
            this.btnHuy.Location = new System.Drawing.Point(780, 10);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 40);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42))))); // Primary
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(670, 10);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 40);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu dữ liệu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68))))); // Danger
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(240, 10);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 40);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(130, 10);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 40);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Location = new System.Drawing.Point(20, 10);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtMaNhom, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTenNhom, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtGhiChu, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 120);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(20);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 160);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhóm:";
            // 
            // txtMaNhom
            // 
            this.txtMaNhom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaNhom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaNhom.Location = new System.Drawing.Point(143, 27);
            this.txtMaNhom.Name = "txtMaNhom";
            this.txtMaNhom.Size = new System.Drawing.Size(734, 25);
            this.txtMaNhom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(23, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên nhóm:";
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenNhom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenNhom.Location = new System.Drawing.Point(143, 67);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.Size = new System.Drawing.Size(734, 25);
            this.txtTenNhom.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(23, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGhiChu.Location = new System.Drawing.Point(143, 107);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(734, 25);
            this.txtGhiChu.TabIndex = 9;
            // 
            // dgvNhomHang
            // 
            this.dgvNhomHang.AllowUserToAddRows = false;
            this.dgvNhomHang.AllowUserToDeleteRows = false;
            this.dgvNhomHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhomHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhomHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNhomHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhomHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhomHang.Location = new System.Drawing.Point(0, 280);
            this.dgvNhomHang.Name = "dgvNhomHang";
            this.dgvNhomHang.ReadOnly = true;
            this.dgvNhomHang.RowHeadersVisible = false;
            this.dgvNhomHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhomHang.Size = new System.Drawing.Size(900, 320);
            this.dgvNhomHang.TabIndex = 3;
            this.dgvNhomHang.SelectionChanged += new System.EventHandler(this.dgvNhomHang_SelectionChanged);
            // 
            // FormNhomHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.dgvNhomHang);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FormNhomHang";
            this.Text = "Quan Ly Nhom Hang";
            this.Load += new System.EventHandler(this.FormNhomHang_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomHang)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNhom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenNhom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGhiChu;

        // CUSTOM CONTROLS
        private DoAnLapTrinhQuanLy.Controls.ModernButton btnThem;
        private DoAnLapTrinhQuanLy.Controls.ModernButton btnSua;
        private DoAnLapTrinhQuanLy.Controls.ModernButton btnXoa;
        private DoAnLapTrinhQuanLy.Controls.ModernButton btnLuu;
        private DoAnLapTrinhQuanLy.Controls.ModernButton btnHuy;
        private DoAnLapTrinhQuanLy.Controls.ModernDataGrid dgvNhomHang;
    }
}
