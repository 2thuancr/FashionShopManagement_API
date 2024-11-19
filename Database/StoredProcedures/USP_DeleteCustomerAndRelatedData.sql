/*
    Tên stored procedure: USP_DeleteCustomerAndRelatedData
    Mô tả: Xóa khách hàng và dữ liệu liên quan
    Tham số:
        @CustomerId: INT - ID của khách hàng cần xóa
    Output: Không có
    Lỗi: Nếu có lỗi xảy ra trong quá trình xóa dữ liệu, sẽ rollback toàn bộ transaction và throw lỗi
*/

CREATE PROCEDURE USP_DeleteCustomerAndRelatedData
    @CustomerId INT
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Xóa chi tiết hóa đơn liên quan
        DELETE FROM BillInfo
        WHERE BillID IN (SELECT ID FROM Bill WHERE CustomerID = @CustomerId);

        -- Xóa hóa đơn liên quan
        DELETE FROM Bill
        WHERE CustomerID = @CustomerId;

        -- Xóa khách hàng
        DELETE FROM Customer
        WHERE CustomerId = @CustomerId;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
GO
