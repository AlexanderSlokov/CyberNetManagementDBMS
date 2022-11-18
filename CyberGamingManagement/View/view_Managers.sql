CREATE VIEW view_Managers 
AS
SELECT id, name
FROM     dbo.employee
WHERE  (position = 'manager')

/*
Tao ra mot view de xem thong tin cua manager
In cac thong tin id, name cua manager
*/