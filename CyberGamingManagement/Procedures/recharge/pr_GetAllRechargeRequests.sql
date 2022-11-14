CREATE PROCEDURE pr_GetAllRechargeRequests
AS
SELECT a.id as ID, a.name as 'Full Name', a.balance as Balance, r.amount as Amount, r.id as 'Recharge ID'
FROM recharge as r INNER JOIN account as a ON r.account_id = a.id

/*
Tao procedure 
Ket qua tra ve gom 5 cot Full Name,Balance,Amount,Recharge ID,ID
Bang cach ket noi 2 bang recharge & bang account
Bang cot ID
*/