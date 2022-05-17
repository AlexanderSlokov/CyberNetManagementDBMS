CREATE PROCEDURE pr_DeleteRecharge @id int
AS
DELETE recharge WHERE id  = @id