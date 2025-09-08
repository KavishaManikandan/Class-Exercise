-- Use the database
USE SchoolDB;
GO

-- DDL Commands
ALTER TABLE Students ADD Address NVARCHAR(100); -- Add new column
DROP TABLE IF EXISTS TempTable;                -- Drop a table
CREATE TABLE TempTable (ID INT);               -- Create a new table

-- TCL Commands
BEGIN TRANSACTION;
    INSERT INTO Students VALUES (3, 'Meena', 'meena@gmail.com', 22, 'Chennai');
    INSERT INTO Students VALUES (4, 'Ravi', 'ravi@gmail.com', 21, 'Bangalore');
ROLLBACK;  -- Undo the inserts

-- Check if rollback worked (no Meena or Ravi)
SELECT * FROM Students;

BEGIN TRANSACTION;
    INSERT INTO Students VALUES (5, 'Divya', 'divya@gmail.com', 19, 'Delhi');
COMMIT;   -- Save permanently

-- Check if commit worked
SELECT * FROM Students;

-- DCL Commands (run as an Admin user)
-- Create a login and user
CREATE LOGIN test_user WITH PASSWORD = 'Test@123';
CREATE USER test_user FOR LOGIN test_user;

-- GRANT and REVOKE
GRANT SELECT ON Students TO test_user;
REVOKE SELECT ON Students FROM test_user;
