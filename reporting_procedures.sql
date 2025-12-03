-- 1. Báo cáo Tồn Kho Tổng Hợp (Stock Summary)
-- Logic: Calculates Opening, In, Out, Closing Stock for a period
CREATE OR ALTER PROCEDURE sp_Report_TonKhoTongHop
    @FromDate DATE,
    @ToDate DATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Calculate Opening Stock (Before FromDate)
    WITH TonDau AS (
        SELECT 
            MAHH, 
            SUM(CASE WHEN LOAI_PHIEU = 'N' THEN SO_LUONG_NHAP ELSE -SO_LUONG_NHAP END) AS SL_DAU
        FROM KHO_CHITIET_TONKHO t
        JOIN PHIEU p ON t.ID_PHIEUNHAP_CT = p.SOPHIEU -- Assuming link, or use Date directly if available
        -- Actually KHO_CHITIET_TONKHO has NGAY_NHAP. Let's use that.
        WHERE t.NGAY_NHAP < @FromDate
        GROUP BY MAHH
    ),
    -- Calculate In/Out during Period
    NhapXuat AS (
        SELECT 
            MAHH,
            SUM(CASE WHEN SO_LUONG_NHAP > 0 THEN SO_LUONG_NHAP ELSE 0 END) AS SL_NHAP,
            SUM(CASE WHEN SO_LUONG_NHAP < 0 THEN -SO_LUONG_NHAP ELSE 0 END) AS SL_XUAT
        FROM KHO_CHITIET_TONKHO
        WHERE NGAY_NHAP BETWEEN @FromDate AND @ToDate
        GROUP BY MAHH
    )
    SELECT 
        h.MAHH,
        h.TENHH,
        h.DVT,
        ISNULL(td.SL_DAU, 0) AS TonDau,
        ISNULL(nx.SL_NHAP, 0) AS Nhap,
        ISNULL(nx.SL_XUAT, 0) AS Xuat,
        (ISNULL(td.SL_DAU, 0) + ISNULL(nx.SL_NHAP, 0) - ISNULL(nx.SL_XUAT, 0)) AS TonCuoi,
        ((ISNULL(td.SL_DAU, 0) + ISNULL(nx.SL_NHAP, 0) - ISNULL(nx.SL_XUAT, 0)) * h.GIAVON) AS GiaTriTon
    FROM DM_HANGHOA h
    LEFT JOIN TonDau td ON h.MAHH = td.MAHH
    LEFT JOIN NhapXuat nx ON h.MAHH = nx.MAHH
    WHERE h.ACTIVE = 1
    ORDER BY h.TENHH;
END;
GO

-- 2. Báo cáo Doanh Thu & Lợi Nhuận (Revenue & Profit)
CREATE OR ALTER PROCEDURE sp_Report_DoanhThuLoiNhuan
    @FromDate DATE,
    @ToDate DATE
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        p.NGAYLAP AS Ngay,
        SUM(ct.SL * ct.DONGIA) AS DoanhThu,
        SUM(ct.SL * h.GIAVON) AS GiaVon, -- Using Current Cost as proxy
        SUM((ct.SL * ct.DONGIA) - (ct.SL * h.GIAVON)) AS LoiNhuanGop
    FROM PHIEU p
    JOIN PHIEU_CT ct ON p.SOPHIEU = ct.SOPHIEU
    JOIN DM_HANGHOA h ON ct.MAHH = h.MAHH
    WHERE p.LOAI = 'X' -- Export/Sale
      AND p.TRANGTHAI = 1 -- Approved/Completed
      AND p.NGAYLAP BETWEEN @FromDate AND @ToDate
    GROUP BY p.NGAYLAP
    ORDER BY p.NGAYLAP;
END;
GO

-- 3. Thẻ Kho (Stock Card / Transaction History)
CREATE OR ALTER PROCEDURE sp_Report_TheKho
    @MaHH NVARCHAR(50),
    @FromDate DATE,
    @ToDate DATE
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        t.NGAY_NHAP AS Ngay,
        CASE 
            WHEN t.SO_LUONG_NHAP > 0 THEN N'Nhập' 
            ELSE N'Xuất' 
        END AS Loai,
        ABS(t.SO_LUONG_NHAP) AS SoLuong,
        t.DON_GIA_NHAP AS DonGia,
        (ABS(t.SO_LUONG_NHAP) * t.DON_GIA_NHAP) AS ThanhTien
    FROM KHO_CHITIET_TONKHO t
    WHERE t.MAHH = @MaHH
      AND t.NGAY_NHAP BETWEEN @FromDate AND @ToDate
    ORDER BY t.NGAY_NHAP DESC, t.ID_KHO_CT DESC;
END;
GO
