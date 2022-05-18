CREATE PROCEDURE pr_GetUserBalance @id int
AS
SELECT * FROM account WHERE id = @id