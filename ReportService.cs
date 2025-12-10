using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using DoAnLapTrinhQuanLy.Data; // Nơi chứa DbHelper
using DoAnLapTrinhQuanLy.GuiLayer; // Nơi chứa FormXemBaoCao

namespace DoAnLapTrinhQuanLy
{
    public static class ReportService
    {
        // ---------------------------------------------------------
        // HÀM 1: In Phiếu Nhập / Xuất (Tự động nhận diện)
        // ---------------------------------------------------------
        public static void InPhieu(string soPhieu)
        {
            try
            {
                // 1. Kiểm tra phiếu có tồn tại không và lấy LOAI (N hay X)
                string sqlInfo = "SELECT LOAI FROM PHIEU WHERE SOPHIEU = @SoPhieu";

                // Dùng hàm ExecuteScalar có sẵn trong DbHelper của bà
                object loaiObj = DbHelper.ExecuteScalar(sqlInfo, new SqlParameter("@SoPhieu", soPhieu));

                if (loaiObj == null)
                {
                    MessageBox.Show("Không tìm thấy số phiếu: " + soPhieu, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string loai = loaiObj.ToString();
                string sqlData = "";
                string reportFileName = "";
                string title = "";

                // 2. Viết câu truy vấn lấy dữ liệu (JOIN bảng)
                if (loai == "N") // === PHIẾU NHẬP ===
                {
                    sqlData = @"
                        SELECT 
                            p.SOPHIEU, p.NGAYLAP, p.LOAI, p.GHICHU,
                            ncc.TEN_NCC AS TEN_DOITUONG,   
                            ncc.DIACHI_NCC AS DIACHI,      
                            ncc.SDT,
                            ct.MAHH, hh.TENHH, hh.DVT, 
                            ct.SL, ct.DONGIA, 
                            (ct.SL * ct.DONGIA) AS THANHTIEN
                        FROM PHIEU p
                        JOIN PHIEU_CT ct ON p.SOPHIEU = ct.SOPHIEU
                        JOIN DM_HANGHOA hh ON ct.MAHH = hh.MAHH
                        LEFT JOIN DM_NHACUNGCAP ncc ON p.MA_NCC = ncc.MA_NCC 
                        WHERE p.SOPHIEU = @SoPhieu";

                    reportFileName = "rptPhieuNhap.rdlc";
                    title = "In Phiếu Nhập Kho";
                }
                else // === PHIẾU XUẤT (X) ===
                {
                    sqlData = @"
                        SELECT 
                            p.SOPHIEU, p.NGAYLAP, p.LOAI, p.GHICHU,
                            kh.TENKH AS TEN_DOITUONG,
                            kh.DIACHI,
                            kh.SDT,
                            ct.MAHH, hh.TENHH, hh.DVT, 
                            ct.SL, ct.DONGIA, 
                            (ct.SL * ct.DONGIA) AS THANHTIEN
                        FROM PHIEU p
                        JOIN PHIEU_CT ct ON p.SOPHIEU = ct.SOPHIEU
                        JOIN DM_HANGHOA hh ON ct.MAHH = hh.MAHH
                        LEFT JOIN DANHMUCKHACHHANG kh ON p.MAKH = kh.MAKH
                        WHERE p.SOPHIEU = @SoPhieu";

                    reportFileName = "rptPhieuXuat.rdlc";
                    title = "In Phiếu Xuất Kho";
                }

                // 3. Lấy dữ liệu từ DB (Sửa thành DbHelper.Query cho khớp với file của bà)
                DataTable dt = DbHelper.Query(sqlData, new SqlParameter("@SoPhieu", soPhieu));

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("Phiếu này không có dữ liệu chi tiết để in.", "Thông báo");
                    return;
                }

                // 4. Mở Form xem báo cáo
                ShowReportForm(reportFileName, dt, "dtPhieuNhapXuat", title);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi in phiếu: " + ex.Message);
            }
        }

        // ---------------------------------------------------------
        // HÀM 2: In Báo Cáo Tồn Kho (Theo khoảng thời gian)
        // ---------------------------------------------------------
        public static void InTonKho(DateTime tuNgay, DateTime denNgay)
        {
            try
            {
                string spName = "sp_BaoCaoTongHopTonKho";

                // Gọi Stored Procedure (Sửa thành DbHelper.Proc cho khớp)
                DataTable dt = DbHelper.Proc(spName,
                    new SqlParameter("@TuNgay", tuNgay),
                    new SqlParameter("@DenNgay", denNgay),
                    new SqlParameter("@TuKhoa", "")
                );

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu tồn kho trong khoảng thời gian này.", "Thông báo");
                    return;
                }

                // Mở Form xem báo cáo
                ShowReportForm("rptTonKho.rdlc", dt, "dtTonKho", "Báo Cáo Tổng Hợp Tồn Kho");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi in báo cáo tồn kho: " + ex.Message);
            }
        }

        // ---------------------------------------------------------
        // HÀM PHỤ TRỢ: Mở Form (Để code gọn hơn)
        // ---------------------------------------------------------
        private static void ShowReportForm(string rdlcName, DataTable data, string dataSetName, string formTitle)
        {
            string reportPath = Path.Combine(Application.StartupPath, rdlcName);

            if (!File.Exists(reportPath))
            {
                MessageBox.Show($"Không tìm thấy file mẫu in: {rdlcName}\n\n(Bà nhớ kiểm tra xem file .rdlc đã được copy vào thư mục bin/Debug chưa nha!)", "Thiếu file mẫu");
                return;
            }

            // Gọi FormXemBaoCao (File này do AI tạo ở bước trước)
            FormXemBaoCao f = new FormXemBaoCao(reportPath, data, dataSetName);
            f.Text = formTitle;
            f.ShowDialog();
        }
    }
}