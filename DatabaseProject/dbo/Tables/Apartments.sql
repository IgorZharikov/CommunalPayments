CREATE TABLE [dbo].[Apartments] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Address]   VARCHAR (500) CONSTRAINT [DF_Payers_Address] DEFAULT ('') NOT NULL,
    [Square]    FLOAT (53)    CONSTRAINT [DF_Payers_Square] DEFAULT ((0)) NOT NULL,
    [Residents] INT           CONSTRAINT [DF_Payers_Residents] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Payers] PRIMARY KEY CLUSTERED ([Id] ASC)
);

