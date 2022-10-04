CREATE PROCEDURE pr_DischargeBalance @ammount int , @id int
AS
UPDATE account SET balance = account.balance - @ammount WHERE id = @id