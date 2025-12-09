using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Data; // Chứa DbHelper

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormSoNhatKyChung : Form
    {
        public FormSoNhatKyChung()
        {
            InitializeComponent();
        }

        private void FormSoNhatKyChung_Load(object sender, EventArgs e)
        {
            // Mặc định load tháng hiện tại
            DateTime now = DateTime.Now;
            dtpTuNgay.Value = new DateTime(now.Year, now.Month, 1);
            dtpDenNgay.Value = dtpTuNgay.Value.AddMonths(1).AddDays(-1);

            LoadData(); // Load luôn cho nóng
        }

        private void LoadData()
        {
            try
            {
                // Query trực tiếp vào bảng BUTTOAN_KETOAN
                string sql = @"
                    SELECT NGAY_HT, SO_CT, MA_CT, DIEN_GIAI, TK_NO, TK_CO, SOTIEN 
                    FROM BUTTOAN_KETOAN 
                    WHERE NGAY_HT BETWEEN @TuNgay AND @DenNgay 
                    ORDER BY NGAY_HT DESC, ID DESC";

                DataTable dt = DbHelper.Query(sql,
                    DbHelper.Param("@TuNgay", dtpTuNgay.Value.Date),
                    DbHelper.Param("@DenNgay", dtpDenNgay.Value.Date.AddDays(1).AddSeconds(-1))); // Hết ngày

                dgvNhatKy.DataSource = dt;

                // Format cột
                FormatGrid();

                // Tính tổng tiền
                decimal tongTien = 0;
                foreach (DataRow row in dt.Rows)
                {
                    tongTien += row["SOTIEN"] != DBNull.Value ? Convert.ToDecimal(row["SOTIEN"]) : 0;
                }
                lblTongCong.Text = $"Tổng tiền phát sinh trong kỳ: {tongTien.ToString("N0")} VNĐ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải sổ nhật ký: " + ex.Message);
            }
        }

        private void FormatGrid()
        {
            if (dgvNhatKy.Columns.Contains("NGAY_HT"))
            {
                dgvNhatKy.Columns["NGAY_HT"].HeaderText = "Ngày HT";
                dgvNhatKy.Columns["NGAY_HT"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvNhatKy.Columns["NGAY_HT"].Width = 100;
            }
            if (dgvNhatKy.Columns.Contains("SO_CT"))
            {
                dgvNhatKy.Columns["SO_CT"].HeaderText = "Số CT";
                dgvNhatKy.Columns["SO_CT"].Width = 120;
            }
            if (dgvNhatKy.Columns.Contains("MA_CT"))
            {
                dgvNhatKy.Columns["MA_CT"].HeaderText = "Loại";
                dgvNhatKy.Columns["MA_CT"].Width = 60;
                dgvNhatKy.Columns["MA_CT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (dgvNhatKy.Columns.Contains("DIEN_GIAI"))
            {
                dgvNhatKy.Columns["DIEN_GIAI"].HeaderText = "Diễn giải";
                dgvNhatKy.Columns["DIEN_GIAI"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            if (dgvNhatKy.Columns.Contains("TK_NO"))
            {
                dgvNhatKy.Columns["TK_NO"].HeaderText = "TK Nợ";
                dgvNhatKy.Columns["TK_NO"].Width = 70;
                dgvNhatKy.Columns["TK_NO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (dgvNhatKy.Columns.Contains("TK_CO"))
            {
                dgvNhatKy.Columns["TK_CO"].HeaderText = "TK Có";
                dgvNhatKy.Columns["TK_CO"].Width = 70;
                dgvNhatKy.Columns["TK_CO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (dgvNhatKy.Columns.Contains("SOTIEN"))
            {
                dgvNhatKy.Columns["SOTIEN"].HeaderText = "Số Tiền";
                dgvNhatKy.Columns["SOTIEN"].Width = 120;
                dgvNhatKy.Columns["SOTIEN"].DefaultCellStyle.Format = "N0";
                dgvNhatKy.Columns["SOTIEN"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvNhatKy.Columns["SOTIEN"].DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}