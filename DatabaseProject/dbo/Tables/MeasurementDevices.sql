CREATE TABLE [dbo].[MeasurementDevices] (
    [Id]           INT        IDENTITY (1, 1) NOT NULL,
    [ReceiptId]    INT        NOT NULL,
    [DeviceTypeId] INT        NOT NULL,
    [InitialValue] FLOAT (53) DEFAULT ((0)) NOT NULL,
    [FinalValue]   FLOAT (53) DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_MeasurementDevices] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_MeasurementDevices_MeasurementDeviceTypes] FOREIGN KEY ([DeviceTypeId]) REFERENCES [dbo].[MeasurementDeviceTypes] ([Id]),
    CONSTRAINT [FK_MeasurementDevices_Receipts] FOREIGN KEY ([ReceiptId]) REFERENCES [dbo].[Receipts] ([Id])
);

