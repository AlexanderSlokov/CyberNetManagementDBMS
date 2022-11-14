CREATE PROCEDURE pr_UpdateFeePerHour @fee real, @id int
AS
UPDATE computer SET fee_per_hour = @fee WHERE id = @id

/*
Tao procedure truyen vao 2 tham so @fee va @id
Ket qua se cap nhat lai fee_per_hour voi @fee truyen vao
Voi user co id trung voi @id truyen vao.
*/