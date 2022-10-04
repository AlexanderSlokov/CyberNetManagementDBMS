CREATE PROCEDURE pr_getUserEmail @id int
AS
SELECT * FROM account WHERE id = @id