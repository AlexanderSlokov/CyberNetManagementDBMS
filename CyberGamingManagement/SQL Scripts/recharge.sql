

/* Drop Foreign Key Constraints */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Recharge_account]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [recharge] DROP CONSTRAINT [FK_Recharge_account]
GO

/* Drop Tables */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[recharge]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [recharge]
GO

/* Create Tables */

CREATE TABLE [recharge]
(
	[account_id] int NOT NULL,
	[amount] real NOT NULL,
	[id] int NOT NULL IDENTITY (1, 1)
)
GO

/* Create Primary Keys, Indexes, Uniques, Checks */

ALTER TABLE [recharge] 
 ADD CONSTRAINT [PK_recharge]
	PRIMARY KEY CLUSTERED ([id] ASC)
GO

/* Create Foreign Key Constraints */

ALTER TABLE [recharge] ADD CONSTRAINT [FK_Recharge_account]
	FOREIGN KEY ([account_id]) REFERENCES [account] ([id]) ON DELETE No Action ON UPDATE No Action
GO