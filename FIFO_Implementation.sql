USE [SALEGEARVN]
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_XuatKho_FIFO]
    @SoPhieu BIGINT,       -- ID của phiếu xuất vừa tạo (Bảng PHIEU)
    @MaHH NVARCHAR(30),    -- Mã hàng hóa cần xuất
    @SoLuongXuat INT       -- Số lượng cần xuất
AS
BEGIN
    SET NOCOUNT ON;

    -- 1. Khai báo biến
    DECLARE @SoLuongCanXuat INT = @SoLuongXuat;
    DECLARE @ID_Lo BIGINT;
    DECLARE @TonLo INT;
    DECLARE @GiaVonLo DECIMAL(18, 2);
    DECLARE @TongGiaVon DECIMAL(18, 2) = 0;
    
    -- Kiểm tra tổng tồn kho có đủ không trước khi chạy
    DECLARE @TongTonHienTai INT;
    SELECT @TongTonHienTai = SUM(SO_LUONG_TON) FROM KHO_CHITIET_TONKHO WHERE MAHH = @MaHH;
    
    IF ISNULL(@TongTonHienTai, 0) < @SoLuongXuat
    BEGIN
        RAISERROR (N'Lỗi: Hàng hóa %s không đủ tồn kho để xuất (Tồn: %d, Cần: %d)', 16, 1, @MaHH, @TongTonHienTai, @SoLuongXuat);
        RETURN;
    END

    -- 2. Khai báo CURSOR để duyệt qua các lô hàng còn tồn (Sắp xếp: Cũ nhất lên trước)
    DECLARE cursor_LoHang CURSOR FOR 
    SELECT ID, SO_LUONG_TON, DON_GIA_NHAP 
    FROM KHO_CHITIET_TONKHO 
    WHERE MAHH = @MaHH AND SO_LUONG_TON > 0 
    ORDER BY NGAY_NHAP ASC, ID ASC; -- FIFO: Ngày cũ lấy trước

    OPEN cursor_LoHang;
    FETCH NEXT FROM cursor_LoHang INTO @ID_Lo, @TonLo, @GiaVonLo;

    -- 3. Vòng lặp "Vét kho"
    WHILE @@FETCH_STATUS = 0 AND @SoLuongCanXuat > 0
    BEGIN
        IF @TonLo >= @SoLuongCanXuat -- Trường hợp 1: Lô này đủ hoặc dư hàng
        BEGIN
            -- Trừ kho lô này đúng số lượng cần
            UPDATE KHO_CHITIET_TONKHO 
            SET SO_LUONG_TON = SO_LUONG_TON - @SoLuongCanXuat 
            WHERE ID = @ID_Lo;
            
            -- Cộng dồn giá vốn (Số lượng lấy * Giá nhập lô này)
            SET @TongGiaVon = @TongGiaVon + (@SoLuongCanXuat * @GiaVonLo);
            
            -- Đã lấy đủ, thoát vòng lặp
            SET @SoLuongCanXuat = 0; 
        END
        ELSE -- Trường hợp 2: Lô này không đủ, phải lấy hết lô này rồi sang lô kế
        BEGIN
            -- Vét sạch lô này (về 0)
            UPDATE KHO_CHITIET_TONKHO 
            SET SO_LUONG_TON = 0 
            WHERE ID = @ID_Lo;
            
            -- Cộng dồn giá vốn
            SET @TongGiaVon = @TongGiaVon + (@TonLo * @GiaVonLo);
            
            -- Tính số lượng còn thiếu để tìm lô tiếp theo
            SET @SoLuongCanXuat = @SoLuongCanXuat - @TonLo;
        END

        FETCH NEXT FROM cursor_LoHang INTO @ID_Lo, @TonLo, @GiaVonLo;
    END

    CLOSE cursor_LoHang;
    DEALLOCATE cursor_LoHang;

    -- 4. Lưu lại Giá Vốn và Insert vào PHIEU_CT
    -- Lưu ý: DONGIA trong PHIEU_CT là Giá Bán, còn GIAVON là Giá Vốn chúng ta vừa tính
    -- Chúng ta Update dòng PHIEU_CT đã được insert trước đó hoặc Insert mới tại đây.
    -- Để đơn giản cho Code C#, ta sẽ Insert luôn tại đây.
    
    INSERT INTO PHIEU_CT (SOPHIEU, MAHH, SL, DONGIA, GIAVON)
    VALUES (@SoPhieu, @MaHH, @SoLuongXuat, 0, @TongGiaVon / NULLIF(@SoLuongXuat, 0)); 
    -- Lưu ý: DONGIA (Giá bán) sẽ được update từ C# hoặc tham số thêm nếu cần. 
    -- Ở đây tôi để tạm 0 để C# update sau hoặc bạn truyền thêm tham số @GiaBan vào SP này.
END
