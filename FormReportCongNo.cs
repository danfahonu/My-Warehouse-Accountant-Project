using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Services;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormReportCongNo : Form
    {
        private readonly CongNoService _service = new CongNoService();

        public FormReportCongNo()
        {
            InitializeComponent();
            // 3 DÒNG THẦN THÁNH
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        private void FormReportCongNo_Load(object sender, EventArgs e)
        {
            // Mặc định xem từ đầu tháng
            DateTime dauThang = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpTuKH.Value = dtpTuNCC.Value = dauThang;
            dtpDenKH.Value = dtpDenNCC.Value = DateTime.Now;
        }

        // 1. Xem Công Nợ Khách Hàng
        private void btnXemKH_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = _service.GetCongNoKhachHang(dtpTuKH.Value, dtpDenKH.Value);
                dgvKhachHang.DataSource = dt;
                FormatGrid(dgvKhachHang, "KH");
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        // 2. Xem Công Nợ NCC
        private void btnXemNCC_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = _service.GetCongNoNhaCungCap(dtpTuNCC.Value, dtpDenNCC.Value);
                dgvNCC.DataSource = dt;
                FormatGrid(dgvNCC, "NCC");
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        // Hàm định dạng cột dùng chung
        private void FormatGrid(DataGridView dgv, string type)
        {
            // Cột Thông tin
            if (type == "KH")
            {
                if (dgv.Columns.Contains("MAKH")) dgv.Columns["MAKH"].HeaderText = "Mã KH";
                if (dgv.Columns.Contains("TENKH")) { dgv.Columns["TENKH"].HeaderText = "Tên Khách Hàng"; dgv.Columns["TENKH"].Width = 200; }
            }
            else
            {
                if (dgv.Columns.Contains("MA_NCC")) dgv.Columns["MA_NCC"].HeaderText = "Mã NCC";
                if (dgv.Columns.Contains("TEN_NCC")) { dgv.Columns["TEN_NCC"].HeaderText = "Tên Nhà Cung Cấp"; dgv.Columns["TEN_NCC"].Width = 200; }
            }
            if (dgv.Columns.Contains("SDT")) { dgv.Columns["SDT"].HeaderText = "SĐT"; dgv.Columns["SDT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; }

            // Cột Số tiền (Đã khớp với SQL mới)
            string[] moneyCols = { "NO_DAU", "PS_TANG", "PS_GIAM", "NO_CUOI" };
            string[] headers = { "Dư Nợ Đầu", "Phát Sinh Tăng", "Phát Sinh Giảm", "Dư Nợ Cuối" };

            for (int i = 0; i < moneyCols.Length; i++)
            {
                if (dgv.Columns.Contains(moneyCols[i]))
                {
                    dgv.Columns[moneyCols[i]].HeaderText = headers[i];
                    dgv.Columns[moneyCols[i]].DefaultCellStyle.Format = "N0"; // Phân cách hàng nghìn
                    dgv.Columns[moneyCols[i]].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }

            // Tô đỏ cột Nợ Cuối cho dễ nhìn
            if (dgv.Columns.Contains("NO_CUOI"))
            {
                dgv.Columns["NO_CUOI"].DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                dgv.Columns["NO_CUOI"].DefaultCellStyle.ForeColor = Color.Red;
            }
        }
    }
}