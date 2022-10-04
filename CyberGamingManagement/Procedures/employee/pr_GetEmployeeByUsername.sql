CREATE PROCEDURE pr_GetEmployeeByUsername @username nvarchar(50)
AS
SELECT * FROM employee WHERE username = @username