using DoAnLapTrinhQuanLy.Data;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormTinhLuong : Form
    {
        private const int NGAY_CONG_CHUAN = 26; // Số ngày công chuẩn trong tháng

        public FormTinhLuong()
        {
            InitializeComponent();
        }

        private void btnXemBangLuong_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ form
            DateTime kyLuong = dtpThangNam.Value;
            int thang = kyLuong.Month;
            int nam = kyLuong.Year;

            if (!decimal.TryParse(txtLuongCoBan.Text, out decimal luongCoBan))
            {
                MessageBox.Show("Vui lòng nhập Lương cơ bản là một con số hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Câu truy vấn SQL để tổng hợp và tính toán tất cả trong 1
                string sql = $@"
WITH TamUngTrongKy AS (
    -- Bước 1: Tính tổng tạm ứng của mỗi nhân viên trong kỳ lương
    SELECT MANV, SUM(SOTIEN) AS TongTamUng
    FROM dbo.TAMUNG
    WHERE MONTH(NGAY) = @Thang AND YEAR(NGAY) = @Nam
    GROUP BY MANV
)
-- Bước 2: Join các bảng và tính toán lương
SELECT 
    nv.MANV AS [Mã NV],
    nv.HOTEN AS [Họ Tên],
    nv.CHUCVU AS [Chức Vụ],
    ISNULL(hs.HESOLUONG, 1) AS [HSL],
    ISNULL(cc.NGAYCONG, 0) AS [Ngày Công],
    -- Tính lương Gross (trước khi trừ tạm ứng)
    ( (@LuongCoBan * ISNULL(hs.HESOLUONG, 1)) / {NGAY_CONG_CHUAN} ) * ISNULL(cc.NGAYCONG, 0) AS [Lương Gross],
    ISNULL(tu.TongTamUng, 0) AS [Tổng Tạm Ứng],
    -- Lương thực lãnh = Lương Gross - Tạm ứng
    ((@LuongCoBan * ISNULL(hs.HESOLUONG, 1)) / {NGAY_CONG_CHUAN} * ISNULL(cc.NGAYCONG, 0)) - ISNULL(tu.TongTamUng, 0) AS [Thực Lãnh]
FROM 
    dbo.NHANVIEN nv
LEFT JOIN 
    dbo.HESOLUONG hs ON nv.CHUCVU = hs.CHUCVU
LEFT JOIN 
    dbo.BANGCHAMCONG cc ON nv.MANV = cc.MANV AND cc.THANG = @Thang AND cc.NAM = @Nam
LEFT JOIN 
    TamUngTrongKy tu ON nv.MANV = tu.MANV
ORDER BY 
    nv.HOTEN;";

                // Thực thi truy vấn
                DataTable dtBangLuong = DbHelper.Query(sql,
                    DbHelper.Param("@Thang", thang),
                    DbHelper.Param("@Nam", nam),
                    DbHelper.Param("@LuongCoBan", luongCoBan));

                // Hiển thị kết quả lên Grid
                gridBangLuong.DataSource = dtBangLuong;

                // Định dạng lại các cột số cho dễ đọc
                FormatGridColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tính lương: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Định dạng các cột số và tiền tệ trong DataGridView
        /// </summary>
        private void FormatGridColumns()
        {
            // Định dạng tiền tệ kiểu Việt Nam
            var currencyFormat = new DataGridViewCellStyle { Format = "N0" };
            // Định dạng số thập phân
            var decimalFormat = new DataGridViewCellStyle { Format = "N1" };

            if (gridBangLuong.Columns.Contains("HSL"))
            {
                gridBangLuong.Columns["HSL"].DefaultCellStyle = decimalFormat;
            }
            if (gridBangLuong.Columns.Contains("Ngày Công"))
            {
                gridBangLuong.Columns["Ngày Công"].DefaultCellStyle = decimalFormat;
            }
            if (gridBangLuong.Columns.Contains("Lương Gross"))
            {
                gridBangLuong.Columns["Lương Gross"].DefaultCellStyle = currencyFormat;
                gridBangLuong.Columns["Lương Gross"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (gridBangLuong.Columns.Contains("Tổng Tạm Ứng"))
            {
                gridBangLuong.Columns["Tổng Tạm Ứng"].DefaultCellStyle = currencyFormat;
                gridBangLuong.Columns["Tổng Tạm Ứng"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (gridBangLuong.Columns.Contains("Thực Lãnh"))
            {
                gridBangLuong.Columns["Thực Lãnh"].DefaultCellStyle = currencyFormat;
                gridBangLuong.Columns["Thực Lãnh"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                gridBangLuong.Columns["Thực Lãnh"].HeaderCell.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            }

            gridBangLuong.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}