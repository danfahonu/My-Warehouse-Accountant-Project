using System;
using System.Data;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Data;
using DoAnLapTrinhQuanLy;

namespace DoAnLapTrinhQuanLy.GuiLayer // (Giữ namespace của bà)
{
    public partial class FormDangNhap : Form
    {
        public UserData AuthenticatedUser { get; private set; }

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            try
            {
                ThemeManager.Apply(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải form: " + ex.Message);
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Texts;
            string matKhau = txtMatKhau.Texts;

            if (string.IsNullOrEmpty(taiKhoan) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // === SỬA QUERY: Thêm nd.MANV vào ===
                string query = @"
                    SELECT nd.TAIKHOAN, nd.MATKHAU, nd.HOTEN, nd.MANV, qh.TENQUYEN 
                    FROM NGUOIDUNG nd 
                    JOIN QUYENHAN qh ON nd.MAQUYEN = qh.MAQUYEN 
                    WHERE nd.TAIKHOAN = @TaiKhoan AND nd.MATKHAU = @MatKhau AND nd.HOATDONG = 1";

                DataTable dt = DbHelper.Query(query,
                                    DbHelper.Param("@TaiKhoan", taiKhoan),
                                    DbHelper.Param("@MatKhau", matKhau));

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    AuthenticatedUser = new UserData
                    {
                        TaiKhoan = row["TAIKHOAN"].ToString(),
                        MatKhau = row["MATKHAU"].ToString(),
                        HoTen = row["HOTEN"].ToString(),
                        TenQuyen = row["TENQUYEN"].ToString(),
                        MaNV = row["MANV"].ToString() // === THÊM DÒNG NÀY ===
                    };

                    // === LƯU VÀO SESSION ===
                    Session.LoggedInUser = this.AuthenticatedUser;

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng, hoặc tài khoản đã bị khóa.", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối hoặc truy vấn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtMatKhau.PasswordChar = false;
            }
            else
            {
                txtMatKhau.PasswordChar = true;
            }
        }
    }
}
