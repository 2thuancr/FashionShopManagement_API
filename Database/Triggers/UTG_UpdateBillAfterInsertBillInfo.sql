/*
    Tên trigger: UTG_UpdateBillAfterInsertBillInfo
    Mô tả: Trigger này được sử dụng để cập nhật tổng giá trị hóa đơn sau khi chèn chi tiết hóa đơn
    Bảng: BillInfo
    Sự kiện: AFTER INSERT
    Logic:
        - Trigger thực hiện sau khi chèn dữ liệu
        - Lấy BillID từ bản ghi mới chèn vào
        - Tính tổng giá trị các sản phẩm trong bảng BillInfo cho BillID này
        - Cập nhật tổng giá trị vào bảng Bill
*/

CREATE TRIGGER UTG_UpdateBillAfterInsertBillInfo
ON BillInfo
AFTER INSERT
AS
BEGIN
    -- Tắt thông báo số bản ghi bị ảnh hưởng
    SET NOCOUNT ON;

    DECLARE @BillID INT;

    -- Lấy BillID từ bản ghi mới chèn vào
    SELECT @BillID = i.BillID
    FROM inserted as i;

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
