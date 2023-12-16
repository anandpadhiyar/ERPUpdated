CREATE TABLE [dbo].[tblAddresses]
(
  [addressId] int IDENTITY (1, 1) NOT NULL PRIMARY KEY CLUSTERED ([addressId] ASC),
  [line1] VARCHAR(50) NOT NULL,
  [line2] VARCHAR(50) NULL,
  [city] VARCHAR(50) NOT NULL,
  [zipcode] VARCHAR(6) NOT NULL,
  [stateId] UNIQUEIDENTIFIER NOT NULL,
  CONSTRAINT [FK_tblAddresses_ToState] FOREIGN KEY ([stateId]) REFERENCES [dbo].[tblStates] ([stateId])
)