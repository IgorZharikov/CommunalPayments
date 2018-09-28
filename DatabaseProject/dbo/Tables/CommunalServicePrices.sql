CREATE TABLE [dbo].[CommunalServicePrices] (
    [Id]        INT          IDENTITY (1, 1) NOT NULL,
    [ServiceId] INT          NOT NULL,
    [OrgId]     INT          NOT NULL,
    [Price]     FLOAT (53)   CONSTRAINT [DF_CommunalServicePrices_Price] DEFAULT ((0)) NOT NULL,
    [Units]     VARCHAR (50) CONSTRAINT [DF_CommunalServicePrices_Units] DEFAULT ('') NOT NULL,
    [BeginDate] DATETIME     NOT NULL,
    [EndDate]   DATETIME     NULL,
    CONSTRAINT [PK_CommunalServicePrices] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_CommunalServicePrices_CommunalServices] FOREIGN KEY ([ServiceId]) REFERENCES [dbo].[CommunalServices] ([Id]),
    CONSTRAINT [FK_CommunalServicePrices_Organizations] FOREIGN KEY ([OrgId]) REFERENCES [dbo].[Organizations] ([Id])
);

