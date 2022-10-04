CREATE PROCEDURE pr_IsEmployeeCheckIn @check_in Time(7), @employee_id int
AS
SELECT * FROM salary as sa INNER JOIN schedule as s 
ON sa.startTime = s.startTime AND sa.endTime = s.endTime AND
sa.employee_id = s.employee_id AND sa.roomID = s.roomID AND sa.weekDate = s.weekDate
WHERE EXISTS (
SELECT * FROM  salary as sal INNER JOIN schedule as sc
ON sal.startTime = sc.startTime AND sal.endTime = sc.endTime AND
sal.employee_id = sc.employee_id AND sal.roomID = sc.roomID AND sal.weekDate = sc.weekDate
WHERE @check_in <= sc.endTime AND @check_in >= sc.startTime AND sal.employee_id = @employee_id)