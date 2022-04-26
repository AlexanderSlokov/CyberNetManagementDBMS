CREATE TABLE [dbo].[computer]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [info] NVARCHAR(MAX) NULL, 
    [roomID] INT NULL, 
    [status] NVARCHAR(50) NULL, 
    [fee_per_hour] REAL NULL
)
