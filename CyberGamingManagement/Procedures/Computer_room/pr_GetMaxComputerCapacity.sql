CREATE PROCEDURE pr_GetMaxComputerCapacity @id int
AS
SELECT * FROM computer_room WHERE id = @id