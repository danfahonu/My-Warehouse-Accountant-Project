using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Data;
using System.Data.SqlClient;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormNhanVien : Form
    {
        private bool isAdding = false;
        private string currentImagePath = null;

        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            ThemeManager.Apply(this);
            LoadData();
            LoadComboBoxChucVu();
            SetInputMode(false);
        }

        #region Xử lý dữ liệu

        private void LoadData()
        {
            try
            {
                string query = "SELECT MANV, HOTEN, CHUCVU, DIACHI, SDT, EMAIL, ANH, HOATDONG FROM NHANVIEN";
                DataTable dt = DbHelper.Query(query);
                dgvNhanVien.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadComboBoxChucVu()
        {
            try
            {
                string query = "SELECT CHUCVU FROM HESOLUONG";
                DataTable dt = DbHelper.Query(query);
                cboChucVu.DataSource = dt;
                cboChucVu.DisplayMember = "CHUCVU";
                cboChucVu.ValueMember = "CHUCVU";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách chức vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            txtMaNV.Texts = "";
            txtHoTen.Texts = "";
            txtDiaChi.Texts = "";
            txtSDT.Texts = "";
            txtEmail.Texts = "";
            cboChucVu.SelectedIndex = -1;
            chkHoatDong.Checked = true;
            picHinhAnh.Image = null;
            currentImagePath = null;
        }

        #endregion

        #region Quản lý trạng thái giao diện (UX)

        private void SetInputMode(bool enable)
        {
            txtMaNV.ReadOnly = !isAdding;
            txtHoTen.ReadOnly = !enable;
            txtDiaChi.ReadOnly = !enable;
            txtSDT.ReadOnly = !enable;
            txtEmail.ReadOnly = !enable;
            cboChucVu.Enabled = enable;
            chkHoatDong.Enabled = enable;
            btnBrowse.Enabled = enable;

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
            txtMaNV.Focus();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isAdding = false;
            SetInputMode(true);
            txtHoTen.Focus();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string maNV = dgvNhanVien.SelectedRows[0].Cells["MANV"].Value.ToString();
                    string query = "DELETE FROM NHANVIEN WHERE MANV = @MaNV";
                    DbHelper.Execute(query, DbHelper.Param("@MaNV", maNV));

                    LoadData();
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException sqlEx)
                {
                    if (sqlEx.Number == 547) // Foreign Key constraint violation
                    {
                        MessageBox.Show("Nhân viên này đang có dữ liệu liên quan (hóa đơn, phiếu nhập...), không thể xóa!", "Lỗi ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (string.IsNullOrWhiteSpace(txtMaNV.Texts) || string.IsNullOrWhiteSpace(txtHoTen.Texts))
                {
                    MessageBox.Show("Mã và Tên nhân viên không được để trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (isAdding)
                {
                    // Duplicate Validation
                    object count = DbHelper.Scalar("SELECT COUNT(*) FROM NHANVIEN WHERE MANV = @MaNV", DbHelper.Param("@MaNV", txtMaNV.Texts));
                    if (Convert.ToInt32(count) > 0)
                    {
                        MessageBox.Show("Mã nhân viên này đã tồn tại! Vui lòng chọn mã khác.", "Trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaNV.Focus();
                        return;
                    }

                    string query = @"
                        INSERT INTO NHANVIEN (MANV, HOTEN, CHUCVU, DIACHI, SDT, EMAIL, ANH, HOATDONG)
                        VALUES (@MaNV, @HoTen, @ChucVu, @DiaChi, @SDT, @Email, @Anh, @HoatDong)";
                    DbHelper.Execute(query,
                        DbHelper.Param("@MaNV", txtMaNV.Texts),
                        DbHelper.Param("@HoTen", txtHoTen.Texts),
                        DbHelper.Param("@ChucVu", cboChucVu.SelectedValue),
                        DbHelper.Param("@DiaChi", txtDiaChi.Texts),
                        DbHelper.Param("@SDT", txtSDT.Texts),
                        DbHelper.Param("@Email", txtEmail.Texts),
                        DbHelper.Param("@Anh", currentImagePath),
                        DbHelper.Param("@HoatDong", chkHoatDong.Checked)
                    );
                }
                else
                {
                    string query = @"
                        UPDATE NHANVIEN SET
                            HOTEN = @HoTen, CHUCVU = @ChucVu, DIACHI = @DiaChi, SDT = @SDT, 
                            EMAIL = @Email, ANH = @Anh, HOATDONG = @HoatDong
                        WHERE MANV = @MaNV";
                    DbHelper.Execute(query,
                        DbHelper.Param("@HoTen", txtHoTen.Texts),
                        DbHelper.Param("@ChucVu", cboChucVu.SelectedValue),
                        DbHelper.Param("@DiaChi", txtDiaChi.Texts),
                        DbHelper.Param("@SDT", txtSDT.Texts),
                        DbHelper.Param("@Email", txtEmail.Texts),
                        DbHelper.Param("@Anh", currentImagePath),
                        DbHelper.Param("@HoatDong", chkHoatDong.Checked),
                        DbHelper.Param("@MaNV", txtMaNV.Texts)
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
                DgvNhanVien_SelectionChanged(null, null);
            }
            else
            {
                ClearInputs();
            }
            SetInputMode(false);
            isAdding = false;
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                currentImagePath = openFile.FileName;
                picHinhAnh.Image = new Bitmap(currentImagePath);
            }
        }

        private void DgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (!isAdding && dgvNhanVien.SelectedRows.Count > 0)
            {
                var row = dgvNhanVien.SelectedRows[0];
                txtMaNV.Texts = row.Cells["MANV"].Value?.ToString();
                txtHoTen.Texts = row.Cells["HOTEN"].Value?.ToString();
                cboChucVu.SelectedValue = row.Cells["CHUCVU"].Value;
                txtDiaChi.Texts = row.Cells["DIACHI"].Value?.ToString();
                txtSDT.Texts = row.Cells["SDT"].Value?.ToString();
                txtEmail.Texts = row.Cells["EMAIL"].Value?.ToString();
                chkHoatDong.Checked = row.Cells["HOATDONG"].Value != null && (bool)row.Cells["HOATDONG"].Value;

                currentImagePath = row.Cells["ANH"].Value?.ToString();
                if (!string.IsNullOrEmpty(currentImagePath) && File.Exists(currentImagePath))
                {
                    picHinhAnh.Image = Image.FromFile(currentImagePath);
                }
                else
                {
                    picHinhAnh.Image = null;
                }
            }
        }

        #endregion
    }
}