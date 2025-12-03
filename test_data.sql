-- Create a dummy Approved Request (Status = 2)
INSERT INTO PHIEU_YEUCAU_NHAPKHO (NGAY_YEUCAU, MANV_YEUCAU, LYDO, TRANGTHAI)
VALUES (GETDATE(), 'NV001', N'Nhập hàng test tính năng chọn phiếu', 2);

-- Get the ID of the inserted request
DECLARE @NewID bigint;
SET @NewID = SCOPE_IDENTITY();

-- Insert details for this request
-- Assuming 'HH001' and 'HH002' exist in DM_HANGHOA. If not, please adjust.
INSERT INTO PHIEU_YEUCAU_NHAPKHO_CT (ID_YEUCAU, MAHH, SOLUONG_YEUCAU)
VALUES (@NewID, 'HH001', 10),
       (@NewID, 'HH002', 5);

SELECT * FROM PHIEU_YEUCAU_NHAPKHO WHERE ID_YEUCAU = @NewID;
SELECT * FROM PHIEU_YEUCAU_NHAPKHO_CT WHERE ID_YEUCAU = @NewID;
