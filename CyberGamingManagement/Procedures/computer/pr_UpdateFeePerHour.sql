CREATE PROCEDURE pr_UpdateFeePerHour @fee real, @id int
AS
UPDATE computer SET fee_per_hour = @fee WHERE id = @id