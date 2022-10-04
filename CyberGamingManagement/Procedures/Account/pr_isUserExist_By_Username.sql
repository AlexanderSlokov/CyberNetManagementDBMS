CREATE PROCEDURE pr_isUserExist_By_Username @username nvarchar(50)
AS
SELECT * FROM account WHERE username = @username