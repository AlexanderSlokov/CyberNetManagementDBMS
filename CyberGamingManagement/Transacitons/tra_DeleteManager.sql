BEGIN TRANSACTION 
SAVE TRANSACTION tra_DeleteManager
DELETE dbo.account WHERE name = 'manager'
COMMIT

/*
Tao mot transaction de xoa name la 'manager'
commit de commit transaction
*/