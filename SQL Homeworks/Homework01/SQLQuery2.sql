USE		[master]
GO
CREATE DATABASE [Homework1]
GO
USE[Homework1]
GO
CREATE TABLE [Student](
 Id INT IDENTITY(1,1),
 FirstName NVARCHAR(20) NOT NULL,
 LastName NVARCHAR(50) NOT NULL,
 BirthDate DATE NOT NULL,
 EnroledDate DATE NOT NULL,
 Gender VARCHAR(20) NOT NULL,
 NationalIdNumber INT NOT NULL,
 StudentCardNumber INT NOT NULL,
 CONSTRAINT PK_Student PRIMARY KEY CLUSTERED (Id)
)
GO
CREATE TABLE [Teacher](
Id INT IDENTITY(1,1),
FirstName NVARCHAR(20) NOT NULL,
 LastName NVARCHAR(50) NOT NULL,
 BirthDate DATE NOT NULL,
 AcademicRank INT NOT NULL,
 HireDate DATE NOT NULL,
 CONSTRAINT PK_Teacher PRIMARY KEY CLUSTERED (Id)
)
GO
CREATE TABLE [Grade](
Id INT IDENTITY(1,1),
StudentId INT NOT NULL,
CourseId INT NOT NULL,
TeacherId INT NOT NULL,
Grade INT NOT NULL,
Comment NVARCHAR(300) NOT NULL,
CreatedDate DATE NOT NULL,
CONSTRAINT PK_Grade PRIMARY KEY CLUSTERED (Id)
)
GO
CREATE TABLE[Course](
Id INT IDENTITY(1,1),
[Name] VARCHAR(50) NOT NULL,
Credit INT NOT NULL,
AcademicYear DATETIME NOT NULL,
Semester INT NOT NULL
CONSTRAINT PK_Course PRIMARY KEY CLUSTERED (Id)
)
GO
CREATE TABLE[GradeDetails](
Id INT IDENTITY(1,1),
GradeId INT NOT NULL,
AchievementTypeId INT NOT NULL,
AchievementPoints BIGINT NOT NULL,
AchievementMaxPoints BIGINT NOT NULL,
AchievementDate DATE NOT NULL
CONSTRAINT PK_GradeDetails PRIMARY KEY CLUSTERED (Id)
)
GO
CREATE TABLE [AchievementType](
Id INT IDENTITY(1,1),
[Name] NVARCHAR(100) NOT NULL,
[Description] NVARCHAR(300) NOT NULL,
ParticipationRate DECIMAL(18,2) NOT NULL,
CONSTRAINT PK_AchievementType PRIMARY KEY CLUSTERED (Id)
)
SELECT * FROM dbo.AchievementType
SELECT * FROM dbo.Course
SELECT * FROM dbo.Grade
SELECT * FROM dbo.GradeDetails
SELECT * FROM dbo.Student
SELECT * FROM dbo.Teacher