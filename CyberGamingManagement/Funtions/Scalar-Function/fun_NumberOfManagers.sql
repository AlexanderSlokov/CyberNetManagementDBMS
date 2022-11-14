CREATE FUNCTION fun_NumberOfManagers()
RETURNS int
AS 
BEGIN
	RETURN (SELECT COUNT(id) from employee WHERE position = 'manager')
END;

/*
Tao function tinh tong so luong Managers
Ket qua tra ve la so luong Managers
*/
