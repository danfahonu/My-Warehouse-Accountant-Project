USE [SALEGEARVN]
GO

-- 1. Create View vw_TonKhoHienTai
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vw_TonKhoHienTai]'))
BEGIN
    EXEC dbo.sp_executesql @statement = N'
    CREATE VIEW [dbo].[vw_TonKhoHienTai]
    AS
    SELECT 
        MAHH, 
        SUM(SO_LUONG_TON) AS TON_HIEN_TAI
    FROM dbo.KHO_CHITIET_TONKHO
    GROUP BY MAHH
    '
END
GO

-- 2. Create Stored Procedure sp_XuatKho_FIFO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_XuatKho_FIFO]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[sp_XuatKho_FIFO]
GO

CREATE PROCEDURE [dbo].[sp_XuatKho_FIFO]
    @SoPhieu BIGINT,
    @MaHH NVARCHAR(30),
    @SoLuongXuat INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @SoLuongCanXuat INT = @SoLuongXuat;
    DECLARE @TongGiaVon DECIMAL(18, 2) = 0;
    
    DECLARE @ID_Lo BIGINT;
    DECLARE @TonLo INT;
    DECLARE @GiaVonLo DECIMAL(18, 2);
    
    -- Check total stock first
    DECLARE @TongTon INT;
    SELECT @TongTon = SUM(SO_LUONG_TON) 
    FROM KHO_CHITIET_TONKHO 
    WHERE MAHH = @MaHH;
    
    IF ISNULL(@TongTon, 0) < @SoLuongCanXuat
    BEGIN
        RAISERROR(N'Không đủ tồn kho để xuất.', 16, 1);
        RETURN;
    END

    -- Cursor for FIFO (Oldest first)
    DECLARE cur_FIFO CURSOR FOR
    SELECT ID, SO_LUONG_TON, DON_GIA_NHAP
    FROM KHO_CHITIET_TONKHO
    WHERE MAHH = @MaHH AND SO_LUONG_TON > 0
    ORDER BY NGAY_NHAP ASC, ID ASC;

    OPEN cur_FIFO;
    FETCH NEXT FROM cur_FIFO INTO @ID_Lo, @TonLo, @GiaVonLo;

    WHILE @@FETCH_STATUS = 0 AND @SoLuongCanXuat > 0
    BEGIN
        DECLARE @SoLuongLay INT;

        IF @TonLo >= @SoLuongCanXuat
        BEGIN
            -- Batch has enough
            SET @SoLuongLay = @SoLuongCanXuat;
        END
        ELSE
        BEGIN
            -- Batch not enough, take all
            SET @SoLuongLay = @TonLo;
        END

        -- Deduct from Batch
        UPDATE KHO_CHITIET_TONKHO
        SET SO_LUONG_TON = SO_LUONG_TON - @SoLuongLay
        WHERE ID = @ID_Lo;

        -- Accumulate Cost
        SET @TongGiaVon = @TongGiaVon + (@SoLuongLay * @GiaVonLo);

        -- Decrease needed quantity
        SET @SoLuongCanXuat = @SoLuongCanXuat - @SoLuongLay;

        FETCH NEXT FROM cur_FIFO INTO @ID_Lo, @TonLo, @GiaVonLo;
    END

    CLOSE cur_FIFO;
    DEALLOCATE cur_FIFO;

    -- Update PHIEU_CT with calculated Cost Price (Average Cost of this transaction)
    IF @SoLuongXuat > 0
    BEGIN
        UPDATE PHIEU_CT
        SET GIAVON = @TongGiaVon / @SoLuongXuat
        WHERE SOPHIEU = @SoPhieu AND MAHH = @MaHH;
    END
END
GO
