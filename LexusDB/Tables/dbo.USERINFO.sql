CREATE TABLE [dbo].[USERINFO] (
    [LeaseID]      INT          IDENTITY (1, 1) NOT NULL,
    [FirstName]    VARCHAR (15) NULL,
    [LastNamee]    VARCHAR (15) NULL,
    [MiddleIN]     VARCHAR (10) NULL,
    [Age]          INT          NULL,
    [Sex]          VARCHAR (7)  NULL,
    [Birthday]     VARCHAR (15) NULL,
    [PhoneNumber]  VARCHAR (15) NULL,
    [ValidIDType]  VARCHAR (20) NULL,
    [IDNumber]     VARCHAR (30) NULL,
    [Occupation]   VARCHAR (20) NULL,
    [CreationTime] DATETIME     DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_USERINFO] PRIMARY KEY CLUSTERED ([LeaseID] ASC)
);

