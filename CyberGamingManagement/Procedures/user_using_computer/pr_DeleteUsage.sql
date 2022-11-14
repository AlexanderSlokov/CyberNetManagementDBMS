CREATE PROCEDURE pr_DeleteUsage @computer_id int
AS
DELETE FROM user_using_computer WHERE computer_id = @computer_id


/*
Tao mot PROCEDURE de xoa computer dang duoc su dung
Xoa mot hang trong bang user_using_computer co computer_id bang computer_id duoc nhap vao
*/