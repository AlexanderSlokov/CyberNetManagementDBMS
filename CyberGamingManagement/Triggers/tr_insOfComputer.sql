CREATE TRIGGER tr_insOfComputer ON user_using_computer
AFTER INSERT
AS
BEGIN
DECLARE @id int
SELECT @id = computer_id
FROM inserted
UPDATE computer SET status = 'online'
WHERE @id = id
END

/*
Tao trigger de cap nhap tinh trang cua computer la online
*/