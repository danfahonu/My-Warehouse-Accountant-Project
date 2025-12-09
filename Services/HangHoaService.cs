using System;
using System.Data;
using System.Data.SqlClient;
using DoAnLapTrinhQuanLy.Data;

namespace DoAnLapTrinhQuanLy.Services
{
    public class HangHoaService
    {
        // 1. Lấy danh sách (Có cột ANH và TONKHO)
        public DataTable GetAll()
        {
            string sql = @"
                SELECT h.MAHH, h.TENHH, h.DVT, h.GIAVON, h.GIABAN, h.MANHOM, 
                       n.TENNHOM, h.ACTIVE, h.ANH, h.TONKHO
                FROM DM_HANGHOA h
                LEFT JOIN DM_NHOMHANG n ON h.MANHOM = n.MANHOM
                WHERE h.ACTIVE = 1
                ORDER BY h.TENHH";
            return DbHelper.Query(sql);
        }

        // 2. Lấy nhóm hàng
        public DataTable GetNhomHang()
        {
            return DbHelper.Query("SELECT MANHOM, TENNHOM FROM DM_NHOMHANG");
        }

        // 3. Thêm mới (Lưu cột ANH)
        public bool Add(string ma, string ten, string dvt, decimal giaVon, decimal giaBan, string maNhom, byte[] hinhAnh)
        {
            string check = "SELECT COUNT(*) FROM DM_HANGHOA WHERE MAHH = @Ma";
            if (Convert.ToInt32(DbHelper.Scalar(check, DbHelper.Param("@Ma", ma))) > 0)
                throw new Exception($"Mã hàng '{ma}' đã tồn tại!");

            // Lưu ý: Mặc định TONKHO = 0 khi tạo mới
            string sql = @"INSERT INTO DM_HANGHOA (MAHH, TENHH, DVT, GIAVON, GIABAN, MANHOM, ANH, TONKHO, ACTIVE) 
                           VALUES (@Ma, @Ten, @Dvt, @GiaVon, @GiaBan, @MaNhom, @Hinh, 0, 1)";

            SqlParameter paramHinh = new SqlParameter("@Hinh", SqlDbType.VarBinary);
            if (hinhAnh != null) paramHinh.Value = hinhAnh;
            else paramHinh.Value = DBNull.Value;

            return DbHelper.Execute(sql,
                DbHelper.Param("@Ma", ma),
                DbHelper.Param("@Ten", ten),
                DbHelper.Param("@Dvt", dvt),
                DbHelper.Param("@GiaVon", giaVon),
                DbHelper.Param("@GiaBan", giaBan),
                DbHelper.Param("@MaNhom", maNhom),
                paramHinh) > 0;
        }

        // 4. Cập nhật (Lưu cột ANH)
        public bool Update(string ma, string ten, string dvt, decimal giaVon, decimal giaBan, string maNhom, byte[] hinhAnh)
        {
            string sql = @"UPDATE DM_HANGHOA 
                           SET TENHH = @Ten, DVT = @Dvt, GIAVON = @GiaVon, GIABAN = @GiaBan, MANHOM = @MaNhom, ANH = @Hinh
                           WHERE MAHH = @Ma";

            SqlParameter paramHinh = new SqlParameter("@Hinh", SqlDbType.VarBinary);
            if (hinhAnh != null) paramHinh.Value = hinhAnh;
            else paramHinh.Value = DBNull.Value;

            return DbHelper.Execute(sql,
                DbHelper.Param("@Ten", ten),
                DbHelper.Param("@Dvt", dvt),
                DbHelper.Param("@GiaVon", giaVon),
                DbHelper.Param("@GiaBan", giaBan),
                DbHelper.Param("@MaNhom", maNhom),
                paramHinh,
                DbHelper.Param("@Ma", ma)) > 0;
        }

        // 5. Xóa
        public bool Delete(string ma)
        {
            // Kiểm tra ràng buộc
            string check = "SELECT COUNT(*) FROM PHIEU_CT WHERE MAHH = @Ma";
            int count = Convert.ToInt32(DbHelper.Scalar(check, DbHelper.Param("@Ma", ma)));

            if (count > 0) throw new Exception($"Hàng hóa này đang có {count} giao dịch. Không thể xóa!");

            string sql = "DELETE FROM DM_HANGHOA WHERE MAHH = @Ma";
            return DbHelper.Execute(sql, DbHelper.Param("@Ma", ma)) > 0;
        }
    }
}