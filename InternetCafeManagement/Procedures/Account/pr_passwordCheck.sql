CREATE PROCEDURE pr_passwordCheck @id int, @password nvarchar(50)
AS
SELECT * FROM account WHERE id = @id and password = @password