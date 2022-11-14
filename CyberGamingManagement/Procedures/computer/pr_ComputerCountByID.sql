CREATE PROCEDURE pr_ComputerCountByID @id int
AS
SELECT count(*) FROM computer as c INNER JOIN computer_room as cr 
				ON c.roomID = cr.id WHERE c.roomID = @id

/*
Tao procedure tinh tong so luong computer bang cach truyen vao @id
Ket qua se tra ve tong so luong computer cua 2 bang computer & computer_room
voi Id trung voi @id chung ta truyen vao.
*/