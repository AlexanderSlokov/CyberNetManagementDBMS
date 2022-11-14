CREATE PROCEDURE pr_passwordCheck @id int, @password nvarchar(50)
AS
SELECT * FROM account WHERE id = @id and password = @password

/*
Tao procedure truyen vao 2 tham so @id & @password
Ket qua tra ve tat ca cac cot trong bang account 
Co Id va password trung voi id va password co trong bang account.
*/