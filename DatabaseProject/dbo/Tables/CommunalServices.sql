CREATE TABLE [dbo].[CommunalServices] (
    [Id]      INT           IDENTITY (1, 1) NOT NULL,
    [Name]    VARCHAR (500) NOT NULL,
    [Options] VARCHAR (100) DEFAULT ('') NOT NULL,
    CONSTRAINT [PK_CommunalServices] PRIMARY KEY CLUSTERED ([Id] ASC)
);

