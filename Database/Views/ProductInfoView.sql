/*
    Tên view: ProductInfoView
    Mô tả: View này được sử dụng để lấy thông tin sản phẩm cùng với tổng số lượng đã bán
    Bảng: Product, BillInfo
    Logic:
        - View lấy thông tin sản phẩm từ bảng Product
        - Tính tổng số lượng đã bán của sản phẩm đó từ bảng BillInfo
        - Kết quả trả về bao gồm thông tin sản phẩm và tổng số lượng đã bán
*/

CREATE VIEW ProductInfoView AS
SELECT 
    p.Id AS ProductId,
    p.Name AS ProductName,
    p.Price,
    p.Discount,
    p.Category,
    p.Quantity,
    p.Size,
    p.Image,
    p.Description,
    SUM(bi.Amount) AS TotalSold
FROM 
    Product p
LEFT JOIN 
    BillInfo bi ON p.Id = bi.ProductID
GROUP BY 
    p.Id, p.Name, p.Price, p.Discount, p.Category, p.Quantity, p.Size, p.Image, p.Description;
