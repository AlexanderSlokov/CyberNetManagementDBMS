

/* Drop Foreign Key Constraints */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_computer_computer_room]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [computer] DROP CONSTRAINT [FK_computer_computer_room]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_order_list_account]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [order_list] DROP CONSTRAINT [FK_order_list_account]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_order_list_service]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [order_list] DROP CONSTRAINT [FK_order_list_service]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Recharge_account]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [recharge] DROP CONSTRAINT [FK_Recharge_account]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_salary_employee]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [salary] DROP CONSTRAINT [FK_salary_employee]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Salary_schedule]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [salary] DROP CONSTRAINT [FK_Salary_schedule]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_schedule_employee]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [schedule] DROP CONSTRAINT [FK_schedule_employee]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_shift_computer_room]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [schedule] DROP CONSTRAINT [FK_shift_computer_room]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_computer]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [user_using_computer] DROP CONSTRAINT [FK_computer]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_user_using_computer_account]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [user_using_computer] DROP CONSTRAINT [FK_user_using_computer_account]
GO

/* Drop Tables */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[account]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [account]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[computer]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [computer]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[computer_room]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [computer_room]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[employee]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [employee]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[order_list]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [order_list]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[recharge]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [recharge]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[salary]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [salary]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[schedule]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [schedule]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[service]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [service]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[user_using_computer]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [user_using_computer]
GO

/* Create Tables */

CREATE TABLE [account]
(
	[id] int NOT NULL IDENTITY (1, 1),
	[name] nvarchar(50) NOT NULL,
	[gender] nvarchar(50) NOT NULL,
	[phone] nvarchar(50) NOT NULL,
	[balance] float NULL,
	[email] nvarchar(50) NOT NULL,
	[username] nvarchar(50) NOT NULL,
	[password] nvarchar(50) NOT NULL,
	[role] nvarchar(50) NULL
)
GO

CREATE TABLE [computer]
(
	[id] int NOT NULL IDENTITY (1, 1),
	[info] nvarchar(max) NULL,
	[roomID] int NOT NULL,
	[status] nvarchar(50) NOT NULL,
	[fee_per_hour] real NOT NULL,
	[macAddress] nvarchar(50) NULL
)
GO

CREATE TABLE [computer_room]
(
	[id] int NOT NULL,
	[floor] int NOT NULL,
	[compNum] int NOT NULL,
	[max_comp_num] int NOT NULL
)
GO

CREATE TABLE [employee]
(
	[id] int NOT NULL,
	[name] nvarchar(50) NOT NULL,
	[position] nvarchar(50) NOT NULL,
	[birthDate] datetime NOT NULL,
	[gender] nvarchar(50) NOT NULL,
	[phoneNum] nvarchar(50) NOT NULL,
	[email] nvarchar(50) NOT NULL,
	[image] image NULL,
	[salary_per_hour] real NOT NULL,
	[username] nvarchar(50) NOT NULL,
	[password] nvarchar(50) NOT NULL
)
GO

CREATE TABLE [order_list]
(
	[service_id] int NOT NULL,
	[account_id] int NOT NULL,
	[quantity] int NOT NULL
)
GO

CREATE TABLE [recharge]
(
	[account_id] int NOT NULL,
	[amount] real NOT NULL,
	[id] int NOT NULL IDENTITY (1, 1)
)
GO

CREATE TABLE [salary]
(
	[check_in] datetime NOT NULL,
	[startTime] time(7) NULL,
	[employee_id] int NOT NULL,
	[roomID] int NULL,
	[endTime] time(7) NULL,
	[weeKDate] nvarchar(50) NULL
)
GO

CREATE TABLE [schedule]
(
	[employee_id] int NOT NULL,
	[roomID] int NOT NULL,
	[startTime] time(7) NOT NULL,
	[weekDate] nvarchar(50) NOT NULL,
	[shift_type] nvarchar(50) NOT NULL,
	[endTime] time(7) NOT NULL
)
GO

CREATE TABLE [service]
(
	[id] int NOT NULL,
	[name] nvarchar(50) NOT NULL,
	[description] nvarchar(50) NULL,
	[price] real NOT NULL,
	[picture] image NULL
)
GO

CREATE TABLE [user_using_computer]
(
	[computer_id] int NOT NULL,
	[user_id] int NOT NULL,
	[starting_time] datetime NOT NULL
)
GO

/* Create Primary Keys, Indexes, Uniques, Checks */

ALTER TABLE [account] 
 ADD CONSTRAINT [PK_account]
	PRIMARY KEY CLUSTERED ([id] ASC)
GO

ALTER TABLE [account] 
 ADD CONSTRAINT [U_account] UNIQUE NONCLUSTERED ([username] ASC,[id] ASC)
GO

ALTER TABLE [computer] 
 ADD CONSTRAINT [PK_computer]
	PRIMARY KEY CLUSTERED ([id] ASC)
GO

ALTER TABLE [computer] 
 ADD CONSTRAINT [U_computer] UNIQUE CLUSTERED ([macAddress] ASC)
GO

CREATE TRIGGER tr_computer_ForDelete
ON computer
FOR Delete
AS
BEGIN

	Declare @roomID int
	Select @roomID = roomID from deleted

	UPDATE computer_room set compNum = compNum - 1 
	WHERE @roomID = computer_room.id
END
GO

CREATE TRIGGER tr_computer_ForInsert
ON computer
FOR INSERT
AS
BEGIN

	Declare @roomID int
	Select @roomID = roomID from inserted

	UPDATE computer_room set compNum = compNum + 1 
	WHERE @roomID = computer_room.id
END
GO

ALTER TABLE [computer_room] 
 ADD CONSTRAINT [PK_computer_room]
	PRIMARY KEY CLUSTERED ([id] ASC)
GO

ALTER TABLE [computer_room] 
 ADD CONSTRAINT [U_computer_room] UNIQUE CLUSTERED ([id] ASC)
GO

ALTER TABLE [employee] 
 ADD CONSTRAINT [PK_employee]
	PRIMARY KEY CLUSTERED ([id] ASC)
GO

ALTER TABLE [employee] 
 ADD CONSTRAINT [U_employee] UNIQUE NONCLUSTERED ([id] ASC,[username] ASC)
GO

ALTER TABLE [order_list] 
 ADD CONSTRAINT [PK_order]
	PRIMARY KEY CLUSTERED ([service_id] ASC,[account_id] ASC)
GO

ALTER TABLE [recharge] 
 ADD CONSTRAINT [PK_recharge]
	PRIMARY KEY CLUSTERED ([id] ASC)
GO

ALTER TABLE [salary] 
 ADD CONSTRAINT [PK_Salary]
	PRIMARY KEY CLUSTERED ([check_in] ASC,[employee_id] ASC)
GO

ALTER TABLE [schedule] 
 ADD CONSTRAINT [PK_working_schedule]
	PRIMARY KEY CLUSTERED ([startTime] ASC,[employee_id] ASC,[roomID] ASC,[endTime] ASC,[weekDate] ASC)
GO

ALTER TABLE [service] 
 ADD CONSTRAINT [PK_service]
	PRIMARY KEY CLUSTERED ([id] ASC)
GO

ALTER TABLE [user_using_computer] 
 ADD CONSTRAINT [PK_user_using_computer]
	PRIMARY KEY CLUSTERED ([user_id] ASC,[computer_id] ASC)
GO

/* Create Foreign Key Constraints */

ALTER TABLE [computer] ADD CONSTRAINT [FK_computer_computer_room]
	FOREIGN KEY ([roomID]) REFERENCES [computer_room] ([id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [order_list] ADD CONSTRAINT [FK_order_list_account]
	FOREIGN KEY ([account_id]) REFERENCES [account] ([id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [order_list] ADD CONSTRAINT [FK_order_list_service]
	FOREIGN KEY ([service_id]) REFERENCES [service] ([id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [recharge] ADD CONSTRAINT [FK_Recharge_account]
	FOREIGN KEY ([account_id]) REFERENCES [account] ([id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [salary] ADD CONSTRAINT [FK_salary_employee]
	FOREIGN KEY ([employee_id]) REFERENCES [employee] ([id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [salary] ADD CONSTRAINT [FK_Salary_schedule]
	FOREIGN KEY ([startTime],[employee_id],[roomID],[endTime],[weeKDate]) REFERENCES [schedule] ([startTime],[employee_id],[roomID],[endTime],[weekDate]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [schedule] ADD CONSTRAINT [FK_schedule_employee]
	FOREIGN KEY ([employee_id]) REFERENCES [employee] ([id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [schedule] ADD CONSTRAINT [FK_shift_computer_room]
	FOREIGN KEY ([roomID]) REFERENCES [computer_room] ([id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [user_using_computer] ADD CONSTRAINT [FK_computer]
	FOREIGN KEY ([computer_id]) REFERENCES [computer] ([id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [user_using_computer] ADD CONSTRAINT [FK_user_using_computer_account]
	FOREIGN KEY ([user_id]) REFERENCES [account] ([id]) ON DELETE No Action ON UPDATE No Action
GO
