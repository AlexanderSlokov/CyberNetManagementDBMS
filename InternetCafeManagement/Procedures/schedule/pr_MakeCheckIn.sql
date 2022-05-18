CREATE PROCEDURE pr_MakeCheckIn @employee_id int, @roomID int, @startTime time(7), @endTime time(7), 
@weekDate nvarchar(50), @check_in DateTime
AS
UPDATE schedule SET check_in = @check_in
WHERE employee_id = @employee_id AND roomID = @roomID AND startTime = @startTime AND endTime = @endTime
