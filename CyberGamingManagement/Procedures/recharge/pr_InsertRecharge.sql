CREATE PROCEDURE pr_InsertRecharge @account_id int, @amount real
AS
INSERT INTO recharge (account_id, amount) VALUES (@account_id, @amount)

/*
Tao procedure truyen vao 2 tham so @account_id,@amount
Ket qua them 1 hang moi vao bang recharge gom 2 cot account_id, amount
*/