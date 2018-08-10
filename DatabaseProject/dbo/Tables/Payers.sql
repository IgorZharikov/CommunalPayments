CREATE TABLE [dbo].[Payers] (
    [Id]      INT           IDENTITY (1, 1) NOT NULL,
    [FIO]     VARCHAR (500) NOT NULL,
    [Address] VARCHAR (500) CONSTRAINT [DF_Payers_Address] DEFAULT ('') NOT NULL,
    CONSTRAINT [PK_Payers] PRIMARY KEY CLUSTERED ([Id] ASC)
);

