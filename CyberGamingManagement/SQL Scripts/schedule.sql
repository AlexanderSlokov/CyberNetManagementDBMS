

/* Drop Foreign Key Constraints */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_schedule_employee]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [schedule] DROP CONSTRAINT [FK_schedule_employee]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_shift_computer_room]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [schedule] DROP CONSTRAINT [FK_shift_computer_room]
GO

/* Drop Tables */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[schedule]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [schedule]
GO

/* Create Tables */

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

/* Create Primary Keys, Indexes, Uniques, Checks */

ALTER TABLE [schedule] 
 ADD CONSTRAINT [PK_working_schedule]
	PRIMARY KEY CLUSTERED ([startTime] ASC,[employee_id] ASC,[roomID] ASC,[endTime] ASC,[weekDate] ASC)
GO

/* Create Foreign Key Constraints */

ALTER TABLE [schedule] ADD CONSTRAINT [FK_schedule_employee]
	FOREIGN KEY ([employee_id]) REFERENCES [employee] ([id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [schedule] ADD CONSTRAINT [FK_shift_computer_room]
	FOREIGN KEY ([roomID]) REFERENCES [computer_room] ([id]) ON DELETE No Action ON UPDATE No Action
GO