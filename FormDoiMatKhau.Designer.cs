namespace DoAnLapTrinhQuanLy.GuiLayer
{
    partial class FormDoiMatKhau
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.lblCu = new System.Windows.Forms.Label();
            this.txtCu = new System.Windows.Forms.TextBox();
            this.lblMoi = new System.Windows.Forms.Label();
            this.txtMoi = new System.Windows.Forms.TextBox();
            this.lblXacNhan = new System.Windows.Forms.Label();
            this.txtXacNhan = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Name = "FormDoiMatKhau";
            this.Text = "Đổi Mật Khẩu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // Controls (Số cứng)
            this.lblCu.Location = new System.Drawing.Point(30, 30); this.lblCu.Text = "Mật khẩu cũ:"; this.lblCu.AutoSize = true;
            this.txtCu.Location = new System.Drawing.Point(150, 27); this.txtCu.Size = new System.Drawing.Size(200, 25); this.txtCu.PasswordChar = '*';

            this.lblMoi.Location = new System.Drawing.Point(30, 80); this.lblMoi.Text = "Mật khẩu mới:"; this.lblMoi.AutoSize = true;
            this.txtMoi.Location = new System.Drawing.Point(150, 77); this.txtMoi.Size = new System.Drawing.Size(200, 25); this.txtMoi.PasswordChar = '*';

            this.lblXacNhan.Location = new System.Drawing.Point(30, 130); this.lblXacNhan.Text = "Xác nhận:"; this.lblXacNhan.AutoSize = true;
            this.txtXacNhan.Location = new System.Drawing.Point(150, 127); this.txtXacNhan.Size = new System.Drawing.Size(200, 25); this.txtXacNhan.PasswordChar = '*';

            this.btnLuu.Location = new System.Drawing.Point(150, 180); this.btnLuu.Text = "Đổi Pass"; this.btnLuu.Size = new System.Drawing.Size(90, 35);
            this.btnLuu.BackColor = System.Drawing.Color.RoyalBlue; this.btnLuu.ForeColor = System.Drawing.Color.White; this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);

            this.btnHuy.Location = new System.Drawing.Point(260, 180); this.btnHuy.Text = "Thoát"; this.btnHuy.Size = new System.Drawing.Size(90, 35);
            this.btnHuy.BackColor = System.Drawing.Color.Gray; this.btnHuy.ForeColor = System.Drawing.Color.White; this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);

            this.Controls.Add(this.lblCu); this.Controls.Add(this.txtCu);
            this.Controls.Add(this.lblMoi); this.Controls.Add(this.txtMoi);
            this.Controls.Add(this.lblXacNhan); this.Controls.Add(this.txtXacNhan);
            this.Controls.Add(this.btnLuu); this.Controls.Add(this.btnHuy);
        }

        private System.Windows.Forms.Label lblCu, lblMoi, lblXacNhan;
        private System.Windows.Forms.TextBox txtCu, txtMoi, txtXacNhan;
        private System.Windows.Forms.Button btnLuu, btnHuy;
    }
}