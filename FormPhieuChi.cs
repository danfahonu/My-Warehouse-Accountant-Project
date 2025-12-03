using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Transactions;
using DoAnLapTrinhQuanLy.Data;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormPhieuChi : Form
    {
        private bool isAdding = false;
        private long currentSoPhieu = -1;

        public FormPhieuChi()
        {
            InitializeComponent();
        }

        private void FormPhieuChi_Load(object sender, EventArgs e)
        {
            ThemeManager.Apply(this);
            LoadComboBoxNhaCungCap();
            LoadComboBoxTaiKhoan();
            SetInputMode(false);
            ClearInputs();
        }

        #region Xử lý dữ liệu và ComboBox

        private void LoadComboBoxNhaCungCap()
        {
            try
            {
                string query = "SELECT MA_NCC, TEN_NCC FROM DM_NHACUNGCAP";
                DataTable dt = DbHelper.Query(query);
                cboNhaCungCap.DataSource = dt;
                cboNhaCungCap.DisplayMember = "TEN_NCC";
                cboNhaCungCap.ValueMember = "MA_NCC";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách nhà cung cấp: " + ex.Message);
            }
        }

        private void LoadComboBoxTaiKhoan()
        {
            try
            {
                // Tải các tài khoản tiền (Tiền mặt, Tiền gửi ngân hàng)
                string query = "SELECT SOTK, TENTK FROM DM_TAIKHOANKETOAN WHERE SOTK LIKE '111%' OR SOTK LIKE '112%'";
                DataTable dt = DbHelper.Query(query);
                cboTaiKhoan.DataSource = dt;
                cboTaiKhoan.DisplayMember = "TENTK";
                cboTaiKhoan.ValueMember = "SOTK";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách tài khoản: " + ex.Message);
            }
        }

        private void ClearInputs()
        {
            txtSoPhieu.Texts = "(Phiếu mới)";
            dtpNgayLap.Value = DateTime.Now;
            cboNhaCungCap.SelectedIndex = -1;
            cboTaiKhoan.SelectedIndex = -1;
            txtSoTien.Texts = "0";
            txtLyDo.Texts = "";
            currentSoPhieu = -1;
        }

        #endregion

        #region Quản lý trạng thái giao diện (UX)

        private void SetInputMode(bool enable)
        {
            dtpNgayLap.Enabled = enable;
            cboNhaCungCap.Enabled = enable;
            cboTaiKhoan.Enabled = enable;
            txtLyDo.ReadOnly = !enable;
            txtSoTien.ReadOnly = !enable;

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
            cboNhaCungCap.Focus();
        }

        public void BtnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboNhaCungCap.SelectedValue == null || cboTaiKhoan.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn nhà cung cấp và tài khoản.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (TransactionScope scope = new TransactionScope())
                {
                    if (isAdding)
                    {
                        // Tạo phiếu mới ở trạng thái Nháp, LOAI = 'C' (Chi)
                        string queryPhieu = @"
                            INSERT INTO PHIEUTHUCHI (NGAYLAP, LOAI, MA_NCC, SOTIEN, LYDO, SOTK_CO)
                            OUTPUT INSERTED.SOPTC
                            VALUES (@NgayLap, 'C', @MaNCC, @SoTien, @LyDo, @TkCo)";

                        object generatedId = DbHelper.Scalar(queryPhieu,
                            DbHelper.Param("@NgayLap", dtpNgayLap.Value),
                            DbHelper.Param("@MaNCC", cboNhaCungCap.SelectedValue),
                            DbHelper.Param("@SoTien", decimal.Parse(txtSoTien.Texts)),
                            DbHelper.Param("@LyDo", txtLyDo.Texts),
                            DbHelper.Param("@TkCo", cboTaiKhoan.SelectedValue)
                        );
                        currentSoPhieu = Convert.ToInt64(generatedId);
                    }
                    else
                    {
                        // Cập nhật thông tin phiếu đã có
                        string queryPhieu = @"
                            UPDATE PHIEUTHUCHI SET 
                                NGAYLAP = @NgayLap, MA_NCC = @MaNCC, SOTIEN = @SoTien, 
                                LYDO = @LyDo, SOTK_CO = @TkCo
                            WHERE SOPTC = @SoPhieu";
                        DbHelper.Execute(queryPhieu,
                             DbHelper.Param("@NgayLap", dtpNgayLap.Value),
                             DbHelper.Param("@MaNCC", cboNhaCungCap.SelectedValue),
                             DbHelper.Param("@SoTien", decimal.Parse(txtSoTien.Texts)),
                             DbHelper.Param("@LyDo", txtLyDo.Texts),
                             DbHelper.Param("@TkCo", cboTaiKhoan.SelectedValue),
                             DbHelper.Param("@SoPhieu", currentSoPhieu)
                        );
                    }
                    scope.Complete();
                }

                MessageBox.Show("Lưu phiếu chi nháp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (MessageBox.Show("Ghi sổ sẽ tạo bút toán kế toán và không thể sửa đổi. Bạn chắc chắn muốn tiếp tục?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    // Giả định TK Nợ là 331 - Phải trả cho người bán
                    string tkNo = "331";
                    string tkCo = cboTaiKhoan.SelectedValue.ToString();

                    string queryButToan = @"
                        INSERT INTO BUTTOAN_KETOAN (NGAY_HT, SO_CT, MA_CT, DIEN_GIAI, TK_NO, TK_CO, SOTIEN)
                        VALUES (@NgayHT, @SoCT, 'PC', @DienGiai, @TkNo, @TkCo, @SoTien)";

                    DbHelper.Execute(queryButToan,
                        DbHelper.Param("@NgayHT", dtpNgayLap.Value),
                        DbHelper.Param("@SoCT", currentSoPhieu.ToString()),
                        DbHelper.Param("@DienGiai", txtLyDo.Texts),
                        DbHelper.Param("@TkNo", tkNo),
                        DbHelper.Param("@TkCo", tkCo),
                        DbHelper.Param("@SoTien", decimal.Parse(txtSoTien.Texts))
                    );
                    scope.Complete();
                }

                MessageBox.Show("Ghi sổ thành công!", "Thành công");
                SetInputMode(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi sổ: " + ex.Message, "Lỗi");
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
