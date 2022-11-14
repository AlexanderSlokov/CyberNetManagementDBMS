CREATE PROCEDURE pr_GetAllComputersByRoomID @roomID int
AS
SELECT c.id, c.info, c.roomID, c.Status, c.fee_per_hour FROM computer as c INNER JOIN computer_room as cr  
                    ON c.roomID = cr.id WHERE c.roomID = @roomID


/*
Tao procedure truyen vao @roomID
Ket qua tra ve mot bang gom 6 cot id,info,roomID,Status,fee_per_hour 

*/