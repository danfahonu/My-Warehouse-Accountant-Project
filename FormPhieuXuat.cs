using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Transactions;
using DoAnLapTrinhQuanLy.Data;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormPhieuXuat : Form
    {
        private bool isAdding = false;
        private long currentSoPhieu = -1;

        public FormPhieuXuat()
        {
            InitializeComponent();
        }

        private void FormPhieuXuat_Load(object sender, EventArgs e)
        {
            ThemeManager.Apply(this);
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
                // Remove existing text column if it exists (auto-generated or from designer)
                if (dgvPhieuXuat.Columns.Contains("MAHH"))
                {
                    dgvPhieuXuat.Columns.Remove("MAHH");
                }

                DataGridViewComboBoxColumn cmbCol = new DataGridViewComboBoxColumn();
                cmbCol.HeaderText = "Hàng Hóa";
                cmbCol.Name = "MAHH";
                cmbCol.DataPropertyName = "MAHH"; // Bind to DataTable column if bound, or use as value holder

                string query = "SELECT MAHH, TENHH FROM DM_HANGHOA WHERE ACTIVE = 1";
                DataTable dt = DbHelper.Query(query);

                cmbCol.DataSource = dt;
                cmbCol.DisplayMember = "TENHH";
                cmbCol.ValueMember = "MAHH";
                cmbCol.Width = 200;
                cmbCol.AutoComplete = true;

                // Add to grid at first position
                dgvPhieuXuat.Columns.Insert(0, cmbCol);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách hàng hóa: " + ex.Message);
            }
        }

        private void ClearInputs()
        {
            txtSoPhieu.Texts = "(Phiếu mới)";
            dtpNgayLap.Value = DateTime.Now;
            cboKhachHang.SelectedIndex = -1;
            txtGhiChu.Texts = "";
            dgvPhieuXuat.Rows.Clear();
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
            dgvPhieuXuat.ReadOnly = !enable;

            btnLuu.Enabled = enable;
            btnHuy.Enabled = enable;
            btnThem.Enabled = !enable;
            btnGhiSo.Enabled = !enable && currentSoPhieu != -1;
        }

        #endregion

        #region Sự kiện

        public void BtnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            ClearInputs();
            SetInputMode(true);
            cboKhachHang.Focus();
        }

        public void BtnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboKhachHang.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn khách hàng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 1. Validate Stock Availability BEFORE Save
                foreach (DataGridViewRow row in dgvPhieuXuat.Rows)
                {
                    if (row.IsNewRow) continue;
                    string maHH = row.Cells["MAHH"].Value?.ToString();
                    if (string.IsNullOrEmpty(maHH)) continue;

                    int soLuongXuat = Convert.ToInt32(row.Cells["SL"].Value);

                    // Check current stock
                    object result = DbHelper.Scalar("SELECT TONKHO FROM DM_HANGHOA WHERE MAHH = @MAHH", DbHelper.Param("@MAHH", maHH));
                    int currentStock = result != null && result != DBNull.Value ? Convert.ToInt32(result) : 0;

                    if (soLuongXuat > currentStock)
                    {
                        MessageBox.Show($"Hàng hóa '{maHH}' không đủ tồn kho! Hiện tại còn: {currentStock}, Xuất: {soLuongXuat}", "Lỗi Tồn Kho", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Stop save
                    }
                }

                using (TransactionScope scope = new TransactionScope())
                {
                    if (isAdding)
                    {
                        string queryPhieu = @"
                            INSERT INTO PHIEU (NGAYLAP, LOAI, MAKH, GHICHU, TRANGTHAI)
                            OUTPUT INSERTED.SOPHIEU
                            VALUES (@NgayLap, 'X', @MaKH, @GhiChu, 0)";
                        object generatedId = DbHelper.Scalar(queryPhieu,
                            DbHelper.Param("@NgayLap", dtpNgayLap.Value),
                            DbHelper.Param("@MaKH", cboKhachHang.SelectedValue),
                            DbHelper.Param("@GhiChu", txtGhiChu.Texts)
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
                             DbHelper.Param("@GhiChu", txtGhiChu.Texts),
                             DbHelper.Param("@SoPhieu", currentSoPhieu)
                        );
                        DbHelper.Execute("DELETE FROM PHIEU_CT WHERE SOPHIEU = @SoPhieu", DbHelper.Param("@SoPhieu", currentSoPhieu));
                    }

                    foreach (DataGridViewRow row in dgvPhieuXuat.Rows)
                    {
                        if (row.IsNewRow) continue;
                        string maHH = row.Cells["MAHH"].Value?.ToString();
                        if (string.IsNullOrEmpty(maHH)) continue;

                        int soLuong = Convert.ToInt32(row.Cells["SL"].Value);
                        decimal donGia = Convert.ToDecimal(row.Cells["DONGIA"].Value);

                        // NO THANHTIEN in INSERT
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

                    scope.Complete();
                }

                MessageBox.Show("Lưu phiếu nháp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoPhieu.Texts = currentSoPhieu.ToString();
                isAdding = false;
                SetInputMode(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu phiếu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void BtnGhiSo_Click(object sender, EventArgs e)
        {
            if (currentSoPhieu == -1)
            {
                MessageBox.Show("Vui lòng lưu phiếu trước khi ghi sổ.", "Thông báo");
                return;
            }

            if (MessageBox.Show("Sau khi ghi sổ sẽ không thể sửa đổi. Bạn có chắc chắn muốn tiếp tục?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    // 1. Re-Verify Stock before final commit (Concurrency check)
                    var dtChiTietXuat = DbHelper.Query(
                        "SELECT MAHH, SL FROM PHIEU_CT WHERE SOPHIEU = @SoPhieu",
                        DbHelper.Param("@SoPhieu", currentSoPhieu));

                    foreach (DataRow rowXuat in dtChiTietXuat.Rows)
                    {
                        string maHH = rowXuat["MAHH"].ToString();
                        int soLuongXuat = Convert.ToInt32(rowXuat["SL"]);

                        object result = DbHelper.Scalar("SELECT TONKHO FROM DM_HANGHOA WHERE MAHH = @MAHH", DbHelper.Param("@MAHH", maHH));
                        int currentStock = result != null && result != DBNull.Value ? Convert.ToInt32(result) : 0;

                        if (soLuongXuat > currentStock)
                        {
                            throw new Exception($"Hàng hóa '{maHH}' không đủ tồn kho để ghi sổ! Hiện tại còn: {currentStock}");
                        }
                    }

                    // 2. Update Status to 1 (Completed)
                    // NOTE: We do NOT insert into KHO_CHITIET_TONKHO for Exports.
                    // The system assumes a Trigger on PHIEU/PHIEU_CT or DM_HANGHOA handles the stock deduction,
                    // OR that KHO_CHITIET_TONKHO is strictly for Inbound batches.

                    DbHelper.Execute("UPDATE PHIEU SET TRANGTHAI = 1 WHERE SOPHIEU = @SoPhieu",
                        DbHelper.Param("@SoPhieu", currentSoPhieu));

                    scope.Complete();
                }

                MessageBox.Show("Ghi sổ thành công! Hàng đã được xuất khỏi kho.", "Thành công");
                SetInputMode(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi sổ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DgvPhieuXuat_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvPhieuXuat.Rows[e.RowIndex];

            // Tự động điền giá bán khi chọn hàng hóa
            if (e.ColumnIndex == dgvPhieuXuat.Columns["MAHH"].Index)
            {
                string maHH = row.Cells["MAHH"].Value?.ToString();
                if (!string.IsNullOrEmpty(maHH))
                {
                    object giaBan = DbHelper.Scalar("SELECT GIABAN FROM DM_HANGHOA WHERE MAHH = @maHH", DbHelper.Param("@maHH", maHH));
                    row.Cells["DONGIA"].Value = giaBan;
                }
            }

            // Tự động tính thành tiền
            if (e.ColumnIndex == dgvPhieuXuat.Columns["SL"].Index || e.ColumnIndex == dgvPhieuXuat.Columns["DONGIA"].Index)
            {
                int soLuong = Convert.ToInt32(row.Cells["SL"].Value ?? 0);
                decimal donGia = Convert.ToDecimal(row.Cells["DONGIA"].Value ?? 0);
                row.Cells["THANHTIEN"].Value = soLuong * donGia;

                // Cập nhật tổng tiền
                decimal tongTien = 0;
                foreach (DataGridViewRow r in dgvPhieuXuat.Rows)
                {
                    tongTien += Convert.ToDecimal(r.Cells["THANHTIEN"].Value ?? 0);
                }
                lblTongTien.Text = tongTien.ToString("N0");
            }
        }

        public void BtnHuy_Click(object sender, EventArgs e)
        {
            ClearInputs();
            SetInputMode(false);
            isAdding = false;
        }

        #endregion
    }
}
