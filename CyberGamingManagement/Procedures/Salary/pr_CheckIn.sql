CREATE PROCEDURE pr_CheckIn @employee_id int, @roomID int, @startTime time(7), @endTime time(7), 
@weekDate nvarchar(50), @check_in DateTime
AS
INSERT INTO salary (employee_id, check_in, roomID, startTime, endTime, weekDate)
VALUES ( @employee_id, @check_in, @roomID, @startTime, @endTime, @weekDate)


/*
Tao mot PROCEDURE de them mot hang vao bang salary
Them mot hang trong bang salary co du lieu do nguoi dung nhap vao
*/