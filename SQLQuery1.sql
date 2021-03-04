WITH 
Class_CTE AS (SELECT Studen_Id FROM Class WHERE Id = 3)
SELECT Student.Id, Student.StudentName, Student.Surname FROM Student INNER JOIN Class_CTE ON (Student.Id = Class_CTE.Studen_Id);