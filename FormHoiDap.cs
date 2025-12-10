using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Data; // Nơi chứa GeminiHelper và DbHelper

namespace DoAnLapTrinhQuanLy
{
    public partial class FormHoiDap : Form // Hoặc BaseForm nếu bà có dùng
    {
        public FormHoiDap()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            // Trang trí chút cho đẹp (Optional)
            this.Text = "Trợ lý ảo AI - Hỏi đáp số liệu kho";
            this.lblTrangThai.Text = "Sẵn sàng";
            this.lblTrangThai.ForeColor = Color.Green;
        }

        // Sự kiện khi nhấn nút Gửi
        private async void btnGui_Click(object sender, EventArgs e)
        {
            string cauHoi = txtCauHoi.Text.Trim();

            if (string.IsNullOrEmpty(cauHoi))
            {
                MessageBox.Show("Bà ơi, nhập câu hỏi vào đã chứ!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 1. Hiệu ứng đang chờ (UX cực quan trọng)
                btnGui.Enabled = false;
                lblTrangThai.Text = "AI đang suy nghĩ...";
                lblTrangThai.ForeColor = Color.Blue;
                Cursor = Cursors.WaitCursor;

                // 2. Gọi Gemini để lấy câu lệnh SQL
                // (Hàm này nằm trong file GeminiHelper.cs bà đã tạo)
                string sqlQuery = await GeminiHelper.ChuyenCauHoiThanhSQL(cauHoi);

                // 3. Kiểm tra kết quả
                if (sqlQuery == "KHONG_THE_TRA_LOI" || string.IsNullOrEmpty(sqlQuery))
                {
                    MessageBox.Show("Hic, câu này khó quá tui chưa hiểu. Bà hỏi lại rõ hơn nha!", "AI Trả lời", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // 4. Nếu có SQL, gọi DbHelper để chạy và lấy dữ liệu
                    // Giả sử bà có class DbHelper xử lý kết nối CSDL
                    DataTable dt = DbHelper.Query(sqlQuery);

                    if (dt != null && dt.Rows.Count > 0)
                    {
                        dgvKetQua.DataSource = dt;
                        lblTrangThai.Text = $"Tìm thấy {dt.Rows.Count} kết quả.";
                    }
                    else
                    {
                        dgvKetQua.DataSource = null;
                        lblTrangThai.Text = "Không tìm thấy dữ liệu nào.";
                        MessageBox.Show("Câu lệnh chạy thành công nhưng không có dữ liệu trả về.", "Thông báo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi rồi bà ơi: {ex.Message}", "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // 5. Trả lại trạng thái ban đầu
                btnGui.Enabled = true;
                Cursor = Cursors.Default;
                if (lblTrangThai.Text == "AI đang suy nghĩ...")
                    lblTrangThai.Text = "Hoàn tất";
            }
        }

        // Sự kiện ấn Enter để gửi luôn cho nhanh (Optional)
        private void txtCauHoi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGui.PerformClick();
                e.SuppressKeyPress = true; // Chặn tiếng 'ding' của Windows
            }
        }
    }
}