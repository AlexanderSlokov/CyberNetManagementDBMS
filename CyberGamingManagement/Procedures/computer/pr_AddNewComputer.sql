CREATE PROCEDURE pr_AddNewComputer @info nvarchar(50), @roomID int, @status nvarchar(50), @fee_per_hour float
AS
INSERT INTO computer (info, roomID, status, fee_per_hour)
VALUES (@info, @roomID, @status, @fee_per_hour)