CREATE PROCEDURE pr_DeleteComputerRoom @id int
AS
DELETE FROM computer_room WHERE id = @id