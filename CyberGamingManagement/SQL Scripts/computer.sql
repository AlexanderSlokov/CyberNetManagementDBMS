

/* Drop Foreign Key Constraints */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_computer_computer_room]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [computer] DROP CONSTRAINT [FK_computer_computer_room]
GO

/* Drop Tables */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[computer]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [computer]
GO

/* Create Tables */

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

/* Create Primary Keys, Indexes, Uniques, Checks */

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

/* Create Foreign Key Constraints */

ALTER TABLE [computer] ADD CONSTRAINT [FK_computer_computer_room]
	FOREIGN KEY ([roomID]) REFERENCES [computer_room] ([id]) ON DELETE No Action ON UPDATE No Action
GO