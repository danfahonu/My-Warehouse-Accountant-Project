namespace DoAnLapTrinhQuanLy.GuiLayer
{
    partial class FormDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();

            this.layoutMain = new System.Windows.Forms.TableLayoutPanel();

            // 4 Panel KPI KHO
            this.pnlKpi1 = new System.Windows.Forms.Panel();
            this.lblTongGiaTri = new System.Windows.Forms.Label();
            this.lblTitle1 = new System.Windows.Forms.Label();

            this.pnlKpi2 = new System.Windows.Forms.Panel();
            this.lblCanhBao = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();

            this.pnlKpi3 = new System.Windows.Forms.Panel();
            this.lblPhieuNhap = new System.Windows.Forms.Label();
            this.lblTitle3 = new System.Windows.Forms.Label();

            this.pnlKpi4 = new System.Windows.Forms.Panel();
            this.lblPhieuXuat = new System.Windows.Forms.Label();
            this.lblTitle4 = new System.Windows.Forms.Label();

            // Charts & Grids
            this.chartTonKho = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpCanhBao = new System.Windows.Forms.GroupBox();
            this.dgvCanhBao = new System.Windows.Forms.DataGridView();

            this.layoutMain.SuspendLayout();
            this.pnlKpi1.SuspendLayout();
            this.pnlKpi2.SuspendLayout();
            this.pnlKpi3.SuspendLayout();
            this.pnlKpi4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTonKho)).BeginInit();
            this.grpCanhBao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanhBao)).BeginInit();
            this.SuspendLayout();

            // Form Settings
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.layoutMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Name = "FormDashboard";
            this.Text = "Dashboard Quản Lý Kho";
            this.Load += new System.EventHandler(this.FormDashboard_Load);

            // Layout Main
            this.layoutMain.ColumnCount = 4;
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));

            this.layoutMain.RowCount = 2;
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));

            this.layoutMain.Controls.Add(this.pnlKpi1, 0, 0);
            this.layoutMain.Controls.Add(this.pnlKpi2, 1, 0);
            this.layoutMain.Controls.Add(this.pnlKpi3, 2, 0);
            this.layoutMain.Controls.Add(this.pnlKpi4, 3, 0);

            // Biểu đồ chiếm 2 cột trái
            this.layoutMain.Controls.Add(this.chartTonKho, 0, 1);
            this.layoutMain.SetColumnSpan(this.chartTonKho, 2);

            // Danh sách cảnh báo chiếm 2 cột phải
            this.layoutMain.Controls.Add(this.grpCanhBao, 2, 1);
            this.layoutMain.SetColumnSpan(this.grpCanhBao, 2);

            this.layoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMain.Padding = new System.Windows.Forms.Padding(10);

            // --- KPI 1: TỔNG GIÁ TRỊ TỒN (Xanh Dương - Vốn) ---
            this.pnlKpi1.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlKpi1.Controls.Add(this.lblTongGiaTri);
            this.pnlKpi1.Controls.Add(this.lblTitle1);
            this.pnlKpi1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKpi1.Margin = new System.Windows.Forms.Padding(5);

            this.lblTitle1.Text = "TỔNG GIÁ TRỊ TỒN KHO";
            this.lblTitle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitle1.Location = new System.Drawing.Point(10, 10);
            this.lblTitle1.AutoSize = true;

            this.lblTongGiaTri.Text = "0";
            this.lblTongGiaTri.ForeColor = System.Drawing.Color.White;
            this.lblTongGiaTri.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTongGiaTri.Location = new System.Drawing.Point(10, 40);
            this.lblTongGiaTri.AutoSize = true;

            // --- KPI 2: HÀNG SẮP HẾT (Đỏ - Cảnh báo) ---
            this.pnlKpi2.BackColor = System.Drawing.Color.Crimson;
            this.pnlKpi2.Controls.Add(this.lblCanhBao);
            this.pnlKpi2.Controls.Add(this.lblTitle2);
            this.pnlKpi2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKpi2.Margin = new System.Windows.Forms.Padding(5);

            this.lblTitle2.Text = "HÀNG SẮP HẾT (<10)";
            this.lblTitle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitle2.Location = new System.Drawing.Point(10, 10);
            this.lblTitle2.AutoSize = true;

            this.lblCanhBao.Text = "0";
            this.lblCanhBao.ForeColor = System.Drawing.Color.White;
            this.lblCanhBao.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblCanhBao.Location = new System.Drawing.Point(10, 40);
            this.lblCanhBao.AutoSize = true;

            // --- KPI 3: PHIẾU NHẬP (Xanh Lá - Vào kho) ---
            this.pnlKpi3.BackColor = System.Drawing.Color.ForestGreen;
            this.pnlKpi3.Controls.Add(this.lblPhieuNhap);
            this.pnlKpi3.Controls.Add(this.lblTitle3);
            this.pnlKpi3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKpi3.Margin = new System.Windows.Forms.Padding(5);

            this.lblTitle3.Text = "PHIẾU NHẬP HÔM NAY";
            this.lblTitle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitle3.Location = new System.Drawing.Point(10, 10);
            this.lblTitle3.AutoSize = true;

            this.lblPhieuNhap.Text = "0";
            this.lblPhieuNhap.ForeColor = System.Drawing.Color.White;
            this.lblPhieuNhap.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblPhieuNhap.Location = new System.Drawing.Point(10, 40);
            this.lblPhieuNhap.AutoSize = true;

            // --- KPI 4: PHIẾU XUẤT (Cam - Ra kho) ---
            this.pnlKpi4.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlKpi4.Controls.Add(this.lblPhieuXuat);
            this.pnlKpi4.Controls.Add(this.lblTitle4);
            this.pnlKpi4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKpi4.Margin = new System.Windows.Forms.Padding(5);

            this.lblTitle4.Text = "PHIẾU XUẤT HÔM NAY";
            this.lblTitle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitle4.Location = new System.Drawing.Point(10, 10);
            this.lblTitle4.AutoSize = true;

            this.lblPhieuXuat.Text = "0";
            this.lblPhieuXuat.ForeColor = System.Drawing.Color.White;
            this.lblPhieuXuat.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblPhieuXuat.Location = new System.Drawing.Point(10, 40);
            this.lblPhieuXuat.AutoSize = true;

            // --- CHART: CƠ CẤU TỒN KHO ---
            chartArea1.Name = "ChartArea1";
            this.chartTonKho.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTonKho.Legends.Add(legend1);
            this.chartTonKho.Name = "chartTonKho";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "TonKho";
            this.chartTonKho.Series.Add(series1);
            this.chartTonKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartTonKho.Margin = new System.Windows.Forms.Padding(5);
            title1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            title1.Text = "Tỷ trọng Giá trị Tồn kho theo Nhóm";
            title1.ForeColor = System.Drawing.Color.SteelBlue;
            this.chartTonKho.Titles.Add(title1);

            // --- LIST: CẢNH BÁO HÀNG HẾT ---
            this.grpCanhBao.Controls.Add(this.dgvCanhBao);
            this.grpCanhBao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCanhBao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpCanhBao.ForeColor = System.Drawing.Color.Crimson;
            this.grpCanhBao.Text = "Danh Sách Hàng Sắp Hết (Cần nhập thêm)";

            this.dgvCanhBao.BackgroundColor = System.Drawing.Color.White;
            this.dgvCanhBao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCanhBao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCanhBao.ReadOnly = true;
            this.dgvCanhBao.AllowUserToAddRows = false;
            this.dgvCanhBao.RowHeadersVisible = false;
            this.dgvCanhBao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.layoutMain.ResumeLayout(false);
            this.pnlKpi1.ResumeLayout(false); this.pnlKpi1.PerformLayout();
            this.pnlKpi2.ResumeLayout(false); this.pnlKpi2.PerformLayout();
            this.pnlKpi3.ResumeLayout(false); this.pnlKpi3.PerformLayout();
            this.pnlKpi4.ResumeLayout(false); this.pnlKpi4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTonKho)).EndInit();
            this.grpCanhBao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanhBao)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutMain;
        private System.Windows.Forms.Panel pnlKpi1, pnlKpi2, pnlKpi3, pnlKpi4;
        private System.Windows.Forms.Label lblTongGiaTri, lblTitle1;
        private System.Windows.Forms.Label lblCanhBao, lblTitle2;
        private System.Windows.Forms.Label lblPhieuNhap, lblTitle3;
        private System.Windows.Forms.Label lblPhieuXuat, lblTitle4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTonKho;
        private System.Windows.Forms.GroupBox grpCanhBao;
        private System.Windows.Forms.DataGridView dgvCanhBao;
    }
}