CREATE PROCEDURE pr_GetComputerStatus @id int
AS
SELECT * FROM computer WHERE id = @id

/*
Tao procedure truyen vao @id
Ket qua tra ve mot bang, gom tat ca cac cot cua bang computer
Co id trung voi @id truyen vao.
*/