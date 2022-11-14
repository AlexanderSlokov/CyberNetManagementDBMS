CREATE PROCEDURE pr_MakeBusy @status nvarchar, @id int
AS
UPDATE computer SET status = @status WHERE id = @id


/*
Tao procedure truyen vao 2 tham so @status va @id
Ket qua se cap nhat lai status(Busy) bang @status truyen vao
voi ID trung voi @id truyen vao.
*/