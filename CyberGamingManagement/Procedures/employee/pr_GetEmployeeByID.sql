CREATE PROCEDURE pr_GetEmployeeByID @id int
AS
SELECT * FROM employee WHERE id = @id

/*
Tao procedure truyen vao @id
Ket qua tra ve mot bang gom tat ca cac cot trong bang employee
co id trung voi @id truyen vao.
*/