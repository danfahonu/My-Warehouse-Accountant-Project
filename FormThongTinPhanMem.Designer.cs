namespace DoAnLapTrinhQuanLy.GuiLayer
{
    partial class FormThongTinPhanMem
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
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.table.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.ColumnCount = 2;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table.Controls.Add(this.lblTitle, 0, 0);
            this.table.Controls.Add(this.lblVersion, 0, 1);
            this.table.Controls.Add(this.lblAuthor, 0, 2);
            this.table.Controls.Add(this.txtTitle, 1, 0);
            this.table.Controls.Add(this.txtVersion, 1, 1);
            this.table.Controls.Add(this.txtAuthor, 1, 2);
            this.table.Controls.Add(this.btnThoat, 1, 3);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(10, 10);
            this.table.Name = "table";
            this.table.RowCount = 4;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table.Size = new System.Drawing.Size(380, 150);
            this.table.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(56, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Phần mềm";
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(3, 32);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(90, 25);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Phiên bản";
            // 
            // lblAuthor
            // 
            this.lblAuthor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(3, 62);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(65, 25);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Tác giả";
            // 
            // txtTitle
            // 
            this.txtTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitle.Location = new System.Drawing.Point(103, 3);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(274, 31);
            this.txtTitle.TabIndex = 3;
            // 
            // txtVersion
            // 
            this.txtVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVersion.Location = new System.Drawing.Point(103, 33);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.ReadOnly = true;
            this.txtVersion.Size = new System.Drawing.Size(274, 31);
            this.txtVersion.TabIndex = 4;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAuthor.Location = new System.Drawing.Point(103, 63);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(274, 31);
            this.txtAuthor.TabIndex = 5;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnThoat.Location = new System.Drawing.Point(279, 103);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(98, 33);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FormThongTinPhanMem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 170);
            this.Controls.Add(this.table);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormThongTinPhanMem";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin phần mềm";
            this.Load += new System.EventHandler(this.FormThongTinPhanMem_Load);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            this.ResumeLayout(false);

        }

#endregion

        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Button btnThoat;
    }
}