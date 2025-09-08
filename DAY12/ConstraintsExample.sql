-- Create Database
CREATE DATABASE SchoolDB;
GO
USE SchoolDB;
GO

-- Table with Primary Key, NOT NULL, UNIQUE, CHECK
CREATE TABLE Students (
    StudentID INT PRIMARY KEY,          -- Primary Key
    Name NVARCHAR(50) NOT NULL,         -- NOT NULL
    Email NVARCHAR(100) UNIQUE,         -- UNIQUE
    Age INT CHECK (Age >= 5 AND Age <= 25)  -- CHECK constraint
);

-- Table with Foreign Key
CREATE TABLE Courses (
    CourseID INT PRIMARY KEY,
    CourseName NVARCHAR(50) NOT NULL,
    StudentID INT FOREIGN KEY REFERENCES Students(StudentID)  -- Foreign Key
);

-- Insert sample data
INSERT INTO Students VALUES (1, 'Kavisha', 'kavi@gmail.com', 20);
INSERT INTO Students VALUES (2, 'Arun', 'arun@gmail.com', 18);

INSERT INTO Courses VALUES (101, 'Mathematics', 1);
INSERT INTO Courses VALUES (102, 'Science', 2);

SELECT * FROM Students;
SELECT * FROM Courses;
