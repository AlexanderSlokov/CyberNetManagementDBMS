CREATE PROCEDURE pr_isLogin @computer_id int ,@user_id int
AS
SELECT * FROM user_using_computer WHERE computer_id = @computer_id AND user_id = @user_id

/*
Tao mot PROCEDURE de tim thoi gian bat dau su dung computer
In ra mot hang trong bang user_using_computer co computer_id va @user_id do nguoi dung nhap vao
*/