namespace DoAnLapTrinhQuanLy.GuiLayer
{
    partial class FormDangNhap
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
            this.pnlCard = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.chkTogglePassword = new System.Windows.Forms.CheckBox();
            this.panelPass = new System.Windows.Forms.Panel();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.lblPassLine = new System.Windows.Forms.Label();
            this.panelUser = new System.Windows.Forms.Panel();
            this.txtLoginUsername = new System.Windows.Forms.TextBox();
            this.lblUserLine = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlCard.SuspendLayout();
            this.panelPass.SuspendLayout();
            this.panelUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCard
            // 
            this.pnlCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlCard.Controls.Add(this.btnExit);
            this.pnlCard.Controls.Add(this.btnLogin);
            this.pnlCard.Controls.Add(this.chkTogglePassword);
            this.pnlCard.Controls.Add(this.panelPass);
            this.pnlCard.Controls.Add(this.panelUser);
            this.pnlCard.Controls.Add(this.lblHeader);
            this.pnlCard.Location = new System.Drawing.Point(-2, 3);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(391, 512);
            this.pnlCard.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(50, 320);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(300, 45);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "THOÁT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(50, 260);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(300, 45);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "ĐĂNG NHẬP";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnDangNhap_Click);
            // 
            // chkTogglePassword
            // 
            this.chkTogglePassword.AutoSize = true;
            this.chkTogglePassword.ForeColor = System.Drawing.Color.DimGray;
            this.chkTogglePassword.Location = new System.Drawing.Point(50, 220);
            this.chkTogglePassword.Name = "chkTogglePassword";
            this.chkTogglePassword.Size = new System.Drawing.Size(164, 32);
            this.chkTogglePassword.TabIndex = 3;
            this.chkTogglePassword.Text = "Hiện mật khẩu";
            this.chkTogglePassword.UseVisualStyleBackColor = true;
            this.chkTogglePassword.CheckedChanged += new System.EventHandler(this.ChkShowPassword_CheckedChanged);
            // 
            // panelPass
            // 
            this.panelPass.Controls.Add(this.txtLoginPassword);
            this.panelPass.Controls.Add(this.lblPassLine);
            this.panelPass.Location = new System.Drawing.Point(50, 160);
            this.panelPass.Name = "panelPass";
            this.panelPass.Size = new System.Drawing.Size(300, 50);
            this.panelPass.TabIndex = 2;
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLoginPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoginPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLoginPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtLoginPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtLoginPassword.Location = new System.Drawing.Point(0, 0);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.PasswordChar = '●';
            this.txtLoginPassword.Size = new System.Drawing.Size(300, 32);
            this.txtLoginPassword.TabIndex = 0;
            this.txtLoginPassword.Text = "123";
            // 
            // lblPassLine
            // 
            this.lblPassLine.BackColor = System.Drawing.Color.Silver;
            this.lblPassLine.Location = new System.Drawing.Point(0, 28);
            this.lblPassLine.Name = "lblPassLine";
            this.lblPassLine.Size = new System.Drawing.Size(300, 2);
            this.lblPassLine.TabIndex = 1;
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.txtLoginUsername);
            this.panelUser.Controls.Add(this.lblUserLine);
            this.panelUser.Location = new System.Drawing.Point(50, 90);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(300, 50);
            this.panelUser.TabIndex = 1;
            // 
            // txtLoginUsername
            // 
            this.txtLoginUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLoginUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoginUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLoginUsername.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtLoginUsername.ForeColor = System.Drawing.Color.DimGray;
            this.txtLoginUsername.Location = new System.Drawing.Point(0, 0);
            this.txtLoginUsername.Name = "txtLoginUsername";
            this.txtLoginUsername.Size = new System.Drawing.Size(300, 32);
            this.txtLoginUsername.TabIndex = 0;
            this.txtLoginUsername.Text = "admin";
            // 
            // lblUserLine
            // 
            this.lblUserLine.BackColor = System.Drawing.Color.Silver;
            this.lblUserLine.Location = new System.Drawing.Point(0, 28);
            this.lblUserLine.Name = "lblUserLine";
            this.lblUserLine.Size = new System.Drawing.Size(300, 2);
            this.lblUserLine.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(391, 80);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "ĐĂNG NHẬP";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(387, 512);
            this.Controls.Add(this.pnlCard);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập Hệ Thống";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.panelPass.ResumeLayout(false);
            this.panelPass.PerformLayout();
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.TextBox txtLoginUsername;
        private System.Windows.Forms.Label lblUserLine;
        private System.Windows.Forms.Panel panelPass;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Label lblPassLine;
        private System.Windows.Forms.CheckBox chkTogglePassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
    }
}