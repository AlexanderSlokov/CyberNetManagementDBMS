CREATE PROCEDURE pr_AddEmployee @id int, @name nvarchar(50), @position nvarchar(50), @birthDate DateTime, @gender nvarchar(50), @phoneNum nvarchar(50), @email nvarchar(50), @image image, @salary_per_hour real, @username nvarchar(50), @password nvarchar(50)
AS
INSERT INTO employee (id, name, position, birthDate, gender, phoneNum, email, image, salary_per_hour, username, password)
                 VALUES (@id, @name, @position, @birthDate, @gender, @phoneNum, @email, @image, @salary_per_hour, @username, @password)
/*
Tao procedure them Employee truyen vao cac tham so
Ket qua se them 1 hang moi vao bang employee gom cac cot (id, name, position, birthDate, 
gender, phoneNum, email, image, salary_per_hour, username, password)
Voi gia tri chung ta truyen vao.

*/