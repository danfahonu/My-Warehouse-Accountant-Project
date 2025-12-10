using System;
using System.Collections.Generic;
using System.Data;
using DoAnLapTrinhQuanLy.Data; // Dùng DbHelper Xịn

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
        // 1. Lấy danh sách hiển thị lên Form Yêu Cầu (Admin/Kho xem)
        public DataTable LayDanhSach()
        {
            string sql = @"
                SELECT p.ID, p.NGAY_YEUCAU, nv.HOTEN AS NGUOI_YEUCAU, 
                       CASE 
                           WHEN p.TRANGTHAI = 0 THEN N'Chờ duyệt'
                           WHEN p.TRANGTHAI = 1 THEN N'Đã duyệt'
                           WHEN p.TRANGTHAI = 2 THEN N'Đang nhập'
                           WHEN p.TRANGTHAI = 3 THEN N'Đã hoàn thành'
                           WHEN p.TRANGTHAI = 4 THEN N'Từ chối'
                       END AS TRANGTHAI_TEXT, 
                       p.TRANGTHAI, p.LYDO 
                FROM PHIEU_YEUCAU_NHAPKHO p
                LEFT JOIN NHANVIEN nv ON p.MANV_YEUCAU = nv.MANV
                ORDER BY p.NGAY_YEUCAU DESC, p.ID DESC";
            return DbHelper.Query(sql);
        }

        // 2. Load ComboBox Nhân Viên & Hàng Hóa
        public DataTable LayDanhSachNhanVien() => DbHelper.Query("SELECT MANV, HOTEN FROM NHANVIEN WHERE HOATDONG = 1 ORDER BY HOTEN");
        public DataTable LayDanhSachHangHoa() => DbHelper.Query("SELECT MAHH, TENHH, DVT FROM DM_HANGHOA WHERE ACTIVE = 1 ORDER BY TENHH");

        // 3. Lấy chi tiết phiếu (Xem lại phiếu cũ)
        public DataSet GetChiTietPhieu(long id)
        {
            DataSet ds = new DataSet();

            // Master
            string sqlMaster = "SELECT * FROM PHIEU_YEUCAU_NHAPKHO WHERE ID = @ID";
            DataTable dtMaster = DbHelper.Query(sqlMaster, DbHelper.Param("@ID", id));
            dtMaster.TableName = "Master";
            ds.Tables.Add(dtMaster);

            // Detail (Lấy thêm SOLUONG_DANHAP để user biết tiến độ)
            string sqlDetail = @"
                SELECT ct.MAHH, hh.TENHH, hh.DVT, ct.SOLUONG_YEUCAU, ct.SOLUONG_DANHAP, ct.GHICHU 
                FROM PHIEU_YEUCAU_NHAPKHO_CT ct
                JOIN DM_HANGHOA hh ON ct.MAHH = hh.MAHH
                WHERE ct.ID_YEUCAU = @ID";
            DataTable dtDetail = DbHelper.Query(sqlDetail, DbHelper.Param("@ID", id));
            dtDetail.TableName = "Detail";
            ds.Tables.Add(dtDetail);

            return ds;
        }

        // 4. Lưu phiếu yêu cầu (Thêm/Sửa)
        public void LuuYeuCau(long id, DateTime ngay, string maNV, string lyDo, List<ChiTietYeuCauDTO> details)
        {
            if (details == null || details.Count == 0) throw new Exception("Danh sách hàng hóa trống.");

            DbHelper.ExecuteTran((conn, tran) =>
            {
                long currentId = id;

                // A. Xử lý Master
                if (currentId == 0) // Thêm mới
                {
                    string sqlInsert = @"INSERT INTO PHIEU_YEUCAU_NHAPKHO (NGAY_YEUCAU, MANV_YEUCAU, LYDO, TRANGTHAI)
                                         VALUES (@Ngay, @MaNV, @LyDo, 0); SELECT SCOPE_IDENTITY();";
                    currentId = Convert.ToInt64(DbHelper.ScalarInTran(conn, tran, sqlInsert,
                        DbHelper.Param("@Ngay", ngay), DbHelper.Param("@MaNV", maNV), DbHelper.Param("@LyDo", lyDo)));
                }
                else // Sửa
                {
                    // Chỉ cho sửa khi Chờ duyệt (0)
                    string sqlCheck = "SELECT TRANGTHAI FROM PHIEU_YEUCAU_NHAPKHO WHERE ID = @ID";
                    int status = Convert.ToInt32(DbHelper.ScalarInTran(conn, tran, sqlCheck, DbHelper.Param("@ID", currentId)));
                    if (status != 0) throw new Exception("Chỉ được sửa phiếu khi đang Chờ duyệt.");

                    string sqlUpdate = "UPDATE PHIEU_YEUCAU_NHAPKHO SET NGAY_YEUCAU=@N, MANV_YEUCAU=@M, LYDO=@L WHERE ID=@ID";
                    DbHelper.ExecuteInTran(conn, tran, sqlUpdate,
                        DbHelper.Param("@N", ngay), DbHelper.Param("@M", maNV),
                        DbHelper.Param("@L", lyDo), DbHelper.Param("@ID", currentId));

                    // Xóa chi tiết cũ để thêm lại
                    DbHelper.ExecuteInTran(conn, tran, "DELETE FROM PHIEU_YEUCAU_NHAPKHO_CT WHERE ID_YEUCAU = @ID", DbHelper.Param("@ID", currentId));
                }

                // B. Xử lý Detail
                string sqlCT = @"INSERT INTO PHIEU_YEUCAU_NHAPKHO_CT (ID_YEUCAU, MAHH, SOLUONG_YEUCAU, SOLUONG_DANHAP, GHICHU)
                                 VALUES (@ID, @MaHH, @SL, 0, @GhiChu)"; // Mặc định Đã nhập = 0

                foreach (var item in details)
                {
                    DbHelper.ExecuteInTran(conn, tran, sqlCT,
                        DbHelper.Param("@ID", currentId),
                        DbHelper.Param("@MaHH", item.MaHH),
                        DbHelper.Param("@SL", item.SoLuong),
                        DbHelper.Param("@GhiChu", item.GhiChu ?? "")
                    );
                }
                return 1;
            });
        }

        // 5. Các hàm Duyệt/Từ chối/Xóa (Giữ nguyên logic của bà, tui chuẩn hóa lại xíu)
        public void DuyetYeuCau(long id, string maNVDuyet, string ghiChu)
        {
            string sql = "UPDATE PHIEU_YEUCAU_NHAPKHO SET TRANGTHAI=1, MANV_DUYET=@Ma, GHICHU_DUYET=@Note, NGAY_DUYET=GETDATE() WHERE ID=@ID AND TRANGTHAI=0";
            if (DbHelper.Execute(sql, DbHelper.Param("@Ma", maNVDuyet), DbHelper.Param("@Note", ghiChu), DbHelper.Param("@ID", id)) == 0)
                throw new Exception("Phiếu không hợp lệ để duyệt.");
        }

        public void TuChoiYeuCau(long id, string maNVDuyet, string ghiChu)
        {
            string sql = "UPDATE PHIEU_YEUCAU_NHAPKHO SET TRANGTHAI=4, MANV_DUYET=@Ma, GHICHU_DUYET=@Note, NGAY_DUYET=GETDATE() WHERE ID=@ID AND TRANGTHAI=0";
            if (DbHelper.Execute(sql, DbHelper.Param("@Ma", maNVDuyet), DbHelper.Param("@Note", ghiChu), DbHelper.Param("@ID", id)) == 0)
                throw new Exception("Phiếu không hợp lệ để từ chối.");
        }

        public void XoaYeuCau(long id)
        {
            DbHelper.ExecuteTran((conn, tran) => {
                // Check trạng thái
                int stt = Convert.ToInt32(DbHelper.ScalarInTran(conn, tran, "SELECT TRANGTHAI FROM PHIEU_YEUCAU_NHAPKHO WHERE ID=@ID", DbHelper.Param("@ID", id)));
                if (stt != 0) throw new Exception("Chỉ xóa được phiếu Chờ duyệt.");

                DbHelper.ExecuteInTran(conn, tran, "DELETE FROM PHIEU_YEUCAU_NHAPKHO_CT WHERE ID_YEUCAU=@ID", DbHelper.Param("@ID", id));
                DbHelper.ExecuteInTran(conn, tran, "DELETE FROM PHIEU_YEUCAU_NHAPKHO WHERE ID=@ID", DbHelper.Param("@ID", id));
                return 1;
            });
        }

        // =========================================================================
        // PHẦN MỚI THÊM CHO QUY TRÌNH NHẬP KHO ERP (Bước 2 của bà đây nè)
        // =========================================================================

        // 6. Lấy danh sách phiếu ĐƯỢC PHÉP NHẬP (Đã duyệt (1) hoặc Đang nhập dở (2))
        public DataTable GetListPhieuYeuCauChoNhap()
        {
            string sql = @"
                SELECT ID, NGAY_YEUCAU, nv.HOTEN as NGUOI_YEUCAU, LYDO,
                       CASE WHEN TRANGTHAI=1 THEN N'Đã duyệt' ELSE N'Đang nhập' END as TRANGTHAI
                FROM PHIEU_YEUCAU_NHAPKHO p
                LEFT JOIN NHANVIEN nv ON p.MANV_YEUCAU = nv.MANV
                WHERE TRANGTHAI IN (1, 2) -- Chỉ lấy phiếu Đã duyệt hoặc Đang nhập
                ORDER BY NGAY_YEUCAU DESC";
            return DbHelper.Query(sql);
        }

        // 7. Lấy chi tiết hàng CÒN THIẾU để đổ vào Form Nhập
        public DataTable GetChiTietCanNhap(long idYeuCau)
        {
            string sql = @"
                SELECT 
                    ct.MAHH, 
                    h.TENHH, 
                    h.DVT, 
                    ct.SOLUONG_YEUCAU, 
                    ct.SOLUONG_DANHAP,
                    (ct.SOLUONG_YEUCAU - ct.SOLUONG_DANHAP) AS SOLUONG_CAN_NHAP -- Tự tính số còn lại
                FROM PHIEU_YEUCAU_NHAPKHO_CT ct
                JOIN DM_HANGHOA h ON ct.MAHH = h.MAHH
                WHERE ct.ID_YEUCAU = @ID 
                  AND (ct.SOLUONG_YEUCAU - ct.SOLUONG_DANHAP) > 0"; // Chỉ lấy dòng nào còn chưa nhập đủ

            return DbHelper.Query(sql, DbHelper.Param("@ID", idYeuCau));
        }

        // 8. Cập nhật tiến độ (Sẽ được gọi từ PhieuNhapService)
        public void UpdateTienDo(long idYeuCau, string maHH, int slNhapThem)
        {
            string sql = "UPDATE PHIEU_YEUCAU_NHAPKHO_CT SET SOLUONG_DANHAP = SOLUONG_DANHAP + @SL WHERE ID_YEUCAU=@ID AND MAHH=@Ma";
            DbHelper.Execute(sql, DbHelper.Param("@SL", slNhapThem), DbHelper.Param("@ID", idYeuCau), DbHelper.Param("@Ma", maHH));

            // Cập nhật trạng thái phiếu (Nếu xong hết -> 3: Hoàn thành, còn chưa -> 2: Đang nhập)
            string sqlStt = @"
                UPDATE PHIEU_YEUCAU_NHAPKHO 
                SET TRANGTHAI = CASE 
                    WHEN NOT EXISTS(SELECT 1 FROM PHIEU_YEUCAU_NHAPKHO_CT WHERE ID_YEUCAU=@ID AND SOLUONG_YEUCAU > SOLUONG_DANHAP) THEN 3 
                    ELSE 2 
                END
                WHERE ID=@ID";
            DbHelper.Execute(sqlStt, DbHelper.Param("@ID", idYeuCau));
        }
    }
}