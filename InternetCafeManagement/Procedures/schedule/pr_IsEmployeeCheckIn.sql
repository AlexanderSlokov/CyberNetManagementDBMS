CREATE PROCEDURE pr_IsEmployeeCheckIn @employee_id int, @roomID int, @startTime time(7), 
@endTime time(7), @weekDate nvarchar(50)
AS
SELECT * FROM schedule WHERE employee_id = @employee_id AND roomId = @roomID AND
startTime = @startTime AND endTime = @endTime AND weekDate = @weekDate
AND check_in != null