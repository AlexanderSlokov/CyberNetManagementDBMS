CREATE PROCEDURE pr_GetComputerStatus @id int
AS
SELECT * FROM computer WHERE id = @id