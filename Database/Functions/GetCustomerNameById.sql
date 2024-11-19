/*
    Tên hàm: GetCustomerNameById
    Mô tả: Hàm lấy tên khách hàng dựa trên ID
    Tham số:
        - @CustomerId: ID của khách hàng (INT)
    Kết quả: Tên của khách hàng
*/

CREATE FUNCTION GetCustomerNameById (@CustomerId INT)
RETURNS NVARCHAR(50)
AS
BEGIN
    -- Khai báo biến lưu tên khách hàng
    DECLARE @CustomerName NVARCHAR(50);

    -- Lấy tên khách hàng dựa trên ID
    SELECT @CustomerName = CustomerName
    FROM Customer
    WHERE CustomerId = @CustomerId;

    -- Trả về tên khách hàng
    RETURN @CustomerName;
END;
