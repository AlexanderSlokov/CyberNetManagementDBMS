CREATE PROCEDURE pr_isServiceExsists @id int
AS
SELECT * FROM service WHERE id = @id