CREATE PROCEDURE pr_isLogin @computer_id int ,@user_id int
AS
SELECT * FROM user_using_computer WHERE computer_id = @computer_id AND user_id = @user_id