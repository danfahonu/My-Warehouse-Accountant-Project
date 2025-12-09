using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Data; // Dùng DbHelper

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
            // --- 3 DÒNG THẦN THÁNH ---
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        private async void FormDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadDataKhoAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải Dashboard: " + ex.Message);
            }
        }

        private async Task LoadDataKhoAsync()
        {
            // 1. KPI: Tổng giá trị tồn kho
            // (Số lượng tồn * Giá nhập) lấy từ bảng KHO_CHITIET_TONKHO
            string sqlGiaTri = @"SELECT ISNULL(SUM(SO_LUONG_TON * DON_GIA_NHAP), 0) FROM KHO_CHITIET_TONKHO";
            decimal tongGiaTri = Convert.ToDecimal(DbHelper.ExecuteScalar(sqlGiaTri));
            lblTongGiaTri.Text = tongGiaTri.ToString("N0") + " đ";

            // 2. KPI: Hàng sắp hết (Giả sử định mức < 10 là báo động)
            // Lấy từ bảng DM_HANGHOA hoặc tính tổng tồn từ kho
            string sqlSapHet = @"SELECT COUNT(*) FROM DM_HANGHOA WHERE TONKHO <= 10 AND HOATDONG = 1";
            int countSapHet = Convert.ToInt32(DbHelper.ExecuteScalar(sqlSapHet));
            lblCanhBao.Text = countSapHet.ToString() + " MÃ";

            // 3. KPI: Số phiếu nhập hôm nay (Loại 'N')
            string sqlPhieuNhap = @"SELECT COUNT(*) FROM PHIEU WHERE LOAI = 'N' AND CAST(NGAYLAP AS DATE) = CAST(GETDATE() AS DATE)";
            int countNhap = Convert.ToInt32(DbHelper.ExecuteScalar(sqlPhieuNhap));
            lblPhieuNhap.Text = countNhap.ToString() + " PHIẾU";

            // 4. KPI: Số phiếu xuất hôm nay (Loại 'X')
            string sqlPhieuXuat = @"SELECT COUNT(*) FROM PHIEU WHERE LOAI = 'X' AND CAST(NGAYLAP AS DATE) = CAST(GETDATE() AS DATE)";
            int countXuat = Convert.ToInt32(DbHelper.ExecuteScalar(sqlPhieuXuat));
            lblPhieuXuat.Text = countXuat.ToString() + " PHIẾU";

            // 5. CHART: Cơ cấu tồn kho theo Nhóm Hàng
            string sqlChart = @"
                SELECT nh.TENNHOM, SUM(k.SO_LUONG_TON * k.DON_GIA_NHAP) as GiaTri
                FROM KHO_CHITIET_TONKHO k
                JOIN DM_HANGHOA h ON k.MAHH = h.MAHH
                JOIN DM_NHOMHANG nh ON h.MANHOM = nh.MANHOM
                GROUP BY nh.TENNHOM
                HAVING SUM(k.SO_LUONG_TON * k.DON_GIA_NHAP) > 0";

            DataTable dtChart = DbHelper.Query(sqlChart);
            chartTonKho.DataSource = dtChart;
            chartTonKho.Series["TonKho"].XValueMember = "TENNHOM";
            chartTonKho.Series["TonKho"].YValueMembers = "GiaTri";
            chartTonKho.DataBind();

            // 6. GRID: Danh sách hàng sắp hết
            string sqlGrid = @"SELECT MAHH, TENHH, TONKHO, DVT 
                               FROM DM_HANGHOA 
                               WHERE TONKHO <= 10 AND HOATDONG = 1 
                               ORDER BY TONKHO ASC";

            DataTable dtCanhBao = DbHelper.Query(sqlGrid);
            dgvCanhBao.DataSource = dtCanhBao;

            // Format Grid
            if (dgvCanhBao.Columns.Contains("MAHH")) dgvCanhBao.Columns["MAHH"].HeaderText = "Mã Hàng";
            if (dgvCanhBao.Columns.Contains("TENHH")) dgvCanhBao.Columns["TENHH"].HeaderText = "Tên Hàng Hóa";
            if (dgvCanhBao.Columns.Contains("TONKHO"))
            {
                dgvCanhBao.Columns["TONKHO"].HeaderText = "Tồn";
                dgvCanhBao.Columns["TONKHO"].DefaultCellStyle.ForeColor = Color.Red;
                dgvCanhBao.Columns["TONKHO"].DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            }
            if (dgvCanhBao.Columns.Contains("DVT")) dgvCanhBao.Columns["DVT"].HeaderText = "ĐVT";
        }
    }
}