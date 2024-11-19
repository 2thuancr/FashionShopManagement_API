/*
    Tên trigger: UTG_UpdateBillInfo
    Mô tả: Trigger này được sử dụng để cập nhật số lượng sản phẩm sau khi cập nhật chi tiết hóa đơn
    Bảng: BillInfo
    Sự kiện: AFTER UPDATE
    Logic:
        - Trigger thực hiện sau khi cập nhật dữ liệu
        - Lấy ProductID, Amount mới và Amount cũ từ các bản ghi cập nhật
        - Cập nhật số lượng sản phẩm trong bảng Product dựa trên giá trị Amount
*/

CREATE TRIGGER UTG_UpdateBillInfo
ON BillInfo
FOR UPDATE
AS
BEGIN
    -- Tắt thông báo số bản ghi bị ảnh hưởng
    SET NOCOUNT ON;

    -- Bắt đầu một transaction
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Khai báo các biến để lưu trữ giá trị từ bản ghi cập nhật
        DECLARE @ProductID INT;
        DECLARE @newAmount INT;
        DECLARE @oldAmount INT;

        -- Lấy giá trị ProductID, Amount mới và Amount cũ từ các bản ghi cập nhật
        SELECT @ProductID = ProductID, @newAmount = Amount FROM inserted;
        SELECT @oldAmount = Amount FROM deleted;

        -- Cập nhật số lượng sản phẩm trong bảng Product
        UPDATE Product
        SET Quantity = Quantity - (@newAmount - @oldAmount)
        WHERE Id = @ProductID;

        -- Nếu tất cả các hoạt động trong khối TRY thành công, ghi lại các thay đổi
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Nếu có bất kỳ lỗi nào xảy ra, hoàn tác tất cả các thay đổi trong transaction
        ROLLBACK TRANSACTION;
        -- Phát sinh lỗi để SQL Server xử lý
        THROW;
    END CATCH
END
GO
