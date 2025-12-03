using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Data;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormTroLyAo : Form
    {
        public FormTroLyAo()
        {
            InitializeComponent();
        }

        private void FormTroLyAo_Load(object sender, EventArgs e)
        {
            try
            {
                ThemeManager.Apply(this);
                AppendMessage("Bot", "Xin chào! Tôi là trợ lý ảo AI. Bạn cần hỏi gì về dữ liệu?", Color.Blue);
                txtInput.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải trợ lý ảo: " + ex.Message);
            }
        }

        private async void BtnSend_Click(object sender, EventArgs e)
        {
            await SendMessage();
        }

        private async void TxtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Ngăn tiếng bíp
                await SendMessage();
            }
        }

        private async Task SendMessage()
        {
            string question = txtInput.Text.Trim();
            if (string.IsNullOrEmpty(question)) return;

            // 1. Hiển thị câu hỏi của User
            AppendMessage("Bạn", question, Color.Black);
            txtInput.Clear();
            lblStatus.Text = "Đang suy nghĩ...";

            try
            {
                // 2. Gọi Gemini để lấy SQL
                string sql = await GeminiHelper.ChuyenCauHoiThanhSQL(question);

                if (sql == "KHONG_THE_TRA_LOI")
                {
                    AppendMessage("Bot", "Xin lỗi, tôi không hiểu câu hỏi hoặc không thể truy vấn dữ liệu này.", Color.Red);
                    lblStatus.Text = "Không thể trả lời.";
                    return;
                }

                // Security Check
                if (!IsSafeSql(sql))
                {
                    AppendMessage("Bot", "Cảnh báo: SQL không an toàn hoặc chứa từ khóa bị cấm (chỉ cho phép SELECT).", Color.Red);
                    lblStatus.Text = "SQL bị chặn.";
                    return;
                }

                // 3. Hiển thị SQL (để debug/minh bạch)
                AppendMessage("Bot", $"Đang thực thi SQL: {sql}", Color.Gray);

                // 4. Thực thi SQL và hiển thị kết quả
                DataTable dt = DbHelper.Query(sql);
                dgvResult.DataSource = dt;
                lblStatus.Text = $"Đã tìm thấy {dt.Rows.Count} kết quả.";
                AppendMessage("Bot", "Đã có kết quả bên dưới 👇", Color.Blue);
            }
            catch (Exception ex)
            {
                AppendMessage("Bot", $"Lỗi: {ex.Message}", Color.Red);
                lblStatus.Text = "Có lỗi xảy ra.";
            }
        }

        private void AppendMessage(string sender, string message, Color color)
        {
            rtbChat.SelectionStart = rtbChat.TextLength;
            rtbChat.SelectionLength = 0;

            rtbChat.SelectionColor = color;
            rtbChat.SelectionFont = new Font(rtbChat.Font, FontStyle.Bold);
            rtbChat.AppendText($"{sender}: ");

            rtbChat.SelectionColor = Color.Black;
            rtbChat.SelectionFont = new Font(rtbChat.Font, FontStyle.Regular);
            rtbChat.AppendText($"{message}\n");

            rtbChat.ScrollToCaret();
        }
        private bool IsSafeSql(string sql)
        {
            if (string.IsNullOrWhiteSpace(sql)) return false;
            string upperSql = sql.ToUpper().Trim();

            // 1. Must start with SELECT
            if (!upperSql.StartsWith("SELECT")) return false;

            // 2. Block dangerous keywords
            string[] forbidden = { "INSERT", "UPDATE", "DELETE", "DROP", "ALTER", "TRUNCATE", "EXEC", "--", ";" };
            foreach (string word in forbidden)
            {
                if (upperSql.Contains(word)) return false;
            }
            return true;
        }
    }
}
