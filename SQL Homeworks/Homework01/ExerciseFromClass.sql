USE		[master]
GO
CREATE DATABASE [SEDC]
GO
USE[SEDC]
GO
CREATE TABLE[BusinessEntity](
Id INT IDENTITY(1,1),
[Name] NVARCHAR(100)  NULL,
Region NVARCHAR(1000)  NULL,
Zipcode NVARCHAR(10) NULL,
Size NVARCHAR(10) NULL,
 CONSTRAINT PK_BusinessEntity PRIMARY KEY CLUSTERED (Id)
)
GO
CREATE TABLE [Employee](
Id INT IDENTITY(1,1) NOT NULL,
FirstName NVARCHAR(100)NOT NULL,
LastName NVARCHAR(100)NOT NULL,
DateOfBirth DATE  NULL,
Gender NCHAR(1)  NULL,
HireDate DATE  NULL,
NationalIdNumber NVARCHAR(20) NULL,
 CONSTRAINT PK_Employee PRIMARY KEY CLUSTERED (Id)
)
GO
CREATE TABLE [Product](
Id INT IDENTITY(1,1) NOT NULL,
Code NVARCHAR(50) NULL,
[Name] NVARCHAR(100) NULL,
[Description] NVARCHAR(max) NULL,
[Weight] DECIMAL(18,2) NULL,
Price DECIMAL (18,2) NULL,
Cost Decimal (18,2) NULL,
 CONSTRAINT PK_Product PRIMARY KEY CLUSTERED (Id)
)
GO
CREATE TABLE[Customer](
Id INT IDENTITY(1,1) NOT NULL,
[Name] NVARCHAR(100) NOT NULL, 
AccountNumber NVARCHAR(50),
City NVARCHAR(100),
RegionName NVARCHAR(100)NULL,
CustomerSize NVARCHAR(10)NULL,
PhoneNumber NVARCHAR(20)NULL,
IsActive bit NOT NULL
 CONSTRAINT PK_Customer PRIMARY KEY CLUSTERED (Id)
)
GO
CREATE TABLE[Order](
Id BIGINT IDENTITY(1,1) NOT NULL,
OrderDate DATETIME NULL,
[Status] SMALLINT NULL,
BusinessEntityId INT NULL,
CustomerId INT NULL,
EmployeeId INT NULL,
TotalPrice DECIMAL(18,2)NULL,
Comment NVARCHAR(max)NULL,
 CONSTRAINT PK_Order PRIMARY KEY CLUSTERED (Id)
)
GO
CREATE TABLE [OrderDetails](
Id BIGINT IDENTITY(1,1) NOT NULL,
OrderId BIGINT NULL,
ProductId INT NULL,
Quantity INT NULL,
Price [Decimal](18,2) NULL,
 CONSTRAINT PK_OrderDetails PRIMARY KEY CLUSTERED (Id)
)
GO
INSERT INTO dbo.BusinessEntity([Name],[Region],[Zipcode],[Size])
VALUES('Toyota','Asia','1000','Big'),
('Bmw','Europe','2000','Bigger'),
('Dodge','North America','3000','NotBig')
GO
INSERT INTO dbo.Employee([FirstName],[LastName],[DateOfBirth],[Gender],[HireDate],[NationalIdNumber])
VALUES('Andrej','Jankovikj','2004.09.11','1','2023.12.2','112'),
('Viktor','Zdravkovski','2002.3.25','2','2023.2.11','113'),
('Mario','Gulicovski','2000.2.23','1','2023.2.10','1')
GO
INSERT INTO dbo.Product([Code],[Name],[Description],[Weight],[Price],[Cost])
VALUES('12345','Avensis','Good Car',1700.23,6500,200),
('123456','320d','Very Good Car',1400.22,10000,1000),(
'1234567','c320','Not So Good Car', 1600.21,8000,600)
GO
INSERT INTO dbo.Customer([Name],[AccountNumber],[City],[RegionName],[CustomerSize],[PhoneNumber],[IsActive])
VALUES('Martin','223305','Skopje','Makedonija','BIG','075500000',1),
('Ceco','62525','Belgrad','Serbia','Small','022666333',0),
('Burazer','232323','Prilep','Macedonia','Medium','070236261613',1)
GO
INSERT INTO dbo.[Order]([OrderDate],[Status],[BusinessEntityId],[CustomerId],[EmployeeId],[TotalPrice],[Comment])
VALUES('2024.5.14',11,131314,1514,223305,15000.9,'Very good Order Date'),
('2024.5.15',12,121213,1415,225555,14000.99,'An Even Better Order Date'),
('2024.5.16',13,141415,1314,51561,20000.49,'THE BEST ORDER DATE')
GO
INSERT INTO dbo.OrderDetails([OrderId],[ProductId],[Quantity],[Price])
VALUES(1940194,246810,5,1000.59),
(1839083,135791,8,2000.13),
(0728972,612182430,11,24000.12)
GO



SELECT * FROM [dbo].[BusinessEntity]
SELECT * FROM [dbo].[Employee]
SELECT * FROM [dbo].[Product]
SELECT * FROM [dbo].Customer
SELECT * FROM [dbo].[Order]
SELECT * FROM [dbo].[OrderDetails]

DROP TABLE dbo.BusinessEntity
DROP TABLE dbo.Customer
DROP TABLE dbo.Employee

DROP TABLE dbo.[Order]
DROP TABLE dbo.OrderDetails
DROP TABLE dbo.Product

