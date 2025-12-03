-- 1. Stored Procedure tính giá vốn Bình Quân Gia Quyền
IF OBJECT_ID('sp_UpdateGiaVonBQGQ', 'P') IS NOT NULL
    DROP PROCEDURE sp_UpdateGiaVonBQGQ;
GO

CREATE PROCEDURE sp_UpdateGiaVonBQGQ
    @MAHH NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @TongGiaTri DECIMAL(18, 2);
    DECLARE @TongSoLuong INT;
    DECLARE @GiaVonMoi DECIMAL(18, 2);

    -- Tính tổng giá trị và tổng số lượng tồn kho hiện tại của hàng hóa
    SELECT 
        @TongGiaTri = SUM(SO_LUONG_TON * DON_GIA_NHAP),
        @TongSoLuong = SUM(SO_LUONG_TON)
    FROM KHO_CHITIET_TONKHO
    WHERE MAHH = @MAHH AND SO_LUONG_TON > 0;

    -- Nếu có tồn kho, tính giá vốn bình quân
    IF @TongSoLuong > 0
    BEGIN
        SET @GiaVonMoi = @TongGiaTri / @TongSoLuong;
        
        -- Cập nhật giá vốn vào bảng danh mục
        UPDATE DM_HANGHOA
        SET GIAVON = @GiaVonMoi
        WHERE MAHH = @MAHH;
    END
    ELSE
    BEGIN
        -- Nếu hết tồn kho, có thể giữ nguyên giá vốn cũ hoặc set về 0 tùy nghiệp vụ. 
        -- Ở đây ta giữ nguyên giá cũ để tham khảo cho lần nhập sau (hoặc set 0 nếu muốn).
        -- UPDATE DM_HANGHOA SET GIAVON = 0 WHERE MAHH = @MAHH;
        PRINT 'Het ton kho, khong cap nhat gia von (giu gia cu)';
    END
END;
GO

-- 2. Trigger tự động cập nhật Tồn Kho và Giá Vốn
IF OBJECT_ID('trg_UpdateTonKho', 'TR') IS NOT NULL
    DROP TRIGGER trg_UpdateTonKho;
GO

CREATE TRIGGER trg_UpdateTonKho
ON KHO_CHITIET_TONKHO
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @MAHH NVARCHAR(50);

    -- Lấy danh sách MAHH bị ảnh hưởng (từ cả Inserted và Deleted để cover hết các case)
    SELECT DISTINCT MAHH INTO #AffectedItems
    FROM (
        SELECT MAHH FROM Inserted
        UNION
        SELECT MAHH FROM Deleted
    ) AS Combined;

    DECLARE cur CURSOR FOR SELECT MAHH FROM #AffectedItems;
    OPEN cur;
    FETCH NEXT FROM cur INTO @MAHH;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        -- A. Cập nhật Số Lượng Tồn Kho Tổng (DM_HANGHOA.TONKHO)
        DECLARE @TongTon INT;
        SELECT @TongTon = ISNULL(SUM(SO_LUONG_TON), 0)
        FROM KHO_CHITIET_TONKHO
        WHERE MAHH = @MAHH;

        UPDATE DM_HANGHOA
        SET TONKHO = @TongTon
        WHERE MAHH = @MAHH;

        -- B. Cập nhật Giá Vốn Bình Quân (Gọi SP vừa tạo)
        EXEC sp_UpdateGiaVonBQGQ @MAHH;

        FETCH NEXT FROM cur INTO @MAHH;
    END

    CLOSE cur;
    DEALLOCATE cur;
    DROP TABLE #AffectedItems;
END;
GO
