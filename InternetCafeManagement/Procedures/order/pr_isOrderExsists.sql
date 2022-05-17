CREATE PROCEDURE pr_isOrderExsists @service_id int, @account_id int
AS
SELECT * FROM order_list WHERE service_id = @service_id AND account_id = @account_id