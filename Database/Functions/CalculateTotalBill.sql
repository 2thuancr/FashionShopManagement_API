/*
    Tên hàm: CalculateTotalBill
    Mô tả: Hàm tính tổng giá trị hóa đơn
    Tham số:
        - @BillID: ID của hóa đơn cần tính tổng giá trị (INT)
    Kết quả: Tổng giá trị hóa đơn
*/

CREATE FUNCTION CalculateTotalBill (@BillID INT)
RETURNS DECIMAL(18,0)
AS
BEGIN
    -- Khai báo biến lưu tổng giá trị hóa đơn
    DECLARE @Total DECIMAL(18,0);

    -- Tính tổng giá trị hóa đơn
    SELECT @Total = SUM(Product.Price * BillInfo.Amount)
    FROM BillInfo
    JOIN Product ON BillInfo.ProductID = Product.Id
    WHERE BillInfo.BillID = @BillID;

    -- Trả về tổng giá trị hóa đơn
    RETURN @Total;
END;
