CREATE FUNCTION fun_salaryAllEmployees()
RETURNS @table TABLE(
	sumSalary real,
	id int,
	name nvarchar(50),
	birthDate DateTime,
	gender nvarchar(50),
	phoneNum nvarchar(50),
	email nvarchar(50)
)
AS
BEGIN
	INSERT INTO @table
	SELECT 
		[dbo].[fun_SumSalaryOfEmployee](employee.id) as 'Sum Salary',
		id as 'Employee ID',
		name as 'Employee Name',
		birthDate as 'Birth Date',
		gender 'Gender',
		phoneNum as 'Phone',
		email as 'Email'
	FROM
		dbo.employee
	WHERE position = 'employee'

	RETURN;
END;

/*
Tao function tra ve mot bang tong so luong cua tat ca nhan vien (employee)
Gom cac cot Salary ( duoc tinh bang function fun_SumSalaryOfEmployee )
Employee ID, Employee Name, Birth Date, Gender, Phone, Email.
*/