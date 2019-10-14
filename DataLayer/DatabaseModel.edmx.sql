
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/14/2019 12:53:14
-- Generated from EDMX file: C:\Users\marcu\source\repos\G4-Solutions\DataLayer\DatabaseModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [suht1904];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PrognosIntäktsbudget]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Intäktsbudget] DROP CONSTRAINT [FK_PrognosIntäktsbudget];
GO
IF OBJECT_ID(N'[dbo].[FK_KundIntäktsbudget]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Intäktsbudget] DROP CONSTRAINT [FK_KundIntäktsbudget];
GO
IF OBJECT_ID(N'[dbo].[FK_KundKategoriKund]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Kund] DROP CONSTRAINT [FK_KundKategoriKund];
GO
IF OBJECT_ID(N'[dbo].[FK_ProduktIntäktsbudget]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Produkt] DROP CONSTRAINT [FK_ProduktIntäktsbudget];
GO
IF OBJECT_ID(N'[dbo].[FK_ProduktPrognos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Produkt] DROP CONSTRAINT [FK_ProduktPrognos];
GO
IF OBJECT_ID(N'[dbo].[FK_AntalTimmarPersonal]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AntalTimmar] DROP CONSTRAINT [FK_AntalTimmarPersonal];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonalProdukt_Personal]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonalProdukt] DROP CONSTRAINT [FK_PersonalProdukt_Personal];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonalProdukt_Produkt]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonalProdukt] DROP CONSTRAINT [FK_PersonalProdukt_Produkt];
GO
IF OBJECT_ID(N'[dbo].[FK_AvdelningPersonal_Avdelning]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AvdelningPersonal] DROP CONSTRAINT [FK_AvdelningPersonal_Avdelning];
GO
IF OBJECT_ID(N'[dbo].[FK_AvdelningPersonal_Personal]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AvdelningPersonal] DROP CONSTRAINT [FK_AvdelningPersonal_Personal];
GO
IF OBJECT_ID(N'[dbo].[FK_ProduktProduktkategori]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Produkt] DROP CONSTRAINT [FK_ProduktProduktkategori];
GO
IF OBJECT_ID(N'[dbo].[FK_ProduktgruppProdukt]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Produkt] DROP CONSTRAINT [FK_ProduktgruppProdukt];
GO
IF OBJECT_ID(N'[dbo].[FK_AktivitetAvdelning]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Aktivitet] DROP CONSTRAINT [FK_AktivitetAvdelning];
GO
IF OBJECT_ID(N'[dbo].[FK_schablonkostnadKonto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[schablonkostnad] DROP CONSTRAINT [FK_schablonkostnadKonto];
GO
IF OBJECT_ID(N'[dbo].[FK_KontoDirektkostnad]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Direktkostnad] DROP CONSTRAINT [FK_KontoDirektkostnad];
GO
IF OBJECT_ID(N'[dbo].[FK_KontoAvdelning_Konto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[KontoAvdelning] DROP CONSTRAINT [FK_KontoAvdelning_Konto];
GO
IF OBJECT_ID(N'[dbo].[FK_KontoAvdelning_Avdelning]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[KontoAvdelning] DROP CONSTRAINT [FK_KontoAvdelning_Avdelning];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Prognos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Prognos];
GO
IF OBJECT_ID(N'[dbo].[Intäktsbudget]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Intäktsbudget];
GO
IF OBJECT_ID(N'[dbo].[Kund]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Kund];
GO
IF OBJECT_ID(N'[dbo].[KundKategori]', 'U') IS NOT NULL
    DROP TABLE [dbo].[KundKategori];
GO
IF OBJECT_ID(N'[dbo].[Produkt]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Produkt];
GO
IF OBJECT_ID(N'[dbo].[Personal]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Personal];
GO
IF OBJECT_ID(N'[dbo].[AntalTimmar]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AntalTimmar];
GO
IF OBJECT_ID(N'[dbo].[Avdelning]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Avdelning];
GO
IF OBJECT_ID(N'[dbo].[Produktgrupp]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Produktgrupp];
GO
IF OBJECT_ID(N'[dbo].[Produktkategori]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Produktkategori];
GO
IF OBJECT_ID(N'[dbo].[Aktivitet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Aktivitet];
GO
IF OBJECT_ID(N'[dbo].[Direktkostnad]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Direktkostnad];
GO
IF OBJECT_ID(N'[dbo].[Konto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Konto];
GO
IF OBJECT_ID(N'[dbo].[schablonkostnad]', 'U') IS NOT NULL
    DROP TABLE [dbo].[schablonkostnad];
GO
IF OBJECT_ID(N'[dbo].[PersonalProdukt]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonalProdukt];
GO
IF OBJECT_ID(N'[dbo].[AvdelningPersonal]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AvdelningPersonal];
GO
IF OBJECT_ID(N'[dbo].[KontoAvdelning]', 'U') IS NOT NULL
    DROP TABLE [dbo].[KontoAvdelning];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Prognos'
CREATE TABLE [dbo].[Prognos] (
    [PrognosID] int IDENTITY(1,1) NOT NULL,
    [Namn] nvarchar(max)  NOT NULL,
    [Datum] datetime  NOT NULL,
    [Belopp] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'Intäktsbudget'
CREATE TABLE [dbo].[Intäktsbudget] (
    [IntäktsbudgetID] int IDENTITY(1,1) NOT NULL,
    [Låst] bit  NOT NULL,
    [Avtal] decimal(18,0)  NOT NULL,
    [GradA] bit  NOT NULL,
    [Tillägg] decimal(18,0)  NOT NULL,
    [GradT] bit  NOT NULL,
    [Budget] decimal(18,0)  NOT NULL,
    [Tim] int  NOT NULL,
    [Kommentar] nvarchar(max)  NOT NULL,
    [Prognos_PrognosID] int  NOT NULL,
    [Kund_KundID] int  NOT NULL
);
GO

-- Creating table 'Kund'
CREATE TABLE [dbo].[Kund] (
    [KundID] int IDENTITY(1,1) NOT NULL,
    [Namn] nvarchar(max)  NOT NULL,
    [KundKategori_KundKategoriID] int  NOT NULL
);
GO

-- Creating table 'KundKategori'
CREATE TABLE [dbo].[KundKategori] (
    [KundKategoriID] int IDENTITY(1,1) NOT NULL,
    [Namn] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Produkt'
CREATE TABLE [dbo].[Produkt] (
    [ProduktID] int IDENTITY(1,1) NOT NULL,
    [ProduktKod] nvarchar(max)  NOT NULL,
    [Namn] nvarchar(max)  NOT NULL,
    [Intäktsbudget_IntäktsbudgetID] int  NOT NULL,
    [Prognos_PrognosID] int  NOT NULL,
    [Produktkategori_ProduktkategoriID] int  NOT NULL,
    [Produktgrupp_ProduktgruppID] int  NOT NULL
);
GO

-- Creating table 'Personal'
CREATE TABLE [dbo].[Personal] (
    [PersonalID] int IDENTITY(1,1) NOT NULL,
    [PersonNr] nvarchar(max)  NOT NULL,
    [Namn] nvarchar(max)  NOT NULL,
    [Månadslön] int  NOT NULL,
    [Sysselsättningsgrad] int  NOT NULL,
    [Vakansavdrag] int  NOT NULL,
    [Lösenord] nvarchar(max)  NOT NULL,
    [Behörighet] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'AntalTimmar'
CREATE TABLE [dbo].[AntalTimmar] (
    [AntalTimmarID] int IDENTITY(1,1) NOT NULL,
    [Adm] int  NOT NULL,
    [FörsMark] int  NOT NULL,
    [UtvFörv] int  NOT NULL,
    [Drift] int  NOT NULL,
    [Personal_PersonalID] int  NOT NULL
);
GO

-- Creating table 'Avdelning'
CREATE TABLE [dbo].[Avdelning] (
    [AvdelningID] int IDENTITY(1,1) NOT NULL,
    [Namn] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Produktgrupp'
CREATE TABLE [dbo].[Produktgrupp] (
    [ProduktgruppID] int IDENTITY(1,1) NOT NULL,
    [Namn] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Produktkategori'
CREATE TABLE [dbo].[Produktkategori] (
    [ProduktkategoriID] int IDENTITY(1,1) NOT NULL,
    [Namn] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Aktivitet'
CREATE TABLE [dbo].[Aktivitet] (
    [AktivitetID] int IDENTITY(1,1) NOT NULL,
    [Namn] nvarchar(max)  NOT NULL,
    [Avdelning_AvdelningID] int  NOT NULL
);
GO

-- Creating table 'Direktkostnad'
CREATE TABLE [dbo].[Direktkostnad] (
    [DirektkostnadID] int IDENTITY(1,1) NOT NULL,
    [Namn] nvarchar(max)  NOT NULL,
    [Belopp] decimal(18,0)  NOT NULL,
    [Konto_KontoID] int  NOT NULL
);
GO

-- Creating table 'Konto'
CREATE TABLE [dbo].[Konto] (
    [KontoID] int IDENTITY(1,1) NOT NULL,
    [Namn] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'schablonkostnad'
CREATE TABLE [dbo].[schablonkostnad] (
    [schablonkostnadID] int IDENTITY(1,1) NOT NULL,
    [Namn] nvarchar(max)  NOT NULL,
    [Belopp] decimal(18,0)  NOT NULL,
    [Konto_KontoID] int  NOT NULL
);
GO

-- Creating table 'PersonalProdukt'
CREATE TABLE [dbo].[PersonalProdukt] (
    [Personal_PersonalID] int  NOT NULL,
    [Produkt_ProduktID] int  NOT NULL
);
GO

-- Creating table 'AvdelningPersonal'
CREATE TABLE [dbo].[AvdelningPersonal] (
    [Avdelning_AvdelningID] int  NOT NULL,
    [Personal_PersonalID] int  NOT NULL
);
GO

-- Creating table 'KontoAvdelning'
CREATE TABLE [dbo].[KontoAvdelning] (
    [Konto_KontoID] int  NOT NULL,
    [Avdelning_AvdelningID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [PrognosID] in table 'Prognos'
ALTER TABLE [dbo].[Prognos]
ADD CONSTRAINT [PK_Prognos]
    PRIMARY KEY CLUSTERED ([PrognosID] ASC);
GO

-- Creating primary key on [IntäktsbudgetID] in table 'Intäktsbudget'
ALTER TABLE [dbo].[Intäktsbudget]
ADD CONSTRAINT [PK_Intäktsbudget]
    PRIMARY KEY CLUSTERED ([IntäktsbudgetID] ASC);
GO

-- Creating primary key on [KundID] in table 'Kund'
ALTER TABLE [dbo].[Kund]
ADD CONSTRAINT [PK_Kund]
    PRIMARY KEY CLUSTERED ([KundID] ASC);
GO

-- Creating primary key on [KundKategoriID] in table 'KundKategori'
ALTER TABLE [dbo].[KundKategori]
ADD CONSTRAINT [PK_KundKategori]
    PRIMARY KEY CLUSTERED ([KundKategoriID] ASC);
GO

-- Creating primary key on [ProduktID] in table 'Produkt'
ALTER TABLE [dbo].[Produkt]
ADD CONSTRAINT [PK_Produkt]
    PRIMARY KEY CLUSTERED ([ProduktID] ASC);
GO

-- Creating primary key on [PersonalID] in table 'Personal'
ALTER TABLE [dbo].[Personal]
ADD CONSTRAINT [PK_Personal]
    PRIMARY KEY CLUSTERED ([PersonalID] ASC);
GO

-- Creating primary key on [AntalTimmarID] in table 'AntalTimmar'
ALTER TABLE [dbo].[AntalTimmar]
ADD CONSTRAINT [PK_AntalTimmar]
    PRIMARY KEY CLUSTERED ([AntalTimmarID] ASC);
GO

-- Creating primary key on [AvdelningID] in table 'Avdelning'
ALTER TABLE [dbo].[Avdelning]
ADD CONSTRAINT [PK_Avdelning]
    PRIMARY KEY CLUSTERED ([AvdelningID] ASC);
GO

-- Creating primary key on [ProduktgruppID] in table 'Produktgrupp'
ALTER TABLE [dbo].[Produktgrupp]
ADD CONSTRAINT [PK_Produktgrupp]
    PRIMARY KEY CLUSTERED ([ProduktgruppID] ASC);
GO

-- Creating primary key on [ProduktkategoriID] in table 'Produktkategori'
ALTER TABLE [dbo].[Produktkategori]
ADD CONSTRAINT [PK_Produktkategori]
    PRIMARY KEY CLUSTERED ([ProduktkategoriID] ASC);
GO

-- Creating primary key on [AktivitetID] in table 'Aktivitet'
ALTER TABLE [dbo].[Aktivitet]
ADD CONSTRAINT [PK_Aktivitet]
    PRIMARY KEY CLUSTERED ([AktivitetID] ASC);
GO

-- Creating primary key on [DirektkostnadID] in table 'Direktkostnad'
ALTER TABLE [dbo].[Direktkostnad]
ADD CONSTRAINT [PK_Direktkostnad]
    PRIMARY KEY CLUSTERED ([DirektkostnadID] ASC);
GO

-- Creating primary key on [KontoID] in table 'Konto'
ALTER TABLE [dbo].[Konto]
ADD CONSTRAINT [PK_Konto]
    PRIMARY KEY CLUSTERED ([KontoID] ASC);
GO

-- Creating primary key on [schablonkostnadID] in table 'schablonkostnad'
ALTER TABLE [dbo].[schablonkostnad]
ADD CONSTRAINT [PK_schablonkostnad]
    PRIMARY KEY CLUSTERED ([schablonkostnadID] ASC);
GO

-- Creating primary key on [Personal_PersonalID], [Produkt_ProduktID] in table 'PersonalProdukt'
ALTER TABLE [dbo].[PersonalProdukt]
ADD CONSTRAINT [PK_PersonalProdukt]
    PRIMARY KEY CLUSTERED ([Personal_PersonalID], [Produkt_ProduktID] ASC);
GO

-- Creating primary key on [Avdelning_AvdelningID], [Personal_PersonalID] in table 'AvdelningPersonal'
ALTER TABLE [dbo].[AvdelningPersonal]
ADD CONSTRAINT [PK_AvdelningPersonal]
    PRIMARY KEY CLUSTERED ([Avdelning_AvdelningID], [Personal_PersonalID] ASC);
GO

-- Creating primary key on [Konto_KontoID], [Avdelning_AvdelningID] in table 'KontoAvdelning'
ALTER TABLE [dbo].[KontoAvdelning]
ADD CONSTRAINT [PK_KontoAvdelning]
    PRIMARY KEY CLUSTERED ([Konto_KontoID], [Avdelning_AvdelningID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Prognos_PrognosID] in table 'Intäktsbudget'
ALTER TABLE [dbo].[Intäktsbudget]
ADD CONSTRAINT [FK_PrognosIntäktsbudget]
    FOREIGN KEY ([Prognos_PrognosID])
    REFERENCES [dbo].[Prognos]
        ([PrognosID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PrognosIntäktsbudget'
CREATE INDEX [IX_FK_PrognosIntäktsbudget]
ON [dbo].[Intäktsbudget]
    ([Prognos_PrognosID]);
GO

-- Creating foreign key on [Kund_KundID] in table 'Intäktsbudget'
ALTER TABLE [dbo].[Intäktsbudget]
ADD CONSTRAINT [FK_KundIntäktsbudget]
    FOREIGN KEY ([Kund_KundID])
    REFERENCES [dbo].[Kund]
        ([KundID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_KundIntäktsbudget'
CREATE INDEX [IX_FK_KundIntäktsbudget]
ON [dbo].[Intäktsbudget]
    ([Kund_KundID]);
GO

-- Creating foreign key on [KundKategori_KundKategoriID] in table 'Kund'
ALTER TABLE [dbo].[Kund]
ADD CONSTRAINT [FK_KundKategoriKund]
    FOREIGN KEY ([KundKategori_KundKategoriID])
    REFERENCES [dbo].[KundKategori]
        ([KundKategoriID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_KundKategoriKund'
CREATE INDEX [IX_FK_KundKategoriKund]
ON [dbo].[Kund]
    ([KundKategori_KundKategoriID]);
GO

-- Creating foreign key on [Intäktsbudget_IntäktsbudgetID] in table 'Produkt'
ALTER TABLE [dbo].[Produkt]
ADD CONSTRAINT [FK_ProduktIntäktsbudget]
    FOREIGN KEY ([Intäktsbudget_IntäktsbudgetID])
    REFERENCES [dbo].[Intäktsbudget]
        ([IntäktsbudgetID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProduktIntäktsbudget'
CREATE INDEX [IX_FK_ProduktIntäktsbudget]
ON [dbo].[Produkt]
    ([Intäktsbudget_IntäktsbudgetID]);
GO

-- Creating foreign key on [Prognos_PrognosID] in table 'Produkt'
ALTER TABLE [dbo].[Produkt]
ADD CONSTRAINT [FK_ProduktPrognos]
    FOREIGN KEY ([Prognos_PrognosID])
    REFERENCES [dbo].[Prognos]
        ([PrognosID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProduktPrognos'
CREATE INDEX [IX_FK_ProduktPrognos]
ON [dbo].[Produkt]
    ([Prognos_PrognosID]);
GO

-- Creating foreign key on [Personal_PersonalID] in table 'AntalTimmar'
ALTER TABLE [dbo].[AntalTimmar]
ADD CONSTRAINT [FK_AntalTimmarPersonal]
    FOREIGN KEY ([Personal_PersonalID])
    REFERENCES [dbo].[Personal]
        ([PersonalID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AntalTimmarPersonal'
CREATE INDEX [IX_FK_AntalTimmarPersonal]
ON [dbo].[AntalTimmar]
    ([Personal_PersonalID]);
GO

-- Creating foreign key on [Personal_PersonalID] in table 'PersonalProdukt'
ALTER TABLE [dbo].[PersonalProdukt]
ADD CONSTRAINT [FK_PersonalProdukt_Personal]
    FOREIGN KEY ([Personal_PersonalID])
    REFERENCES [dbo].[Personal]
        ([PersonalID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Produkt_ProduktID] in table 'PersonalProdukt'
ALTER TABLE [dbo].[PersonalProdukt]
ADD CONSTRAINT [FK_PersonalProdukt_Produkt]
    FOREIGN KEY ([Produkt_ProduktID])
    REFERENCES [dbo].[Produkt]
        ([ProduktID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonalProdukt_Produkt'
CREATE INDEX [IX_FK_PersonalProdukt_Produkt]
ON [dbo].[PersonalProdukt]
    ([Produkt_ProduktID]);
GO

-- Creating foreign key on [Avdelning_AvdelningID] in table 'AvdelningPersonal'
ALTER TABLE [dbo].[AvdelningPersonal]
ADD CONSTRAINT [FK_AvdelningPersonal_Avdelning]
    FOREIGN KEY ([Avdelning_AvdelningID])
    REFERENCES [dbo].[Avdelning]
        ([AvdelningID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Personal_PersonalID] in table 'AvdelningPersonal'
ALTER TABLE [dbo].[AvdelningPersonal]
ADD CONSTRAINT [FK_AvdelningPersonal_Personal]
    FOREIGN KEY ([Personal_PersonalID])
    REFERENCES [dbo].[Personal]
        ([PersonalID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AvdelningPersonal_Personal'
CREATE INDEX [IX_FK_AvdelningPersonal_Personal]
ON [dbo].[AvdelningPersonal]
    ([Personal_PersonalID]);
GO

-- Creating foreign key on [Produktkategori_ProduktkategoriID] in table 'Produkt'
ALTER TABLE [dbo].[Produkt]
ADD CONSTRAINT [FK_ProduktProduktkategori]
    FOREIGN KEY ([Produktkategori_ProduktkategoriID])
    REFERENCES [dbo].[Produktkategori]
        ([ProduktkategoriID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProduktProduktkategori'
CREATE INDEX [IX_FK_ProduktProduktkategori]
ON [dbo].[Produkt]
    ([Produktkategori_ProduktkategoriID]);
GO

-- Creating foreign key on [Produktgrupp_ProduktgruppID] in table 'Produkt'
ALTER TABLE [dbo].[Produkt]
ADD CONSTRAINT [FK_ProduktgruppProdukt]
    FOREIGN KEY ([Produktgrupp_ProduktgruppID])
    REFERENCES [dbo].[Produktgrupp]
        ([ProduktgruppID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProduktgruppProdukt'
CREATE INDEX [IX_FK_ProduktgruppProdukt]
ON [dbo].[Produkt]
    ([Produktgrupp_ProduktgruppID]);
GO

-- Creating foreign key on [Avdelning_AvdelningID] in table 'Aktivitet'
ALTER TABLE [dbo].[Aktivitet]
ADD CONSTRAINT [FK_AktivitetAvdelning]
    FOREIGN KEY ([Avdelning_AvdelningID])
    REFERENCES [dbo].[Avdelning]
        ([AvdelningID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AktivitetAvdelning'
CREATE INDEX [IX_FK_AktivitetAvdelning]
ON [dbo].[Aktivitet]
    ([Avdelning_AvdelningID]);
GO

-- Creating foreign key on [Konto_KontoID] in table 'schablonkostnad'
ALTER TABLE [dbo].[schablonkostnad]
ADD CONSTRAINT [FK_schablonkostnadKonto]
    FOREIGN KEY ([Konto_KontoID])
    REFERENCES [dbo].[Konto]
        ([KontoID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_schablonkostnadKonto'
CREATE INDEX [IX_FK_schablonkostnadKonto]
ON [dbo].[schablonkostnad]
    ([Konto_KontoID]);
GO

-- Creating foreign key on [Konto_KontoID] in table 'Direktkostnad'
ALTER TABLE [dbo].[Direktkostnad]
ADD CONSTRAINT [FK_KontoDirektkostnad]
    FOREIGN KEY ([Konto_KontoID])
    REFERENCES [dbo].[Konto]
        ([KontoID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_KontoDirektkostnad'
CREATE INDEX [IX_FK_KontoDirektkostnad]
ON [dbo].[Direktkostnad]
    ([Konto_KontoID]);
GO

-- Creating foreign key on [Konto_KontoID] in table 'KontoAvdelning'
ALTER TABLE [dbo].[KontoAvdelning]
ADD CONSTRAINT [FK_KontoAvdelning_Konto]
    FOREIGN KEY ([Konto_KontoID])
    REFERENCES [dbo].[Konto]
        ([KontoID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Avdelning_AvdelningID] in table 'KontoAvdelning'
ALTER TABLE [dbo].[KontoAvdelning]
ADD CONSTRAINT [FK_KontoAvdelning_Avdelning]
    FOREIGN KEY ([Avdelning_AvdelningID])
    REFERENCES [dbo].[Avdelning]
        ([AvdelningID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_KontoAvdelning_Avdelning'
CREATE INDEX [IX_FK_KontoAvdelning_Avdelning]
ON [dbo].[KontoAvdelning]
    ([Avdelning_AvdelningID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------