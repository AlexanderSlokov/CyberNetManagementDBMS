CREATE VIEW view_AllOfSalary 
AS
SELECT nv.name, nv.position, luong.weeKDate, nv.salary_per_hour, nv.username
FROM     dbo.salary AS luong INNER JOIN
                  dbo.employee AS nv ON luong.employee_id = nv.id

/*
Tao ra mot view de xem luong mot gio cua toan bo nhan vien
bao gom employees, managers.
In ra mot bang gom cac thong tin name, position, weeKDate, salary_per_hour, username
cua toan bo nhan vien
*/