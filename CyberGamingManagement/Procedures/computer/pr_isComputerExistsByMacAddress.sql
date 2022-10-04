CREATE PROCEDURE pr_isComputerExistsByMacAddress @macAddress nvarchar(50)
AS
SELECT * FROM computer WHERE macAddress = @macAddress