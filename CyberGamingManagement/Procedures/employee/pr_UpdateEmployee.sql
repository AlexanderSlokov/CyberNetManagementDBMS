CREATE PROCEDURE pr_UpdateEmployee @name nvarchar(50), @position nvarchar(50), @birthDate DateTime, @gender nvarchar(50), @phoneNum nvarchar(50), 
@email nvarchar(50), @image image, @salary_per_hour real, @username nvarchar(50), @password nvarchar(50), @id int
AS
UPDATE employee SET name = @name, position = @position, birthDate = @birthDate, gender = @gender, phoneNum = @phoneNum, email = @email, image = @image, 
                            salary_per_hour = @salary_per_hour, username = @username, password = @password 
							WHERE id = @id
/*
Tao procedure cap nhat lai thong tin employee voi cac tham so truyen vao
Ket qua se cap nhat lai tat ca thong tin voi tham so truyen vao.
Voi User co id trung voi @id truyen vao.

*/