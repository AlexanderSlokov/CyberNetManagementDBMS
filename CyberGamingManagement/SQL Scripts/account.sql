

/* Drop Tables */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[account]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [account]
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

/* Create Primary Keys, Indexes, Uniques, Checks */

ALTER TABLE [account] 
 ADD CONSTRAINT [PK_account]
	PRIMARY KEY CLUSTERED ([id] ASC)
GO

ALTER TABLE [account] 
 ADD CONSTRAINT [U_account] UNIQUE NONCLUSTERED ([username] ASC,[id] ASC)
GO