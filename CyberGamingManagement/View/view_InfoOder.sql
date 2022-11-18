CREATE VIEW view_InfoOrder 
AS
SELECT dv.id, dv.name, dv.description, dv.price, od.quantity
FROM     dbo.service AS dv INNER JOIN
                  dbo.order_list AS od ON dv.id = od.service_id

/*
Tao mot view de xem thong tin Order cua khach hang
In ra mot bang gom cac thong tin id, name, description, price, quantity
cua khach hang va mat hang
*/