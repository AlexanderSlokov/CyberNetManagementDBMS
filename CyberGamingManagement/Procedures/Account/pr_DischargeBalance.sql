CREATE PROCEDURE pr_DischargeBalance @ammount int , @id int
AS
UPDATE account SET balance = account.balance - @ammount WHERE id = @id


/*
Tao procedure tinh so du balance, truyen 2 tham so @ammount & @id
Ket qua se cap nhat balance, bang cach tru balance hien co voi @ammount truyen vao
Voi id trung voi @id truyen vao.
*/