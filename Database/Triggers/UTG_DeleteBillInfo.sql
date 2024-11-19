CREATE TRIGGER [dbo].[UTG_DeleteBillInfo]
ON [dbo].[BillInfo]
FOR DELETE
AS
BEGIN
    -- Bắt đầu giao dịch
    BEGIN TRANSACTION;

    DECLARE @ProductID INT;
    DECLARE @Amount INT;

    -- Lấy giá trị ProductID và Amount từ bản ghi bị xóa
    SELECT @ProductID = ProductID, @Amount = Amount FROM deleted;

    -- Cập nhật số lượng sản phẩm trong bảng Product
    UPDATE Product
    SET Quantity = Quantity + @Amount
    WHERE Id = @ProductID;

    -- Kiểm tra lỗi và xác nhận giao dịch
    IF @@ERROR <> 0
    BEGIN
        -- Hủy bỏ giao dịch nếu có lỗi
        ROLLBACK TRANSACTION;
    END
    ELSE
    BEGIN
        -- Xác nhận giao dịch nếu không có lỗi
        COMMIT TRANSACTION;
    END
END;
