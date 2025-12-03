using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Transactions;
using DoAnLapTrinhQuanLy.Data;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormPhieuThu : Form
    {
        private bool isAdding = false;
        private long currentSoPhieu = -1;

        public FormPhieuThu()
        {
            InitializeComponent();
        }

        private void FormPhieuThu_Load(object sender, EventArgs e)
        {
            ThemeManager.Apply(this);
            LoadComboBoxKhachHang();
            LoadComboBoxTaiKhoan();
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
            cboKhachHang.SelectedIndex = -1;
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
            cboKhachHang.Enabled = enable;
            cboTaiKhoan.Enabled = enable;
            txtLyDo.ReadOnly = !enable;
            txtSoTien.ReadOnly = !enable;

            btnLuu.Enabled = enable;
            btnHuy.Enabled = enable;
            btnThem.Enabled = !enable;

            // Nút Ghi sổ chỉ bật khi đã lưu phiếu nháp và chưa ghi sổ
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
                if (cboKhachHang.SelectedValue == null || cboTaiKhoan.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn khách hàng và tài khoản.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (TransactionScope scope = new TransactionScope())
                {
                    if (isAdding)
                    {
                        // Tạo phiếu mới ở trạng thái Nháp, LOAI = 'T' (Thu)
                        string queryPhieu = @"
                            INSERT INTO PHIEUTHUCHI (NGAYLAP, LOAI, MAKH, SOTIEN, LYDO, SOTK_NO)
                            OUTPUT INSERTED.SOPTC
                            VALUES (@NgayLap, 'T', @MaKH, @SoTien, @LyDo, @TkNo)";

                        object generatedId = DbHelper.Scalar(queryPhieu,
                            DbHelper.Param("@NgayLap", dtpNgayLap.Value),
                            DbHelper.Param("@MaKH", cboKhachHang.SelectedValue),
                            DbHelper.Param("@SoTien", decimal.Parse(txtSoTien.Texts)),
                            DbHelper.Param("@LyDo", txtLyDo.Texts),
                            DbHelper.Param("@TkNo", cboTaiKhoan.SelectedValue)
                        );
                        currentSoPhieu = Convert.ToInt64(generatedId);
                    }
                    else
                    {
                        // Cập nhật thông tin phiếu đã có
                        string queryPhieu = @"
                            UPDATE PHIEUTHUCHI SET 
                                NGAYLAP = @NgayLap, MAKH = @MaKH, SOTIEN = @SoTien, 
                                LYDO = @LyDo, SOTK_NO = @TkNo
                            WHERE SOPTC = @SoPhieu";
                        DbHelper.Execute(queryPhieu,
                             DbHelper.Param("@NgayLap", dtpNgayLap.Value),
                             DbHelper.Param("@MaKH", cboKhachHang.SelectedValue),
                             DbHelper.Param("@SoTien", decimal.Parse(txtSoTien.Texts)),
                             DbHelper.Param("@LyDo", txtLyDo.Texts),
                             DbHelper.Param("@TkNo", cboTaiKhoan.SelectedValue),
                             DbHelper.Param("@SoPhieu", currentSoPhieu)
                        );
                    }
                    scope.Complete();
                }

                MessageBox.Show("Lưu phiếu thu nháp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    string tkNo = cboTaiKhoan.SelectedValue.ToString();
                    // Giả định TK Có là 131 - Phải thu của khách hàng
                    string tkCo = "131";

                    string queryButToan = @"
                        INSERT INTO BUTTOAN_KETOAN (NGAY_HT, SO_CT, MA_CT, DIEN_GIAI, TK_NO, TK_CO, SOTIEN)
                        VALUES (@NgayHT, @SoCT, 'PT', @DienGiai, @TkNo, @TkCo, @SoTien)";

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

                // Cập nhật trạng thái phiếu (nếu có cột trạng thái trong bảng PHIEUTHUCHI)
                // Ví dụ: DbHelper.Execute("UPDATE PHIEUTHUCHI SET TRANGTHAI = 1 WHERE SOPTC = @SoPhieu", DbHelper.Param("@SoPhieu", currentSoPhieu));

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
