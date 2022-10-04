CREATE PROCEDURE pr_GetEmployeesDataTable @position nvarchar(50)
AS
SELECT * FROM employee WHERE position = @position