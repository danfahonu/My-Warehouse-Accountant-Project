namespace DoAnLapTrinhQuanLy.GuiLayer
{
    partial class FormDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new DoAnLapTrinhQuanLy.CustomControls.ModernPanel();
            this.lblGiaTriTon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new DoAnLapTrinhQuanLy.CustomControls.ModernPanel();
            this.lblSoMatHang = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new DoAnLapTrinhQuanLy.CustomControls.ModernPanel();
            this.lblTongTon = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new DoAnLapTrinhQuanLy.CustomControls.ModernPanel();
            this.lblHangSapHet = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new DoAnLapTrinhQuanLy.CustomControls.ModernPanel();
            this.chartNhomHang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new DoAnLapTrinhQuanLy.CustomControls.DarkTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvTopSoLuong = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvTopGiaTri = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartNhomHang)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopSoLuong)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopGiaTri)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 461);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderRadius = 30;
            this.panel1.Controls.Add(this.lblGiaTriTon);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.GradientAngle = 45F;
            this.panel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.panel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(254)))), ((int)(((byte)(157)))));
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblGiaTriTon
            // 
            this.lblGiaTriTon.AutoSize = true;
            this.lblGiaTriTon.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblGiaTriTon.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblGiaTriTon.Location = new System.Drawing.Point(15, 45);
            this.lblGiaTriTon.Name = "lblGiaTriTon";
            this.lblGiaTriTon.Size = new System.Drawing.Size(33, 37);
            this.lblGiaTriTon.TabIndex = 1;
            this.lblGiaTriTon.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(170)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giá Trị Tồn Kho";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderRadius = 30;
            this.panel2.Controls.Add(this.lblSoMatHang);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.GradientAngle = 45F;
            this.panel2.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(247)))), ((int)(((byte)(254)))));
            this.panel2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(231, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 100);
            this.panel2.TabIndex = 1;
            // 
            // lblSoMatHang
            // 
            this.lblSoMatHang.AutoSize = true;
            this.lblSoMatHang.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblSoMatHang.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSoMatHang.Location = new System.Drawing.Point(15, 45);
            this.lblSoMatHang.Name = "lblSoMatHang";
            this.lblSoMatHang.Size = new System.Drawing.Size(33, 37);
            this.lblSoMatHang.TabIndex = 1;
            this.lblSoMatHang.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(170)))), ((int)(((byte)(242)))));
            this.label3.Location = new System.Drawing.Point(15, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tổng số Mã hàng (SKU)";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderRadius = 30;
            this.panel3.Controls.Add(this.lblTongTon);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.GradientAngle = 45F;
            this.panel3.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.panel3.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.panel3.Location = new System.Drawing.Point(452, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(201, 100);
            this.panel3.TabIndex = 2;
            // 
            // lblTongTon
            // 
            this.lblTongTon.AutoSize = true;
            this.lblTongTon.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTongTon.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTongTon.Location = new System.Drawing.Point(15, 45);
            this.lblTongTon.Name = "lblTongTon";
            this.lblTongTon.Size = new System.Drawing.Size(33, 37);
            this.lblTongTon.TabIndex = 1;
            this.lblTongTon.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(170)))), ((int)(((byte)(242)))));
            this.label5.Location = new System.Drawing.Point(15, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng Tồn Kho";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderRadius = 30;
            this.panel4.Controls.Add(this.lblHangSapHet);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.GradientAngle = 45F;
            this.panel4.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(108)))));
            this.panel4.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(75)))), ((int)(((byte)(43)))));
            this.panel4.Location = new System.Drawing.Point(673, 10);
            this.panel4.Margin = new System.Windows.Forms.Padding(10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(201, 100);
            this.panel4.TabIndex = 3;
            // 
            // lblHangSapHet
            // 
            this.lblHangSapHet.AutoSize = true;
            this.lblHangSapHet.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblHangSapHet.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHangSapHet.Location = new System.Drawing.Point(15, 45);
            this.lblHangSapHet.Name = "lblHangSapHet";
            this.lblHangSapHet.Size = new System.Drawing.Size(33, 37);
            this.lblHangSapHet.TabIndex = 1;
            this.lblHangSapHet.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(170)))), ((int)(((byte)(242)))));
            this.label7.Location = new System.Drawing.Point(15, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Hàng sắp hết";
            // 
            // panel5
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel5, 2);
            this.panel5.Controls.Add(this.chartNhomHang);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 123);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10);
            this.panel5.Size = new System.Drawing.Size(436, 335);
            this.panel5.TabIndex = 4;
            // 
            // chartNhomHang
            // 
            this.chartNhomHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            chartArea1.Name = "ChartArea1";
            this.chartNhomHang.ChartAreas.Add(chartArea1);
            this.chartNhomHang.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartNhomHang.Legends.Add(legend1);
            this.chartNhomHang.Location = new System.Drawing.Point(10, 10);
            this.chartNhomHang.Name = "chartNhomHang";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartNhomHang.Series.Add(series1);
            this.chartNhomHang.Size = new System.Drawing.Size(416, 315);
            this.chartNhomHang.TabIndex = 0;
            this.chartNhomHang.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Tỷ trọng Giá trị tồn kho theo Nhóm hàng";
            this.chartNhomHang.Titles.Add(title1);
            // 
            // tabControl1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tabControl1, 2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(445, 123);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(436, 335);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvTopSoLuong);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(428, 309);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Top 5 theo Số lượng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvTopSoLuong
            // 
            this.dgvTopSoLuong.AllowUserToAddRows = false;
            this.dgvTopSoLuong.AllowUserToDeleteRows = false;
            this.dgvTopSoLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopSoLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopSoLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTopSoLuong.Location = new System.Drawing.Point(3, 3);
            this.dgvTopSoLuong.Name = "dgvTopSoLuong";
            this.dgvTopSoLuong.ReadOnly = true;
            this.dgvTopSoLuong.RowHeadersVisible = false;
            this.dgvTopSoLuong.Size = new System.Drawing.Size(422, 303);
            this.dgvTopSoLuong.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvTopGiaTri);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(428, 309);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Top 5 theo Giá trị";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvTopGiaTri
            // 
            this.dgvTopGiaTri.AllowUserToAddRows = false;
            this.dgvTopGiaTri.AllowUserToDeleteRows = false;
            this.dgvTopGiaTri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopGiaTri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopGiaTri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTopGiaTri.Location = new System.Drawing.Point(3, 3);
            this.dgvTopGiaTri.Name = "dgvTopGiaTri";
            this.dgvTopGiaTri.ReadOnly = true;
            this.dgvTopGiaTri.RowHeadersVisible = false;
            this.dgvTopGiaTri.Size = new System.Drawing.Size(422, 303);
            this.dgvTopGiaTri.TabIndex = 1;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormDashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartNhomHang)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopSoLuong)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopGiaTri)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DoAnLapTrinhQuanLy.CustomControls.ModernPanel panel1;
        private System.Windows.Forms.Label lblGiaTriTon;
        private System.Windows.Forms.Label label1;
        private DoAnLapTrinhQuanLy.CustomControls.ModernPanel panel2;
        private System.Windows.Forms.Label lblSoMatHang;
        private System.Windows.Forms.Label label3;
        private DoAnLapTrinhQuanLy.CustomControls.ModernPanel panel3;
        private System.Windows.Forms.Label lblTongTon;
        private System.Windows.Forms.Label label5;
        private DoAnLapTrinhQuanLy.CustomControls.ModernPanel panel4;
        private System.Windows.Forms.Label lblHangSapHet;
        private System.Windows.Forms.Label label7;
        private DoAnLapTrinhQuanLy.CustomControls.ModernPanel panel5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNhomHang;
        private DoAnLapTrinhQuanLy.CustomControls.DarkTabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvTopSoLuong;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvTopGiaTri;
    }
}