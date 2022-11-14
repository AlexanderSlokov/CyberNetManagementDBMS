CREATE FUNCTION fun_NumberOfUsers()
RETURNS int
AS 
BEGIN
	RETURN (SELECT COUNT(id) from account)
END;

/*
Tao function tinh tong so luong User
Ket qua tra ve la so luong User
*/
