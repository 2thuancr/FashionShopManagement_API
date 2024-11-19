/*
    Tên trigger: UTG_InsertBillInfo
    Mô tả: Trigger này được sử dụng để cập nhật số lượng sản phẩm sau khi chèn chi tiết hóa đơn
    Bảng: BillInfo
    Sự kiện: AFTER INSERT
    Logic:
        - Trigger thực hiện sau khi chèn dữ liệu
        - Lấy ProductID và Amount từ bản ghi mới chèn vào
        - Cập nhật số lượng sản phẩm trong bảng Product dựa trên giá trị Amount
*/

CREATE TRIGGER UTG_InsertBillInfo
ON BillInfo
FOR INSERT
AS
BEGIN
    -- Tắt thông báo số bản ghi bị ảnh hưởng
    SET NOCOUNT ON;

    -- Bắt đầu một transaction, tất cả hoặc không có gì
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Khai báo các biến để lưu trữ giá trị từ bản ghi mới chèn vào
        DECLARE @productId INT;
        DECLARE @productAmount INT;

        -- Lấy giá trị ProductID và Amount từ bản ghi mới chèn vào (bảng inserted)
        SELECT @productId = ProductID, @productAmount = Amount
        FROM inserted;

        -- Cập nhật số lượng sản phẩm trong bảng Product dựa trên giá trị Amount
        UPDATE Product
        SET Quantity = Quantity - @productAmount
        WHERE Id = @productId;

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
