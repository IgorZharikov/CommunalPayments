CREATE TABLE [dbo].[Receipts] (
    [Id]            INT        IDENTITY (1, 1) NOT NULL,
    [ApartmentId]   INT        NOT NULL,
    [OperationDate] DATETIME   NOT NULL,
    [ServiceId]     INT        NOT NULL,
    [BillingDate]   DATETIME   NOT NULL,
    [AdditionalFee] FLOAT (53) CONSTRAINT [DF_Table_1_AdditionalPayment] DEFAULT ((0)) NOT NULL,
    [Total]         FLOAT (53) NOT NULL,
    CONSTRAINT [PK_Receipts] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Receipts_Apartments] FOREIGN KEY ([ApartmentId]) REFERENCES [dbo].[Apartments] ([Id]),
    CONSTRAINT [FK_Receipts_CommunalServices] FOREIGN KEY ([ServiceId]) REFERENCES [dbo].[CommunalServices] ([Id])
);

