--Calculate the count of all grades per Teacher in the system
SELECT COUNT(*) AS Grades
FROM [dbo].[Teacher] t
INNER JOIN [dbo].[Grade] g ON t.ID=g.TeacherID
GROUP BY t.ID
GO
--Calculate the count of all grades per Teacher in hte System for first 100
--Students (ID<100)
SELECT COUNT(*) AS GradesPerTeacher
FROM [dbo].[Teacher] t
INNER JOIN [dbo].[Student] s ON t.ID=s.ID
WHERE s.ID <100
GO
--Find the Maximal Grade and the Average Grade per Student on all grades in the system
SELECT Max(g.Grade)AS MaximalGrade, AVG(g.Grade) AS AverageGrade 
FROM [dbo].[Student]s
INNER JOIN [dbo].[Grade] g ON s.Id=g.StudentID
GROUP BY s.Id
GO
--Find the Grade Count, Maximal Grade, Average Grade per Student on all grades in the system. Filter only records where Maximal Grade is equal to Average Grade
SELECT s.Id as StudentId, COUNT(g.Grade) AS Grade, Max(g.Grade) AS MaximalGrade, AVG(g.Grade) AS AverageGrade , s.FirstName, s.LastName
FROM [dbo].[Student] s
JOIN [dbo].[Grade] g ON s.Id=g.StudentId
GROUP BY s.ID
WHERE g.MaximalGrade=AverageGrade
GO
--CANT FIGURE OUT HOW TO FILTER MAXIMAL-AVERAGE PLS HELP
--List Student First NAme and Last Name next to other details from previous query
SELECT s.Id as StudentId, COUNT(g.Grade) AS Grade , MAX (g.Grade) AS MaxGrade, AVG(g.Grade) AS AvgGrade, s.FirstName,s.LastName
FROM [dbo].[Student] s
INNER JOIN [dbo].[Grade] g ON s.Id=g.StudentID
GROUP BY s.Id,s.FirstName,s.LastName
GO
--Create new view (vw_StudentGrades) that will List all StudentIds and count of Grades per student
CREATE VIEW VW_StudentGrades AS
SELECT s.Id AS StudentId, COUNT (g.Grade) AS GradeCount
FROM [dbo].Student s
JOIN [dbo].[Grade] g ON s.ID=g.StudentID
GROUP BY
s.ID
GO
SELECT VW_StudentGrades.GradeCount AS GradeCount, VW_StudentGrades.StudentId AS StudentID FROM VW_StudentGrades
--Change the view to show student First and Last Names instead of StudentID
SELECT * FROM VW_StudentGrades
ALTER VIEW VW_StudentGrades AS
SELECT s.FirstName, s.LastName,
COUNT(g.Grade) AS GradeCount 
FROM [dbo].[Student] s
JOIN [dbo].[Grade] g ON s.Id=g.StudentID 
GROUP BY s.FirstName, s.LastName
GO
--List all row sfrom view ordered by biggest Grade Count
SELECT * 
FROM VW_StudentGrades
ORDER BY GradeCOUNT DESC

