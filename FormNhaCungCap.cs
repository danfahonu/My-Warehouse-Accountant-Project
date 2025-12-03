using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Data; // Đảm bảo using này đúng

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormNhaCungCap : Form
    {
        private bool isAdding = false;

        public FormNhaCungCap()
        {
            InitializeComponent();
        }

        private void FormNhaCungCap_Load(object sender, EventArgs e)
        {
            ThemeManager.Apply(this);
            LoadData();
            SetInputMode(false); // Khóa giao diện khi mới mở
        }

        #region Xử lý dữ liệu

        private void LoadData()
        {
            try
            {
                string query = "SELECT MA_NCC, TEN_NCC, DIACHI_NCC, SDT, EMAIL, MSTHUE, GHICHU FROM DM_NHACUNGCAP";
                DataTable dt = DbHelper.Query(query);
                dgvNhaCungCap.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu nhà cung cấp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            txtMaNCC.Texts = "";
            txtTenNCC.Texts = "";
            txtDiaChi.Texts = "";
            txtSDT.Texts = "";
            txtEmail.Texts = "";
            txtMST.Texts = "";
            txtGhiChu.Texts = "";
        }

        #endregion

        #region Quản lý trạng thái giao diện (UX)

        private void SetInputMode(bool enable)
        {
            txtMaNCC.ReadOnly = !isAdding;
            txtTenNCC.ReadOnly = !enable;
            txtDiaChi.ReadOnly = !enable;
            txtSDT.ReadOnly = !enable;
            txtEmail.ReadOnly = !enable;
            txtMST.ReadOnly = !enable;
            txtGhiChu.ReadOnly = !enable;

            btnLuu.Enabled = enable;
            btnHuy.Enabled = enable;
            btnThem.Enabled = !enable;
            btnSua.Enabled = !enable;
            btnXoa.Enabled = !enable;
        }

        #endregion

        #region Sự kiện

        private void BtnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            ClearInputs();
            SetInputMode(true);
            txtMaNCC.Focus();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhaCungCap.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một nhà cung cấp để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isAdding = false;
            SetInputMode(true);
            txtTenNCC.Focus();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhaCungCap.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một nhà cung cấp để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string maNCC = dgvNhaCungCap.SelectedRows[0].Cells["MA_NCC"].Value.ToString();
                    string query = "DELETE FROM DM_NHACUNGCAP WHERE MA_NCC = @MaNCC";
                    DbHelper.Execute(query, DbHelper.Param("@MaNCC", maNCC));

                    LoadData();
                    MessageBox.Show("Xóa nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (System.Data.SqlClient.SqlException sqlEx)
                {
                    if (sqlEx.Number == 547) // Foreign Key constraint violation
                    {
                        MessageBox.Show("Nhà cung cấp này đang được sử dụng trong hệ thống, không thể xóa!", "Lỗi ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi SQL khi xóa: " + sqlEx.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaNCC.Texts) || string.IsNullOrWhiteSpace(txtTenNCC.Texts))
                {
                    MessageBox.Show("Mã và Tên nhà cung cấp không được để trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (isAdding)
                {
                    // Duplicate Validation
                    object count = DbHelper.Scalar("SELECT COUNT(*) FROM DM_NHACUNGCAP WHERE MA_NCC = @MaNCC", DbHelper.Param("@MaNCC", txtMaNCC.Texts));
                    if (Convert.ToInt32(count) > 0)
                    {
                        MessageBox.Show("Mã nhà cung cấp này đã tồn tại! Vui lòng chọn mã khác.", "Trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaNCC.Focus();
                        return;
                    }

                    string query = @"
                        INSERT INTO DM_NHACUNGCAP (MA_NCC, TEN_NCC, DIACHI_NCC, SDT, EMAIL, MSTHUE, GHICHU)
                        VALUES (@MaNCC, @TenNCC, @DiaChi, @SDT, @Email, @MST, @GhiChu)";
                    DbHelper.Execute(query,
                        DbHelper.Param("@MaNCC", txtMaNCC.Texts),
                        DbHelper.Param("@TenNCC", txtTenNCC.Texts),
                        DbHelper.Param("@DiaChi", txtDiaChi.Texts),
                        DbHelper.Param("@SDT", txtSDT.Texts),
                        DbHelper.Param("@Email", txtEmail.Texts),
                        DbHelper.Param("@MST", txtMST.Texts),
                        DbHelper.Param("@GhiChu", txtGhiChu.Texts)
                    );
                }
                else
                {
                    string query = @"
                        UPDATE DM_NHACUNGCAP SET
                            TEN_NCC = @TenNCC, DIACHI_NCC = @DiaChi, SDT = @SDT, 
                            EMAIL = @Email, MSTHUE = @MST, GHICHU = @GhiChu
                        WHERE MA_NCC = @MaNCC";
                    DbHelper.Execute(query,
                        DbHelper.Param("@TenNCC", txtTenNCC.Texts),
                        DbHelper.Param("@DiaChi", txtDiaChi.Texts),
                        DbHelper.Param("@SDT", txtSDT.Texts),
                        DbHelper.Param("@Email", txtEmail.Texts),
                        DbHelper.Param("@MST", txtMST.Texts),
                        DbHelper.Param("@GhiChu", txtGhiChu.Texts),
                        DbHelper.Param("@MaNCC", txtMaNCC.Texts)
                    );
                }
                MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                SetInputMode(false);
                isAdding = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            if (!isAdding)
            {
                DgvNhaCungCap_SelectionChanged(null, null);
            }
            else
            {
                ClearInputs();
            }
            SetInputMode(false);
            isAdding = false;
        }

        private void DgvNhaCungCap_SelectionChanged(object sender, EventArgs e)
        {
            if (!isAdding && dgvNhaCungCap.SelectedRows.Count > 0)
            {
                var row = dgvNhaCungCap.SelectedRows[0];
                txtMaNCC.Texts = row.Cells["MA_NCC"].Value?.ToString();
                txtTenNCC.Texts = row.Cells["TEN_NCC"].Value?.ToString();
                txtDiaChi.Texts = row.Cells["DIACHI_NCC"].Value?.ToString();
                txtSDT.Texts = row.Cells["SDT"].Value?.ToString();
                txtEmail.Texts = row.Cells["EMAIL"].Value?.ToString();
                txtMST.Texts = row.Cells["MSTHUE"].Value?.ToString();
                txtGhiChu.Texts = row.Cells["GHICHU"].Value?.ToString();
            }
        }

        #endregion
    }
}