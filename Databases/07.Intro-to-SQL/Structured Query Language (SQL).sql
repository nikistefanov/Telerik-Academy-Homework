--What is SQL? What is DML? What is DDL? Recite the most important SQL commands.
/*
- SQL (Structured Query Language) is a special-purpose programming language designed for managing data held in a relational database management system (RDBMS), or for stream processing in a relational data stream management system (RDSMS).
- DML (Data Manipulation Language) is a family of syntax elements similar to a computer programming language used for selecting, inserting, deleting and updating data in a database.
- DDL (Data Definition Language or Data Description Danguage) is a syntax similar to a computer programming language for defining data structures, especially database schemas.
- Some of The Most Important SQL Commands
SELECT - extracts data from a database
UPDATE - updates data in a database
DELETE - deletes data from a database
INSERT INTO - inserts new data into a database
CREATE DATABASE - creates a new database
ALTER DATABASE - modifies a database
CREATE TABLE - creates a new table
ALTER TABLE - modifies a table
DROP TABLE - deletes a table
CREATE INDEX - creates an index (search key)
DROP INDEX - deletes an index
*/
--What is Transact-SQL (T-SQL)?
-- Transact-SQL (T-SQL) is Microsoft's and Sybase's proprietary extension to SQL. SQL, the acronym for Structured Query Language, is a standardized computer language that was originally developed by IBM for querying, altering and defining relational databases, using declarative statements.
--Start SQL Management Studio and connect to the database TelerikAcademy. Examine the major tables in the "TelerikAcademy" database.
-- CHECK :)
--04.Write a SQL query to find all information about all departments (use "TelerikAcademy" database).

USE TelerikAcademy

SELECT *
FROM dbo.Departments

--05.Write a SQL query to find all department names.

USE TelerikAcademy

SELECT Name
FROM dbo.Departments

--06.Write a SQL query to find the salary of each employee.

USE TelerikAcademy

SELECT FirstName + ' ' + LastName AS 'Employee', Salary
FROM dbo.Employees

--07.Write a SQL to find the full name of each employee.

USE TelerikAcademy

SELECT FirstName + ' ' + LastName AS FullName
FROM dbo.Employees

--08.Write a SQL query to find the email addresses of each employee (by his first and last name). Consider that the mail domain is telerik.com. Emails should look like “John.Doe@telerik.com". The produced column should be named "Full Email Addresses".

USE TelerikAcademy

SELECT FirstName + '.' + LastName + '@telerik.com' AS [Full Email Addresses]
FROM dbo.Employees

--09.Write a SQL query to find all different employee salaries.

USE TelerikAcademy

SELECT DISTINCT Salary
FROM dbo.Employees
ORDER BY Salary ASC

--10.Write a SQL query to find all information about the employees whose job title is “Sales Representative“.

USE TelerikAcademy

SELECT *
FROM Employees
WHERE JobTitle = 'Sales Representative'

--11.Write a SQL query to find the names of all employees whose first name starts with "SA".

USE TelerikAcademy

SELECT FirstName + ' ' + LastName AS 'Employee'
FROM Employees
WHERE FirstName LIKE 'SA%'

--12.Write a SQL query to find the names of all employees whose last name contains "ei".

USE TelerikAcademy

SELECT FirstName + ' ' + LastName AS 'Employee'
FROM Employees
WHERE LastName LIKE '%ei%'

--13.Write a SQL query to find the salary of all employees whose salary is in the range [20000…30000].

USE TelerikAcademy

SELECT FirstName + ' ' + LastName AS 'Employee', Salary
FROM Employees
WHERE Salary BETWEEN 20000 AND 30000
ORDER BY Salary ASC

--14.Write a SQL query to find the names of all employees whose salary is 25000, 14000, 12500 or 23600.

USE TelerikAcademy

SELECT FirstName + ' ' + LastName AS 'Employee', Salary
FROM Employees
WHERE Salary IN (25000, 14000, 12500, 23600)
ORDER BY Salary ASC

--15.Write a SQL query to find all employees that do not have manager.

USE TelerikAcademy

SELECT FirstName + ' ' + LastName AS 'BOSSES'
FROM Employees
WHERE ManagerID IS NULL

--16.Write a SQL query to find all employees that have salary more than 50000. Order them in decreasing order by salary.

USE TelerikAcademy

SELECT FirstName + ' ' + LastName AS 'Employees', Salary
FROM Employees
WHERE Salary <= 50000
ORDER BY Salary DESC

--17.Write a SQL query to find the top 5 best paid employees.

USE TelerikAcademy

SELECT TOP 5 FirstName + ' ' + LastName AS 'Richest Employees', Salary
FROM Employees
ORDER BY Salary DESC

--18.Write a SQL query to find all employees along with their address. Use inner join with ON clause.

USE TelerikAcademy

SELECT e.FirstName + ' ' + e.LastName AS 'Employee', a.AddressText
FROM Employees e 
INNER JOIN Addresses a
ON e.AddressID = a.AddressID

--19.Write a SQL query to find all employees and their address. Use equijoins (conditions in the WHERE clause).

USE TelerikAcademy

SELECT e.FirstName + ' ' + e.LastName AS 'Employee', a.AddressText
FROM Employees e, Addresses a
WHERE e.AddressID = a.AddressID

--20.Write a SQL query to find all employees along with their manager.

USE TelerikAcademy

SELECT e.FirstName + ' ' + e.LastName AS Employee,  m.FirstName + ' ' + m.Lastname AS Manager
FROM Employees e 
JOIN Employees m
ON e.ManagerID = m.EmployeeID
/*
USE TelerikAcademy

SELECT e.FirstName + ' ' + e.LastName AS Employee,  m.FirstName + ' ' + m.Lastname AS Manager
FROM Employees e, Employees m
WHERE e.ManagerID = m.EmployeeID
*/

--21.Write a SQL query to find all employees, along with their manager and their address. Join the 3 tables: Employees e, Employees m and Addresses a.

USE TelerikAcademy

SELECT e.FirstName + ' ' + e.LastName AS Employee,  m.FirstName + ' ' + m.Lastname AS Manager, a.AddressText
FROM Employees e, Employees m, Addresses a
WHERE e.ManagerID = m.EmployeeID
	AND e.AddressID = a.AddressID
	
/*
USE TelerikAcademy

SELECT e.FirstName + ' ' + e.LastName AS Employee,  m.FirstName + ' ' + m.Lastname AS Manager, a.AddressText
FROM Employees e 
JOIN Employees m
 ON e.ManagerID = m.EmployeeID
	JOIN Addresses a
		ON e.AddressID = a.AddressID
*/

--22.Write a SQL query to find all departments and all town names as a single list. Use UNION.

USE TelerikAcademy

SELECT Name AS [Departments/Towns]
FROM Departments
UNION
SELECT Name AS [Departments/Towns]
FROM Towns

--23.Write a SQL query to find all the employees and the manager for each of them along with the employees that do not have manager. Use right outer join. Rewrite the query to use left outer join.

-- Right join --
USE TelerikAcademy

SELECT e.FirstName + ' ' + e.LastName AS Employee,  m.FirstName + ' ' + m.Lastname AS Manager
FROM Employees e 
RIGHT JOIN Employees m
ON e.ManagerID = m.EmployeeID

/*
-- Left join --
USE TelerikAcademy

SELECT e.FirstName + ' ' + e.LastName AS Employee,  m.FirstName + ' ' + m.Lastname AS Manager
FROM Employees e 
LEFT JOIN Employees m
ON e.ManagerID = m.EmployeeID
*/
--24.Write a SQL query to find the names of all employees from the departments "Sales" and "Finance" whose hire year is between 1995 and 2005.

USE TelerikAcademy

SELECT e.FirstName + ' ' + e.LastName AS Employee, e.HireDate,  d.Name AS Department
FROM Employees e, Departments d
WHERE e.DepartmentID = d.DepartmentID AND d.Name IN ('Sales', 'Finance')
AND e.HireDate BETWEEN '1995-01-01' AND '2005-12-31'
ORDER BY e.HireDate ASC