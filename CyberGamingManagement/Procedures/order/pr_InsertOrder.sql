CREATE PROCEDURE pr_InsertOrder @service_id int, @account_id int, @quantity int
AS
INSERT INTO order_list (service_id, account_id, quantity)
VALUES (@service_id, @account_id, @quantity)

/*
Tao procedure them Order voi 3 tham so truyen vao @service_id,@account_id,@quantity
Ket qua se them mot hang moi vao bang order_list gom 3 cot service_id, account_id, quantity
*/