CREATE VIEW view_UsingComputer 
AS
SELECT ac.id, ac.name, ucp.computer_id, ucp.starting_time
FROM account AS ac INNER JOIN user_using_computer AS ucp ON ac.id = ucp.user_id

/*
Tao ra mot view de xem computer dang duoc su dung boi user nao
In ra mot bang gom cac thong tin id, name, computer_id, starting_time
cua user dang su dung computer
*/