CREATE PROCEDURE GetOrderTotal 
    @CustomerID INT,
    @TotalAmount DECIMAL(10,2) OUTPUT
AS
BEGIN
    SELECT @TotalAmount = SUM(Amount)
    FROM Orders
    WHERE CustomerID = @CustomerID;
END;

DECLARE @Total DECIMAL(10,2);
EXEC GetOrderTotal 1, @Total OUTPUT;
SELECT @Total AS TotalAmount;
