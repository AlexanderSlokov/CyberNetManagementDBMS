CREATE PROCEDURE pr_GetUserGender @id int
AS
SELECT * FROM account WHERE id = @id