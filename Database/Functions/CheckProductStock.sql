/*
    Tên function: CheckProductStock
    Mô tả: Function này được sử dụng để kiểm tra số lượng sản phẩm còn trong kho
    Tham số: 
        - @ProductID: ID của sản phẩm cần kiểm tra (INT)
    Output: INT - Số lượng sản phẩm còn trong kho
*/

CREATE FUNCTION CheckProductStock (@ProductID INT)
RETURNS INT
AS
BEGIN
    -- Khai báo biến lưu số lượng sản phẩm còn trong kho
    DECLARE @Stock INT;

    -- Lấy số lượng sản phẩm còn trong kho
    SELECT @Stock = Quantity
    FROM Product
    WHERE Id = @ProductID;

    -- Trả về số lượng sản phẩm còn trong kho
    RETURN @Stock;
END;
