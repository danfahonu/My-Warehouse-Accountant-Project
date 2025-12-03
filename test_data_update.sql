-- Insert Dummy Approved Request (Status = 1)
INSERT INTO PHIEU_YEUCAU_NHAPKHO (NGAY_YEUCAU, MANV_YEUCAU, LYDO, TRANGTHAI)
VALUES (GETDATE(), 'NV001', N'Nhập hàng test', 1);

-- Get the ID of the newly inserted request
DECLARE @NewID bigint = SCOPE_IDENTITY();

-- Insert Details for the request
-- Ensure HH001 exists, if not, you might need to insert it or use an existing MAHH
IF NOT EXISTS (SELECT 1 FROM DM_HANGHOA WHERE MAHH = 'HH001')
BEGIN
    INSERT INTO DM_HANGHOA (MAHH, TENHH, DVT, GIAVON) VALUES ('HH001', N'Hàng Hóa Test', N'Cái', 10000);
END

INSERT INTO PHIEU_YEUCAU_NHAPKHO_CT (ID_YEUCAU, MAHH, SOLUONG_YEUCAU)
VALUES (@NewID, 'HH001', 10);

SELECT * FROM PHIEU_YEUCAU_NHAPKHO WHERE ID_YEUCAU = @NewID;
