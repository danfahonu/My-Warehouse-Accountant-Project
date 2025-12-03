using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using DoAnLapTrinhQuanLy.Data;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormReportViewer : Form
    {
        public FormReportViewer()
        {
            InitializeComponent();
        }

        private void FormReportViewer_Load(object sender, EventArgs e)
        {
            ThemeManager.Apply(this);
            SetupReportTypes();
            dtpTuNgay.Value = DateTime.Now.AddDays(-30);
            dtpDenNgay.Value = DateTime.Now;
        }

        private void SetupReportTypes()
        {
            cboLoaiBaoCao.Items.Clear();
            cboLoaiBaoCao.Items.Add("Báo cáo Tồn Kho Tổng Hợp");
            cboLoaiBaoCao.Items.Add("Báo cáo Doanh Thu & Lợi Nhuận");
            cboLoaiBaoCao.Items.Add("Thẻ Kho (Chi tiết hàng hóa)");
            cboLoaiBaoCao.SelectedIndex = 0;
        }

        private void BtnXemBaoCao_Click(object sender, EventArgs e)
        {
            try
            {
                string reportType = cboLoaiBaoCao.SelectedItem.ToString();
                DataTable dt = new DataTable();

                if (reportType == "Báo cáo Tồn Kho Tổng Hợp")
                {
                    dt = DbHelper.Query("EXEC sp_Report_TonKhoTongHop @FromDate, @ToDate",
                        DbHelper.Param("@FromDate", dtpTuNgay.Value.Date),
                        DbHelper.Param("@ToDate", dtpDenNgay.Value.Date));
                }
                else if (reportType == "Báo cáo Doanh Thu & Lợi Nhuận")
                {
                    dt = DbHelper.Query("EXEC sp_Report_DoanhThuLoiNhuan @FromDate, @ToDate",
                        DbHelper.Param("@FromDate", dtpTuNgay.Value.Date),
                        DbHelper.Param("@ToDate", dtpDenNgay.Value.Date));
                }
                else if (reportType == "Thẻ Kho (Chi tiết hàng hóa)")
                {
                    if (string.IsNullOrWhiteSpace(txtFilter.Texts))
                    {
                        MessageBox.Show("Vui lòng nhập Mã Hàng để xem Thẻ Kho.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    dt = DbHelper.Query("EXEC sp_Report_TheKho @MaHH, @FromDate, @ToDate",
                        DbHelper.Param("@MaHH", txtFilter.Texts),
                        DbHelper.Param("@FromDate", dtpTuNgay.Value.Date),
                        DbHelper.Param("@ToDate", dtpDenNgay.Value.Date));
                }

                dgvBaoCao.DataSource = dt;
                FormatGrid();
                lblStatus.Text = $"Tìm thấy {dt.Rows.Count} dòng dữ liệu.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatGrid()
        {
            // Apply number formatting
            foreach (DataGridViewColumn col in dgvBaoCao.Columns)
            {
                if (col.ValueType == typeof(decimal) || col.ValueType == typeof(int) || col.ValueType == typeof(double))
                {
                    col.DefaultCellStyle.Format = "N0";
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
        }

        private void BtnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dgvBaoCao.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV Files (*.csv)|*.csv";
            sfd.FileName = "BaoCao_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        // Write Headers
                        for (int i = 0; i < dgvBaoCao.Columns.Count; i++)
                        {
                            sw.Write(dgvBaoCao.Columns[i].HeaderText);
                            if (i < dgvBaoCao.Columns.Count - 1) sw.Write(",");
                        }
                        sw.WriteLine();

                        // Write Rows
                        foreach (DataGridViewRow row in dgvBaoCao.Rows)
                        {
                            if (row.IsNewRow) continue;
                            for (int i = 0; i < dgvBaoCao.Columns.Count; i++)
                            {
                                string value = row.Cells[i].Value?.ToString().Replace(",", " ").Replace("\n", " ");
                                sw.Write(value);
                                if (i < dgvBaoCao.Columns.Count - 1) sw.Write(",");
                            }
                            sw.WriteLine();
                        }
                    }
                    MessageBox.Show("Xuất file thành công!", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất file: " + ex.Message);
                }
            }
        }
    }
}
