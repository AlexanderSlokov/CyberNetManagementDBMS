CREATE PROCEDURE pr_updatePassword @id int, @password nvarchar(50)
AS
UPDATE account SET password = @password WHERE id = @id


/*
Tao procedure de cap nhat password, voi 2 tham so truyen vao la @id va @password
Ket qua se cap nhat lai password cua user
Co id trung voi @id truyen vao.
*/