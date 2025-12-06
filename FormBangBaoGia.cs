using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Data;
using DoAnLapTrinhQuanLy.Core;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormBangBaoGia : BaseForm
    {
        private bool isAdding = false;
        private long currentSoPhieu = -1; // -1 nghĩa là phiếu mới

        public FormBangBaoGia()
        {
            InitializeComponent();
            UseCustomTitleBar = false;
        }

        private void FormBangBaoGia_Load(object sender, EventArgs e)
        {
            LoadComboBoxKhachHang();
            SetupDataGridViewComboBox();
            SetInputMode(false);
            ClearInputs();
        }

        #region Xử lý dữ liệu và ComboBox

        private void LoadComboBoxKhachHang()
        {
            try
            {
                string query = "SELECT MAKH, TENKH FROM DANHMUCKHACHHANG";
                DataTable dt = DbHelper.Query(query);
                cboKhachHang.DataSource = dt;
                cboKhachHang.DisplayMember = "TENKH";
                cboKhachHang.ValueMember = "MAKH";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách khách hàng: " + ex.Message);
            }
        }

        private void SetupDataGridViewComboBox()
        {
            try
            {
                string query = "SELECT MAHH, TENHH FROM DM_HANGHOA WHERE ACTIVE = 1";
                DataTable dt = DbHelper.Query(query);

                DataGridViewComboBoxColumn cmbCol = dgvBaoGia.Columns["MAHH"] as DataGridViewComboBoxColumn;
                if (cmbCol != null)
                {
                    cmbCol.DataSource = dt;
                    cmbCol.DisplayMember = "TENHH";
                    cmbCol.ValueMember = "MAHH";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách hàng hóa: " + ex.Message);
            }
        }

        private void ClearInputs()
        {
            txtSoPhieu.Text = "(Báo giá mới)";
            dtpNgayLap.Value = DateTime.Now;
            cboKhachHang.SelectedIndex = -1;
            txtGhiChu.Text = "";
            dgvBaoGia.Rows.Clear();
            lblTongTien.Text = "0";
            currentSoPhieu = -1;
        }

        #endregion

        #region Quản lý trạng thái giao diện (UX)

        private void SetInputMode(bool enable)
        {
            dtpNgayLap.Enabled = enable;
            cboKhachHang.Enabled = enable;
            txtGhiChu.ReadOnly = !enable;
            dgvBaoGia.ReadOnly = !enable;

            btnLuu.Enabled = enable;
            btnHuy.Enabled = enable;
            btnThem.Enabled = !enable;

            btnIn.Enabled = !enable && currentSoPhieu != -1;
        }

        #endregion

        #region Sự kiện

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            ClearInputs();
            SetInputMode(true);
            cboKhachHang.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboKhachHang.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn khách hàng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (isAdding)
                {
                    string queryPhieu = @"
                        INSERT INTO PHIEU (NGAYLAP, LOAI, MAKH, GHICHU, TRANGTHAI)
                        OUTPUT INSERTED.SOPHIEU
                        VALUES (@NgayLap, 'B', @MaKH, @GhiChu, 0)";

                    object generatedId = DbHelper.Scalar(queryPhieu,
                        DbHelper.Param("@NgayLap", dtpNgayLap.Value),
                        DbHelper.Param("@MaKH", cboKhachHang.SelectedValue),
                        DbHelper.Param("@GhiChu", txtGhiChu.Text)
                    );
                    currentSoPhieu = Convert.ToInt64(generatedId);
                }
                else
                {
                    string queryPhieu = @"
                        UPDATE PHIEU SET NGAYLAP = @NgayLap, MAKH = @MaKH, GHICHU = @GhiChu
                        WHERE SOPHIEU = @SoPhieu";
                    DbHelper.Execute(queryPhieu,
                         DbHelper.Param("@NgayLap", dtpNgayLap.Value),
                         DbHelper.Param("@MaKH", cboKhachHang.SelectedValue),
                         DbHelper.Param("@GhiChu", txtGhiChu.Text),
                         DbHelper.Param("@SoPhieu", currentSoPhieu)
                    );
                    DbHelper.Execute("DELETE FROM PHIEU_CT WHERE SOPHIEU = @SoPhieu", DbHelper.Param("@SoPhieu", currentSoPhieu));
                }

                foreach (DataGridViewRow row in dgvBaoGia.Rows)
                {
                    if (row.IsNewRow) continue;
                    string maHH = row.Cells["MAHH"].Value?.ToString();
                    if (string.IsNullOrEmpty(maHH)) continue;

                    int soLuong = Convert.ToInt32(row.Cells["SL"].Value);
                    decimal donGia = Convert.ToDecimal(row.Cells["DONGIA"].Value);

                    string queryCT = @"
                        INSERT INTO PHIEU_CT (SOPHIEU, MAHH, SL, DONGIA)
                        VALUES (@SoPhieu, @MaHH, @SL, @DonGia)";
                    DbHelper.Execute(queryCT,
                        DbHelper.Param("@SoPhieu", currentSoPhieu),
                        DbHelper.Param("@MaHH", maHH),
                        DbHelper.Param("@SL", soLuong),
                        DbHelper.Param("@DonGia", donGia)
                    );
                }

                MessageBox.Show("Lưu báo giá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoPhieu.Text = currentSoPhieu.ToString();
                isAdding = false;
                SetInputMode(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu báo giá: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearInputs();
            SetInputMode(false);
            isAdding = false;
        }

        private void dgvBaoGia_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvBaoGia.Rows[e.RowIndex];

            if (e.ColumnIndex == dgvBaoGia.Columns["MAHH"].Index)
            {
                string maHH = row.Cells["MAHH"].Value?.ToString();
                if (!string.IsNullOrEmpty(maHH))
                {
                    object giaBan = DbHelper.Scalar("SELECT GIABAN FROM DM_HANGHOA WHERE MAHH = @maHH", DbHelper.Param("@maHH", maHH));
                    row.Cells["DONGIA"].Value = giaBan;
                }
            }

            if (e.ColumnIndex == dgvBaoGia.Columns["SL"].Index || e.ColumnIndex == dgvBaoGia.Columns["DONGIA"].Index)
            {
                int soLuong = Convert.ToInt32(row.Cells["SL"].Value ?? 0);
                decimal donGia = Convert.ToDecimal(row.Cells["DONGIA"].Value ?? 0);
                row.Cells["THANHTIEN"].Value = soLuong * donGia;

                decimal tongTien = 0;
                foreach (DataGridViewRow r in dgvBaoGia.Rows)
                {
                    tongTien += Convert.ToDecimal(r.Cells["THANHTIEN"].Value ?? 0);
                }
                lblTongTien.Text = tongTien.ToString("N0");
            }
        }

        #endregion
    }
}