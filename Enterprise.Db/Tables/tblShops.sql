CREATE TABLE [dbo].[tblShops] (
    [shopId]   INT          IDENTITY (1, 1) NOT NULL PRIMARY KEY CLUSTERED ([shopId] ASC),
    [shopName] VARCHAR (50) NOT NULL,
    [primaryAddressId] int NOT NULL,
    CONSTRAINT [FK_tblShops_ToAddress] FOREIGN KEY ([primaryAddressId]) REFERENCES [dbo].[tblAddresses] ([addressId])
);