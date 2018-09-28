CREATE TABLE [dbo].[MeasurementDeviceTypes] (
    [Id]      INT           IDENTITY (1, 1) NOT NULL,
    [Name]    VARCHAR (100) NOT NULL,
    [Options] VARCHAR (100) DEFAULT ('') NOT NULL,
    CONSTRAINT [PK_MeasurementDeviceTypes] PRIMARY KEY CLUSTERED ([Id] ASC)
);

