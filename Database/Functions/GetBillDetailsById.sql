/*
    Tên hàm: GetBillDetailsById
    Mô tả: Hàm lấy thông tin chi tiết của hóa đơn dựa trên ID.
    Tham số:
        - @BillID: ID của hóa đơn cần lấy thông tin (INT)
    Kết quả: Bảng thông tin chi tiết của hóa đơn bao gồm các cột:
        - ID: ID của hóa đơn
        - BusinessTime: Thời gian khách hàng mua hàng
        - CustomerName: Tên của khách hàng
        - StaffName: Tên của nhân viên thực hiện hóa đơn
        - Discount: Giảm giá của hóa đơn
        - TotalPrice: Tổng giá trị của hóa đơn
        - Status: Trạng thái của hóa đơn
*/

CREATE FUNCTION GetBillDetailsById (@BillID INT)
RETURNS TABLE
AS
RETURN 
(
    SELECT b.ID, b.BusinessTime, c.CustomerName, s.SurnameStaff + ' ' + s.NameStaff AS StaffName, b.Discount, b.TotalPrice, b.Status
    FROM Bill b
    LEFT JOIN Customer c ON b.CustomerID = c.CustomerId
    LEFT JOIN Staff s ON b.StaffID = s.StaffId
    WHERE b.ID = @BillID
);


-- Đầy đủ hơn

CREATE FUNCTION GetBillDetailsById (@BillID INT)
RETURNS TABLE
AS
RETURN 
(
    SELECT 
        b.ID, 
        b.BusinessTime, 
        c.CustomerName, 
        s.SurnameStaff + ' ' + s.NameStaff AS StaffName, 
        b.Discount, 
        b.TotalPrice, 
        CASE 
            WHEN b.Status = 0 THEN 'Chưa thanh toán'
            WHEN b.Status = 1 THEN 'Đã thanh toán'
            ELSE 'Không xác định'
        END AS Status
    FROM Bill b
    LEFT JOIN Customer c ON b.CustomerID = c.CustomerId
    LEFT JOIN Staff s ON b.StaffID = s.StaffId
    WHERE b.ID = @BillID
);
