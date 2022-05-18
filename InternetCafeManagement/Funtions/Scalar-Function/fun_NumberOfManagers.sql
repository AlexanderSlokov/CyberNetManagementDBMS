CREATE FUNCTION fun_NumberOfManagers()
RETURNS int
AS 
BEGIN
	RETURN (SELECT COUNT(id) from employee WHERE position = 'manager')
END;