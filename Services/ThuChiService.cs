using System;
using System.Data;
using DoAnLapTrinhQuanLy.Data;

namespace DoAnLapTrinhQuanLy.Services
{
    public class ThuChiService
    {
        // 1. Lấy danh sách (JOIN đúng tên cột)
        public DataTable GetAll()
        {
            // Sửa MANCC -> MA_NCC, TENNCC -> TEN_NCC
            string sql = @"
                SELECT p.SOPTC, p.NGAYLAP, p.LOAI, p.SOTIEN, p.LYDO, 
                       p.MAKH, k.TENKH, 
                       p.MA_NCC, n.TEN_NCC, 
                       p.SOTK_NO, p.SOTK_CO
                FROM PHIEUTHUCHI p
                LEFT JOIN DANHMUCKHACHHANG k ON p.MAKH = k.MAKH
                LEFT JOIN DM_NHACUNGCAP n ON p.MA_NCC = n.MA_NCC
                ORDER BY p.NGAYLAP DESC";
            return DbHelper.Query(sql);
        }

        // 2. Load ComboBox (Sửa tên cột)
        public DataTable GetKhachHang() => DbHelper.Query("SELECT MAKH, TENKH FROM DANHMUCKHACHHANG");

        // Sửa query lấy NCC
        public DataTable GetNhaCungCap() => DbHelper.Query("SELECT MA_NCC, TEN_NCC FROM DM_NHACUNGCAP");

        // 3. Thêm mới
        public bool Add(string soPhieu, DateTime ngay, string loai, string maDoiTuong, bool isKhachHang, decimal tien, string lyDo, string tkNo, string tkCo, string maNV)
        {
            // Kiểm tra trùng
            if (Convert.ToInt32(DbHelper.Scalar("SELECT COUNT(*) FROM PHIEUTHUCHI WHERE SOPTC = @So", DbHelper.Param("@So", soPhieu))) > 0)
                throw new Exception($"Số phiếu '{soPhieu}' đã tồn tại!");

            string sql = @"INSERT INTO PHIEUTHUCHI (SOPTC, NGAYLAP, LOAI, MAKH, MA_NCC, SOTIEN, LYDO, SOTK_NO, SOTK_CO, MANV) 
                           VALUES (@So, @Ngay, @Loai, @MaKH, @MaNCC, @Tien, @LyDo, @TkNo, @TkCo, @MaNV)";

            return DbHelper.Execute(sql,
                DbHelper.Param("@So", soPhieu),
                DbHelper.Param("@Ngay", ngay),
                DbHelper.Param("@Loai", loai),
                DbHelper.Param("@MaKH", isKhachHang ? maDoiTuong : (object)DBNull.Value),
                DbHelper.Param("@MaNCC", !isKhachHang ? maDoiTuong : (object)DBNull.Value),
                DbHelper.Param("@Tien", tien),
                DbHelper.Param("@LyDo", lyDo),
                DbHelper.Param("@TkNo", tkNo),
                DbHelper.Param("@TkCo", tkCo),
                DbHelper.Param("@MaNV", maNV)) > 0;
        }

        // 4. Cập nhật
        public bool Update(string soPhieu, DateTime ngay, string loai, string maDoiTuong, bool isKhachHang, decimal tien, string lyDo, string tkNo, string tkCo)
        {
            string sql = @"UPDATE PHIEUTHUCHI 
                           SET NGAYLAP = @Ngay, LOAI = @Loai, MAKH = @MaKH, MA_NCC = @MaNCC, 
                               SOTIEN = @Tien, LYDO = @LyDo, SOTK_NO = @TkNo, SOTK_CO = @TkCo
                           WHERE SOPTC = @So";

            return DbHelper.Execute(sql,
                DbHelper.Param("@Ngay", ngay),
                DbHelper.Param("@Loai", loai),
                DbHelper.Param("@MaKH", isKhachHang ? maDoiTuong : (object)DBNull.Value),
                DbHelper.Param("@MaNCC", !isKhachHang ? maDoiTuong : (object)DBNull.Value),
                DbHelper.Param("@Tien", tien),
                DbHelper.Param("@LyDo", lyDo),
                DbHelper.Param("@TkNo", tkNo),
                DbHelper.Param("@TkCo", tkCo),
                DbHelper.Param("@So", soPhieu)) > 0;
        }

        // 5. Xóa
        public bool Delete(string soPhieu)
        {
            return DbHelper.Execute("DELETE FROM PHIEUTHUCHI WHERE SOPTC = @So", DbHelper.Param("@So", soPhieu)) > 0;
        }
    }
}