CREATE PROCEDURE pr_UpdateInfo @info nvarchar(50) , @id int
AS
UPDATE computer SET info = @info WHERE id = @id


/*
Tao procedure truyen vao 2 tham so @info va @id
Ket qua se cap nhat lai info voi @info truyen vao
Voi user co id trung voi @id truyen vao.
*/