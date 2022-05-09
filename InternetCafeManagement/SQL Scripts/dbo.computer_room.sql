CREATE TABLE [dbo].[computer_room]
(
	[id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [floor] INT NOT NULL, 
    [compNum] INT NOT NULL, 
    [status] NVARCHAR(50) NOT NULL
)
