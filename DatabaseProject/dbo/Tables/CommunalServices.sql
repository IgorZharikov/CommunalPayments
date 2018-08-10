CREATE TABLE [dbo].[CommunalServices] (
    [Id]    INT           IDENTITY (1, 1) NOT NULL,
    [Name]  VARCHAR (500) NOT NULL,
    [OrgId] INT           NOT NULL,
    [Price] FLOAT (53)    CONSTRAINT [DF_CommunalServices_Rate] DEFAULT ((0)) NOT NULL,
    [Units] VARCHAR (50)  CONSTRAINT [DF_CommunalServices_Units] DEFAULT ('') NOT NULL,
    [Rate]  FLOAT (53)    CONSTRAINT [DF_CommunalServices_Factor] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_CommunalServices] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_CommunalServices_Organizations] FOREIGN KEY ([OrgId]) REFERENCES [dbo].[Organizations] ([Id])
);

