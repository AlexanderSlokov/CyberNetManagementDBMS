CREATE PROCEDURE pr_InsertService @id int, @name nvarchar(50), @description nvarchar(50),
@price real, @picture image
AS
	INSERT INTO service (id, name, description, price, picture) VALUES
	(@id, @name, @description, @price, @picture)