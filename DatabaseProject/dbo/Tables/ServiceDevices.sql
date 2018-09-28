CREATE TABLE [dbo].[ServiceDevices] (
    [Id]           INT NOT NULL,
    [ServiceId]    INT NOT NULL,
    [DeviceTypeId] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ServiceDevices_CommunalServices] FOREIGN KEY ([ServiceId]) REFERENCES [dbo].[CommunalServices] ([Id]),
    CONSTRAINT [FK_ServiceDevices_MeasurementDeviceTypes] FOREIGN KEY ([DeviceTypeId]) REFERENCES [dbo].[MeasurementDeviceTypes] ([Id])
);

