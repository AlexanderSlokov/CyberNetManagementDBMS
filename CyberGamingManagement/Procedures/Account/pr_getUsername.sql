CREATE PROCEDURE pr_getUsername @id int
AS
SELECT * FROM account WHERE id = @id