CREATE TRIGGER tr_computer_ForInsert
ON computer
FOR INSERT
AS
BEGIN

	Declare @roomID int
	Select @roomID = roomID from inserted

	UPDATE computer_room set compNum = compNum + 1 
	WHERE @roomID = computer_room.id
END

/*
Tao mot trigger de them mot computer
*/