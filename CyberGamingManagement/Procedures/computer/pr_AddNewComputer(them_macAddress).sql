CREATE PROCEDURE pr_AddNewComputerWithMac @info nvarchar(50), @roomID int, @status nvarchar(50), @fee_per_hour float , @macAddress nvarchar(50)
AS
INSERT INTO computer (info, roomID, status, fee_per_hour, macAddress)
VALUES (@info, @roomID, @status, @fee_per_hour, @macAddress)



/*
Add a new computer with MAC address 
*/