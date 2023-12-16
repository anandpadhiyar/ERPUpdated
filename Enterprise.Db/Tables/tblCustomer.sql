CREATE TABLE [dbo].[tblCustomer]
(
  [customerId] INT IDENTITY (1, 1) NOT NULL PRIMARY KEY CLUSTERED ([customerId] ASC),
  [customerName] VARCHAR(50) NOT NULL,
  [addressId] INT NOT NULL,
  [shopId] INT NOT NULL,
  CONSTRAINT [FK_tblCustomer_ToAddress] FOREIGN KEY ([addressId]) REFERENCES [dbo].[tblAddresses] ([addressId]),
  CONSTRAINT [FK_tblCustomer_ToShop] FOREIGN KEY ([shopId]) REFERENCES [dbo].[tblShops] ([shopId])
)