using System;
using System.Data;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Services;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormBaoCaoKho : Form
    {
        private readonly BaoCaoKhoService _service = new BaoCaoKhoService();

        public FormBaoCaoKho()
        {
            InitializeComponent();
        }

        private void FormBaoCaoKho_Load(object sender, EventArgs e)
        {
            // Mặc định load tháng hiện tại
            DateTime now = DateTime.Now;
            dtpTuNgay.Value = new DateTime(now.Year, now.Month, 1);
            dtpDenNgay.Value = dtpTuNgay.Value.AddMonths(1).AddDays(-1);

            btnXem.PerformClick();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ Service
                DataTable dt = _service.GetNhapXuatTon(dtpTuNgay.Value, dtpDenNgay.Value);

                // Thêm cột Tồn Cuối vào DataTable (Tính toán = Đầu + Nhập - Xuất)
                if (!dt.Columns.Contains("CUOIKY"))
                    dt.Columns.Add("CUOIKY", typeof(int));

                long tongTon = 0;
                foreach (DataRow row in dt.Rows)
                {
                    int dau = Convert.ToInt32(row["DAUKY"]);
                    int nhap = Convert.ToInt32(row["NHAP"]);
                    int xuat = Convert.ToInt32(row["XUAT"]);
                    int cuoi = dau + nhap - xuat;

                    row["CUOIKY"] = cuoi;
                    tongTon += cuoi;
                }

                dgvBaoCao.DataSource = dt;
                FormatGrid();

                lblTongTon.Text = $"Tổng số lượng tồn kho toàn hệ thống: {tongTon:N0}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải báo cáo: " + ex.Message);
            }
        }

        private void FormatGrid()
        {
            if (dgvBaoCao.Columns.Contains("MAHH"))
            {
                dgvBaoCao.Columns["MAHH"].HeaderText = "Mã HH";
                dgvBaoCao.Columns["MAHH"].Width = 80;
            }
            if (dgvBaoCao.Columns.Contains("TENHH"))
            {
                dgvBaoCao.Columns["TENHH"].HeaderText = "Tên Hàng Hóa";
                dgvBaoCao.Columns["TENHH"].Width = 250;
            }
            if (dgvBaoCao.Columns.Contains("DVT"))
            {
                dgvBaoCao.Columns["DVT"].HeaderText = "ĐVT";
                dgvBaoCao.Columns["DVT"].Width = 60;
                dgvBaoCao.Columns["DVT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // Định dạng các cột số
            string[] cols = { "DAUKY", "NHAP", "XUAT", "CUOIKY" };
            string[] headers = { "Tồn Đầu", "Nhập Trong Kỳ", "Xuất Trong Kỳ", "Tồn Cuối" };

            for (int i = 0; i < cols.Length; i++)
            {
                if (dgvBaoCao.Columns.Contains(cols[i]))
                {
                    dgvBaoCao.Columns[cols[i]].HeaderText = headers[i];
                    dgvBaoCao.Columns[cols[i]].DefaultCellStyle.Format = "N0";
                    dgvBaoCao.Columns[cols[i]].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    // Highlight Tồn Cuối
                    if (cols[i] == "CUOIKY")
                    {
                        dgvBaoCao.Columns[cols[i]].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
                        dgvBaoCao.Columns[cols[i]].DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}