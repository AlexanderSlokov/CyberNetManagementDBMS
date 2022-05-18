CREATE PROCEDURE pr_IsComputerExistsByID @id int
AS
SELECT * FROM computer WHERE id = @id