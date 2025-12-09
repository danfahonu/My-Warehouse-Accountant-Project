using System;
using System.Data;
using System.Data.SqlClient;
using DoAnLapTrinhQuanLy.Data; // Using DbHelper Xịn

namespace DoAnLapTrinhQuanLy.Services
{
    public class NhaCungCapService
    {
        // 1. Get List
        public DataTable GetAll()
        {
            return DbHelper.Query("SELECT * FROM DM_NHACUNGCAP ORDER BY TEN_NCC");
        }

        // 2. Add New
        public void Add(string ma, string ten, string sdt, string diachi, string email, string mst, string ghichu)
        {
            // Check for duplicate ID in DM_NHACUNGCAP
            string check = "SELECT COUNT(*) FROM DM_NHACUNGCAP WHERE MA_NCC = @Ma";
            int count = Convert.ToInt32(DbHelper.ExecuteScalar(check, DbHelper.Param("@Ma", ma)));

            if (count > 0) throw new Exception($"Mã NCC '{ma}' đã tồn tại!");

            string sql = @"INSERT INTO DM_NHACUNGCAP (MA_NCC, TEN_NCC, DIACHI_NCC, SDT, EMAIL, MSTHUE, GHICHU) 
                           VALUES (@Ma, @Ten, @DiaChi, @Sdt, @Email, @Mst, @GhiChu)";

            DbHelper.Execute(sql,
                DbHelper.Param("@Ma", ma),
                DbHelper.Param("@Ten", ten),
                DbHelper.Param("@DiaChi", diachi),
                DbHelper.Param("@Sdt", sdt),
                DbHelper.Param("@Email", email ?? ""),
                DbHelper.Param("@Mst", mst ?? ""),
                DbHelper.Param("@GhiChu", ghichu ?? "")
            );
        }

        // 3. Update
        public void Update(string ma, string ten, string sdt, string diachi, string email, string mst, string ghichu)
        {
            string sql = @"UPDATE DM_NHACUNGCAP 
                           SET TEN_NCC = @Ten, 
                               DIACHI_NCC = @DiaChi, 
                               SDT = @Sdt, 
                               EMAIL = @Email, 
                               MSTHUE = @Mst, 
                               GHICHU = @GhiChu
                           WHERE MA_NCC = @Ma";

            DbHelper.Execute(sql,
                DbHelper.Param("@Ma", ma),
                DbHelper.Param("@Ten", ten),
                DbHelper.Param("@DiaChi", diachi),
                DbHelper.Param("@Sdt", sdt),
                DbHelper.Param("@Email", email ?? ""),
                DbHelper.Param("@Mst", mst ?? ""),
                DbHelper.Param("@GhiChu", ghichu ?? "")
            );
        }

        // 4. Delete (Corrected Logic)
        public void Delete(string ma)
        {
            // Check foreign key constraint in PHIEU table
            // Based on your schema: [PHIEU] has column [MA_NCC]
            string checkSql = "SELECT COUNT(*) FROM PHIEU WHERE MA_NCC = @Ma";

            int count = Convert.ToInt32(DbHelper.ExecuteScalar(checkSql, DbHelper.Param("@Ma", ma)));

            if (count > 0)
            {
                throw new Exception($"Nhà cung cấp này đã có {count} phiếu giao dịch. Không thể xóa!");
            }

            // If no transactions exist, safe to delete from DM_NHACUNGCAP
            string sql = "DELETE FROM DM_NHACUNGCAP WHERE MA_NCC = @Ma";
            DbHelper.Execute(sql, DbHelper.Param("@Ma", ma));
        }
    }
}