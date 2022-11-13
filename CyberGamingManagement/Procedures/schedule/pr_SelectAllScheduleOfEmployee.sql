CREATE PROCEDURE pr_SelectAllScheduleOfEmployee @weekDate nvarchar(50), @employee_id int
AS
SELECT s.roomID as 'Room ID', s.startTime as 'Check In Time', 
s.endTime as 'Check Out time', s.shift_type as 'Shift Type' 
FROM schedule as s INNER JOIN employee as e ON s.employee_id = e.id
WHERE s.weekDate = @weekDate AND e.id = @employee_id


/*
Tao mot PROCEDURE xem du lieu trong bang schedule
In ra mot hang gom cac thong in Room ID, Check In Time, Check Out Time, Shift Type
cua employee co weekDate va id do nguoi dung nhap vao
*/