CREATE TABLE Sales (
    SaleID INT,
    Amount DECIMAL(10,2)
);

INSERT INTO Sales VALUES (1, 100.50), (2, 200.75), (3, 150.25);

-- Sum of all sales
SELECT SUM(Amount) AS TotalSales FROM Sales;

-- Average sale amount
SELECT AVG(Amount) AS AverageSale FROM Sales;

-- Count of sales
SELECT COUNT(*) AS TotalSalesCount FROM Sales;
