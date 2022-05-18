CREATE PROCEDURE pr_GetComputerFeePerHour @id int
AS
SELECT * FROM computer WHERE id = @id