/*
    Tên trigger: UTG_UpdateBillAfterUpdateBillInfo
    Mô tả: Cập nhật tổng giá trị của hóa đơn sau khi cập nhật thông tin chi tiết hóa đơn
    Bảng trigger: BillInfo
    Sự kiện: AFTER UPDATE
    Logic:
        - Lấy BillID từ bản ghi mới cập nhật
        - Tính tổng giá trị các sản phẩm trong bảng BillInfo cho BillID này
        - Cập nhật tổng giá trị vào bảng Bill
*/

CREATE TRIGGER UTG_UpdateBillAfterUpdateBillInfo
ON BillInfo
AFTER UPDATE
AS
BEGIN
    -- Tắt thông báo số bản ghi bị ảnh hưởng
    SET NOCOUNT ON;

    DECLARE @BillID INT;

    -- Lấy BillID từ bản ghi mới cập nhật
    SELECT @BillID = i.BillID
    FROM inserted i;

    -- Tính tổng giá trị các sản phẩm trong bảng BillInfo cho BillID này
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
