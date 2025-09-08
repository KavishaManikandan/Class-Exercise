CREATE TABLE Customers (CustomerID INT, Name VARCHAR(50));
CREATE TABLE Orders (OrderID INT, CustomerID INT, Amount DECIMAL(10,2));

INSERT INTO Customers VALUES (1,'Alice'),(2,'Bob');
INSERT INTO Orders VALUES (101,1,250),(102,2,150),(103,1,300);

-- INNER JOIN
SELECT c.Name, o.Amount
FROM Customers c
INNER JOIN Orders o ON c.CustomerID = o.CustomerID;

-- LEFT JOIN
SELECT c.Name, o.Amount
FROM Customers c
LEFT JOIN Orders o ON c.CustomerID = o.CustomerID;

-- RIGHT JOIN
SELECT c.Name, o.Amount
FROM Customers c
RIGHT JOIN Orders o ON c.CustomerID = o.CustomerID;

-- FULL OUTER JOIN
SELECT c.Name, o.Amount
FROM Customers c
FULL OUTER JOIN Orders o ON c.CustomerID = o.CustomerID;

-- CROSS JOIN
SELECT c.Name, o.Amount
FROM Customers c
CROSS JOIN Orders o;
