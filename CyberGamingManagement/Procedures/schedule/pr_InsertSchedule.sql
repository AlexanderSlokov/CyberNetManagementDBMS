CREATE PROCEDURE pr_InsertSchedule @employee_id int, @roomID int, @startTime time(7), @endTime time(7), @weekDate nvarchar(50),
@shift_type nvarchar(50) 
AS 
INSERT INTO schedule(employee_id, roomID, startTime, endTime, weekDate, shift_type) 
VALUES (@employee_id, @roomID, @startTime, @endTime, @weekDate, @shift_type);


/*
Tao mot PROCEDURE de them mot hang vao bang schedule
Them mot hang trong bang schedule co du lieu do nguoi dung nhap vao
*/