using System;
using System.Data;
using DoAnLapTrinhQuanLy.Data;

namespace DoAnLapTrinhQuanLy.Services
{
    public class NhaCungCapService
    {
        // 1. Lấy danh sách
        public DataTable GetAll()
        {
            string sql = "SELECT MA_NCC, TEN_NCC, DIACHI_NCC, SDT, EMAIL, MSTHUE, GHICHU FROM DM_NHACUNGCAP";
            return DbHelper.Query(sql);
        }

        // 2. Thêm mới
        public bool Add(string ma, string ten, string sdt, string diachi)
        {
            // Check trùng mã
            string check = "SELECT COUNT(*) FROM DM_NHACUNGCAP WHERE MANCC = @Ma";
            if (Convert.ToInt32(DbHelper.Scalar(check, DbHelper.Param("@Ma", ma))) > 0)
                throw new Exception($"Mã NCC '{ma}' đã tồn tại!");

            string sql = @"INSERT INTO DM_NHACUNGCAP (MA_NCC, TEN_NCC, DIACHI_NCC, SDT, EMAIL, MSTHUE, GHICHU) 
                       VALUES (@MA_NCC, @TEN_NCC, @DIACHI_NCC, @SDT, @EMAIL, @MSTHUE, @GHICHU)";

            return DbHelper.Execute(sql,
                DbHelper.Param("@Ma", ma),
                DbHelper.Param("@Ten", ten),
                DbHelper.Param("@Sdt", sdt),
                DbHelper.Param("@DiaChi", diachi)) > 0;
        }

        // 3. Cập nhật
        public bool Update(string ma, string ten, string sdt, string diachi)
        {
            string sql = @"UPDATE DM_NHACUNGCAP 
                       SET TEN_NCC = @TEN_NCC, DIACHI_NCC = @DIACHI_NCC, SDT = @SDT, EMAIL = @EMAIL, MSTHUE = @MSTHUE, GHICHU = @GHICHU 
                       WHERE MA_NCC = @MA_NCC";

            return DbHelper.Execute(sql,
                DbHelper.Param("@Ten", ten),
                DbHelper.Param("@Sdt", sdt),
                DbHelper.Param("@DiaChi", diachi),
                DbHelper.Param("@Ma", ma)) > 0;
        }

        // 4. Xóa
        public bool Delete(string ma)
        {
            // Kiểm tra ràng buộc (Ví dụ: Đã có phiếu nhập chưa)
            // Lưu ý: Tùy bảng PHIEU của bà lưu NCC vào cột nào (MAKH hay cột khác), sửa lại cho khớp
            string check = "SELECT COUNT(*) FROM PHIEU WHERE MAKH = @Ma";
            int count = Convert.ToInt32(DbHelper.Scalar(check, DbHelper.Param("@Ma", ma)));

            if (count > 0) throw new Exception($"Nhà cung cấp này đã có {count} phiếu giao dịch. Không thể xóa!");

            string sql = "DELETE FROM DM_NHACUNGCAP WHERE MANCC = @Ma";
            return DbHelper.Execute(sql, DbHelper.Param("@Ma", ma)) > 0;
        }
    }
}