CREATE PROCEDURE pr_MakeInUse @status nvarchar(50) , @id int
AS
UPDATE computer SET status = @status WHERE id = @id


/*
Tao procedure truyen vao 2 tham so @status va @id
Ket qua se cap nhat lai status(InUSE) bang @status truyen vao
voi ID trung voi @id truyen vao.
*/