CREATE PROCEDURE pr_GetEmployeeByUsername @username nvarchar(50)
AS
SELECT * FROM employee WHERE username = @username


/*
Tao procedure truyen vao @username
Ket qua tra ve mot bang gom tat ca cac cot trong bang employee
co username trung voi @username truyen vao.
*/