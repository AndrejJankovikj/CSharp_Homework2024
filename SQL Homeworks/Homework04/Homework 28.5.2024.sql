--Declare scalar variable for storing FirstName values
--• Assign value ‘Antonio’ to the FirstName variable
USE SEDC_ACADEMY_HOMEWORK
GO
DECLARE @FirstName NVARCHAR(50)
SET @FirstName= 'Antonio'
SELECT @FirstName
--• Find all Students having FirstName same as the variable
SELECT*
FROM[dbo].[Student] 
WHERE FirstName=@FirstName
GO
--• Declare table variable that will contain StudentId, StudentName and DateOfBirth
DECLARE @StudentInfo TABLE
(StudentId INT NOT NULL,
StudentName NVARCHAR(100) NOT NULL,
DateOfBirth DATE NOT NULL)
--• Fill the table variable with all Female students
INSERT INTO @StudentInfo(StudentId,StudentName,DateOfBirth)
SELECT Id,FirstName,DateOfBirth
FROM [dbo].[Student]
WHERE Gender='F'
SELECT * FROM @StudentInfo
GO
--• Declare temp table that will contain LastName and EnrolledDate columns
CREATE TABLE #EnrolledTable 
(LastName NVARCHAR(100),
EnrolledDate DATE)
GO
--• Fill the temp table with all Male students having First Name starting with ‘A’
INSERT INTO #EnrolledTable (LastName,EnrolledDate)
SELECT LastName, EnrolledDate
FROM [dbo].[Student]
WHERE Gender='M' AND FirstName LIKE 'A%'
SELECT * FROM #EnrolledTable
SELECT * FROM [dbo].[Student]
--• Retrieve the students from the table which last name is with 7 characters
SELECT * FROM [dbo].Student  
WHERE LEN(LastName)=7
--• Find all teachers whose FirstName length is less than 5 and
--• the first 3 characters of their FirstName and LastName are the same.
SELECT * FROM [dbo].[Teacher] WHERE LEN(FirstName)<5 AND LEFT(FirstName,3)=LEFT (LastName,3)
