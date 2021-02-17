CREATE TABLE [dbo].[Inventory]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProductId] INT NOT NULL, 
    [Quantity] INT NOT NULL DEFAULT 1, 
    [Price] DECIMAL(18, 2) NOT NULL, 
    [PurchaseDate] DATETIME2 NOT NULL DEFAULT getutcdate()
)
