CREATE PROCEDURE pr_SelectAllSchedules
AS 
SELECT e.id, e.name, e.position, s.roomID, s.startTime, s.endTime, s.weekDate, s.shift_type 
FROM schedule as s INNER JOIN employee as e ON s.employee_id = e.id


/*
Tao mot PROCEDURE xem du lieu trong bang employee va schedule
In ra mot hang gom cac thong in position, roomID, startTime, endTime, weekDate, shift_type 
cua employee 
*/