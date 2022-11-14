	CREATE PROCEDURE pr_login @User nvarchar(50), @Pass nvarchar(50)
	AS
	SELECT * FROM account WHERE username = @User AND password = @Pass

	/*
	Tao procedure login, truyen vao 2 tham so @User & @Pass
	Ket qua tra ve mot bang gom tat cac cac cot trong bang account
	Co @user va @pass trung voi user & pass trong bang account
	*/