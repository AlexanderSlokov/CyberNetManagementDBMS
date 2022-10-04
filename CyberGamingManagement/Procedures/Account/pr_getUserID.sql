CREATE PROCEDURE pr_getUserID @username nvarchar(50)
AS
SELECT * FROM account WHERE username = @username