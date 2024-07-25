
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/25/2024 11:42:05
-- Generated from EDMX file: C:\Banu\Infinite\Batch_June24\EF\ModelFirst\ModelFirst\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MotorsDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Cars'
CREATE TABLE [dbo].[Cars] (
    [CarId] int IDENTITY(1,1) NOT NULL,
    [CarName] nvarchar(max)  NOT NULL,
    [CarCost] float  NOT NULL,
    [ManufacturerID] int  NOT NULL,
    [ManufacturerMfrId] int  NOT NULL
);
GO

-- Creating table 'Manufacturers'
CREATE TABLE [dbo].[Manufacturers] (
    [MfrId] int IDENTITY(1,1) NOT NULL,
    [MName] nvarchar(max)  NOT NULL,
    [CarType] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CarId] in table 'Cars'
ALTER TABLE [dbo].[Cars]
ADD CONSTRAINT [PK_Cars]
    PRIMARY KEY CLUSTERED ([CarId] ASC);
GO

-- Creating primary key on [MfrId] in table 'Manufacturers'
ALTER TABLE [dbo].[Manufacturers]
ADD CONSTRAINT [PK_Manufacturers]
    PRIMARY KEY CLUSTERED ([MfrId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ManufacturerMfrId] in table 'Cars'
ALTER TABLE [dbo].[Cars]
ADD CONSTRAINT [FK_ManufacturerCar]
    FOREIGN KEY ([ManufacturerMfrId])
    REFERENCES [dbo].[Manufacturers]
        ([MfrId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ManufacturerCar'
CREATE INDEX [IX_FK_ManufacturerCar]
ON [dbo].[Cars]
    ([ManufacturerMfrId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------