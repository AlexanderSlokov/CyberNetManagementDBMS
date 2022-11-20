BEGIN TRANSACTION 
SAVE TRANSACTION tra_DeleteAdmin
DELETE dbo.account WHERE name = 'admin'
COMMIT


/*
Tao mot transaction de xoa name la 'Admin'
commit de commit transaction
*/