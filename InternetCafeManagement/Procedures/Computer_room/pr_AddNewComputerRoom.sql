CREATE PROCEDURE pr_AddNewComputerRoom @id int, @floor int, @compNum int, @max_comp_num int 
AS
INSERT INTO computer_room (id, floor, compNum, max_comp_num)
VALUES (@id, @floor, @compNum, @max_comp_num)