CREATE PROCEDURE pr_DeleteEmployee @id int
AS
DELETE FROM EMPLOYEE WHERE id = @id

/*
Tao procedure truyen vao @id
Ket qua se xoa 1 hang trong bang EMPLOYEE 
Co id trung voi @id truyen vao.
*/