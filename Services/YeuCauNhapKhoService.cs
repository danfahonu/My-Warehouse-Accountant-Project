using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DoAnLapTrinhQuanLy.Data;

namespace DoAnLapTrinhQuanLy.Services
{
    public class ChiTietYeuCauDTO
    {
        public string MaHH { get; set; }
        public string TenHH { get; set; }
        public string DVT { get; set; }
        public int SoLuong { get; set; }
        public string GhiChu { get; set; }
    }

    public class YeuCauNhapKhoService
    {
        public DataTable LayDanhSach()
        {
            string sql = @"
                SELECT ID, NGAY_YEUCAU, MANV_YEUCAU, 
                       CASE 
                           WHEN TRANGTHAI = 0 THEN N'Chờ duyệt'
                           WHEN TRANGTHAI = 1 THEN N'Đã duyệt'
                           WHEN TRANGTHAI = 2 THEN N'Đang nhập'
                           WHEN TRANGTHAI = 3 THEN N'Đã hoàn thành'
                           WHEN TRANGTHAI = 4 THEN N'Từ chối'
                       END AS TRANGTHAI_TEXT, 
                       TRANGTHAI,
                       LYDO 
                FROM PHIEU_YEUCAU_NHAPKHO 
                ORDER BY NGAY_YEUCAU DESC, ID DESC";
            return DbHelper.Query(sql);
        }

        public DataTable LayDanhSachNhanVien()
        {
            return DbHelper.Query("SELECT MANV, HOTEN FROM NHANVIEN WHERE HOATDONG = 1 ORDER BY HOTEN");
        }

        public DataTable LayDanhSachHangHoa()
        {
            return DbHelper.Query("SELECT MAHH, TENHH, DVT FROM DM_HANGHOA ORDER BY TENHH");
        }

        public DataSet GetChiTietPhieu(long id)
        {
            DataSet ds = new DataSet();

            string sqlMaster = "SELECT * FROM PHIEU_YEUCAU_NHAPKHO WHERE ID = @ID";
            DataTable dtMaster = DbHelper.Query(sqlMaster, DbHelper.Param("@ID", id));
            dtMaster.TableName = "Master";
            ds.Tables.Add(dtMaster);

            string sqlDetail = @"
                SELECT ct.MAHH, hh.TENHH, hh.DVT, ct.SOLUONG_YEUCAU, ct.GHICHU 
                FROM PHIEU_YEUCAU_NHAPKHO_CT ct
                JOIN DM_HANGHOA hh ON ct.MAHH = hh.MAHH
                WHERE ct.ID_YEUCAU = @ID";
            DataTable dtDetail = DbHelper.Query(sqlDetail, DbHelper.Param("@ID", id));
            dtDetail.TableName = "Detail";
            ds.Tables.Add(dtDetail);

            return ds;
        }

        public void LuuYeuCau(long id, DateTime ngay, string maNV, string lyDo, List<ChiTietYeuCauDTO> details)
        {
            if (details == null || details.Count == 0)
                throw new Exception("Danh sách hàng hóa không thể trống.");

            DbHelper.ExecuteTran((conn, tran) =>
            {
                long currentId = id;
                // 1. Insert/Update Master
                if (currentId == 0)
                {
                    string sqlInsert = @"INSERT INTO PHIEU_YEUCAU_NHAPKHO (NGAY_YEUCAU, MANV_YEUCAU, LYDO, TRANGTHAI)
                                         VALUES (@Ngay, @MaNV, @LyDo, 0); 
                                         SELECT SCOPE_IDENTITY();";
                    currentId = Convert.ToInt64(DbHelper.ScalarInTran(conn, tran, sqlInsert,
                        DbHelper.Param("@Ngay", ngay),
                        DbHelper.Param("@MaNV", maNV),
                        DbHelper.Param("@LyDo", lyDo)
                    ));
                }
                else
                {
                    string sqlUpdate = @"UPDATE PHIEU_YEUCAU_NHAPKHO 
                                         SET NGAY_YEUCAU = @Ngay, MANV_YEUCAU = @MaNV, LYDO = @LyDo
                                         WHERE ID = @ID AND TRANGTHAI = 0";
                    int rows = DbHelper.ExecuteInTran(conn, tran, sqlUpdate,
                        DbHelper.Param("@Ngay", ngay),
                        DbHelper.Param("@MaNV", maNV),
                        DbHelper.Param("@LyDo", lyDo),
                        DbHelper.Param("@ID", currentId)
                    );
                    if (rows == 0) throw new Exception("Không thể sửa phiếu đã duyệt hoặc không tồn tại.");

                    // Delete old details
                    DbHelper.ExecuteInTran(conn, tran, "DELETE FROM PHIEU_YEUCAU_NHAPKHO_CT WHERE ID_YEUCAU = @ID",
                        DbHelper.Param("@ID", currentId));
                }

                // 2. Insert Details
                string sqlDetail = @"INSERT INTO PHIEU_YEUCAU_NHAPKHO_CT (ID_YEUCAU, MAHH, SOLUONG_YEUCAU, GHICHU)
                                     VALUES (@ID, @MaHH, @SL, @GhiChu)";
                foreach (var item in details)
                {
                    DbHelper.ExecuteInTran(conn, tran, sqlDetail,
                        DbHelper.Param("@ID", currentId),
                        DbHelper.Param("@MaHH", item.MaHH),
                        DbHelper.Param("@SL", item.SoLuong),
                        DbHelper.Param("@GhiChu", item.GhiChu ?? "")
                    );
                }
                return 1;
            });
        }

        public void DuyetYeuCau(long id, string maNVDuyet, string ghiChuDuyet)
        {
            string sql = @"UPDATE PHIEU_YEUCAU_NHAPKHO 
                           SET TRANGTHAI = 1, MANV_DUYET = @MaNV, GHICHU_DUYET = @GhiChu, NGAY_DUYET = GETDATE()
                           WHERE ID = @ID AND TRANGTHAI = 0";

            int rows = DbHelper.Execute(sql,
                DbHelper.Param("@MaNV", maNVDuyet),
                DbHelper.Param("@GhiChu", ghiChuDuyet),
                DbHelper.Param("@ID", id)
            );

            if (rows == 0) throw new Exception("Phiếu không đúng trạng thái chờ duyệt hoặc không tồn tại.");
        }

        public void TuChoiYeuCau(long id, string maNVDuyet, string ghiChuDuyet)
        {
            string sql = @"UPDATE PHIEU_YEUCAU_NHAPKHO 
                           SET TRANGTHAI = 4, MANV_DUYET = @MaNV, GHICHU_DUYET = @GhiChu, NGAY_DUYET = GETDATE()
                           WHERE ID = @ID AND TRANGTHAI = 0";

            int rows = DbHelper.Execute(sql,
                DbHelper.Param("@MaNV", maNVDuyet),
                DbHelper.Param("@GhiChu", ghiChuDuyet),
                DbHelper.Param("@ID", id)
            );

            if (rows == 0) throw new Exception("Phiếu không đúng trạng thái chờ duyệt hoặc không tồn tại.");
        }

        public void XoaYeuCau(long id)
        {
            DbHelper.ExecuteTran((conn, tran) =>
            {
                // Check status first logic is implicit in Where clause, but let's be safe
                string checkSql = "SELECT TRANGTHAI FROM PHIEU_YEUCAU_NHAPKHO WHERE ID = @ID";
                object statusObj = DbHelper.ScalarInTran(conn, tran, checkSql, DbHelper.Param("@ID", id));

                if (statusObj == null) return 0;
                int status = Convert.ToInt32(statusObj);

                if (status != 0) throw new Exception("Chỉ được xóa phiếu ở trạng thái chờ duyệt.");

                DbHelper.ExecuteInTran(conn, tran, "DELETE FROM PHIEU_YEUCAU_NHAPKHO_CT WHERE ID_YEUCAU = @ID", DbHelper.Param("@ID", id));
                DbHelper.ExecuteInTran(conn, tran, "DELETE FROM PHIEU_YEUCAU_NHAPKHO WHERE ID = @ID", DbHelper.Param("@ID", id));

                return 1;
            });
        }
    }
}