CREATE PROCEDURE pr_GetComputerCount @id int
AS
SELECT * FROM computer_room WHERE id = @id