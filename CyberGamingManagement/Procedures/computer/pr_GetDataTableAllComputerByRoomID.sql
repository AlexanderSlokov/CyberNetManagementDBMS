CREATE PROCEDURE pr_GetDataTableAllComputerByRoomID @roomID int
AS
SELECT c.id, c.info, c.roomID, c.status, c.fee_per_hour, c.macAddress FROM computer as c INNER JOIN computer_room as cr 
                    ON c.roomID = cr.id WHERE c.roomID = @roomID

/*
Tao procedure voi tham so truyen vao @roomID
Ket qua tra ve mot bang gom 6 cot id,info,roomID,status,fee_per_hour,macAddress
Bang cach ket noi 2 bang computer & computer_room voi cot roomID
*/