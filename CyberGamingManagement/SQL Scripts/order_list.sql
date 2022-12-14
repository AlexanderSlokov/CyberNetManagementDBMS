

/* Drop Foreign Key Constraints */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_order_list_account]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [order_list] DROP CONSTRAINT [FK_order_list_account]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_order_list_service]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [order_list] DROP CONSTRAINT [FK_order_list_service]
GO

/* Drop Tables */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[order_list]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [order_list]
GO

/* Create Tables */

CREATE TABLE [order_list]
(
	[service_id] int NOT NULL,
	[account_id] int NOT NULL,
	[quantity] int NOT NULL
)
GO

/* Create Primary Keys, Indexes, Uniques, Checks */

ALTER TABLE [order_list] 
 ADD CONSTRAINT [PK_order]
	PRIMARY KEY CLUSTERED ([service_id] ASC,[account_id] ASC)
GO

/* Create Foreign Key Constraints */

ALTER TABLE [order_list] ADD CONSTRAINT [FK_order_list_account]
	FOREIGN KEY ([account_id]) REFERENCES [account] ([id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [order_list] ADD CONSTRAINT [FK_order_list_service]
	FOREIGN KEY ([service_id]) REFERENCES [service] ([id]) ON DELETE No Action ON UPDATE No Action
GO