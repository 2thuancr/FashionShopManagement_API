/*
    Tên trigger: UTG_PreventDuplicateAccount
    Mô tả: Trigger này được sử dụng để ngăn chặn việc chèn dữ liệu trùng lặp vào bảng Account
    Bảng: Account
    Sự kiện: INSTEAD OF INSERT
    Logic:
        - Trigger thực hiện trước khi chèn dữ liệu
        - Kiểm tra xem tài khoản mới chèn vào có trùng với tài khoản nào khác không
        - Nếu có tài khoản trùng lặp, phát sinh lỗi và ngăn chặn việc chèn dữ liệu
        - Nếu không có tài khoản trùng lặp, tiếp tục chèn dữ liệu vào bảng Account
*/

CREATE TRIGGER UTG_PreventDuplicateAccount
ON Account
INSTEAD OF INSERT
AS
BEGIN
    -- Tắt thông báo số bản ghi bị ảnh hưởng
    SET NOCOUNT ON;

    -- Khai báo biến lưu giá trị từ bản ghi mới chèn vào
    DECLARE @NewUserName NVARCHAR(100);
    DECLARE @NewDisplayName NVARCHAR(100);
    DECLARE @NewPassword NVARCHAR(500);
    DECLARE @NewTypeID INT;

    -- Lấy giá trị từ bản ghi mới chèn vào
    SELECT 
        @NewUserName = i.UserName,
        @NewDisplayName = i.DisplayName,
        @NewPassword = i.Password,
        @NewTypeID = i.TypeID
    FROM inserted i;

    -- Kiểm tra xem có tài khoản trùng lặp không
    IF EXISTS (SELECT 1 FROM Account WHERE UserName = @NewUserName)
    BEGIN
        -- Nếu có tài khoản trùng lặp, phát sinh lỗi và ngăn chặn việc chèn dữ liệu
        RAISERROR('Duplicate_Account_Detected', 16, 1);
    END
    ELSE
    BEGIN
        -- Nếu không có tài khoản trùng lặp, tiếp tục chèn dữ liệu vào bảng Account
        INSERT INTO Account (UserName, DisplayName, Password, TypeID)
        VALUES (@NewUserName, @NewDisplayName, @NewPassword, @NewTypeID);
    END
END
GO
