CREATE PROCEDURE pr_GetComputerInfo @id int
AS
SELECT * FROM computer WHERE id = @id