-- DROP DATABASE IF EXISTS DataBaseForTest;
-- GO
--
-- CREATE DATABASE DataBaseForTest;
-- GO
--
-- USE DataBaseForTest;
-- GO
--
--
-- CREATE TABLE Employee (
--     Id INT PRIMARY KEY IDENTITY(1,1),
--     Fullname NVARCHAR(255) NOT NULL,
--     Age INT NOT NULL CHECK (Age >= 0),
--     Email NVARCHAR(255) NOT NULL UNIQUE,
--     Salary DECIMAL(10, 2) NOT NULL CHECK (Salary BETWEEN 300 AND 2000),
--     CONSTRAINT CK_SalaryIsPositive CHECK (Salary > 0)
-- );
--
--
-- INSERT INTO Employee (Fullname, Age, Email, Salary) VALUES
--     ('Artur Doe', 30, 'artur.doe@example.com', 1500.00),
--     ('Will Smith', 25, 'will.smith@example.com', 1800.50),
--     ('Michael Johnson', 35, 'michael.johnson@example.com', 2000.00),
--     ('Emily Brown', 28, 'emily.brown@example.com', 1200.75);
--
--
-- SELECT * FROM Employee;