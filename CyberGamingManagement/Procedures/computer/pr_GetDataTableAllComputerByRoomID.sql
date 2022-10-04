CREATE PROCEDURE pr_GetDataTableAllComputerByRoomID @roomID int
AS
SELECT c.id, c.info, c.roomID, c.status, c.fee_per_hour, c.macAddress FROM computer as c INNER JOIN computer_room as cr 
                    ON c.roomID = cr.id WHERE c.roomID = @roomID