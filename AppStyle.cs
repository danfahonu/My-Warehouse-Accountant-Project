using System;
using System.Drawing;
using System.Windows.Forms;

namespace YourNamespace // Đổi thành Namespace project của bạn (ví dụ: SaleGearVn)
{
    public static class AppStyle
    {
        // --- BẢNG MÀU (XÁM HIỆN ĐẠI) ---
        // Bạn có thể chỉnh mã màu Hex tại đây
        public static Color PrimaryColor = ColorTranslator.FromHtml("#4A4A4A");   // Xám đậm (Header, Button chính)
        public static Color SecondaryColor = ColorTranslator.FromHtml("#6D6D6D"); // Xám vừa (Button phụ)
        public static Color BackgroundColor = ColorTranslator.FromHtml("#F5F5F5"); // Xám rất nhạt (Nền Form)
        public static Color TextColor = ColorTranslator.FromHtml("#2D2D30");       // Chữ đen xám
        public static Color AccentColor = ColorTranslator.FromHtml("#007ACC");     // Xanh Visual Studio (Dùng cho điểm nhấn)
        public static Color ErrorColor = Color.Red;

        // --- FONTS ---
        // Nên dùng Segoe UI cho chuẩn Windows hiện đại
        public static Font MainFont = new Font("Segoe UI", 10F, FontStyle.Regular);
        public static Font HeaderFont = new Font("Segoe UI", 12F, FontStyle.Bold);

        // --- CÁC HÀM ÁP DỤNG GIAO DIỆN ---

        // 1. Áp dụng cho Form
        public static void ApplyFormStyle(Form form)
        {
            form.BackColor = BackgroundColor;
            form.ForeColor = TextColor;
            form.Font = MainFont;
            form.StartPosition = FormStartPosition.CenterScreen;
            // Nếu muốn bỏ viền windows cũ kỹ:
            // form.FormBorderStyle = FormBorderStyle.Sizable; 
        }

        // 2. Áp dụng cho Nút bấm (Button)
        public static void ApplyPrimaryButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = PrimaryColor;
            btn.ForeColor = Color.White;
            btn.Font = new Font(MainFont, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
        }

        public static void ApplySecondaryButton(Button btn) // Nút Hủy, Thoát...
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = SecondaryColor;
            btn.BackColor = Color.White;
            btn.ForeColor = TextColor;
            btn.Cursor = Cursors.Hand;
        }

        // 3. Áp dụng cho Ô nhập liệu (TextBox)
        public static void ApplyTextBox(TextBox txt)
        {
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.BackColor = Color.White;
            txt.Font = MainFont;
        }

        // 4. Áp dụng cho GridView (Bảng dữ liệu) - Quan trọng nhất để nhìn xịn
        public static void ApplyGridViewStyle(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.EnableHeadersVisualStyles = false;

            // Header
            dgv.ColumnHeadersDefaultCellStyle.BackColor = PrimaryColor;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font(MainFont, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 35;

            // Dòng dữ liệu
            dgv.DefaultCellStyle.SelectionBackColor = AccentColor;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Font = MainFont;
            dgv.RowTemplate.Height = 30;

            // Chỉnh chế độ co giãn
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}