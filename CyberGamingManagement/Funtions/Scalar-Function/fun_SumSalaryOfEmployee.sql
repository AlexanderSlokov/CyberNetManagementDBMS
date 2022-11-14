CREATE FUNCTION fun_SumSalaryOfEmployee(@employee_id int)
returns real
as
Begin
return 
(SELECT SUM(e.salary_per_hour * DATEDIFF(HH, s.startTime, s.endTime)) 
FROM schedule as s INNER JOIN employee as e ON s.employee_id = e.id
INNER JOIN salary as sa ON sa.startTime = s.startTime AND sa.endTime = s.endTime AND
sa.employee_id = s.employee_id AND sa.roomID = s.roomID AND sa.weekDate = s.weekDate
WHERE sa.check_in IS NOT null AND e.id = @employee_id)
END

/*
Tao function tinh tong so luong cua nhan vien truyen vao @emloyee_id
Ket qua se tra ve tong so luong cua nhan vien co id trung voi @emloyee_id
*/

