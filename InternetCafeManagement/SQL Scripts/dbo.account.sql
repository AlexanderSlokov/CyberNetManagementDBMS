CREATE TABLE [dbo].[account] (
    [id]       INT           NOT NULL,
    [name]     NCHAR (50)    NULL,
    [gender]   NCHAR (50)    NULL,
    [phone]    NVARCHAR (50) NULL,
	[balance]  FLOAT NULL,
    [email]    NVARCHAR (50) NULL,
    [username] NVARCHAR (50) NULL,
    [password] NVARCHAR (50) NULL,
	[role]     NCHAR (50)    NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);


