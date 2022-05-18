CREATE PROCEDURE pr_UpdateInfo @info nvarchar(50) , @id int
AS
UPDATE computer SET info = @info WHERE id = @id