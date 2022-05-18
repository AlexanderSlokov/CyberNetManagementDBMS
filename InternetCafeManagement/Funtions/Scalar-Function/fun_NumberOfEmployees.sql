CREATE FUNCTION fun_NumberOfEmployees()
RETURNS int
AS 
BEGIN
	RETURN (SELECT COUNT(id) from employee WHERE position = 'employee')
END;