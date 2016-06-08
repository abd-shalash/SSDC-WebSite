CREATE TABLE [dbo].[Table]
(
	[Id] INT NULL PRIMARY KEY, 
    [Username] NCHAR(10) NOT NULL, 
    [Password] NCHAR(10) NOT NULL, 
    [Fname] NCHAR(10) NULL, 
    [Mname] NCHAR(10) NULL, 
    [Lname] NCHAR(10) NULL
)
