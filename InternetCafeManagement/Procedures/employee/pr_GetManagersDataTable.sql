CREATE PROCEDURE pr_GetManagersDataTable @position nvarchar(50)
AS
SELECT * FROM employee WHERE position = @position