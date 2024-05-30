USE SEDC_ACADEMY_HOMEWORK
--Create new procedure called CreateGrade;
--• Procedure should create only Grade header info (not Grade Details);
--• Procedure should return the total number of grades in the system for
--the Student on input (from the CreateGrade);
--• Procedure should return second resultset with the MAX Grade of all
--grades for the Student and Teacher on input (regardless the Course).
GO
CREATE OR ALTER PROCEDURE dbo.usp_CreateGrade
(
    @StudentID INT,
    @TeacherID INT,
    @Grade TINYINT,
    @Comment NVARCHAR(MAX),
    @CreatedDate DATETIME
)
AS
BEGIN
INSERT INTO dbo.Grade(StudentId,TeacherId,Grade,Comment,CreatedDate)
VALUES(@StudentID,@TeacherID,@Grade,@Comment,@CreatedDate)
SELECT COUNT(g.StudentID)FROM dbo.Grade g 
--WHERE StudentID=@StudentID
--SELECT COUNT(g.Grade) AS TotalGrades
--FROM dbo.Grade g
SELECT MAX(Grade) AS MaxGrade
FROM dbo.Grade
WHERE StudentID=@StudentID AND TeacherId=@TeacherID
END
 GO
EXEC dbo.usp_CreateGrade 
    @StudentID = 50, 
    @TeacherID = 1, 
    @Grade = 9, 
    @Comment = 'Excellent performance', 
    @CreatedDate = '2024-05-30'
	--@GradeCount=@GradeCounter OUT
	GO


--	Create new procedure called CreateGradeDetail;
--• Procedure should add details for specific Grade (new record for new
--AchievementTypeID, Points, MaxPoints, Date for specific Grade);
--• Output from this procedure should be resultset with SUM of
--GradePoints calculated with formula
--AchievementPoints/AchievementMaxPoints*ParticipationRate for
--specific Grade

CREATE OR ALTER PROCEDURE dbo.usp_CreateGradeDetail
(
@GradeID INT,
@AchievementTypeID INT,
@AchievementPoints SMALLINT,
@AchievementMaxPoints SMALLINT,
@AchievementDate DATE
)
AS
BEGIN
INSERT INTO [dbo].[GradeDetails](GradeID,AchievementTypeID,AchievementPoints,AchievementMaxPoints,AchievementDate)
VALUES(@GradeID,@AchievementTypeID,@AchievementPoints,@AchievementMaxPoints,@AchievementDate)
SELECT SUM(CAST(gd.AchievementPoints AS INT)/CAST(gd.AchievementMaxPoints AS INT)*CAST([at].ParticipationRate AS INT)) FROM [dbo].[GradeDetails] gd
INNER JOIN [dbo].[AchievementType] [at] ON gd.ID=[at].ID


END

EXEC dbo.usp_CreateGradeDetail
@GradeId=5,
@AchievementTypeID=5,
@AchievementPoints=50,
@AchievementMaxPoints=80,
@AchievementDate ='2020-01-11'
--@SomeSum=@TheSum




SELECT * FROM [dbo].[GradeDetails]
--CREATE OR ALTER PROCEDURE dbo.usp_InsertEmployee 
--(
--@FirstName NVARCHAR(100),
--@LastName NVARCHAR(100),
--@DateOfBirth DATE,
--@Gender NCHAR(1),
--@HireDate DATE,
--@NationalIdNumber NVARCHAR(20),
--@EmployeeId INT OUT
--)
--AS
--BEGIN
--INSERT INTO [dbo].[Employee]
--           ([FirstName]
--           ,[LastName]
--           ,[DateOfBirth]
--           ,[Gender]
--           ,[HireDate]
--           ,[NationalIdNumber])
--     VALUES (@FirstName,@LastName,@DateOfBirth,@Gender,@HireDate,@NationalIdNumber)
--	SET @EmployeeId= SCOPE_IDENTITY ()
--END
--GO