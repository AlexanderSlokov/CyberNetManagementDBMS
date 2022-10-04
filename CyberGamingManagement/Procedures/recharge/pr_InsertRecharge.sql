CREATE PROCEDURE pr_InsertRecharge @account_id int, @amount real
AS
INSERT INTO recharge (account_id, amount) VALUES (@account_id, @amount)