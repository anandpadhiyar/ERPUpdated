CREATE TABLE [dbo].[tblStates] (
    [stateId]    UNIQUEIDENTIFIER NOT NULL PRIMARY KEY CLUSTERED ([stateId] ASC),
    [stateTitle] VARCHAR (50)     NOT NULL,
    [countryId]  UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [FK_tblStates_ToCountry] FOREIGN KEY ([countryId]) REFERENCES [dbo].[tblCountries] ([countryId])
);
