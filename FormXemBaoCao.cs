using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormXemBaoCao : Form
    {
        private string _reportPath;
        private DataTable _data;
        private string _dataSetName;

        public FormXemBaoCao(string reportPath, DataTable data, string dataSetName)
        {
            InitializeComponent();
            _reportPath = reportPath;
            _data = data;
            _dataSetName = dataSetName;
            this.Load += FormXemBaoCao_Load;
        }

        private void FormXemBaoCao_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {
            try
            {
                this.reportViewer1.LocalReport.ReportPath = _reportPath;
                this.reportViewer1.LocalReport.DataSources.Clear();

                ReportDataSource rds = new ReportDataSource(_dataSetName, _data);
                this.reportViewer1.LocalReport.DataSources.Add(rds);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
