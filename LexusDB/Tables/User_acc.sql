CREATE TABLE [dbo].[User_Acc] (
    [ID]       INT          IDENTITY (1, 1) NOT NULL,
    [Username] VARCHAR (15) NOT NULL,
    [Password] VARCHAR (20) NOT NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([ID] ASC),
    UNIQUE NONCLUSTERED ([Username] ASC)
);

