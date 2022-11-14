
CREATE PROCEDURE pr_SelectAllOrdersOfUser @account_id int
AS 
SELECT s.id as 'Service ID', s.name as 'Service Name', s.picture as 'Picture', s.price as 'Price', s.description as 'description', ol.account_id as 'User ID'
FROM order_list as ol INNER JOIN service as s ON ol.service_id = s.id
WHERE ol.account_id = @account_id

/*
Tao procedure truyen vao @account_id
Ket qua se tra ve mot bang gom 6 cot Service ID,Service Name,Picture,Price,description,User ID
Bang cach ket noi 2 bang order_list & service
co account_id ben bang order_list trung voi @account_id truyen vao.
*/