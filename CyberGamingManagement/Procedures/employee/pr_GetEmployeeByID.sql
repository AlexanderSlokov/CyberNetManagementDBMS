CREATE PROCEDURE pr_GetEmployeeByID @id int
AS
SELECT * FROM employee WHERE id = @id