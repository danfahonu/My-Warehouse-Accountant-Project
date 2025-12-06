using System;
using System.Data;
using System.Data.SqlClient;
using DoAnLapTrinhQuanLy.Data;

namespace DoAnLapTrinhQuanLy.Services
{
    /// <summary>
    /// Service xử lý nghiệp vụ cho Danh mục Hàng Hóa.
    /// Chứa các phương thức CRUD và truy vấn liên quan đến Hàng hóa.
    /// </summary>
    public class HangHoaService
    {
        /// <summary>
        /// Lấy danh sách hàng hóa kèm theo Tên Nhóm và Tồn kho hiện tại.
        /// </summary>
        /// <returns>DataTable chi tiết hàng hóa</returns>
        public DataTable LayDanhSach()
        {
            // JOIN DM_HANGHOA với DM_NHOMHANG để lấy tên nhóm
            // LEFT JOIN view TonKhoHienTai để lấy số lượng tồn (nếu null thì là 0)
            string sql = @"
                SELECT 
                    hh.MAHH, 
                    hh.TENHH, 
                    hh.MANHOM, 
                    nh.TENNHOM, 
                    hh.DVT, 
                    hh.GIAVON, 
                    hh.GIABAN, 
                    hh.ANH, 
                    hh.ACTIVE, 
                    ISNULL(tk.TON_HIEN_TAI, 0) AS TONKHO
                FROM DM_HANGHOA hh
                LEFT JOIN DM_NHOMHANG nh ON hh.MANHOM = nh.MANHOM
                LEFT JOIN vw_TonKhoHienTai tk ON hh.MAHH = tk.MAHH
                ORDER BY hh.TENHH";
            
            return DbHelper.Query(sql);
        }

        /// <summary>
        /// Lấy danh sách nhóm hàng để đổ vào ComboBox.
        /// </summary>
        /// <returns>DataTable (MANHOM, TENNHOM)</returns>
        public DataTable LayDanhSachNhomHang()
        {
            string sql = "SELECT MANHOM, TENNHOM FROM DM_NHOMHANG ORDER BY TENNHOM";
            return DbHelper.Query(sql);
        }

        /// <summary>
        /// Thêm mới hàng hóa.
        /// </summary>
        public bool Them(string ma, string ten, string maNhom, string dvt, decimal giaVon, decimal giaBan, string anh, bool active)
        {
            // Validate: check trùng mã
            string checkSql = "SELECT COUNT(*) FROM DM_HANGHOA WHERE MAHH = @Ma";
            if (Convert.ToInt32(DbHelper.Scalar(checkSql, DbHelper.Param("@Ma", ma))) > 0)
            {
                throw new Exception($"Mã hàng '{ma}' đã tồn tại!");
            }

            string sql = @"
                INSERT INTO DM_HANGHOA (MAHH, TENHH, MANHOM, DVT, GIAVON, GIABAN, ANH, ACTIVE)
                VALUES (@Ma, @Ten, @MaNhom, @Dvt, @GiaVon, @GiaBan, @Anh, @Active)";

            return DbHelper.Execute(sql,
                DbHelper.Param("@Ma", ma),
                DbHelper.Param("@Ten", ten),
                DbHelper.Param("@MaNhom", maNhom),
                DbHelper.Param("@Dvt", dvt),
                DbHelper.Param("@GiaVon", giaVon),
                DbHelper.Param("@GiaBan", giaBan),
                DbHelper.Param("@Anh", anh ?? (object)DBNull.Value),
                DbHelper.Param("@Active", active)
            ) > 0;
        }

        /// <summary>
        /// Cập nhật thông tin hàng hóa.
        /// </summary>
        public bool Sua(string ma, string ten, string maNhom, string dvt, decimal giaVon, decimal giaBan, string anh, bool active)
        {
            string sql = @"
                UPDATE DM_HANGHOA
                SET TENHH = @Ten, 
                    MANHOM = @MaNhom, 
                    DVT = @Dvt, 
                    GIAVON = @GiaVon, 
                    GIABAN = @GiaBan, 
                    ANH = @Anh, 
                    ACTIVE = @Active
                WHERE MAHH = @Ma";

            return DbHelper.Execute(sql,
                DbHelper.Param("@Ten", ten),
                DbHelper.Param("@MaNhom", maNhom),
                DbHelper.Param("@Dvt", dvt),
                DbHelper.Param("@GiaVon", giaVon),
                DbHelper.Param("@GiaBan", giaBan),
                DbHelper.Param("@Anh", anh ?? (object)DBNull.Value),
                DbHelper.Param("@Active", active),
                DbHelper.Param("@Ma", ma)
            ) > 0;
        }

        /// <summary>
        /// Xóa hàng hóa.
        /// </summary>
        public bool Xoa(string ma)
        {
            // Check lịch sử giao dịch (PHIEU_CT) trước khi xóa
            string checkSql = "SELECT COUNT(*) FROM PHIEU_CT WHERE MAHH = @Ma";
            int count = Convert.ToInt32(DbHelper.Scalar(checkSql, DbHelper.Param("@Ma", ma)));
            if (count > 0)
            {
                throw new Exception($"Không thể xóa hàng hóa này vì đã có {count} giao dịch liên quan.");
            }

            string sql = "DELETE FROM DM_HANGHOA WHERE MAHH = @Ma";
            return DbHelper.Execute(sql, DbHelper.Param("@Ma", ma)) > 0;
        }
    }
}
