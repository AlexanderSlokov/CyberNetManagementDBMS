CREATE PROCEDURE pr_GetManagersList @position nvarchar(50)
AS
SELECT * FROM employee WHERE position = @position