CREATE PROCEDURE pr_AddNewComputerRoom @id int, @floor int, @compNum int, @max_comp_num int 
AS
INSERT INTO computer_room (id, floor, compNum, max_comp_num)
VALUES (@id, @floor, @compNum, @max_comp_num)

/*
Tao procedure truyen vao cac tham so @id,@floor,@compNum,@max_comp_num
Ket qua se them mot hang moi vao bang computer_room voi cac cot id, floor, compNum, max_comp_num
*/