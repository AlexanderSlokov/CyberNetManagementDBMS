CREATE PROCEDURE pr_DeleteComputerRoom @id int
AS
DELETE FROM computer_room WHERE id = @id

/*
Tao procedure voi tham so truyen vao @id
Ket qua se xoa 1 hang trong computer_room 
Co Id trung voi @id truyen vao.
*/