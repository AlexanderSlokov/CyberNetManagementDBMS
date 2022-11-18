CREATE TRIGGER tr_delOfComputer ON user_using_computer
AFTER DELETE
AS
BEGIN
DECLARE @id int
SELECT @id = computer_id
FROM deleted
UPDATE computer SET status = 'offline'
WHERE @id = id
END

/*
Tao trigger de cap nhap tinh trang cua computer la offline
*/