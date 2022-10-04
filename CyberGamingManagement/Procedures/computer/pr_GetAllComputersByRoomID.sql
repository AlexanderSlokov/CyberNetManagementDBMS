CREATE PROCEDURE pr_GetAllComputersByRoomID @roomID int
AS
SELECT c.id, c.info, c.roomID, c.Status, c.fee_per_hour FROM computer as c INNER JOIN computer_room as cr  
                    ON c.roomID = cr.id WHERE c.roomID = @roomID