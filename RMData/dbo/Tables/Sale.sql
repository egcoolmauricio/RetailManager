﻿CREATE TABLE [dbo].[Sale]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CashierId] NVARCHAR(128) NOT NULL, 
    [SaleDate] DATETIME2 NOT NULL, 
    [SubTotal] DECIMAL(18, 2) NOT NULL, 
    [Tax] DECIMAL(18, 2) NOT NULL, 
    [Total] DECIMAL(18, 2) NOT NULL
)
