CREATE PROCEDURE pr_GetShiftOfAllEmployees @weekDate nvarchar(50)
AS
SELECT e.id, e.name, s.roomID, s.startTime, s.endTime, s.shift_type FROM schedule as s INNER JOIN employee as e ON s.employee_id = e.id
WHERE s.weekDate = @weekDate