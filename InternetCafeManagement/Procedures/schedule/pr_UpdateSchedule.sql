CREATE PROCEDURE pr_UpdateSchedule @employee_id int, @roomID int, @startTime time(7), @endTime time(7), @weekDate nvarchar(50),
@shift_type nvarchar(50) 
AS 
UPDATE dbo.schedule SET employee_id = @employee_id, roomID = @roomID, startTime = @startTime, endTime = @endTime, weekDate = @weekDate, shift_type = @shift_type 
WHERE employee_id = @employee_id AND roomID = @roomID AND startTime = @startTime AND endTime = @endTime