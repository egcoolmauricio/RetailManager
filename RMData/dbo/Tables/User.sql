CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(250) NOT NULL, 
    [LastName] NVARCHAR(250) NOT NULL, 
    [EmailAddress] NVARCHAR(256) NOT NULL, 
    [CreatedDate] DATETIME2 NOT NULL DEFAULT getutcdate()

)
