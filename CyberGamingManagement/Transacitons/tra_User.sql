BEGIN TRANSACTION  tra_User
DELETE dbo.account WHERE name = 'user'
ROLLBACK

/*
Tao mot transaction de xoa name la 'User'
rollback de quay lai transaction
*/