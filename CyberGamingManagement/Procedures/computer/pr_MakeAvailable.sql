CREATE PROCEDURE pr_MakeAvailable @status nvarchar(50), @id int
AS
UPDATE computer SET status = @status WHERE id = @id