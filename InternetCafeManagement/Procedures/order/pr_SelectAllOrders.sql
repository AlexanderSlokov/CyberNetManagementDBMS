CREATE PROCEDURE pr_SelectAllOrders
AS
SELECT s.id as 'Service ID', s.name as 'Service Name', s.picture as 'Picture', s.price as 'Price', 
ol.quantity as 'Quantity', s.description as 'Description', ol.account_id as 'User ID', 
a.name as 'User Name', a.balance as 'Balance'
FROM order_list as ol INNER JOIN service as s ON ol.service_id = s.id 
INNER JOIN account as a ON ol.account_id = a.id