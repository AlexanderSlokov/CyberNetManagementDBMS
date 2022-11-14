CREATE FUNCTION fun_NumberOfEmployees()
RETURNS int
AS 
BEGIN
	RETURN (SELECT COUNT(id) from employee WHERE position = 'employee')
END;

/*
Tao function tinh tong so luong employee
Ket qua tra ve la so luong employee
*/
