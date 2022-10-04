CREATE PROCEDURE pr_DeleteOrder @service_id int, @account_id int
AS
DELETE FROM order_list WHERE service_id = @service_id AND account_id = @account_id