CREATE TABLE [dbo].[account] (
    [id]       INT  IDENTITY(1,1)   NOT NULL,
    [name]     NCHAR (50)    NOT NULL,
    [gender]   NCHAR (50)    NOT NULL,
    [phone]    NVARCHAR (50) NOT NULL,
	[balance]  FLOAT NULL,
    [email]    NVARCHAR (50) NOT NULL,
    [username] NVARCHAR (50) NOT NULL,
    [password] NVARCHAR (50) NOT NULL,
	[role]     NCHAR (50)    NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);


