BEGIN TRY
    IF EXISTS (SELECT * FROM Customers WHERE CustomerID = 5)
        PRINT 'Customer exists';
    ELSE
        PRINT 'Customer does not exist';
END TRY
BEGIN CATCH
    PRINT 'Error occurred: ' + ERROR_MESSAGE();
END CATCH
