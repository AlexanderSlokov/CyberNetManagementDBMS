CREATE PROCEDURE pr_IsEmployeeExistByUsername @username nvarchar(50)
AS
SELECT * FROM employee WHERE username = @username