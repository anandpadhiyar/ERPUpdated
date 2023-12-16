CREATE TABLE [dbo].[tblProductPrices]
(
  [productPriceVersionId] INT IDENTITY (1, 1) NOT NULL PRIMARY KEY CLUSTERED ([productPriceVersionId] ASC),
  [startedOn] DATETIME NOT NULL,
  [endOn] DATETIME NULL,
  [flagLatest] BIT NOT NULL
)
