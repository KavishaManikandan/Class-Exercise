CREATE DATABASE ShopDB;
GO
USE ShopDB;

CREATE TABLE Customers (
    CustomerId INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100),
    Email NVARCHAR(100) UNIQUE
);

INSERT INTO Customers (Name, Email) VALUES ('Kavisha', 'kavi@example.com');
SELECT * FROM Customers;