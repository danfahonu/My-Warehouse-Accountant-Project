-- SP Báo cáo Nhập Xuất Tồn
CREATE PROCEDURE sp_BaoCao_NhapXuatTon
    @TuNgay DATETIME,
    @DenNgay DATETIME
AS
BEGIN
    SELECT 
        hh.MAHH, 
        hh.TENHH, 
        hh.DVT,
        ISNULL(SUM(CASE WHEN p.LOAI = 'N' THEN ct.SL ELSE 0 END), 0) AS NHAP,
        ISNULL(SUM(CASE WHEN p.LOAI = 'X' THEN ct.SL ELSE 0 END), 0) AS XUAT,
        ISNULL(v.TON_HIEN_TAI, 0) AS TON_CUOI
    FROM DM_HANGHOA hh
    LEFT JOIN PHIEU_CT ct ON hh.MAHH = ct.MAHH
    LEFT JOIN PHIEU p ON ct.SOPHIEU = p.SOPHIEU
    LEFT JOIN vw_TonKhoHienTai v ON hh.MAHH = v.MAHH
    WHERE (p.NGAYLAP BETWEEN @TuNgay AND @DenNgay) OR p.SOPHIEU IS NULL
    GROUP BY hh.MAHH, hh.TENHH, hh.DVT, v.TON_HIEN_TAI
    ORDER BY hh.TENHH;
END
GO

-- SP Báo cáo Doanh Thu
CREATE PROCEDURE sp_BaoCao_DoanhThu
    @TuNgay DATETIME,
    @DenNgay DATETIME
AS
BEGIN
    SELECT 
        p.NGAYLAP,
        p.SOPHIEU,
        kh.TENKH,
        SUM(ct.SL * ct.DONGIA) AS DOANH_THU,
        p.GHICHU
    FROM PHIEU p
    JOIN PHIEU_CT ct ON p.SOPHIEU = ct.SOPHIEU
    JOIN DANHMUCKHACHHANG kh ON p.MAKH = kh.MAKH
    WHERE p.LOAI = 'X' AND p.TRANGTHAI = 1 -- Chỉ lấy phiếu xuất đã hoàn thành
    AND p.NGAYLAP BETWEEN @TuNgay AND @DenNgay
    GROUP BY p.NGAYLAP, p.SOPHIEU, kh.TENKH, p.GHICHU
    ORDER BY p.NGAYLAP DESC;
END
GO
