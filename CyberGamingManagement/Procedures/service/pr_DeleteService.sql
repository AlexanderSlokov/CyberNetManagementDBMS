CREATE PROCEDURE pr_DeleteService @id int
AS
DELETE FROM service WHERE id = @id

/*
Tao mot PROCEDURE de xoa mot hang trong bang service
Xoa mot hang trong bang service co id bang id do nguoi dung nhap vao
*/