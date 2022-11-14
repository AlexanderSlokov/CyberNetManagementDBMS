CREATE PROCEDURE pr_GetComputerByMacAddress @macAdress nvarchar(50)
AS
SELECT * FROM computer WHERE macAddress = @macAdress

/*
Tao procedure truyen vao @macAdress
Ket qua tra ve mot bang, gom tat ca cac cot cua bang computer
Co macAddress trung voi @macAdress truyen vao.
*/