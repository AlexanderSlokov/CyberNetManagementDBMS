

/* Drop Foreign Key Constraints */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_computer]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [user_using_computer] DROP CONSTRAINT [FK_computer]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_user_using_computer_account]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [user_using_computer] DROP CONSTRAINT [FK_user_using_computer_account]
GO

/* Drop Tables */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[user_using_computer]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [user_using_computer]
GO

/* Create Tables */

CREATE TABLE [user_using_computer]
(
	[computer_id] int NOT NULL,
	[user_id] int NOT NULL,
	[starting_time] datetime NOT NULL
)
GO

/* Create Primary Keys, Indexes, Uniques, Checks */

ALTER TABLE [user_using_computer] 
 ADD CONSTRAINT [PK_user_using_computer]
	PRIMARY KEY CLUSTERED ([user_id] ASC,[computer_id] ASC)
GO

/* Create Foreign Key Constraints */

ALTER TABLE [user_using_computer] ADD CONSTRAINT [FK_computer]
	FOREIGN KEY ([computer_id]) REFERENCES [computer] ([id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [user_using_computer] ADD CONSTRAINT [FK_user_using_computer_account]
	FOREIGN KEY ([user_id]) REFERENCES [account] ([id]) ON DELETE No Action ON UPDATE No Action
GO