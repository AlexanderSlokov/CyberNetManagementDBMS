CREATE PROCEDURE pr_isServiceExsists @id int
AS
SELECT * FROM service WHERE id = @id


/*
Tao mot PROCEDURE de tim kiem du lieu trong bang service
In ra mot hang trong bang service co id bang id do nguoi dung nhap vao
*/