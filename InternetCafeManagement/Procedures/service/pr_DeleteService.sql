CREATE PROCEDURE pr_DeleteService @id int
AS
DELETE FROM service WHERE id = @id