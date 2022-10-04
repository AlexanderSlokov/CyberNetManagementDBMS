CREATE PROCEDURE pr_TableAllSalary
AS
SELECT t.sumSalary as 'Total Payment', t.id as 'Employee ID', t.name as 'Employee Name',
t.birthDate as 'Birth Date', t.gender as 'Gender', t.phoneNum as 'Phone', t.email as 'Email'
FROM dbo.fun_salaryAllEmployees() as t