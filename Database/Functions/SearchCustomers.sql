/* 
    Tên hàm: SearchCustomers
    Mô tả: Hàm tìm kiếm khách hàng dựa trên tên hoặc số điện thoại
    Tham số:
        - @Filter: Chuỗi tìm kiếm (NVARCHAR(500))
    Kết quả: Bảng thông tin khách hàng bao gồm các cột:
        - CustomerId: ID của khách hàng
        - CustomerName: Tên của khách hàng
        - PhoneNumber: Số điện thoại của khách hàng
        - DoB: Ngày sinh của khách hàng
        - Address: Địa chỉ của khách hàng
*/

CREATE FUNCTION SearchCustomers (@Filter NVARCHAR(500))
RETURNS TABLE
AS
RETURN 
(
    SELECT CustomerId, CustomerName, PhoneNumber, DoB, Address
    FROM Customer
    WHERE (CustomerName LIKE '%' + @Filter + '%')
       OR (PhoneNumber LIKE '%' + @Filter + '%')
);




CREATE FUNCTION SearchCustomers (@Filter NVARCHAR(500))
RETURNS TABLE
AS
RETURN 
(
    SELECT CustomerId, CustomerName, PhoneNumber, DoB, Address
    FROM Customer
    WHERE (dbo.LoaiBoDauTiengViet(CustomerName) LIKE '%' + dbo.LoaiBoDauTiengViet(@Filter) + '%')
       OR (PhoneNumber LIKE '%' + @Filter + '%')
);
