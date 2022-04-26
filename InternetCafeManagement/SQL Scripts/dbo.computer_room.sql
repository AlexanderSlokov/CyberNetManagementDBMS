CREATE TABLE [dbo].[computer_room]
(
	[id] INT NOT NULL PRIMARY KEY, 
    [floor] INT NULL, 
    [compNum] INT NULL, 
    [status] NVARCHAR(50) NULL
)
