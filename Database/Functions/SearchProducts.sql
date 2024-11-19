/*
    Tên hàm: SearchProducts
    Mô tả: Hàm tìm kiếm sản phẩm dựa trên tên hoặc loại sản phẩm
    Tham số:
        - @Filter: Chuỗi tìm kiếm (NVARCHAR(500))
    Kết quả: Bảng thông tin sản phẩm bao gồm các cột:
        - Id: ID của sản phẩm
        - Name: Tên của sản phẩm
        - Price: Giá của sản phẩm
        - Discount: Giảm giá của sản phẩm
        - Category: Loại của sản phẩm
        - Quantity: Số lượng tồn kho của sản phẩm
        - Size: Kích thước của sản phẩm
        - Image: Đường dẫn ảnh của sản phẩm
        - Description: Mô tả của sản phẩm
*/

CREATE FUNCTION SearchProducts (@Filter NVARCHAR(50))
RETURNS TABLE
AS
RETURN 
(
    SELECT Id, Name, Price, Discount, Category, Quantity, Size, Image, Description
    FROM Product
    WHERE dbo.LoaiBoDauTiengViet(Name) LIKE '%' + dbo.LoaiBoDauTiengViet(@Filter) + '%'
       OR dbo.LoaiBoDauTiengViet(Category) LIKE '%' + dbo.LoaiBoDauTiengViet(@Filter) + '%'
);
