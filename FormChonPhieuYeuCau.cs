using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Data;
using DoAnLapTrinhQuanLy.Core;
using System.Data.SqlClient;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormChonPhieuYeuCau : Form
    {
        public long SelectedYeuCauID { get; private set; } = 0;

        public FormChonPhieuYeuCau()
        {
            InitializeComponent();
        }

        private void FormChonPhieuYeuCau_Load(object sender, EventArgs e)
        {
            ThemeManager.Apply(this);

            // Set default date range (Last 30 days)
            dtpTuNgay.Value = DateTime.Now.AddDays(-30);
            dtpDenNgay.Value = DateTime.Now;

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                // Query to get Approved requests (TRANGTHAI = 2) within date range
                // Also excluding requests that are already imported (TRANGTHAI = 3) just in case, 
                // though the requirement only specified TRANGTHAI = 2. 
                // Adding TRANGTHAI = 2 ensures we only pick approved ones ready for import.
                string sql = @"
                    SELECT 
                        ID, 
                        NGAY_YEUCAU, 
                        MANV_YEUCAU, 
                        LYDO,
                        CASE 
                            WHEN TRANGTHAI = 1 THEN N'Chờ duyệt'
                            WHEN TRANGTHAI = 2 THEN N'Đã duyệt'
                            WHEN TRANGTHAI = 3 THEN N'Đã nhập'
                            ELSE N'Khác'
                        END as TRANGTHAI_TEXT
                    FROM PHIEU_YEUCAU_NHAPKHO 
                    WHERE TRANGTHAI = 2 
                    AND NGAY_YEUCAU BETWEEN @TuNgay AND @DenNgay
                    ORDER BY NGAY_YEUCAU DESC";

                // Adjust EndDate to include the full day (23:59:59)
                DateTime tuNgay = dtpTuNgay.Value.Date;
                DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1).AddSeconds(-1);

                DataTable dt = DbHelper.Query(sql,
                    DbHelper.Param("@TuNgay", tuNgay),
                    DbHelper.Param("@DenNgay", denNgay)
                );

                dgvDanhSach.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            ConfirmSelection();
        }

        private void dgvDanhSach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ConfirmSelection();
            }
        }

        private void ConfirmSelection()
        {
            if (dgvDanhSach.CurrentRow != null)
            {
                if (long.TryParse(dgvDanhSach.CurrentRow.Cells["colID"].Value.ToString(), out long id))
                {
                    SelectedYeuCauID = id;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu yêu cầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
