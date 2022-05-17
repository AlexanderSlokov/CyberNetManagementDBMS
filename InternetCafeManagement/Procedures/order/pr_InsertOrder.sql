CREATE PROCEDURE pr_InsertOrder @service_id int, @account_id int, @quantity int
AS
INSERT INTO order_list (service_id, account_id, quantity)
VALUES (@service_id, @account_id, @quantity)