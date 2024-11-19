/*
    Tên view: AccountPermissionView
    Mô tả: View này được sử dụng để lấy thông tin tài khoản cùng với quyền của tài khoản đó
    Bảng: Account, AccountType, AccountTypePermission, Permission
    Logic:
        - View lấy thông tin tài khoản từ bảng Account
        - Lấy tên loại tài khoản từ bảng AccountType
        - Lấy quyền của loại tài khoản đó từ bảng AccountTypePermission
        - Lấy tên quyền từ bảng Permission
        - Kết quả trả về bao gồm thông tin tài khoản và quyền của tài khoản đó
*/

CREATE VIEW AccountPermissionView AS
SELECT 
    a.Id AS AccountId,
    a.UserName,
    a.DisplayName,
    at.TypeName,
    p.Name AS PermissionName
FROM 
    Account a
JOIN 
    AccountType at ON a.TypeID = at.ID
JOIN 
    AccountTypePermission atp ON at.ID = atp.AccountTypeId
JOIN 
    Permission p ON atp.PermissionId = p.Id;
