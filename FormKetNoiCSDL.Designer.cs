namespace DoAnLapTrinhQuanLy.GuiLayer
{
    partial class FormKetNoiCSDL
    {
        #region
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.infoPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblServer = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lblDBName = new System.Windows.Forms.Label();
            this.txtDBName = new System.Windows.Forms.TextBox();
            this.lblAuth = new System.Windows.Forms.Label();
            this.cboAuthMode = new System.Windows.Forms.ComboBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnAttachDB = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.grpInfo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelButtons, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(450, 300);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.infoPanel);
            this.grpInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpInfo.Location = new System.Drawing.Point(3, 3);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(444, 244);
            this.grpInfo.TabIndex = 0;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Thông tin kết nối";
            // 
            // infoPanel
            // 
            this.infoPanel.ColumnCount = 2;
            this.infoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.infoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.infoPanel.Controls.Add(this.lblServer, 0, 0);
            this.infoPanel.Controls.Add(this.txtServer, 1, 0);
            this.infoPanel.Controls.Add(this.lblDBName, 0, 1);
            this.infoPanel.Controls.Add(this.txtDBName, 1, 1);
            this.infoPanel.Controls.Add(this.lblAuth, 0, 2);
            this.infoPanel.Controls.Add(this.cboAuthMode, 1, 2);
            this.infoPanel.Controls.Add(this.lblUser, 0, 3);
            this.infoPanel.Controls.Add(this.txtUser, 1, 3);
            this.infoPanel.Controls.Add(this.lblPassword, 0, 4);
            this.infoPanel.Controls.Add(this.txtPassword, 1, 4);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoPanel.Location = new System.Drawing.Point(3, 27);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Padding = new System.Windows.Forms.Padding(5);
            this.infoPanel.RowCount = 5;
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.infoPanel.Size = new System.Drawing.Size(438, 214);
            this.infoPanel.TabIndex = 0;
            // 
            // lblServer
            // 
            this.lblServer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(8, 10);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(61, 25);
            this.lblServer.TabIndex = 0;
            this.lblServer.Text = "Server";
            // 
            // txtServer
            // 
            this.txtServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtServer.Location = new System.Drawing.Point(128, 8);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(302, 31);
            this.txtServer.TabIndex = 1;
            // 
            // lblDBName
            // 
            this.lblDBName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDBName.AutoSize = true;
            this.lblDBName.Location = new System.Drawing.Point(8, 40);
            this.lblDBName.Name = "lblDBName";
            this.lblDBName.Size = new System.Drawing.Size(86, 35);
            this.lblDBName.TabIndex = 2;
            this.lblDBName.Text = "Tên Database";
            // 
            // txtDBName
            // 
            this.txtDBName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDBName.Location = new System.Drawing.Point(128, 43);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(302, 31);
            this.txtDBName.TabIndex = 3;
            // 
            // lblAuth
            // 
            this.lblAuth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAuth.AutoSize = true;
            this.lblAuth.Location = new System.Drawing.Point(8, 80);
            this.lblAuth.Name = "lblAuth";
            this.lblAuth.Size = new System.Drawing.Size(80, 25);
            this.lblAuth.TabIndex = 4;
            this.lblAuth.Text = "Xác thực";
            // 
            // cboAuthMode
            // 
            this.cboAuthMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAuthMode.FormattingEnabled = true;
            this.cboAuthMode.Location = new System.Drawing.Point(128, 78);
            this.cboAuthMode.Name = "cboAuthMode";
            this.cboAuthMode.Size = new System.Drawing.Size(302, 33);
            this.cboAuthMode.TabIndex = 5;
            this.cboAuthMode.SelectedIndexChanged += new System.EventHandler(this.cboAuthMode_SelectedIndexChanged);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(8, 115);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(86, 25);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "Tài khoản";
            // 
            // txtUser
            // 
            this.txtUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUser.Location = new System.Drawing.Point(128, 113);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(302, 31);
            this.txtUser.TabIndex = 7;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(8, 164);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(86, 25);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // txtPassword
            // 
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Location = new System.Drawing.Point(128, 148);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(302, 31);
            this.txtPassword.TabIndex = 9;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnThoat);
            this.panelButtons.Controls.Add(this.btnAttachDB);
            this.panelButtons.Controls.Add(this.btnTest);
            this.panelButtons.Controls.Add(this.btnSave);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.Location = new System.Drawing.Point(3, 253);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(444, 44);
            this.panelButtons.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(335, 6);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 32);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnAttachDB
            // 
            this.btnAttachDB.Location = new System.Drawing.Point(8, 6);
            this.btnAttachDB.Name = "btnAttachDB";
            this.btnAttachDB.Size = new System.Drawing.Size(119, 32);
            this.btnAttachDB.TabIndex = 2;
            this.btnAttachDB.Text = "Đính kèm CSDL...";
            this.btnAttachDB.UseVisualStyleBackColor = true;
            this.btnAttachDB.Click += new System.EventHandler(this.btnAttachDB_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(133, 6);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(95, 32);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "Kiểm tra";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(234, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 32);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu và Thoát";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormKetNoiCSDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 320);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormKetNoiCSDL";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấu hình Kết nối CSDL";
            this.Load += new System.EventHandler(this.FormKetNoiCSDL_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpInfo.ResumeLayout(false);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

#endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.TableLayoutPanel infoPanel;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label lblDBName;
        private System.Windows.Forms.TextBox txtDBName;
        private System.Windows.Forms.Label lblAuth;
        private System.Windows.Forms.ComboBox cboAuthMode;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnAttachDB;
        private System.Windows.Forms.Button btnThoat;
    }
}