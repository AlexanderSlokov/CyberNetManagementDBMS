CREATE PROCEDURE pr_MakeBalanceZero @id int
AS
UPDATE account SET balance = 0 WHERE id = @id