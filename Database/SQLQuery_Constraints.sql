USE [FashionShopManagement]
GO

/****** Object:  Table [dbo].[Customer]    Script Date: 11/14/2024 8:39:48 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Customer](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](50) NULL,
	[PhoneNumber] [nvarchar](20) NULL,
	[DoB] [datetime] NULL,
	[Address] [nvarchar](500) NULL
	)
GO

use FashionShopManagement
go

--Số điện thoại phải là duy nhất
ALTER TABLE [dbo].[Customer] 
ADD CONSTRAINT UQ_Customer_PhoneNumber UNIQUE ([PhoneNumber]);

-- SĐT Chỉ được chứa ký tự số
ALTER TABLE [dbo].[Customer]
ADD CONSTRAINT CHK_PhoneNumber_Numeric CHECK (PhoneNumber NOT LIKE '%[^0-9]%');

-- SĐT phải bắt đầu bằng số 0
ALTER TABLE [dbo].[Customer]
ADD CONSTRAINT CHK_PhoneNumber_Start CHECK (LEFT(PhoneNumber, 1) = '0');




-- 
ALTER TABLE [dbo].[Account] 
ADD CONSTRAINT UQ_Account_UserName UNIQUE ([UserName]);



ALTER TABLE [dbo].[Account]
ADD CONSTRAINT CHK_Password CHECK (LEN([Password]) >= 6);





-- 
ALTER TABLE [dbo].[Product]
ADD CONSTRAINT CHK_Product_Price CHECK (Price >= 0);

ALTER TABLE [dbo].[Product]
ADD CONSTRAINT CHK_Product_Discount CHECK (Discount >= 0 and Discount <= Price);

ALTER TABLE [dbo].[Product]
ADD CONSTRAINT CHK_Product_Quantity CHECK (Quantity >= 0);



--- BẢNG BILL
ALTER TABLE [dbo].[Bill]
ADD CONSTRAINT CHK_Bill_TotalPrice CHECK (TotalPrice >= 0);

ALTER TABLE [dbo].[Bill]
ADD CONSTRAINT CHK_Bill_Discount CHECK (Discount >= 0 and Discount <= TotalPrice);


--- BANGT BILLINFO
ALTER TABLE [dbo].[BillInfo]
ADD CONSTRAINT CHK_BillInfo_Amount CHECK (Amount > 0);

