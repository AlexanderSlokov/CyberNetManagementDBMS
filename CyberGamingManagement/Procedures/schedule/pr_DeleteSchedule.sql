CREATE PROCEDURE pr_DeleteSchedule @employee_id int, @roomID int, @startTime time(7), @endTime time(7), @weekDate nvarchar(50)
AS
DELETE FROM schedule  WHERE employee_id = @employee_id AND roomID = @roomID AND startTime = @startTime AND endTime = @endTime AND weekDate = @weekDate


/*
Tao mot PROCEDURE de mot hang trong bang schedule
Xoa mot hang trong bang schedule co du lieu do nguoi dung nhap vao
*/