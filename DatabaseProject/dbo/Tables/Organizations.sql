CREATE TABLE [dbo].[Organizations] (
    [Id]                    INT           IDENTITY (1, 1) NOT NULL,
    [Name]                  VARCHAR (500) NOT NULL,
    [Details]               VARCHAR (500) CONSTRAINT [DF_Organizations_Details] DEFAULT ('') NOT NULL,
    [PersonalAccountNumber] VARCHAR (50)  CONSTRAINT [DF_Organizations_PersonalAccountNumber] DEFAULT ('') NOT NULL,
    CONSTRAINT [PK_Organizations] PRIMARY KEY CLUSTERED ([Id] ASC)
);

