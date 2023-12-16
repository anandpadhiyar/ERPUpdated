CREATE TABLE [dbo].[tblOrderItems]
(
  [orderItemId] INT IDENTITY (1, 1) NOT NULL PRIMARY KEY CLUSTERED ([orderItemId] ASC),
  [productId] INT NOT NULL,
  [quantity] INT NOT NULL,
  CONSTRAINT [FK_tblOrderItems_ToProduct] FOREIGN KEY ([productId]) REFERENCES [dbo].[tblProducts] ([productId])
)
