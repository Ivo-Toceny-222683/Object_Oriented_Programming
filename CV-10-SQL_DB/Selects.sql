SELECT FirstName,Surname,SignedSubjects.Shortage 
	FROM Students
	LEFT JOIN SignedSubjects ON SignedSubjects.ID = Students.ID;

SELECT Surname, Count(SurName) as StundentsCount 
	FROM Students 
	GROUP BY SurName 
	ORDER BY SurName DESC;

SELECT Shortage, COUNT(Shortage) as NumberOfSigns 
	FROM SignedSubjects
	GROUP BY Shortage 
	HAVING COUNT(Shortage) < 3 AND Shortage IS NOT NULL 
	ORDER BY Shortage DESC;

SELECT SignedSubjects.Shortage, COUNT(SignedSubjects.Shortage) as NumOfStudents, 
	MAX(Ratings.Rating) as MaxValue, MIN(Ratings.Rating) as MinValue, AVG(Ratings.Rating) as AvgValue 
	FROM SignedSubjects LEFT JOIN Ratings ON SignedSubjects.PersonSub = Ratings.PersonSub 
	GROUP BY SignedSubjects.Shortage 
	HAVING SignedSubjects.Shortage IS NOT NULL 
	ORDER BY NumOfStudents DESC;