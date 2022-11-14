CREATE PROCEDURE pr_DeleteOrder @service_id int, @account_id int
AS
DELETE FROM order_list WHERE service_id = @service_id AND account_id = @account_id

/*
Tao procedure xoa Order voi 2 tham so truyen vao @service_id,@account_id
Ket qua se xoa mot hang trong bang order_list
Co service_id & account_id trung voi 2 tham so truyen vao.
*/