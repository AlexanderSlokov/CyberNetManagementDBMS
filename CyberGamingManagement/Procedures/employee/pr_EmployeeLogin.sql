CREATE PROCEDURE pr_EmployeeLogin @User nvarchar(50), @Pass nvarchar(50)
AS
SELECT * FROM employee WHERE username = @User AND password = @Pass

/*
Tao procedure Login truyen vao 2 tham so @User & @Pass
Ket qua tra ve mot bang gom tat ca cac cot trong bang employee
co username trung voi @User & password trung voi @Pass truyen vao.
*/