CREATE PROCEDURE pr_isScheduleExsists @employee_id int, @roomID int, @startTime time(7), @endTime time(7), @weekDate nvarchar(50)
AS
SELECT * FROM dbo.schedule WHERE employee_id = @employee_id AND roomID = @roomID AND startTime = @startTime AND endTime = @endTime AND weekDate = @weekDate



/*
Tao mot PROCEDURE de tim kiem du lieu trong bang schedule
In ra mot hang trong bang service co du lieu do nguoi dung nhap vao(neu co)
neu du lieu khong dung se khong in ra 
*/