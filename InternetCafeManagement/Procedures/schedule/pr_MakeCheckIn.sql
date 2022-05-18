CREATE PROCEDURE pr_MakeCheckIn @employee_id int, @roomID int, @startTime time(7), @endTime time(7), 
@weekDate nvarchar(50), @check_in DateTime, @shift_type nvarchar(50)
AS
INSERT INTO schedule (employee_id, check_in, roomID, startTime, endTime, weekDate, shift_type)
VALUES ( @employee_id, @check_in, @roomID, @startTime, @endTime, @weekDate, @shift_type)
