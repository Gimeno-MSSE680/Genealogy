
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 05/25/2013 15:23:02
-- Generated from EDMX file: C:\Users\Kelly\Documents\Visual Studio 2012\Projects\MSSE680\Week 3\auto code\Genealogy\Domain\GenealogyModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [GenealogyDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_LoginUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users] DROP CONSTRAINT [FK_LoginUser];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonList]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[People] DROP CONSTRAINT [FK_PersonList];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonFather]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[People] DROP CONSTRAINT [FK_PersonFather];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonMother]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[People] DROP CONSTRAINT [FK_PersonMother];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[Logins]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Logins];
GO
IF OBJECT_ID(N'[dbo].[Lists]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Lists];
GO
IF OBJECT_ID(N'[dbo].[People]', 'U') IS NOT NULL
    DROP TABLE [dbo].[People];
GO
IF OBJECT_ID(N'[dbo].[Fathers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Fathers];
GO
IF OBJECT_ID(N'[dbo].[Mothers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Mothers];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [userId] int IDENTITY(1,1) NOT NULL,
    [userFirstName] nvarchar(max)  NOT NULL,
    [userLastName] nvarchar(max)  NOT NULL,
    [userEmail] nvarchar(max)  NOT NULL,
    [Login_loginId] int  NOT NULL
);
GO

-- Creating table 'Logins'
CREATE TABLE [dbo].[Logins] (
    [loginId] int IDENTITY(1,1) NOT NULL,
    [username] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Lists'
CREATE TABLE [dbo].[Lists] (
    [listId] int IDENTITY(1,1) NOT NULL,
    [knownPersonQuantity] smallint  NOT NULL,
    [unknownPersonQuantity] smallint  NOT NULL
);
GO

-- Creating table 'People'
CREATE TABLE [dbo].[People] (
    [personId] int IDENTITY(1,1) NOT NULL,
    [firstName] nvarchar(max)  NOT NULL,
    [lastName] nvarchar(max)  NOT NULL,
    [givenName] nvarchar(max)  NOT NULL,
    [gender] nvarchar(max)  NOT NULL,
    [birthDate] nvarchar(max)  NOT NULL,
    [birthPlace] nvarchar(max)  NOT NULL,
    [deathDate] nvarchar(max)  NOT NULL,
    [deathPlace] nvarchar(max)  NOT NULL,
    [occupation] nvarchar(max)  NOT NULL,
    [Lists_listId] int  NOT NULL,
    [Fathers_fatherId] int  NOT NULL,
    [Mothers_motherId] int  NOT NULL
);
GO

-- Creating table 'Fathers'
CREATE TABLE [dbo].[Fathers] (
    [fatherId] int IDENTITY(1,1) NOT NULL,
    [fatherKnown] bit  NOT NULL,
    [fFirstName] nvarchar(max)  NOT NULL,
    [fLastName] nvarchar(max)  NOT NULL,
    [fGivenName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Mothers'
CREATE TABLE [dbo].[Mothers] (
    [motherId] int IDENTITY(1,1) NOT NULL,
    [motherKnown] bit  NOT NULL,
    [mFirstName] nvarchar(max)  NOT NULL,
    [mLastName] nvarchar(max)  NOT NULL,
    [mGivenName] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [userId] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([userId] ASC);
GO

-- Creating primary key on [loginId] in table 'Logins'
ALTER TABLE [dbo].[Logins]
ADD CONSTRAINT [PK_Logins]
    PRIMARY KEY CLUSTERED ([loginId] ASC);
GO

-- Creating primary key on [listId] in table 'Lists'
ALTER TABLE [dbo].[Lists]
ADD CONSTRAINT [PK_Lists]
    PRIMARY KEY CLUSTERED ([listId] ASC);
GO

-- Creating primary key on [personId] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [PK_People]
    PRIMARY KEY CLUSTERED ([personId] ASC);
GO

-- Creating primary key on [fatherId] in table 'Fathers'
ALTER TABLE [dbo].[Fathers]
ADD CONSTRAINT [PK_Fathers]
    PRIMARY KEY CLUSTERED ([fatherId] ASC);
GO

-- Creating primary key on [motherId] in table 'Mothers'
ALTER TABLE [dbo].[Mothers]
ADD CONSTRAINT [PK_Mothers]
    PRIMARY KEY CLUSTERED ([motherId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Login_loginId] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [FK_LoginUser]
    FOREIGN KEY ([Login_loginId])
    REFERENCES [dbo].[Logins]
        ([loginId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_LoginUser'
CREATE INDEX [IX_FK_LoginUser]
ON [dbo].[Users]
    ([Login_loginId]);
GO

-- Creating foreign key on [Lists_listId] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [FK_PersonList]
    FOREIGN KEY ([Lists_listId])
    REFERENCES [dbo].[Lists]
        ([listId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonList'
CREATE INDEX [IX_FK_PersonList]
ON [dbo].[People]
    ([Lists_listId]);
GO

-- Creating foreign key on [Fathers_fatherId] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [FK_PersonFather]
    FOREIGN KEY ([Fathers_fatherId])
    REFERENCES [dbo].[Fathers]
        ([fatherId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonFather'
CREATE INDEX [IX_FK_PersonFather]
ON [dbo].[People]
    ([Fathers_fatherId]);
GO

-- Creating foreign key on [Mothers_motherId] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [FK_PersonMother]
    FOREIGN KEY ([Mothers_motherId])
    REFERENCES [dbo].[Mothers]
        ([motherId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonMother'
CREATE INDEX [IX_FK_PersonMother]
ON [dbo].[People]
    ([Mothers_motherId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------