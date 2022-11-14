CREATE PROCEDURE pr_RechargeForUser @account_id int, @amount real
AS
UPDATE account SET balance = balance + @amount WHERE id = @account_id

/*
Tao procedure gom 2 tham so truyen vao @account_id,@amount
Ket qua se update lai balance bang cach cong balance hien co voi @ammount truyen vao
Voi id trung voi @account_id truyen vao.
*/