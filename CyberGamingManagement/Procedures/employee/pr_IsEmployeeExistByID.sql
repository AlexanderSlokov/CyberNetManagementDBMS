CREATE PROCEDURE pr_IsEmployeeExistByID @id int
AS
SELECT * FROM employee WHERE id = @id