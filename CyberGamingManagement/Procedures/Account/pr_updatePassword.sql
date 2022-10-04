CREATE PROCEDURE pr_updatePassword @id int, @password nvarchar(50)
AS
UPDATE account SET password = @password WHERE id = @id