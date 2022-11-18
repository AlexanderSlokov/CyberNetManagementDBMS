CREATE VIEW view_ScheduleOfEmployees
AS
SELECT ep.id, ep.name, ep.gender, sal.check_in, sal.startTime, sal.endTime, sal.weeKDate
FROM dbo.schedule AS sc INNER JOIN
                  dbo.employee AS ep ON sc.employee_id = ep.id INNER JOIN
                    dbo.salary AS sal ON sal.employee_id = ep.id
WHERE  (ep.position = 'employee')

/*
Tao ra mot view de xem lich trinh lam viec cua employee
In ra mot bang gom cac thong tin id, name, gender, check_in, startTime,
endTime, weeKDate cua emloyees
*/
