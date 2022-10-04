CREATE PROCEDURE pr_updateUserData @id int,@name nvarchar(50), @gender nvarchar(50), @email nvarchar(50), @phone nvarchar(50)
AS
UPDATE account SET name = @name, gender = @gender, email = @email, phone = @phone WHERE id = @id