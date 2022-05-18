CREATE PROCEDURE pr_UpdateFeePerHour @fee float, @id int
AS
UPDATE computer SET fee_per_hour = @fee WHERE id = @id