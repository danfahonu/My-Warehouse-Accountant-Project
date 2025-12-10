using System;
using System.Data;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Services;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormChonPhieuYeuCau : Form
    {
        private readonly YeuCauNhapKhoService _service = new YeuCauNhapKhoService();
        public long SelectedYeuCauID { get; private set; } = 0; // Biến trả về ID

        public FormChonPhieuYeuCau()
        {
            InitializeComponent();
        }

        private void FormChonPhieuYeuCau_Load(object sender, EventArgs e)
        {
            // Mặc định load 30 ngày gần đây
            dtpTuNgay.Value = DateTime.Now.AddDays(-30);
            dtpDenNgay.Value = DateTime.Now;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                // Gọi hàm lấy danh sách phiếu ĐANG CHỜ NHẬP (TRANGTHAI = 1 hoặc 2)
                DataTable dt = _service.GetListPhieuYeuCauChoNhap();

                // Lọc theo ngày (trên giao diện)
                // Lưu ý: Nếu muốn lọc từ SQL thì truyền tham số vào Service, ở đây tui lọc trên View cho nhanh
                if (dt != null)
                {
                    dt.DefaultView.RowFilter = $"NGAY_YEUCAU >= '{dtpTuNgay.Value:yyyy-MM-dd}' AND NGAY_YEUCAU <= '{dtpDenNgay.Value:yyyy-MM-dd 23:59:59}'";
                    dgvDanhSach.DataSource = dt.DefaultView;
                }

                SetupGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void SetupGrid()
        {
            // Format tên cột cho đẹp
            if (dgvDanhSach.Columns.Contains("ID"))
            {
                dgvDanhSach.Columns["ID"].HeaderText = "Mã Phiếu";
                dgvDanhSach.Columns["ID"].Width = 100;
            }
            if (dgvDanhSach.Columns.Contains("NGAY_YEUCAU"))
            {
                dgvDanhSach.Columns["NGAY_YEUCAU"].HeaderText = "Ngày Yêu Cầu";
                dgvDanhSach.Columns["NGAY_YEUCAU"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            if (dgvDanhSach.Columns.Contains("NGUOI_YEUCAU"))
                dgvDanhSach.Columns["NGUOI_YEUCAU"].HeaderText = "Người Yêu Cầu";

            if (dgvDanhSach.Columns.Contains("LYDO"))
                dgvDanhSach.Columns["LYDO"].Visible = false; // Ẩn bớt cho gọn
        }

        private void ConfirmSelection()
        {
            if (dgvDanhSach.CurrentRow != null)
            {
                // Lấy ID trả về
                SelectedYeuCauID = Convert.ToInt64(dgvDanhSach.CurrentRow.Cells["ID"].Value);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu.");
            }
        }

        // Sự kiện nút bấm
        private void btnTimKiem_Click(object sender, EventArgs e) => LoadData();
        private void btnChon_Click(object sender, EventArgs e) => ConfirmSelection();
        private void dgvDanhSach_DoubleClick(object sender, EventArgs e) => ConfirmSelection();
        private void btnHuy_Click(object sender, EventArgs e) { this.DialogResult = DialogResult.Cancel; this.Close(); }
    }
}