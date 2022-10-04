CREATE PROCEDURE pr_InsertUsage @computer_id int, @user_id int, @starting_time DateTime
AS
INSERT INTO user_using_computer (computer_id, user_id, starting_time)
VALUES (@computer_id, @user_id, @starting_time)