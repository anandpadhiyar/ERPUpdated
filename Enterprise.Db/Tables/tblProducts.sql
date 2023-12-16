CREATE TABLE [dbo].[tblProducts]
(
  [productId] INT IDENTITY (1, 1) NOT NULL PRIMARY KEY CLUSTERED ([productId] ASC),
  [productName] VARCHAR(50) NOT NULL,
  [shopId] INT NOT NULL,
  CONSTRAINT [FK_tblProducts_ToShop] FOREIGN KEY ([shopId]) REFERENCES [dbo].[tblShops] ([shopId])
)
