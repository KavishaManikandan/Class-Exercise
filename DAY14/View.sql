-- Create table
CREATE TABLE Employees (
    EmpID INT PRIMARY KEY,
    Name VARCHAR(50),
    Department VARCHAR(50),
    Salary DECIMAL(10,2)
);

-- Insert data
INSERT INTO Employees VALUES
(1,'Alice','HR',5000),
(2,'Bob','IT',6000),
(3,'Charlie','Finance',5500);


SELECT * FROM IT_Employees;
