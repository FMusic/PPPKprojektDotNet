
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/13/2020 12:59:03
-- Generated from EDMX file: C:\Users\frane\source\repos\PPPKprojektDotNet\Datebase\I7\PPPKModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [pppk1db];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__CarServic__Vehic__2F10007B]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CarService] DROP CONSTRAINT [FK__CarServic__Vehic__2F10007B];
GO
IF OBJECT_ID(N'[dbo].[FK__Fuels__DriverId__34C8D9D1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Fuels] DROP CONSTRAINT [FK__Fuels__DriverId__34C8D9D1];
GO
IF OBJECT_ID(N'[dbo].[FK__Fuels__VehicleID__35BCFE0A]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Fuels] DROP CONSTRAINT [FK__Fuels__VehicleID__35BCFE0A];
GO
IF OBJECT_ID(N'[dbo].[FK__Routes__WarrantI__31EC6D26]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Routes] DROP CONSTRAINT [FK__Routes__WarrantI__31EC6D26];
GO
IF OBJECT_ID(N'[dbo].[FK__ServiceIt__CarSe__38996AB5]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ServiceItems] DROP CONSTRAINT [FK__ServiceIt__CarSe__38996AB5];
GO
IF OBJECT_ID(N'[dbo].[FK__travelWar__Drive__2A4B4B5E]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[travelWarrants] DROP CONSTRAINT [FK__travelWar__Drive__2A4B4B5E];
GO
IF OBJECT_ID(N'[dbo].[FK__travelWar__Vehic__2B3F6F97]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[travelWarrants] DROP CONSTRAINT [FK__travelWar__Vehic__2B3F6F97];
GO
IF OBJECT_ID(N'[dbo].[FK__travelWar__Warra__2C3393D0]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[travelWarrants] DROP CONSTRAINT [FK__travelWar__Warra__2C3393D0];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CarService]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CarService];
GO
IF OBJECT_ID(N'[dbo].[Drivers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Drivers];
GO
IF OBJECT_ID(N'[dbo].[Fuels]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Fuels];
GO
IF OBJECT_ID(N'[dbo].[Routes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Routes];
GO
IF OBJECT_ID(N'[dbo].[ServiceItems]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ServiceItems];
GO
IF OBJECT_ID(N'[dbo].[travelWarrants]', 'U') IS NOT NULL
    DROP TABLE [dbo].[travelWarrants];
GO
IF OBJECT_ID(N'[dbo].[Vehicles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Vehicles];
GO
IF OBJECT_ID(N'[dbo].[WarrantStateEnum]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WarrantStateEnum];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CarServices'
CREATE TABLE [dbo].[CarServices] (
    [IDService] int IDENTITY(1,1) NOT NULL,
    [VehicleID] int  NULL,
    [Date] datetime  NULL
);
GO

-- Creating table 'Vehicles'
CREATE TABLE [dbo].[Vehicles] (
    [IDVehicle] int IDENTITY(1,1) NOT NULL,
    [Type] nvarchar(10)  NULL,
    [Maker] nvarchar(10)  NULL,
    [YearOfMaking] int  NULL,
    [miles] int  NULL
);
GO

-- Creating table 'ServiceItems'
CREATE TABLE [dbo].[ServiceItems] (
    [IDItem] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(30)  NULL,
    [TotalPrice] decimal(19,4)  NULL,
    [CarServiceID] int  NULL
);
GO

-- Creating table 'Drivers'
CREATE TABLE [dbo].[Drivers] (
    [IDDriver] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(20)  NULL,
    [Surname] nvarchar(20)  NULL,
    [phoneNumber] nvarchar(20)  NULL,
    [driversLicenseID] nvarchar(30)  NULL
);
GO

-- Creating table 'Fuels'
CREATE TABLE [dbo].[Fuels] (
    [IDFuel] int IDENTITY(1,1) NOT NULL,
    [DriverId] int  NULL,
    [DateWhen] datetime  NULL,
    [TimeWhen] time  NULL,
    [Location] nvarchar(20)  NULL,
    [Quantity] int  NULL,
    [Price] int  NULL,
    [VehicleID] int  NULL
);
GO

-- Creating table 'Routes'
CREATE TABLE [dbo].[Routes] (
    [IDRoute] int IDENTITY(1,1) NOT NULL,
    [WarrantID] int  NULL,
    [DateFrom] datetime  NULL,
    [DateTo] datetime  NULL,
    [CoordA] nvarchar(20)  NULL,
    [CoordB] nvarchar(20)  NULL,
    [DistanceInKm] int  NULL,
    [AvgV] int  NULL,
    [FuelSpent] int  NULL
);
GO

-- Creating table 'travelWarrants'
CREATE TABLE [dbo].[travelWarrants] (
    [IDTwarrant] int IDENTITY(1,1) NOT NULL,
    [DriverID] int  NULL,
    [VehicleID] int  NULL,
    [WarrantStateEnumId] int  NULL
);
GO

-- Creating table 'WarrantStateEnums'
CREATE TABLE [dbo].[WarrantStateEnums] (
    [IDWarrantState] int IDENTITY(1,1) NOT NULL,
    [State] nvarchar(6)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IDService] in table 'CarServices'
ALTER TABLE [dbo].[CarServices]
ADD CONSTRAINT [PK_CarServices]
    PRIMARY KEY CLUSTERED ([IDService] ASC);
GO

-- Creating primary key on [IDVehicle] in table 'Vehicles'
ALTER TABLE [dbo].[Vehicles]
ADD CONSTRAINT [PK_Vehicles]
    PRIMARY KEY CLUSTERED ([IDVehicle] ASC);
GO

-- Creating primary key on [IDItem] in table 'ServiceItems'
ALTER TABLE [dbo].[ServiceItems]
ADD CONSTRAINT [PK_ServiceItems]
    PRIMARY KEY CLUSTERED ([IDItem] ASC);
GO

-- Creating primary key on [IDDriver] in table 'Drivers'
ALTER TABLE [dbo].[Drivers]
ADD CONSTRAINT [PK_Drivers]
    PRIMARY KEY CLUSTERED ([IDDriver] ASC);
GO

-- Creating primary key on [IDFuel] in table 'Fuels'
ALTER TABLE [dbo].[Fuels]
ADD CONSTRAINT [PK_Fuels]
    PRIMARY KEY CLUSTERED ([IDFuel] ASC);
GO

-- Creating primary key on [IDRoute] in table 'Routes'
ALTER TABLE [dbo].[Routes]
ADD CONSTRAINT [PK_Routes]
    PRIMARY KEY CLUSTERED ([IDRoute] ASC);
GO

-- Creating primary key on [IDTwarrant] in table 'travelWarrants'
ALTER TABLE [dbo].[travelWarrants]
ADD CONSTRAINT [PK_travelWarrants]
    PRIMARY KEY CLUSTERED ([IDTwarrant] ASC);
GO

-- Creating primary key on [IDWarrantState] in table 'WarrantStateEnums'
ALTER TABLE [dbo].[WarrantStateEnums]
ADD CONSTRAINT [PK_WarrantStateEnums]
    PRIMARY KEY CLUSTERED ([IDWarrantState] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [VehicleID] in table 'CarServices'
ALTER TABLE [dbo].[CarServices]
ADD CONSTRAINT [FK__CarServic__Vehic__2F10007B]
    FOREIGN KEY ([VehicleID])
    REFERENCES [dbo].[Vehicles]
        ([IDVehicle])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__CarServic__Vehic__2F10007B'
CREATE INDEX [IX_FK__CarServic__Vehic__2F10007B]
ON [dbo].[CarServices]
    ([VehicleID]);
GO

-- Creating foreign key on [CarServiceID] in table 'ServiceItems'
ALTER TABLE [dbo].[ServiceItems]
ADD CONSTRAINT [FK__ServiceIt__CarSe__38996AB5]
    FOREIGN KEY ([CarServiceID])
    REFERENCES [dbo].[CarServices]
        ([IDService])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__ServiceIt__CarSe__38996AB5'
CREATE INDEX [IX_FK__ServiceIt__CarSe__38996AB5]
ON [dbo].[ServiceItems]
    ([CarServiceID]);
GO

-- Creating foreign key on [DriverId] in table 'Fuels'
ALTER TABLE [dbo].[Fuels]
ADD CONSTRAINT [FK__Fuels__DriverId__34C8D9D1]
    FOREIGN KEY ([DriverId])
    REFERENCES [dbo].[Drivers]
        ([IDDriver])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Fuels__DriverId__34C8D9D1'
CREATE INDEX [IX_FK__Fuels__DriverId__34C8D9D1]
ON [dbo].[Fuels]
    ([DriverId]);
GO

-- Creating foreign key on [DriverID] in table 'travelWarrants'
ALTER TABLE [dbo].[travelWarrants]
ADD CONSTRAINT [FK__travelWar__Drive__2A4B4B5E]
    FOREIGN KEY ([DriverID])
    REFERENCES [dbo].[Drivers]
        ([IDDriver])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__travelWar__Drive__2A4B4B5E'
CREATE INDEX [IX_FK__travelWar__Drive__2A4B4B5E]
ON [dbo].[travelWarrants]
    ([DriverID]);
GO

-- Creating foreign key on [VehicleID] in table 'Fuels'
ALTER TABLE [dbo].[Fuels]
ADD CONSTRAINT [FK__Fuels__VehicleID__35BCFE0A]
    FOREIGN KEY ([VehicleID])
    REFERENCES [dbo].[Vehicles]
        ([IDVehicle])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Fuels__VehicleID__35BCFE0A'
CREATE INDEX [IX_FK__Fuels__VehicleID__35BCFE0A]
ON [dbo].[Fuels]
    ([VehicleID]);
GO

-- Creating foreign key on [WarrantID] in table 'Routes'
ALTER TABLE [dbo].[Routes]
ADD CONSTRAINT [FK__Routes__WarrantI__31EC6D26]
    FOREIGN KEY ([WarrantID])
    REFERENCES [dbo].[travelWarrants]
        ([IDTwarrant])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Routes__WarrantI__31EC6D26'
CREATE INDEX [IX_FK__Routes__WarrantI__31EC6D26]
ON [dbo].[Routes]
    ([WarrantID]);
GO

-- Creating foreign key on [VehicleID] in table 'travelWarrants'
ALTER TABLE [dbo].[travelWarrants]
ADD CONSTRAINT [FK__travelWar__Vehic__2B3F6F97]
    FOREIGN KEY ([VehicleID])
    REFERENCES [dbo].[Vehicles]
        ([IDVehicle])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__travelWar__Vehic__2B3F6F97'
CREATE INDEX [IX_FK__travelWar__Vehic__2B3F6F97]
ON [dbo].[travelWarrants]
    ([VehicleID]);
GO

-- Creating foreign key on [WarrantStateEnumId] in table 'travelWarrants'
ALTER TABLE [dbo].[travelWarrants]
ADD CONSTRAINT [FK__travelWar__Warra__2C3393D0]
    FOREIGN KEY ([WarrantStateEnumId])
    REFERENCES [dbo].[WarrantStateEnums]
        ([IDWarrantState])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__travelWar__Warra__2C3393D0'
CREATE INDEX [IX_FK__travelWar__Warra__2C3393D0]
ON [dbo].[travelWarrants]
    ([WarrantStateEnumId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------