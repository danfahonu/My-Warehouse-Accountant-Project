using System;
using System.Data;
using DoAnLapTrinhQuanLy.Data;

namespace DoAnLapTrinhQuanLy.Services
{
    public class CongNoService
    {
        // 1. Công nợ Khách Hàng (Phải Thu)
        public DataTable GetCongNoKhachHang(DateTime tuNgay, DateTime denNgay)
        {
            // SỬA: Đổi .Query thành .Proc
            return DbHelper.Proc("sp_BaoCaoCongNoKhachHang",
                DbHelper.Param("@TuNgay", tuNgay.Date),
                DbHelper.Param("@DenNgay", denNgay.Date.AddDays(1).AddSeconds(-1)));
        }

        // 2. Công nợ Nhà Cung Cấp (Phải Trả)
        public DataTable GetCongNoNhaCungCap(DateTime tuNgay, DateTime denNgay)
        {
            // SỬA: Đổi .Query thành .Proc
            return DbHelper.Proc("sp_BaoCaoCongNoNhaCungCap",
                DbHelper.Param("@TuNgay", tuNgay.Date),
                DbHelper.Param("@DenNgay", denNgay.Date.AddDays(1).AddSeconds(-1)));
        }
    }
}