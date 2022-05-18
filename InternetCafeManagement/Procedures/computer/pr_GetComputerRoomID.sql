CREATE PROCEDURE pr_GetComputerRoomID @id int
AS
SELECT * FROM computer WHERE id = @id