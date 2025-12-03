using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Data;

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
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                // Load approved requests (TRANGTHAI = 1)
                string sql = @"
                    SELECT 
                        ID,              -- Correct PK column name
                        NGAY_YEUCAU, 
                        MANV_YEUCAU, 
                        LYDO 
                    FROM PHIEU_YEUCAU_NHAPKHO 
                    WHERE TRANGTHAI = 1  -- Status 1 = Approved
                    AND TRANGTHAI != 3   -- Not yet Imported
                    ORDER BY NGAY_YEUCAU DESC";

                DataTable dt = DbHelper.Query(sql);
                dgvDanhSach.DataSource = dt;

                // Format Grid
                ThemeManager.Apply(this); // Re-apply to ensure grid styling
                dgvDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách phiếu yêu cầu: " + ex.Message);
            }
        }

        private void BtnChon_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.CurrentRow != null)
            {
                // Assuming first column is ID
                if (long.TryParse(dgvDanhSach.CurrentRow.Cells["ID"].Value.ToString(), out long id))
                {
                    SelectedYeuCauID = id;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu yêu cầu!");
            }
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
