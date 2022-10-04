CREATE PROCEDURE pr_GetComputerByMacAddress @macAdress nvarchar(50)
AS
SELECT * FROM computer WHERE macAddress = @macAdress