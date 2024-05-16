--Use script for inserting dummy data in already created SEDCHome
--database
--● Session 2 - 06 Insert example data in SEDCHome database - data.sql
--● Requirements:
--● Find all Students with FirstName = Antonio
SELECT *
FROM [dbo].Student
WHERE FirstName = 'Antonio'
GO
--● Find all Students with DateOfBirth greater than ‘01.01.1999’
SELECT *
FROM [dbo].Student
WHERE [DateOfBirth]>'1999.01.01'
GO
--● Find all Students with LastName starting With ‘J’ enrolled in January/1998
SELECT *
FROM [dbo].Student
WHERE LastName LIKE 'J%' AND [EnrolledDate]<='1998.01.01' AND [EnrolledDate]=>'1998.01.31'
GO
--● List all Students ordered by FirstName
Select*
FROM [dbo].[Student]
ORDER BY [FirstName]
GO
--● List all Teacher Last Names and Student Last Names in single result set.
--Remove duplicates
SELECT[LastName]
FROM [dbo].Teacher
UNION 
SELECT[LastName]
FROM[dbo].Student
GO
--● Create Foreign key constraints from diagram or with script
ALTER TABLE[FK_Student]


--CONSTRAINT [FK_GradeDetails_Grade] FOREIGN KEY(GradeID) REFERENCES [dbo].Grade(ID),
--CONSTRAINT [FK_GradeDetails_AchievementType] FOREIGN KEY(AchievementTypeID) REFERENCES [dbo].AchievementType(ID)

--● List all possible combinations of Courses names and AchievementType
--names that can be passed by student

SELECT * 
FROM dbo.[Course] CROSS JOIN dbo.[AchievementType]


--● List all Teachers without exam Grade









