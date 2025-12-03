using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DoAnLapTrinhQuanLy.Data;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
        }

        private async void FormDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                ThemeManager.Apply(this);

                // Update Labels for new KPIs
                label1.Text = "Doanh Số Hôm Nay";
                label3.Text = "Tiền Mặt Hiện Có";
                label5.Text = "Giá Trị Tồn Kho";
                label7.Text = "Hàng Sắp Hết (<10)";

                this.Cursor = Cursors.WaitCursor;

                // Async Data Loading
                var kpiTask = Task.Run(() => GetKpiData());
                var chartTask = Task.Run(() => GetCategoryChartData());
                var topProductsTask = Task.Run(() => GetTopProductsData());

                await Task.WhenAll(kpiTask, chartTask, topProductsTask);

                var (sales, cash, stockValue, lowStock) = kpiTask.Result;
                var dtChart = chartTask.Result;
                var (dtQty, dtVal) = topProductsTask.Result;

                // Update UI
                lblGiaTriTon.Text = sales.ToString("N0");
                lblSoMatHang.Text = cash.ToString("N0");
                lblTongTon.Text = stockValue.ToString("N0");
                lblHangSapHet.Text = lowStock.ToString();

                // Chart
                BindCategoryChart(dtChart);

                // Grids
                dgvTopSoLuong.DataSource = dtQty;
                FormatGrid(dgvTopSoLuong);
                dgvTopGiaTri.DataSource = dtVal;
                FormatGrid(dgvTopGiaTri);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải Dashboard: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private (decimal, decimal, decimal, int) GetKpiData()
        {
            // 1. Doanh số hôm nay
            string salesQuery = @"
                SELECT ISNULL(SUM(ct.THANHTIEN), 0)
                FROM PHIEU p
                JOIN PHIEU_CT ct ON p.SOPHIEU = ct.SOPHIEU
                WHERE p.LOAI = 'X' AND p.TRANGTHAI = 1 AND p.NGAYLAP = CAST(GETDATE() AS DATE)";
            decimal sales = Convert.ToDecimal(DbHelper.Scalar(salesQuery));

            // 2. Tiền mặt hiện có
            string cashQuery = "SELECT ISNULL(SUM(CASE WHEN LOAI = 'T' THEN SOTIEN ELSE -SOTIEN END), 0) FROM PHIEUTHUCHI";
            decimal cash = Convert.ToDecimal(DbHelper.Scalar(cashQuery));

            // 3. Giá trị tồn kho
            string stockValueQuery = "SELECT ISNULL(SUM(SO_LUONG_TON * DON_GIA_NHAP), 0) FROM KHO_CHITIET_TONKHO";
            decimal stockValue = Convert.ToDecimal(DbHelper.Scalar(stockValueQuery));

            // 4. Hàng sắp hết
            string lowStockQuery = "SELECT COUNT(MAHH) FROM DM_HANGHOA WHERE ACTIVE = 1 AND TONKHO < 10";
            int lowStock = Convert.ToInt32(DbHelper.Scalar(lowStockQuery));

            return (sales, cash, stockValue, lowStock);
        }

        private DataTable GetCategoryChartData()
        {
            string query = @"
                SELECT 
                    nh.TENNHOM,
                    ISNULL(SUM(t.SO_LUONG_TON * t.DON_GIA_NHAP), 0) as TongGiaTri
                FROM KHO_CHITIET_TONKHO t
                JOIN DM_HANGHOA h ON t.MAHH = h.MAHH
                JOIN DM_NHOMHANG nh ON h.MANHOM = nh.MANHOM
                WHERE t.SO_LUONG_TON > 0
                GROUP BY nh.TENNHOM
                HAVING ISNULL(SUM(t.SO_LUONG_TON * t.DON_GIA_NHAP), 0) > 0";

            return DbHelper.Query(query);
        }

        private (DataTable, DataTable) GetTopProductsData()
        {
            // Top 5 theo số lượng
            string topQtyQuery = @"
                SELECT TOP 5 
                    h.TENHH AS [Tên Hàng], 
                    SUM(t.SO_LUONG_TON) as [Tồn Kho]
                FROM KHO_CHITIET_TONKHO t
                JOIN DM_HANGHOA h ON t.MAHH = h.MAHH
                WHERE t.SO_LUONG_TON > 0
                GROUP BY h.TENHH
                ORDER BY [Tồn Kho] DESC";
            DataTable dtQty = DbHelper.Query(topQtyQuery);

            // Top 5 theo giá trị
            string topValueQuery = @"
                SELECT TOP 5 
                    h.TENHH AS [Tên Hàng], 
                    SUM(t.SO_LUONG_TON * t.DON_GIA_NHAP) as [Giá Trị]
                FROM KHO_CHITIET_TONKHO t
                JOIN DM_HANGHOA h ON t.MAHH = h.MAHH
                WHERE t.SO_LUONG_TON > 0
                GROUP BY h.TENHH
                ORDER BY [Giá Trị] DESC";
            DataTable dtVal = DbHelper.Query(topValueQuery);

            return (dtQty, dtVal);
        }

        private void BindCategoryChart(DataTable dt)
        {
            chartNhomHang.DataSource = dt;
            chartNhomHang.Series["Series1"].XValueMember = "TENNHOM";
            chartNhomHang.Series["Series1"].YValueMembers = "TongGiaTri";
            chartNhomHang.Series["Series1"].Label = "#PERCENT{P0}";
            chartNhomHang.Series["Series1"].LegendText = "#VALX";
            chartNhomHang.DataBind();

            // Theme Chart
            chartNhomHang.BackColor = ThemeManager.SecondaryColor;
            chartNhomHang.ChartAreas[0].BackColor = ThemeManager.SecondaryColor;
            chartNhomHang.Legends[0].BackColor = ThemeManager.SecondaryColor;
            chartNhomHang.Legends[0].ForeColor = ThemeManager.TextColor;
        }

        private void FormatGrid(DataGridView dgv)
        {
            // Styling is handled by ThemeManager.Apply()
            // Only format columns here
            if (dgv.Columns.Count > 1)
            {
                dgv.Columns[1].DefaultCellStyle.Format = "N0";
                dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }
    }
}