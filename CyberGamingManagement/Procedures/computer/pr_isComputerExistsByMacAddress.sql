CREATE PROCEDURE pr_isComputerExistsByMacAddress @macAddress nvarchar(50)
AS
SELECT * FROM computer WHERE macAddress = @macAddress


/*
Tao procedure truyen vao @macAddress
Ket qua tra ve mot bang, gom tat ca cac cot cua bang computer
Co macAddress trung voi @macAddress truyen vao.
*/