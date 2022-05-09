CREATE TABLE [dbo].[computer]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [info] NVARCHAR(MAX) NULL, 
    [roomID] INT NOT NULL, 
    [status] NVARCHAR(50) NOT NULL, 
    [fee_per_hour] REAL NOT NULL
)
