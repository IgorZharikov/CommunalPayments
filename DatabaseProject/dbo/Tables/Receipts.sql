CREATE TABLE [dbo].[Receipts] (
    [Id]            INT        IDENTITY (1, 1) NOT NULL,
    [PayerId]       INT        NOT NULL,
    [OperationDate] DATETIME   NOT NULL,
    [ServiceId]     INT        NOT NULL,
    [BillingDate]   DATETIME   NOT NULL,
    [BeginReadout]  FLOAT (53) NULL,
    [EndReadout]    FLOAT (53) NULL,
    [AdditionalFee] FLOAT (53) CONSTRAINT [DF_Table_1_AdditionalPayment] DEFAULT ((0)) NOT NULL,
    [Total]         FLOAT (53) NOT NULL,
    CONSTRAINT [PK_Receipts] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Receipts_CommunalServices] FOREIGN KEY ([ServiceId]) REFERENCES [dbo].[CommunalServices] ([Id]),
    CONSTRAINT [FK_Receipts_Payers] FOREIGN KEY ([PayerId]) REFERENCES [dbo].[Payers] ([Id])
);

