

/* Drop Tables */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[salary]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [salary]
GO

/* Create Tables */

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

/* Create Primary Keys, Indexes, Uniques, Checks */

ALTER TABLE [salary] 
 ADD CONSTRAINT [PK_Salary]
	PRIMARY KEY CLUSTERED ([check_in] ASC,[employee_id] ASC)
GO