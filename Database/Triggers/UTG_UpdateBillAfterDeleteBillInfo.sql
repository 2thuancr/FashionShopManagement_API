/*
    Tên trigger: UTG_UpdateBillAfterDeleteBillInfo
    Mô tả: Trigger này được sử dụng để cập nhật tổng giá trị hóa đơn sau khi xóa chi tiết hóa đơn
    Bảng: BillInfo
    Sự kiện: AFTER DELETE
    Logic:
        - Trigger thực hiện sau khi xóa dữ liệu
        - Lấy BillID từ bản ghi vừa bị xóa
        - Tính tổng giá trị các sản phẩm còn lại trong bảng BillInfo cho BillID này
        - Cập nhật tổng giá trị vào bảng Bill
*/

CREATE TRIGGER UTG_UpdateBillAfterDeleteBillInfo
ON BillInfo
AFTER DELETE
AS
BEGIN
    -- Tắt thông báo số bản ghi bị ảnh hưởng
    SET NOCOUNT ON;

    DECLARE @BillID INT;

    -- Lấy BillID từ bản ghi vừa bị xóa
    SELECT @BillID = d.BillID
    FROM deleted d;

    -- Tính tổng giá trị các sản phẩm còn lại trong bảng BillInfo cho BillID này
    UPDATE Bill
    SET TotalPrice = (
        SELECT SUM(p.Price * bi.Amount)
        FROM BillInfo bi
        JOIN Product p ON bi.ProductID = p.Id
        WHERE bi.BillID = @BillID
    )
    WHERE ID = @BillID;

    --Tính tổng giảm giá cho hóa đơn
    UPDATE Bill
    SET Discount = (
        SELECT SUM(p.Discount * bi.Amount)
        FROM BillInfo bi
        JOIN Product p ON bi.ProductID = p.Id
        WHERE bi.BillID = @BillID
    )
    WHERE ID = @BillID;
END
GO
