using System;
using System.Data;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Services;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormChonPhieuYeuCau : Form
    {
        private readonly PhieuYeuCauService _service = new PhieuYeuCauService();
        public long SelectedYeuCauID { get; private set; }

        public FormChonPhieuYeuCau()
        {
            InitializeComponent();
        }

        private void FormChonPhieuYeuCau_Load(object sender, EventArgs e)
        {
            // Default Date Range: Last 30 Days
            dtpTuNgay.Value = DateTime.Now.AddDays(-30);
            dtpDenNgay.Value = DateTime.Now;

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                // Ensure End Date includes the whole day
                DateTime tuNgay = dtpTuNgay.Value.Date;
                DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1).AddSeconds(-1);

                DataTable dt = _service.GetDanhSachDaDuyet(tuNgay, denNgay);
                dgvDanhSach.DataSource = dt;

                SetupGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupGrid()
        {
            if (dgvDanhSach.Columns.Contains("ID"))
            {
                dgvDanhSach.Columns["ID"].HeaderText = "Số Phiếu";
                dgvDanhSach.Columns["ID"].Width = 100;
            }
            if (dgvDanhSach.Columns.Contains("NGAY_YEUCAU"))
            {
                dgvDanhSach.Columns["NGAY_YEUCAU"].HeaderText = "Ngày Yêu Cầu";
                dgvDanhSach.Columns["NGAY_YEUCAU"].Width = 150;
                dgvDanhSach.Columns["NGAY_YEUCAU"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            if (dgvDanhSach.Columns.Contains("NGUOI_YEU_CAU"))
            {
                dgvDanhSach.Columns["NGUOI_YEU_CAU"].HeaderText = "Người Yêu Cầu";
                dgvDanhSach.Columns["NGUOI_YEU_CAU"].Width = 200;
            }
            if (dgvDanhSach.Columns.Contains("LYDO"))
            {
                dgvDanhSach.Columns["LYDO"].HeaderText = "Lý Do";
                dgvDanhSach.Columns["LYDO"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            if (dgvDanhSach.Columns.Contains("TRANGTHAI_TEXT"))
            {
                dgvDanhSach.Columns["TRANGTHAI_TEXT"].HeaderText = "Trạng Thái";
                dgvDanhSach.Columns["TRANGTHAI_TEXT"].Width = 120;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ConfirmSelection()
        {
            if (dgvDanhSach.CurrentRow != null && dgvDanhSach.CurrentRow.Selected)
            {
                // Must verify the cell is not null
                var cell = dgvDanhSach.CurrentRow.Cells["ID"].Value;
                if (cell != null && long.TryParse(cell.ToString(), out long id))
                {
                    SelectedYeuCauID = id;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu yêu cầu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            ConfirmSelection();
        }

        private void dgvDanhSach_DoubleClick(object sender, EventArgs e)
        {
            ConfirmSelection();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}