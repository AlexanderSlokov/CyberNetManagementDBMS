CREATE PROCEDURE pr_RechargeForUser @account_id int, @amount real
AS
UPDATE account SET balance = balance + @amount WHERE id = @account_id