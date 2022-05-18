CREATE PROCEDURE pr_ChargeBalance @ammount int, @id int
AS
UPDATE account SET balance = account.balance + @ammount WHERE id = @id