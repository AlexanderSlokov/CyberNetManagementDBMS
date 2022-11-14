CREATE PROCEDURE pr_MakeBalanceZero @id int
AS
UPDATE account SET balance = 0 WHERE id = @id

/*
Tao procedure truyen vao @id
Ket qua se cap nhat lai balance = 0
Voi id trung voi @id truyen vao.
*/