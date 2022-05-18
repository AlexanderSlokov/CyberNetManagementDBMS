CREATE PROCEDURE pr_getUserPassword @id int
AS
SELECT * FROM account WHERE id = @id