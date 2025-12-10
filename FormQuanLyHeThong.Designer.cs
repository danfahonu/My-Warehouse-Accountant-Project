namespace DoAnLapTrinhQuanLy.GuiLayer
{
    partial class FormQuanLyHeThong
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.grpList = new System.Windows.Forms.GroupBox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.grpDetail = new System.Windows.Forms.GroupBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.cboQuyen = new System.Windows.Forms.ComboBox();
            this.lblQuyen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.flowLayoutPanelBtn = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.grpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.grpDetail.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.flowLayoutPanelBtn.SuspendLayout();
            this.SuspendLayout();

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.splitContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Name = "FormQuanLyHeThong";
            this.Text = "Quản Lý Người Dùng";
            this.Load += new System.EventHandler(this.FormQuanLyHeThong_Load);

            // SplitContainer
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Size = new System.Drawing.Size(1000, 600);
            this.splitContainer.SplitterDistance = 600;
            this.splitContainer.TabIndex = 0;

            // --- LEFT ---
            this.grpList.Controls.Add(this.dgvUsers);
            this.grpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpList.Text = "Danh sách tài khoản";

            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.SelectionChanged += new System.EventHandler(this.dgvUsers_SelectionChanged);

            // --- RIGHT ---
            this.grpDetail.Controls.Add(this.chkActive);
            this.grpDetail.Controls.Add(this.cboNhanVien);
            this.grpDetail.Controls.Add(this.lblNhanVien);
            this.grpDetail.Controls.Add(this.cboQuyen);
            this.grpDetail.Controls.Add(this.lblQuyen);
            this.grpDetail.Controls.Add(this.txtHoTen);
            this.grpDetail.Controls.Add(this.lblHoTen);
            this.grpDetail.Controls.Add(this.txtMatKhau);
            this.grpDetail.Controls.Add(this.lblMatKhau);
            this.grpDetail.Controls.Add(this.txtTaiKhoan);
            this.grpDetail.Controls.Add(this.lblTaiKhoan);
            this.grpDetail.Controls.Add(this.pnlButtons);
            this.grpDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDetail.Text = "Thông tin chi tiết";

            // --- TỌA ĐỘ CỨNG (KHÔNG DÙNG BIẾN) ---

            // 1. Tài khoản (Y=40)
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Location = new System.Drawing.Point(20, 40);
            this.lblTaiKhoan.Text = "Username:";

            this.txtTaiKhoan.Location = new System.Drawing.Point(100, 37);
            this.txtTaiKhoan.Size = new System.Drawing.Size(250, 25);

            // 2. Mật khẩu (Y=90)
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(20, 90);
            this.lblMatKhau.Text = "Mật khẩu:";

            this.txtMatKhau.Location = new System.Drawing.Point(100, 87);
            this.txtMatKhau.Size = new System.Drawing.Size(250, 25);
            this.txtMatKhau.PasswordChar = '*';

            // 3. Họ tên (Y=140)
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(20, 140);
            this.lblHoTen.Text = "Họ tên:";

            this.txtHoTen.Location = new System.Drawing.Point(100, 137);
            this.txtHoTen.Size = new System.Drawing.Size(250, 25);

            // 4. Quyền (Y=190)
            this.lblQuyen.AutoSize = true;
            this.lblQuyen.Location = new System.Drawing.Point(20, 190);
            this.lblQuyen.Text = "Quyền:";

            this.cboQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuyen.Items.AddRange(new object[] { "ADMIN", "KHO", "KETOAN", "BANHANG", "USER" });
            this.cboQuyen.Location = new System.Drawing.Point(100, 187);
            this.cboQuyen.Size = new System.Drawing.Size(150, 25);

            // 5. Nhân viên (Y=240)
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Location = new System.Drawing.Point(20, 240);
            this.lblNhanVien.Text = "Nhân viên:";

            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.Location = new System.Drawing.Point(100, 237);
            this.cboNhanVien.Size = new System.Drawing.Size(250, 25);

            // 6. Checkbox (Y=290)
            this.chkActive.AutoSize = true;
            this.chkActive.Checked = true;
            this.chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActive.Location = new System.Drawing.Point(100, 290);
            this.chkActive.Text = "Đang hoạt động";

            // Buttons Panel
            this.pnlButtons.Controls.Add(this.flowLayoutPanelBtn);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Height = 70;

            this.flowLayoutPanelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelBtn.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelBtn.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanelBtn.Controls.Add(this.btnThoat);
            this.flowLayoutPanelBtn.Controls.Add(this.btnHuy);
            this.flowLayoutPanelBtn.Controls.Add(this.btnLuu);
            this.flowLayoutPanelBtn.Controls.Add(this.btnXoa);
            this.flowLayoutPanelBtn.Controls.Add(this.btnSua);
            this.flowLayoutPanelBtn.Controls.Add(this.btnThem);

            // Buttons
            this.btnThoat.Text = "Thoát"; this.btnThoat.Size = new System.Drawing.Size(80, 40); this.btnThoat.BackColor = System.Drawing.Color.Gray; this.btnThoat.ForeColor = System.Drawing.Color.White; this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            this.btnHuy.Text = "Hủy"; this.btnHuy.Size = new System.Drawing.Size(80, 40); this.btnHuy.BackColor = System.Drawing.Color.OrangeRed; this.btnHuy.ForeColor = System.Drawing.Color.White; this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            this.btnLuu.Text = "Lưu"; this.btnLuu.Size = new System.Drawing.Size(80, 40); this.btnLuu.BackColor = System.Drawing.Color.RoyalBlue; this.btnLuu.ForeColor = System.Drawing.Color.White; this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            this.btnXoa.Text = "Xóa"; this.btnXoa.Size = new System.Drawing.Size(80, 40); this.btnXoa.BackColor = System.Drawing.Color.Crimson; this.btnXoa.ForeColor = System.Drawing.Color.White; this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            this.btnSua.Text = "Sửa"; this.btnSua.Size = new System.Drawing.Size(80, 40); this.btnSua.BackColor = System.Drawing.Color.Teal; this.btnSua.ForeColor = System.Drawing.Color.White; this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            this.btnThem.Text = "Thêm"; this.btnThem.Size = new System.Drawing.Size(80, 40); this.btnThem.BackColor = System.Drawing.Color.ForestGreen; this.btnThem.ForeColor = System.Drawing.Color.White; this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.grpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.grpDetail.ResumeLayout(false);
            this.grpDetail.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.flowLayoutPanelBtn.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.GroupBox grpDetail;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.ComboBox cboQuyen;
        private System.Windows.Forms.Label lblQuyen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBtn;
        private System.Windows.Forms.Button btnThoat, btnHuy, btnLuu, btnXoa, btnSua, btnThem;
    }
}