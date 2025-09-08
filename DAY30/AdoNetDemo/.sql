CREATE PROCEDURE GetAllUsers
AS
BEGIN
    SELECT Id, Username, Email FROM Users
END
