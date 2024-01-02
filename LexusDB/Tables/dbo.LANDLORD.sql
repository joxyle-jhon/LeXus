CREATE TABLE [dbo].[LANDLORD] (
    [LandlordID] INT          IDENTITY (1, 1) NOT NULL,
    [Firstname]  VARCHAR (50) NULL,
    [Middlename] VARCHAR (50) NULL,
    [Lastname]   VARCHAR (50) NULL,
    [ContactNo]  VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([LandlordID] ASC)
);

