CREATE PROCEDURE pr_updatePassword @id int, @password nvarchar(50)
AS
UPDATE account SET password = @password WHERE id = @id

/*
Tao procedure truyen vao 2 tham so @password va @id
Ket qua se cap nhat lai password trong bang account voi @password truyen vao
Voi user co id trung voi @id truyen vao.
*/