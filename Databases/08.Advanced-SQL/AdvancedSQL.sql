USE TelerikAcademy

--01.
SELECT FirstName, LastName, Salary
FROM Employees 
WHERE Salary =
(SELECT MIN(Salary) FROM Employees)

--02.
SELECT FirstName, LastName, Salary
FROM Employees 
WHERE Salary < 
	(SELECT MIN(Salary)*1.1 FROM Employees)

--03.
SELECT FirstName+ ' ' + LastName AS [Full name], Salary, d.Name AS [Department name]
FROM Employees e, Departments d
WHERE Salary = 
	(SELECT MIN(Salary)FROM Employees s WHERE s.DepartmentID = d.DepartmentID)
ORDER BY Salary ASC

--04.
SELECT AVG(Salary) AS [Average salary]
FROM Employees
WHERE DepartmentID = 1

--05.
SELECT AVG(Salary) AS [Average salary]
FROM Employees e, Departments d
WHERE  e.DepartmentID = d.DepartmentID AND Name = 'Sales'

--06.
SELECT COUNT(*) AS [Employees in 'Sales' department]
FROM Employees e, Departments d
WHERE  e.DepartmentID = d.DepartmentID AND d.Name = 'Sales'

--07.
SELECT COUNT(*) AS [Employees which have manager]
FROM Employees e
WHERE  e.ManagerID IS NOT NULL

--08.
SELECT COUNT(*) AS [Number of employees with manager]
FROM Employees e
WHERE  e.ManagerID IS NULL

--09.
SELECT AVG(e.Salary) AS [AverageSalary], d.Name AS [Department name]
FROM Employees e, Departments d
WHERE  e.DepartmentID = d.DepartmentID
GROUP BY  d.Name 
ORDER BY [AverageSalary] DESC

--10.
SELECT COUNT(*) AS [Employees], d.Name AS [Department], t.Name AS [Town]
FROM Employees e, Departments d, Towns t, Addresses a
WHERE  e.DepartmentID = d.DepartmentID
AND e.AddressID = a.AddressID
AND a.TownID = t.TownID
GROUP BY t.Name, d.Name

--11.
SELECT e.FirstName + ' ' + e.LastName AS [Names of manager with 5 employees]
FROM Employees e, Employees m
WHERE e.ManagerID = m.EmployeeID OR m.ManagerID IS NULL
GROUP BY e.EmployeeID, e.FirstName, e.LastName
HAVING COUNT(*) = 5

--12.
SELECT e.FirstName + ' ' + e.LastName AS [Employee], 
	ISNULL(m.FirstName + ' ' + m.LastName, ('no manager')) AS [Manager]
FROM Employees e
LEFT OUTER JOIN Employees m
ON e.ManagerID = m.EmployeeID

--13.
SELECT e.FirstName + ' ' + e.LastName AS [Employee]
FROM Employees e
WHERE LEN(e.LastName) = 5;

--14.
SELECT CONVERT(VARCHAR(50), GETDATE(), 104) + ' -|- ' + CONVERT(VARCHAR(50), GETDATE(), 114) AS [Date and time]

--15.
CREATE TABLE Users (
UserID int IDENTITY,
Username nvarchar(100) NOT NULL,
Password varchar(50) NOT NULL,
LastLogin datetime,
CONSTRAINT PK_Users PRIMARY KEY(UserID),
CONSTRAINT UK_Username UNIQUE(Username),
CONSTRAINT CK_Password CHECK (LEN(Password)>=5))
GO

--16.
INSERT INTO Users (Username, Password,LastLogin)
VALUES ('Richy','Jam14',GETDATE())
GO
CREATE VIEW [Persons] AS
SELECT Username, LastLogin
FROM Users
WHERE CONVERT(NVARCHAR(20),LastLogin,104) = CONVERT(NVARCHAR(20),GETDATE(),104)
GO

--17.
CREATE TABLE Groups (
GroupID int IDENTITY,
Name nvarchar(50) NOT NULL, 
CONSTRAINT UK_Name UNIQUE (Name),
CONSTRAINT PK_Groups PRIMARY KEY (GroupID))
GO

--18.
ALTER TABLE Users
ADD GroupID int

ALTER TABLE Users
ADD CONSTRAINT FK_Users_Groups_GroupID
FOREIGN KEY (GroupID)
REFERENCES Groups(GroupID)
GO

--19
INSERT INTO Groups (Name)
VALUES ('First group'),('Second group')
GO
INSERT INTO Users (Username, Password, LastLogin, GroupID)
VALUES ('Someone', 'hardcorePassword', GETDATE(), 1),('NOone', 'batkata15', GETDATE(), 2)
GO

--20.
UPDATE Users
SET Username = 'Birko', GroupID = 2
WHERE Username='Someone';
GO

UPDATE Users
SET GroupID = 2
WHERE GroupID IS NULL;
GO

UPDATE TOP(1) Groups
SET Name = 'The group of smart kids';
GO

--21.
INSERT INTO Groups (Name)
VALUES ('Group for deleting')
GO

DELETE FROM Users 
WHERE Username = 'Birko'
GO

DELETE FROM Groups 
WHERE Name = 'Group for deleting'
GO

--22.
ALTER TABLE Users
ADD [Full Name] NVARCHAR(100)
GO

INSERT INTO Users ([Full Name], Username, Password)
SELECT CONCAT(FirstName, ' ', LastName), LOWER(FirstName+LastName), 'hardpassword' FROM Employees

--23.
UPDATE Users
    SET Password = NULL
    WHERE DATEDIFF(day, LastLogin, '2010-3-10 00:00:00') > 0

--24.
DELETE FROM Users
    WHERE [Password] IS NULL

--25.
SELECT AVG(e.Salary), e.JobTitle , d.Name  
FROM Employees e, Departments d
WHERE d.DepartmentID = e.DepartmentID
GROUP BY e.JobTitle, d.Name

--26.
SELECT MIN(e.Salary) AS 'Minimun Salary', e.JobTitle , d.Name AS 'Department name', 
e.FirstName + ' ' + e.LastName AS 'Full Name'  
FROM Employees e, Departments d
WHERE d.DepartmentID = e.DepartmentID
GROUP BY e.JobTitle, d.Name, e.FirstName + ' ' + e.LastName

--27.
SELECT TOP 1 t.Name, COUNT(e.EmployeeID) AS [Number of employees]
FROM Employees e
JOIN Addresses a ON e.AddressID = a.AddressID
JOIN Towns t ON t.TownID = a.TownID
GROUP BY t.Name
ORDER BY [Number of employees] DESC

--28.
SELECT t.Name, COUNT(DISTINCT e.ManagerID) AS [Number of managers]
FROM Employees e
	JOIN Employees m 
		ON e.ManagerID = m.EmployeeID
	JOIN Addresses a 
		ON a.AddressID = m.AddressID
	JOIN Towns t 
		ON t.TownID = a.TownID
GROUP BY T.Name

--29.
--WorkHours--
CREATE TABLE WorkHours (
WorkHoursID INT IDENTITY,
WorkDate DATETIME,
Task NVARCHAR(100),
Comments NVARCHAR(100),
EmployeeID INT,
WorkHours INT,
CONSTRAINT PK_WorkHoursID PRIMARY KEY(WorkHoursID) ,
CONSTRAINT FK_WorkHours_Employees_EmployeeID FOREIGN KEY(EmployeeID) REFERENCES Employees(EmployeeID)
)
GO


--Add some records--
INSERT INTO WorkHours
			(WorkDate,Task,Comments,EmployeeID,WorkHours)
		VALUES
			(GETDATE(), 'Important task #1', 'Uslees comment', 2, 8),
			(GETDATE(), 'Such wow task', 'Very comment', 13, 6),
			(GETDATE(), 'Yaarlw', 'Arrrhhgh', 23, 8)

--30.
BEGIN TRAN
	ALTER TABLE Departments
		DROP CONSTRAINT FK_Departments_Employees
	DELETE e FROM  Employees e, Departments d
		WHERE e.DepartmentID = d.DepartmentID
		AND d.Name = 'Sales'
ROLLBACK TRAN

--31.
BEGIN TRAN
	DROP TABLE EmployeesProjects
ROLLBACK TRAN

--32.
BEGIN TRAN
	SELECT *  INTO  #Temp_EmployeesProjects
	FROM EmployeesProjects
	DROP TABLE EmployeesProjects
	SELECT * INTO EmployeesPRojects
	FROM #Temp_EmployeesProjects
ROLLBACK TRAN