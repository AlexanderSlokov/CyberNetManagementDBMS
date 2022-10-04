CREATE PROCEDURE pr_AddEmployee @id int, @name nvarchar(50), @position nvarchar(50), @birthDate DateTime, @gender nvarchar(50), @phoneNum nvarchar(50), @email nvarchar(50), @image image, @salary_per_hour real, @username nvarchar(50), @password nvarchar(50)
AS
INSERT INTO employee (id, name, position, birthDate, gender, phoneNum, email, image, salary_per_hour, username, password)
                 VALUES (@id, @name, @position, @birthDate, @gender, @phoneNum, @email, @image, @salary_per_hour, @username, @password)