CREATE PROCEDURE pr_EmployeeLogin @User nvarchar(50), @Pass nvarchar(50)
AS
SELECT * FROM employee WHERE username = @User AND password = @Pass