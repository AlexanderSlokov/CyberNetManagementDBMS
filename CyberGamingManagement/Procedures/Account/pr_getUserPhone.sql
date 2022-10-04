CREATE PROCEDURE pr_getUserPhone @id int
AS
SELECT * FROM account WHERE id = @id