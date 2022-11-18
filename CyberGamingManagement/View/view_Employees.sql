CREATE VIEW view_Employees
AS
SELECT id, name
FROM     dbo.employee
WHERE  (position = 'employee')

/*
Tao ra mot view de xem thong tin cua employee
In cac thong tin id, name cua employee
*/