CREATE TABLE [dbo].[tblShopProducts] (
    [shopProductId] INT IDENTITY (1, 1) NOT NULL PRIMARY KEY CLUSTERED ([shopProductId] ASC),
    [shopId]        INT NOT NULL,
    CONSTRAINT [FK_tblShopProducts_ToShops] FOREIGN KEY ([shopId]) REFERENCES [dbo].[tblShops] ([shopId])
);

--docker run -d --name sql_server -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=anand@123' -p 1433:1433 mcr.microsoft.com/mssql/server:2022-latest 