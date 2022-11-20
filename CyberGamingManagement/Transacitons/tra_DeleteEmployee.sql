BEGIN TRANSACTION 
SAVE TRANSACTION tra_DeleteEmployee
DELETE dbo.account WHERE name = 'employee'
COMMIT

/*
Tao mot transaction de xoa name la 'Employee'
commit de commit transaction
*/