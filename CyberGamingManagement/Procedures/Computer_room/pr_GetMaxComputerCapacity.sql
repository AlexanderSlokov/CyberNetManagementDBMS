CREATE PROCEDURE pr_GetMaxComputerCapacity @id int
AS
SELECT * FROM computer_room WHERE id = @id

/*
Tao procedure voi tham so truyen vao @id
Ket qua se tra ve mot bang gom tat ca cac cot trong bang computer_room
Co Id trung voi @id truyen vao.
*/