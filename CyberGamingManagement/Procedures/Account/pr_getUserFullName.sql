CREATE PROCEDURE pr_getUserFullName @id int
AS
SELECT * FROM account WHERE id = @id