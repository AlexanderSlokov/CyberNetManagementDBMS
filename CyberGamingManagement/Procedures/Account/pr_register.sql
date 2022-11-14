CREATE PROCEDURE pr_register @name nvarchar(50), @gender nvarchar(50), @phone nvarchar(50), 
@balance float, @email nvarchar(50), @username nvarchar(50), @password nvarchar(50)
AS
INSERT INTO account (name, gender, phone, balance, email, username, password)
VALUES (@name, @gender, @phone, @balance, @email, @username, @password)

/*
Tao procedure dang ki, truyen vao cac tham so (@name,@gender..@username,@password)
Ket qua se them mot hang moi vao bang account gom cac cot name, gender, phone, balance, email, username, password

*/