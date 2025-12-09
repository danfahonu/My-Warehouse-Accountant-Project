using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Data; // Để dùng DbHelper
// using DoAnLapTrinhQuanLy.Core; // Bỏ comment dòng này nếu báo lỗi không tìm thấy UserData

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormDangNhap : Form
    {
        // --- KHAI BÁO BIẾN NGƯỜI DÙNG (QUAN TRỌNG) ---
        // Biến này để các Form khác truy cập lấy thông tin người vừa đăng nhập
        public UserData AuthenticatedUser { get; private set; }

        public FormDangNhap()
        {
            InitializeComponent();
            // Thiết lập nút Enter thì tự bấm Đăng nhập
            this.AcceptButton = btnLogin;
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            // Focus vào ô tài khoản khi mở form
            txtLoginUsername.Focus();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ChkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Nếu check thì hiện chữ thường (null), không check thì hiện dấu chấm tròn
            txtLoginPassword.PasswordChar = chkTogglePassword.Checked ? '\0' : '●';
        }

        private async void BtnDangNhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtLoginUsername.Text.Trim();
            string matKhau = txtLoginPassword.Text.Trim();

            if (string.IsNullOrEmpty(taiKhoan) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLoginUsername.Focus();
                return;
            }

            // Khóa nút để tránh bấm nhiều lần
            btnLogin.Enabled = false;
            btnLogin.Text = "Đang xử lý...";

            try
            {
                // Chạy query trong Task riêng để không treo giao diện
                DataTable dt = await Task.Run(() => CheckLogin(taiKhoan, matKhau));

                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    // --- LƯU THÔNG TIN ĐĂNG NHẬP (ĐÃ KHÔI PHỤC) ---
                    AuthenticatedUser = new UserData
                    {
                        TaiKhoan = row["TAIKHOAN"].ToString(),
                        MatKhau = row["MATKHAU"].ToString(), // Lưu ý: Code cũ có lưu pass, cân nhắc bảo mật sau này
                        HoTen = row["HOTEN"].ToString(),
                        TenQuyen = row["TENQUYEN"].ToString(),
                        MaNV = row["MANV"].ToString()
                    };

                    // Lưu vào Session toàn cục (như code cũ)
                    if (Session.LoggedInUser == null) Session.LoggedInUser = AuthenticatedUser;
                    else Session.LoggedInUser = AuthenticatedUser;

                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!\nHoặc tài khoản đã bị khóa.", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLoginPassword.SelectAll();
                    txtLoginPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Mở lại nút dù thành công hay thất bại
                btnLogin.Enabled = true;
                btnLogin.Text = "ĐĂNG NHẬP";
            }
        }

        // Hàm tách riêng để gọi DB (Trả về DataTable)
        private DataTable CheckLogin(string user, string pass)
        {
            // Lưu ý: Hiện tại code này đang so sánh mật khẩu plain-text (không mã hóa) theo code cũ.
            string query = @"
                SELECT nd.TAIKHOAN, nd.MATKHAU, nd.HOTEN, nd.MANV, qh.TENQUYEN 
                FROM NGUOIDUNG nd 
                JOIN QUYENHAN qh ON nd.MAQUYEN = qh.MAQUYEN 
                WHERE nd.TAIKHOAN = @TaiKhoan 
                  AND nd.MATKHAU = @MatKhau 
                  AND nd.HOATDONG = 1";

            return DbHelper.Query(query,
                DbHelper.Param("@TaiKhoan", user),
                DbHelper.Param("@MatKhau", pass)
            );
        }
    }
}