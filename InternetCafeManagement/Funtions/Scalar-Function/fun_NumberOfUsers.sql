CREATE FUNCTION fun_NumberOfUsers()
RETURNS int
AS 
BEGIN
	RETURN (SELECT COUNT(id) from account)
END;