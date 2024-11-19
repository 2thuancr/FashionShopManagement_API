/*
    Tên hàm: GetUserNameById
    Mô tả: Lấy tên người dùng dựa trên ID
    Tham số:
        - @AccountId: ID người dùng cần lấy tên (INT)
    Kết quả: Tên người dùng
*/

CREATE FUNCTION GetUserNameById (@AccountId INT)
RETURNS VARCHAR(100)
AS
BEGIN
    -- Khai báo biến lưu tên người dùng
    DECLARE @UserName VARCHAR(100);

    -- Lấy tên người dùng dựa trên ID
    SELECT @UserName = UserName
    FROM Account
    WHERE Id = @AccountId;

    -- Trả về tên người dùng
    RETURN @UserName;
END;
