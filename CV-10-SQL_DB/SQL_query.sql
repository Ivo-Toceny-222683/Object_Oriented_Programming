CREATE TABLE Subjects (
	Shortage varchar(50) unique, 
	SubName varchar(70) unique, 
	PRIMARY KEY(Shortage)
	);

CREATE TABLE Students (
	FirstName varchar(50), 
	SurName varchar(70), 
	DateOfBirth date, 
	ID int unique NOT NULL, 
	PRIMARY KEY(ID));

CREATE TABLE SignedSubjects (
	PersonSub int NOT NULL unique, 
	ID int, Shortage varchar(50), 
	FOREIGN KEY(ID) REFERENCES Students(ID), 
	FOREIGN KEY(Shortage) REFERENCES Subjects(Shortage), 
	CONSTRAINT PersonSub unique(ID, Shortage), 
	PRIMARY KEY (PersonSub));

CREATE TABLE Ratings (
	PersonSub int, 
	FOREIGN KEY (PersonSub) REFERENCES SignedSubjects(PersonSub),
	DateofRate date, 
	Rating float);

INSERT INTO Subjects (Shortage, SubName) VALUES ('BPC-OOP', 'Objektovo orientovane programovanie');
INSERT INTO Subjects (Shortage, SubName) VALUES ('BPC-PC2T', 'Počítače a programovanie 2');
INSERT INTO Subjects (Shortage, SubName) VALUES ('BPC-MA1', 'Matematika 1');
INSERT INTO Subjects (Shortage, SubName) VALUES ('BPC-EL1', 'Elektrotechnika 1');
INSERT INTO Subjects (Shortage, SubName) VALUES ('BPC-EL2', 'Elektrotechnika 2');

INSERT INTO Students (FirstName, SurName, DateOfBirth, ID) VALUES ('Ivo', 'Toceny', '1998-07-25', 1);
INSERT INTO Students (FirstName, SurName, DateOfBirth, ID) VALUES ('Karol', 'Toceny', '1995-03-29', 6);
INSERT INTO Students (FirstName, SurName, DateOfBirth, ID) VALUES ('Tomas', 'Mrkva', '2008-09-05', 2);
INSERT INTO Students (FirstName, SurName, DateOfBirth, ID) VALUES ('Palo', 'Kedlubna', '1995-03-10', 3);
INSERT INTO Students (FirstName, SurName, DateOfBirth, ID) VALUES ('Jana', 'Oblakova', '1997-11-12', 4);
INSERT INTO Students (FirstName, SurName, DateOfBirth, ID) VALUES ('Hana', 'Smutna', '1990-01-28', 5);

INSERT INTO SignedSubjects(PersonSub, ID, Shortage) VALUES (100, 1, 'BPC-OOP');
INSERT INTO SignedSubjects(PersonSub, ID, Shortage) VALUES (101, 1, 'BPC-EL1');
INSERT INTO SignedSubjects(PersonSub, ID, Shortage) VALUES (102, 2, 'BPC-PC2T');
INSERT INTO SignedSubjects(PersonSub, ID, Shortage) VALUES (103, 3, 'BPC-OOP');
INSERT INTO SignedSubjects(PersonSub, ID, Shortage) VALUES (104, 3, 'BPC-EL2');
INSERT INTO SignedSubjects(PersonSub, ID, Shortage) VALUES (105, 3, 'BPC-PC2T');
INSERT INTO SignedSubjects(PersonSub, ID, Shortage) VALUES (106, 4, 'BPC-MA1');
INSERT INTO SignedSubjects(PersonSub, ID, Shortage) VALUES (107, 4, 'BPC-OOP');
INSERT INTO SignedSubjects(PersonSub, ID, Shortage) VALUES (108, 5, NULL);

INSERT INTO Ratings(PersonSub, DateofRate, Rating) VALUES (100, '2021-02-25', 2.5);
INSERT INTO Ratings(PersonSub, DateofRate, Rating) VALUES (100, '2021-02-27', 1);
INSERT INTO Ratings(PersonSub, DateofRate, Rating) VALUES (100, '2021-03-21', 4.5);
INSERT INTO Ratings(PersonSub, DateofRate, Rating) VALUES (101, '2021-01-05', 2);
INSERT INTO Ratings(PersonSub, DateofRate, Rating) VALUES (102, '2021-04-03', 3);
INSERT INTO Ratings(PersonSub, DateofRate, Rating) VALUES (103, '2021-01-22', 5);
INSERT INTO Ratings(PersonSub, DateofRate, Rating) VALUES (107, '2021-02-27', 1);
INSERT INTO Ratings(PersonSub, DateofRate, Rating) VALUES (106, '2021-03-21', 4.5);
INSERT INTO Ratings(PersonSub, DateofRate, Rating) VALUES (105, '2021-01-05', 2);
INSERT INTO Ratings(PersonSub, DateofRate, Rating) VALUES (104, '2021-04-03', 3);
INSERT INTO Ratings(PersonSub, DateofRate, Rating) VALUES (104, '2021-01-22', 5);
