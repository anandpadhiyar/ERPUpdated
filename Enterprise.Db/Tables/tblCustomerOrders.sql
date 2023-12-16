CREATE TABLE [dbo].[tblCustomerOrders]
(
  [customerOrderId] INT IDENTITY (1, 1) NOT NULL PRIMARY KEY CLUSTERED ([customerOrderId] ASC),
  [orderDate] DATETIME NOT NULL,
  [orderAmount] MONEY NOT NULL,
  [customerId] INT NOT NULL,
  CONSTRAINT [FK_tblCustomerOrders_ToCustomer] FOREIGN KEY ([customerId]) REFERENCES [dbo].[tblCustomer] ([customerId])
)