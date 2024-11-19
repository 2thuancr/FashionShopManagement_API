/*
    Tên trigger: UTG_PreventAccountTypeChange
    Mô tả: Ngăn chặn việc thay đổi loại tài khoản
    Bảng: Account
    Sự kiện: INSTEAD OF UPDATE
    Logic:
        - Trigger thực hiện trước khi cập nhật dữ liệu
        - Kiểm tra xem loại tài khoản có bị thay đổi không
        - Nếu loại tài khoản bị thay đổi, phát sinh lỗi và ngăn chặn việc cập nhật
        - Nếu loại tài khoản không bị thay đổi, tiếp tục cập nhật dữ liệu
*/

CREATE TRIGGER UTG_PreventAccountTypeChange
ON Account
-- Thực hiện trigger trước khi cập nhật dữ liệu
INSTEAD OF UPDATE
AS
BEGIN
    -- Tắt thông báo số bản ghi bị ảnh hưởng
    SET NOCOUNT ON;

    -- Khai báo biến tạm
    DECLARE @OldTypeID INT;
    DECLARE @NewTypeID INT;
    DECLARE @AccountID INT;

    -- Lấy giá trị từ bản ghi cũ và bản ghi mới cập nhật
    SELECT 
        @AccountID = i.Id,
        @NewTypeID = i.TypeID,
        @OldTypeID = d.TypeID
    FROM inserted i
    JOIN deleted d ON i.Id = d.Id;

    -- Kiểm tra xem loại tài khoản có bị thay đổi không
    IF @OldTypeID <> @NewTypeID
    BEGIN
        -- Nếu loại tài khoản bị thay đổi, phát sinh lỗi và ngăn chặn việc cập nhật
        RAISERROR('Not_Allow_Change_AccountType', 16, 1);
    END
    ELSE
    BEGIN
        -- Nếu loại tài khoản không bị thay đổi, tiếp tục cập nhật dữ liệu
        UPDATE Account
        SET UserName = i.UserName,
            DisplayName = i.DisplayName,
            Password = i.Password,
            TypeID = i.TypeID
        FROM inserted i
        WHERE Account.Id = i.Id;
    END
END
GO
