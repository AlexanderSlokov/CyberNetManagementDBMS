CREATE VIEW view_FeeOfComputer 
AS
SELECT cpt.info, cpt.macAddress, cpt.roomID, cpt.fee_per_hour
FROM dbo.computer_room AS cpt_r INNER JOIN dbo.computer AS cpt 
ON cpt_r.id = cpt.roomID

/*
Tao mot view de xem phi su dung cua may tinh
In ra mot bang gom cac thong tin info, macAddress, roomID, fee_per_hour
cua cac may tinh
*/