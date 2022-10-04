CREATE PROCEDURE pr_DeleteUsage @computer_id int
AS
DELETE FROM user_using_computer WHERE computer_id = @computer_id