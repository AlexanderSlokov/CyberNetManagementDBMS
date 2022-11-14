CREATE PROCEDURE pr_DeleteComputer @id int
AS
DELETE FROM computer WHERE id = @id

/*
Tao procedure voi tham so truyen vao @id
Ket qua se xoa mot hang trong bang computer
Voi id trung voi @id truyen vao.
*/