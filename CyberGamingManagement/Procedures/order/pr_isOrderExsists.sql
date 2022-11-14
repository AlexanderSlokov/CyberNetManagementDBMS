CREATE PROCEDURE pr_isOrderExsists @service_id int, @account_id int
AS
SELECT * FROM order_list WHERE service_id = @service_id AND account_id = @account_id

/*
Tao procedure truyen voa 2 tham so @service_id,@account_id
Ket qua se tra ve mot bang gom tat ca cac cot trong bang order_list
Co service_id,account_id trung voi 2 tham so truyen vao.
*/