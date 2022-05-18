CREATE PROCEDURE pr_ComputerCountByID @id int
AS
SELECT count(*) FROM computer as c INNER JOIN computer_room as cr 
				ON c.roomID = cr.id WHERE c.roomID = @id