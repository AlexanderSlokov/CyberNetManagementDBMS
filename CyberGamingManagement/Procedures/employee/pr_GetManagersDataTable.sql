CREATE PROCEDURE pr_GetManagersDataTable @position nvarchar(50)
AS
SELECT * FROM employee WHERE position = @position

/*
Tao procedure truyen vao @position
Ket qua tra ve mot bang gom tat ca cac cot trong bang employee
co position trung voi @position truyen vao.
*/