CREATE PROCEDURE pr_MakeBusy @status nvarchar, @id int
AS
UPDATE computer SET status = @status WHERE id = @id