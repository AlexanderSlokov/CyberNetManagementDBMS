	CREATE PROCEDURE pr_login @User nvarchar(50), @Pass nvarchar(50)
	AS
	SELECT * FROM account WHERE username = @User AND password = @Pass