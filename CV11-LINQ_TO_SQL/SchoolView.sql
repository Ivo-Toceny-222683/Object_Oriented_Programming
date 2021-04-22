CREATE VIEW Quantity AS 
	SELECT Subjects.Shortage, 
	COUNT(SignedSubjects.Shortage) AS NumOfStudents
	FROM Subjects 
	LEFT JOIN SignedSubjects 
	ON SignedSubjects.Shortage = Subjects.Shortage
	WHERE Subjects.Shortage IS NOT NULL
	GROUP BY Subjects.Shortage
	