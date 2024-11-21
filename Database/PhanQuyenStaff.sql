

-- PHÂN QUYỀN MANAGER
USE FashionShopManagement;

--I. Bước 1: Tạo người dùng và vai trò trong SQL Server
-- 1. Tạo người dùng:
CREATE LOGIN [staff] WITH PASSWORD = 'DB_staff';
ALTER LOGIN [staff] WITH DEFAULT_DATABASE = [FashionShopManagement];
CREATE USER [staff] FOR LOGIN [staff];

-- 2. Tạo vai trò:
CREATE ROLE [role_staff];

-- 3. Gán người dùng vào vai trò:
ALTER ROLE [role_staff] ADD MEMBER [staff];


 --II. Bước 2: Gán quyền cho vai trò
--1. Gán quyền truy cập cơ sở dữ liệu:
ALTER ROLE [role_staff] ADD MEMBER [staff];

--2.Gán quyền cụ thể cho vai trò:
GRANT SELECT, UPDATE ON [Account] TO [role_staff];
GRANT SELECT ON [AccountType] TO [role_staff];
GRANT SELECT ON [AccountTypePermission] TO [role_staff];
GRANT SELECT, INSERT, UPDATE, DELETE ON [Bill] TO [role_staff];
GRANT SELECT, INSERT, UPDATE, DELETE ON [BillInfo] TO [role_staff];
GRANT SELECT, INSERT, UPDATE, DELETE ON [Customer] TO [role_staff];
GRANT SELECT ON [Permission] TO [role_staff];
GRANT SELECT ON [Product] TO [role_staff];
GRANT SELECT, UPDATE ON [Staff] TO [role_staff];
GRANT SELECT ON [ViewAllCustomers] TO [role_staff];
GRANT SELECT ON [ViewAllCampaigns] TO [role_staff];
GRANT SELECT ON [ViewAllBills] TO [role_staff];
GRANT SELECT ON [ViewAllAccounts] TO [role_staff];
GRANT SELECT ON [ViewAllPermissions] TO [role_staff];
GRANT SELECT ON [ViewAllProducts] TO [role_staff];
GRANT SELECT ON [ViewAllShifts] TO [role_staff];
GRANT SELECT ON [ViewAllStaffs] TO [role_staff];

--3. Gán quyền cụ thể cho vai trò trên các stored procedures
GRANT EXECUTE ON OBJECT::dbo.USP_DeleteBill TO role_staff;
GRANT EXECUTE ON OBJECT::dbo.USP_DeleteBillInfo TO role_staff;
GRANT EXECUTE ON OBJECT::dbo.USP_DeleteBillInfoByBillID TO role_staff;
GRANT EXECUTE ON OBJECT::dbo.USP_GetAccountByUserName TO role_staff;
GRANT EXECUTE ON OBJECT::dbo.USP_GetAllBills TO role_staff;
GRANT EXECUTE ON OBJECT::dbo.USP_GetAllCustomer TO role_staff;
GRANT EXECUTE ON OBJECT::dbo.USP_GetAllProduct TO role_staff;
GRANT EXECUTE ON OBJECT::dbo.USP_GetBillByCustomerId TO role_staff;
GRANT EXECUTE ON OBJECT::dbo.USP_GetBillById TO role_staff;
GRANT EXECUTE ON OBJECT::dbo.USP_GetBillInfoDetailByBillId TO role_staff;
GRANT EXECUTE ON OBJECT::dbo.USP_GetCustomerById TO role_staff;
GRANT EXECUTE ON OBJECT::dbo.USP_GetCustomerByPhone TO role_staff;
GRANT EXECUTE ON OBJECT::dbo.USP_GetListBillByDay TO role_staff;
GRANT EXECUTE ON OBJECT::dbo.USP_GetListBillByDayForReport TO role_staff;
GRANT EXECUTE ON OBJECT::dbo.USP_GetListProductByCategory TO role_staff;
GRANT EXECUTE ON OBJECT::dbo.USP_GetMaxBillID TO role_staff;
GRANT EXECUTE ON OBJECT::dbo.USP_GetPermissionByAccountTypeId TO role_staff;
GRANT EXECUTE ON OBJECT::dbo.USP_GetProductById TO role_staff;
GRANT EXECUTE ON OBJECT::dbo.USP_InsertBill TO role_staff;
GRANT EXECUTE ON OBJECT::dbo.USP_InsertBillInfo TO role_staff;
GRANT EXECUTE ON OBJECT::dbo.USP_InsertUpdateBillInfo TO role_staff;
GRANT EXECUTE ON OBJECT::dbo.USP_Login TO role_staff;
GRANT EXECUTE ON OBJECT::dbo.USP_ResetPassword TO role_staff;
GRANT EXECUTE ON OBJECT::dbo.USP_SearchAccountByUserName TO role_staff;
GRANT EXECUTE ON OBJECT::dbo.USP_SearchProductByName TO role_staff;
GRANT EXECUTE ON OBJECT::dbo.USP_UpdateAccount TO role_staff;
GRANT EXECUTE ON OBJECT::dbo.USP_UpdateBill TO role_staff;
GRANT EXECUTE ON OBJECT::dbo.USP_UpdateBillStatus TO role_staff;
GRANT EXECUTE ON OBJECT::dbo.USP_InsertCustomer TO role_staff;

GO


-- III. Bước 3: Cấu hình kết nối trong ứng dụng C#





