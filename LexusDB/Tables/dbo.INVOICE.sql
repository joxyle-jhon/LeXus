CREATE TABLE [dbo].[INVOICE] (
    [InvoiceID]     INT             IDENTITY (1, 1) NOT NULL,
    [PropertyID]    INT             NOT NULL,
    [DatePaid]      DATE            NULL,
    [DueDate]       DATE            NULL,
    [TotalAmount]   DECIMAL (10, 2) NULL,
    [PaymentStatus] VARCHAR (50)    NULL,
    [PaymentType]   VARCHAR (50)    NULL,
    [InvoiceDate]   DATETIME        DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([InvoiceID] ASC),
    FOREIGN KEY ([PropertyID]) REFERENCES [dbo].[PROPERTY] ([PropertyID])
);

