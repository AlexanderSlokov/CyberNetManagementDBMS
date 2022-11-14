CREATE PROCEDURE pr_isUserExist_By_Username @username nvarchar(50)
AS
SELECT * FROM account WHERE username = @username

/*
Tao procedure lay thong tin User, bang cach truyen @username 
Ket qua se tra ve mot bang gom tat ca cac cot cua bang account
Voi username trung voi @username truyen vao.
*/