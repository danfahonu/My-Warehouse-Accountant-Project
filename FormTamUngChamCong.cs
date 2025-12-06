using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Transactions;
using DoAnLapTrinhQuanLy.Data;
using DoAnLapTrinhQuanLy.Core;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormTamUngChamCong : BaseForm
    {
        public FormTamUngChamCong()
        {
            InitializeComponent();
            UseCustomTitleBar = false;
        }

        private void FormTamUngChamCong_Load(object sender, EventArgs e)
        {
            // ThemeManager.Apply(this);
            LoadComboBoxNhanVien();
            numThang.Value = DateTime.Now.Month;
            numNam.Value = DateTime.Now.Year;
            LoadDataChamCong();
            LoadDataTamUng();
            SetInputMode(false);
        }

        #region Xử lý dữ liệu và ComboBox

        private void LoadComboBoxNhanVien()
        {
            try
            {
                string query = "SELECT MANV, HOTEN FROM NHANVIEN WHERE HOATDONG = 1";
                DataTable dt = DbHelper.Query(query);
                cboNhanVien.DataSource = dt;
                cboNhanVien.DisplayMember = "HOTEN";
                cboNhanVien.ValueMember = "MANV";
                cboNhanVien.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách nhân viên: " + ex.Message);
            }
        }

        private void LoadDataChamCong()
        {
            try
            {
                string query = @"
                    SELECT bc.ID, nv.HOTEN, bc.THANG, bc.NAM, bc.NGAYCONG, bc.GHICHU 
                    FROM BANGCHAMCONG bc
                    JOIN NHANVIEN nv ON bc.MANV = nv.MANV
                    WHERE bc.THANG = @Thang AND bc.NAM = @Nam";
                DataTable dt = DbHelper.Query(query,
                                    DbHelper.Param("@Thang", numThang.Value),
                                    DbHelper.Param("@Nam", numNam.Value));
                dgvChamCong.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu chấm công: " + ex.Message);
            }
        }

        private void LoadDataTamUng()
        {
            try
            {
                string query = @"
                    SELECT tu.ID, nv.HOTEN, tu.NGAY, tu.SOTIEN, tu.GHICHU
                    FROM TAMUNG tu
                    JOIN NHANVIEN nv ON tu.MANV = nv.MANV
                    WHERE MONTH(tu.NGAY) = @Thang AND YEAR(tu.NGAY) = @Nam";
                DataTable dt = DbHelper.Query(query,
                                    DbHelper.Param("@Thang", numThang.Value),
                                    DbHelper.Param("@Nam", numNam.Value));
                dgvTamUng.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu tạm ứng: " + ex.Message);
            }
        }

        private void ClearInputs()
        {
            cboNhanVien.SelectedIndex = -1;
            numNgayCong.Value = 0;
            txtGhiChuCC.Text = "";
            numSoTien.Value = 0;
            txtGhiChuTU.Text = "";
        }

        #endregion

        #region Quản lý trạng thái giao diện (UX)

        private void SetInputMode(bool enable)
        {
            btnLuu.Enabled = enable;
            btnHuy.Enabled = enable;
            btnThem.Enabled = !enable;

            gbChamCong.Enabled = enable;
            gbTamUng.Enabled = enable;
            cboNhanVien.Enabled = enable;

            numThang.Enabled = !enable;
            numNam.Enabled = !enable;
            btnXem.Enabled = !enable;
        }

        #endregion

        #region Sự kiện

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearInputs();
            SetInputMode(true);
            cboNhanVien.Focus();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadDataChamCong();
            LoadDataTamUng();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboNhanVien.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn một nhân viên.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    bool daLuu = false;
                    // Xử lý lưu Chấm công
                    if (numNgayCong.Value > 0)
                    {
                        object existingId = DbHelper.Scalar(@"
                            SELECT ID FROM BANGCHAMCONG 
                            WHERE MANV = @MaNV AND THANG = @Thang AND NAM = @Nam",
                            DbHelper.Param("@MaNV", cboNhanVien.SelectedValue),
                            DbHelper.Param("@Thang", numThang.Value),
                            DbHelper.Param("@Nam", numNam.Value)
                        );

                        if (existingId != null)
                        {
                            DbHelper.Execute(@"
                                UPDATE BANGCHAMCONG SET NGAYCONG = @NgayCong, GHICHU = @GhiChu 
                                WHERE ID = @ID",
                                DbHelper.Param("@NgayCong", numNgayCong.Value),
                                DbHelper.Param("@GhiChu", txtGhiChuCC.Text),
                                DbHelper.Param("@ID", existingId)
                            );
                        }
                        else
                        {
                            DbHelper.Execute(@"
                                INSERT INTO BANGCHAMCONG (MANV, THANG, NAM, NGAYCONG, GHICHU)
                                VALUES (@MaNV, @Thang, @Nam, @NgayCong, @GhiChu)",
                                DbHelper.Param("@MaNV", cboNhanVien.SelectedValue),
                                DbHelper.Param("@Thang", numThang.Value),
                                DbHelper.Param("@Nam", numNam.Value),
                                DbHelper.Param("@NgayCong", numNgayCong.Value),
                                DbHelper.Param("@GhiChu", txtGhiChuCC.Text)
                            );
                        }
                        daLuu = true;
                    }

                    // Xử lý lưu Tạm ứng
                    if (numSoTien.Value > 0)
                    {
                        DbHelper.Execute(@"
                            INSERT INTO TAMUNG (MANV, NGAY, SOTIEN, GHICHU)
                            VALUES (@MaNV, @Ngay, @SoTien, @GhiChu)",
                            DbHelper.Param("@MaNV", cboNhanVien.SelectedValue),
                            DbHelper.Param("@Ngay", DateTime.Now.Date),
                            DbHelper.Param("@SoTien", numSoTien.Value),
                            DbHelper.Param("@GhiChu", txtGhiChuTU.Text)
                        );
                        daLuu = true;
                    }

                    if (daLuu)
                    {
                        scope.Complete();
                        MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataChamCong();
                        LoadDataTamUng();
                        SetInputMode(false);
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa nhập ngày công hoặc số tiền tạm ứng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearInputs();
            SetInputMode(false);
        }

        #endregion
    }
}