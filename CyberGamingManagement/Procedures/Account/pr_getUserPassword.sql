CREATE PROCEDURE pr_getUserPassword @id int
AS
SELECT * FROM account WHERE id = @id

/*
Tao procedure lay thong tin UserPassword, bang cach truyen @id 
Ket qua se tra ve mot bang gom tat ca cac cot cua bang account
Voi id trung voi @id truyen vao.
*/