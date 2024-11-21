

-- PHÂN QUYỀN MANAGER
USE FashionShopManagement;

--I. Bước 1: Tạo người dùng và vai trò trong SQL Server
-- 1. Tạo người dùng:
CREATE LOGIN [manager] WITH PASSWORD = 'DB_manager';
ALTER LOGIN [manager] WITH DEFAULT_DATABASE = [FashionShopManagement];
CREATE USER [manager] FOR LOGIN [manager];

-- 2. Tạo vai trò:
CREATE ROLE [role_manager];

-- 3. Gán người dùng vào vai trò:
ALTER ROLE [role_manager] ADD MEMBER [manager];


 --II. Bước 2: Gán quyền cho vai trò
--1. Gán quyền truy cập cơ sở dữ liệu:
ALTER ROLE [role_manager] ADD MEMBER [manager];
ALTER ROLE [db_datareader] ADD MEMBER [manager]; 
ALTER ROLE [db_datawriter] ADD MEMBER [manager];

--2.Gán quyền cụ thể cho vai trò trên các table:
GRANT SELECT, INSERT, UPDATE, DELETE ON [Account] TO [role_manager];
GRANT SELECT, INSERT, UPDATE, DELETE ON [AccountType] TO [role_manager];
GRANT SELECT, INSERT, UPDATE, DELETE ON [AccountTypePermission] TO [role_manager];
GRANT SELECT, INSERT, UPDATE, DELETE ON [Bill] TO [role_manager];
GRANT SELECT, INSERT, UPDATE, DELETE ON [BillInfo] TO [role_manager];
GRANT SELECT, INSERT, UPDATE, DELETE ON [Customer] TO [role_manager];
GRANT SELECT, INSERT, UPDATE, DELETE ON [Permission] TO [role_manager];
GRANT SELECT, INSERT, UPDATE, DELETE ON [Product] TO [role_manager];
GRANT SELECT, INSERT, UPDATE, DELETE ON [Staff] TO [role_manager];
GRANT SELECT, INSERT, UPDATE, DELETE ON [Campaign] TO [role_manager];

--3. Gán quyền cụ thể cho vai trò trên các stored procedures
GRANT EXECUTE ON SCHEMA::dbo TO [role_manager];
GO


-- III. Bước 3: Cấu hình kết nối trong ứng dụng C#
