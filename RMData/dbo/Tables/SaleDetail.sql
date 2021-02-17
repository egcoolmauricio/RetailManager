CREATE TABLE [dbo].[SaleDetail]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [SaleId] INT NOT NULL, 
    [ProductId] INT NOT NULL, 
    [Quantity] INT NOT NULL DEFAULT 1,
    [Price] DECIMAL(18, 2) NOT NULL, 
    [Tax] DECIMAL(18, 2) NOT NULL DEFAULT 0
)
