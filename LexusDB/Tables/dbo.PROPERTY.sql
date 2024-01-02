CREATE TABLE [dbo].[PROPERTY] (
    [PropertyID]      INT           IDENTITY (1, 1) NOT NULL,
    [RoomNumber]      INT           NULL,
    [PropertyName]    VARCHAR (50)  NULL,
    [PropertyAddress] VARCHAR (100) NULL,
    [WBillingNumber]  VARCHAR (50)  NULL,
    [EBillingNumber]  VARCHAR (50)  NULL,
    [OccupancyStatus] VARCHAR (50)  NULL,
    [LandlordID]      INT           NULL,
    [LeaseID]         INT           NULL,
    [AgreementID]     INT           NULL,
    PRIMARY KEY CLUSTERED ([PropertyID] ASC),
    FOREIGN KEY ([LandlordID]) REFERENCES [dbo].[LANDLORD] ([LandlordID]),
    FOREIGN KEY ([LeaseID]) REFERENCES [dbo].[USERINFO] ([LeaseID]),
    FOREIGN KEY ([AgreementID]) REFERENCES [dbo].[AGREEMENT] ([AgreementID])
);

