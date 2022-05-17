/* ---------------------------------------------------- */
/*  Generated by Enterprise Architect Version 15.2 		*/
/*  Created On : 17-May-2022 10:13:08 AM 				*/
/*  DBMS       : SQL Server 2012 						*/
/* ---------------------------------------------------- */

/* Drop Tables */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[service]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [service]
GO

/* Create Tables */

CREATE TABLE [service]
(
	[id] int NOT NULL,
	[name] nvarchar(50) NOT NULL,
	[description] nvarchar(50) NULL,
	[price] real NOT NULL,
	[picture] image NULL
)
GO

/* Create Primary Keys, Indexes, Uniques, Checks */

ALTER TABLE [service] 
 ADD CONSTRAINT [PK_service]
	PRIMARY KEY CLUSTERED ([id] ASC)
GO