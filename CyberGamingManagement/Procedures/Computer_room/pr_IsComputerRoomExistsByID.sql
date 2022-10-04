CREATE PROCEDURE pr_IsComputerRoomExistsByID @id int
AS
SELECT * FROM computer_room WHERE id = @id