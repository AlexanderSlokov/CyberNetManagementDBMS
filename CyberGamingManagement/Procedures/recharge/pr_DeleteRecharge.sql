CREATE PROCEDURE pr_DeleteRecharge @id int
AS
DELETE recharge WHERE id  = @id

/*
Tao procedure truyen vao tham so @int
Ket qua se xoa 1 hang trong bang recharge 
co id trung voi @id truyen vao.
*/