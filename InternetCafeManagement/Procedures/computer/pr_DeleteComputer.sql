CREATE PROCEDURE pr_DeleteComputer @id int
AS
DELETE FROM computer WHERE id = @id