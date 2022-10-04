

/* Drop Tables */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[computer_room]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [computer_room]
GO

/* Create Tables */

CREATE TABLE [computer_room]
(
	[id] int NOT NULL,
	[floor] int NOT NULL,
	[compNum] int NOT NULL,
	[max_comp_num] int NOT NULL
)
GO

/* Create Primary Keys, Indexes, Uniques, Checks */

ALTER TABLE [computer_room] 
 ADD CONSTRAINT [PK_computer_room]
	PRIMARY KEY CLUSTERED ([id] ASC)
GO

ALTER TABLE [computer_room] 
 ADD CONSTRAINT [U_computer_room] UNIQUE CLUSTERED ([id] ASC)
GO