

/* Drop Tables */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[employee]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [employee]
GO

/* Create Tables */

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

/* Create Primary Keys, Indexes, Uniques, Checks */

ALTER TABLE [employee] 
 ADD CONSTRAINT [PK_employee]
	PRIMARY KEY CLUSTERED ([id] ASC)
GO

ALTER TABLE [employee] 
 ADD CONSTRAINT [U_employee] UNIQUE NONCLUSTERED ([id] ASC,[username] ASC)
GO