
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/06/2019 19:41:08
-- Generated from EDMX file: C:\Users\look_\source\repos\Rhydik\G4-Solutions\DataLayer\DatabaseModel.edmx
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
    ALTER TABLE [dbo].[Prognos] DROP CONSTRAINT [FK_PrognosIntäktsbudget];
GO
IF OBJECT_ID(N'[dbo].[FK_KundIntäktsbudget_Kund]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[KundIntäktsbudget] DROP CONSTRAINT [FK_KundIntäktsbudget_Kund];
GO
IF OBJECT_ID(N'[dbo].[FK_KundIntäktsbudget_Intäktsbudget]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[KundIntäktsbudget] DROP CONSTRAINT [FK_KundIntäktsbudget_Intäktsbudget];
GO
IF OBJECT_ID(N'[dbo].[FK_KundKategoriKund]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Kund] DROP CONSTRAINT [FK_KundKategoriKund];
GO
IF OBJECT_ID(N'[dbo].[FK_ProduktIntäktsbudget_Produkt]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProduktIntäktsbudget] DROP CONSTRAINT [FK_ProduktIntäktsbudget_Produkt];
GO
IF OBJECT_ID(N'[dbo].[FK_ProduktIntäktsbudget_Intäktsbudget]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProduktIntäktsbudget] DROP CONSTRAINT [FK_ProduktIntäktsbudget_Intäktsbudget];
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
IF OBJECT_ID(N'[dbo].[FK_ProduktAvdelning]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Produkt] DROP CONSTRAINT [FK_ProduktAvdelning];
GO
IF OBJECT_ID(N'[dbo].[FK_KostnadsbudgetProdukt_Kostnadsbudget]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[KostnadsbudgetProdukt] DROP CONSTRAINT [FK_KostnadsbudgetProdukt_Kostnadsbudget];
GO
IF OBJECT_ID(N'[dbo].[FK_KostnadsbudgetProdukt_Produkt]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[KostnadsbudgetProdukt] DROP CONSTRAINT [FK_KostnadsbudgetProdukt_Produkt];
GO
IF OBJECT_ID(N'[dbo].[FK_KostnadsbudgetDirektkostnad_Kostnadsbudget]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[KostnadsbudgetDirektkostnad] DROP CONSTRAINT [FK_KostnadsbudgetDirektkostnad_Kostnadsbudget];
GO
IF OBJECT_ID(N'[dbo].[FK_KostnadsbudgetDirektkostnad_Direktkostnad]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[KostnadsbudgetDirektkostnad] DROP CONSTRAINT [FK_KostnadsbudgetDirektkostnad_Direktkostnad];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonalKostnadsbudget_Personal]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonalKostnadsbudget] DROP CONSTRAINT [FK_PersonalKostnadsbudget_Personal];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonalKostnadsbudget_Kostnadsbudget]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonalKostnadsbudget] DROP CONSTRAINT [FK_PersonalKostnadsbudget_Kostnadsbudget];
GO
IF OBJECT_ID(N'[dbo].[FK_AktivitetKostnadsbudget_Aktivitet]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AktivitetKostnadsbudget] DROP CONSTRAINT [FK_AktivitetKostnadsbudget_Aktivitet];
GO
IF OBJECT_ID(N'[dbo].[FK_AktivitetKostnadsbudget_Kostnadsbudget]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AktivitetKostnadsbudget] DROP CONSTRAINT [FK_AktivitetKostnadsbudget_Kostnadsbudget];
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
IF OBJECT_ID(N'[dbo].[KostnadsbudgetSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[KostnadsbudgetSet];
GO
IF OBJECT_ID(N'[dbo].[KundIntäktsbudget]', 'U') IS NOT NULL
    DROP TABLE [dbo].[KundIntäktsbudget];
GO
IF OBJECT_ID(N'[dbo].[ProduktIntäktsbudget]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProduktIntäktsbudget];
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
IF OBJECT_ID(N'[dbo].[KostnadsbudgetProdukt]', 'U') IS NOT NULL
    DROP TABLE [dbo].[KostnadsbudgetProdukt];
GO
IF OBJECT_ID(N'[dbo].[KostnadsbudgetDirektkostnad]', 'U') IS NOT NULL
    DROP TABLE [dbo].[KostnadsbudgetDirektkostnad];
GO
IF OBJECT_ID(N'[dbo].[PersonalKostnadsbudget]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonalKostnadsbudget];
GO
IF OBJECT_ID(N'[dbo].[AktivitetKostnadsbudget]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AktivitetKostnadsbudget];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Prognos'
CREATE TABLE [dbo].[Prognos] (
    [PrognosID] int IDENTITY(1,1) NOT NULL,
    [Namn] nvarchar(max)  NOT NULL,
    [Datum] datetime  NOT NULL,
    [Belopp] decimal(18,0)  NOT NULL,
    [Intäktsbudget_IntäktsbudgetID] int  NOT NULL
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
    [Kommentar] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Kund'
CREATE TABLE [dbo].[Kund] (
    [KundID] nvarchar(max)  NOT NULL,
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
    [ProduktID] nvarchar(max)  NOT NULL,
    [Namn] nvarchar(max)  NOT NULL,
    [Produktkategori_ProduktkategoriID] int  NOT NULL,
    [Produktgrupp_ProduktgruppID] int  NOT NULL,
    [Avdelning_AvdelningID] int  NOT NULL
);
GO

-- Creating table 'Personal'
CREATE TABLE [dbo].[Personal] (
    [PersonalID] int IDENTITY(1,1) NOT NULL,
    [PersonNr] nvarchar(max)  NOT NULL,
    [Namn] nvarchar(max)  NOT NULL,
    [Månadslön] int  NOT NULL,
    [Sysselsättningsgrad] decimal(18,0)  NOT NULL,
    [Vakansavdrag] decimal(18,0)  NOT NULL,
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
    [AktivitetID] nvarchar(max)  NOT NULL,
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
    [Benämning] nvarchar(max)  NOT NULL,
    [konto] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'schablonkostnad'
CREATE TABLE [dbo].[schablonkostnad] (
    [schablonkostnadID] int IDENTITY(1,1) NOT NULL,
    [Belopp] decimal(18,0)  NOT NULL,
    [Konto_KontoID] int  NOT NULL
);
GO

-- Creating table 'KostnadsbudgetSet'
CREATE TABLE [dbo].[KostnadsbudgetSet] (
    [KostnadsbudgetID] int IDENTITY(1,1) NOT NULL,
    [Summering] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'KundIntäktsbudget'
CREATE TABLE [dbo].[KundIntäktsbudget] (
    [Kund_KundID] nvarchar(max)  NOT NULL,
    [Intäktsbudget_IntäktsbudgetID] int  NOT NULL
);
GO

-- Creating table 'ProduktIntäktsbudget'
CREATE TABLE [dbo].[ProduktIntäktsbudget] (
    [Produkt_ProduktID] nvarchar(max)  NOT NULL,
    [Intäktsbudget_IntäktsbudgetID] int  NOT NULL
);
GO

-- Creating table 'PersonalProdukt'
CREATE TABLE [dbo].[PersonalProdukt] (
    [Personal_PersonalID] int  NOT NULL,
    [Produkt_ProduktID] nvarchar(max)  NOT NULL
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

-- Creating table 'KostnadsbudgetProdukt'
CREATE TABLE [dbo].[KostnadsbudgetProdukt] (
    [Kostnadsbudget_KostnadsbudgetID] int  NOT NULL,
    [Produkt_ProduktID] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'KostnadsbudgetDirektkostnad'
CREATE TABLE [dbo].[KostnadsbudgetDirektkostnad] (
    [Kostnadsbudget_KostnadsbudgetID] int  NOT NULL,
    [Direktkostnad_DirektkostnadID] int  NOT NULL
);
GO

-- Creating table 'PersonalKostnadsbudget'
CREATE TABLE [dbo].[PersonalKostnadsbudget] (
    [Personal_PersonalID] int  NOT NULL,
    [Kostnadsbudget_KostnadsbudgetID] int  NOT NULL
);
GO

-- Creating table 'AktivitetKostnadsbudget'
CREATE TABLE [dbo].[AktivitetKostnadsbudget] (
    [Aktivitet_AktivitetID] nvarchar(max)  NOT NULL,
    [Kostnadsbudget_KostnadsbudgetID] int  NOT NULL
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

-- Creating primary key on [KostnadsbudgetID] in table 'KostnadsbudgetSet'
ALTER TABLE [dbo].[KostnadsbudgetSet]
ADD CONSTRAINT [PK_KostnadsbudgetSet]
    PRIMARY KEY CLUSTERED ([KostnadsbudgetID] ASC);
GO

-- Creating primary key on [Kund_KundID], [Intäktsbudget_IntäktsbudgetID] in table 'KundIntäktsbudget'
ALTER TABLE [dbo].[KundIntäktsbudget]
ADD CONSTRAINT [PK_KundIntäktsbudget]
    PRIMARY KEY CLUSTERED ([Kund_KundID], [Intäktsbudget_IntäktsbudgetID] ASC);
GO

-- Creating primary key on [Produkt_ProduktID], [Intäktsbudget_IntäktsbudgetID] in table 'ProduktIntäktsbudget'
ALTER TABLE [dbo].[ProduktIntäktsbudget]
ADD CONSTRAINT [PK_ProduktIntäktsbudget]
    PRIMARY KEY CLUSTERED ([Produkt_ProduktID], [Intäktsbudget_IntäktsbudgetID] ASC);
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

-- Creating primary key on [Kostnadsbudget_KostnadsbudgetID], [Produkt_ProduktID] in table 'KostnadsbudgetProdukt'
ALTER TABLE [dbo].[KostnadsbudgetProdukt]
ADD CONSTRAINT [PK_KostnadsbudgetProdukt]
    PRIMARY KEY CLUSTERED ([Kostnadsbudget_KostnadsbudgetID], [Produkt_ProduktID] ASC);
GO

-- Creating primary key on [Kostnadsbudget_KostnadsbudgetID], [Direktkostnad_DirektkostnadID] in table 'KostnadsbudgetDirektkostnad'
ALTER TABLE [dbo].[KostnadsbudgetDirektkostnad]
ADD CONSTRAINT [PK_KostnadsbudgetDirektkostnad]
    PRIMARY KEY CLUSTERED ([Kostnadsbudget_KostnadsbudgetID], [Direktkostnad_DirektkostnadID] ASC);
GO

-- Creating primary key on [Personal_PersonalID], [Kostnadsbudget_KostnadsbudgetID] in table 'PersonalKostnadsbudget'
ALTER TABLE [dbo].[PersonalKostnadsbudget]
ADD CONSTRAINT [PK_PersonalKostnadsbudget]
    PRIMARY KEY CLUSTERED ([Personal_PersonalID], [Kostnadsbudget_KostnadsbudgetID] ASC);
GO

-- Creating primary key on [Aktivitet_AktivitetID], [Kostnadsbudget_KostnadsbudgetID] in table 'AktivitetKostnadsbudget'
ALTER TABLE [dbo].[AktivitetKostnadsbudget]
ADD CONSTRAINT [PK_AktivitetKostnadsbudget]
    PRIMARY KEY CLUSTERED ([Aktivitet_AktivitetID], [Kostnadsbudget_KostnadsbudgetID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Intäktsbudget_IntäktsbudgetID] in table 'Prognos'
ALTER TABLE [dbo].[Prognos]
ADD CONSTRAINT [FK_PrognosIntäktsbudget]
    FOREIGN KEY ([Intäktsbudget_IntäktsbudgetID])
    REFERENCES [dbo].[Intäktsbudget]
        ([IntäktsbudgetID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PrognosIntäktsbudget'
CREATE INDEX [IX_FK_PrognosIntäktsbudget]
ON [dbo].[Prognos]
    ([Intäktsbudget_IntäktsbudgetID]);
GO

-- Creating foreign key on [Kund_KundID] in table 'KundIntäktsbudget'
ALTER TABLE [dbo].[KundIntäktsbudget]
ADD CONSTRAINT [FK_KundIntäktsbudget_Kund]
    FOREIGN KEY ([Kund_KundID])
    REFERENCES [dbo].[Kund]
        ([KundID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Intäktsbudget_IntäktsbudgetID] in table 'KundIntäktsbudget'
ALTER TABLE [dbo].[KundIntäktsbudget]
ADD CONSTRAINT [FK_KundIntäktsbudget_Intäktsbudget]
    FOREIGN KEY ([Intäktsbudget_IntäktsbudgetID])
    REFERENCES [dbo].[Intäktsbudget]
        ([IntäktsbudgetID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_KundIntäktsbudget_Intäktsbudget'
CREATE INDEX [IX_FK_KundIntäktsbudget_Intäktsbudget]
ON [dbo].[KundIntäktsbudget]
    ([Intäktsbudget_IntäktsbudgetID]);
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

-- Creating foreign key on [Produkt_ProduktID] in table 'ProduktIntäktsbudget'
ALTER TABLE [dbo].[ProduktIntäktsbudget]
ADD CONSTRAINT [FK_ProduktIntäktsbudget_Produkt]
    FOREIGN KEY ([Produkt_ProduktID])
    REFERENCES [dbo].[Produkt]
        ([ProduktID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Intäktsbudget_IntäktsbudgetID] in table 'ProduktIntäktsbudget'
ALTER TABLE [dbo].[ProduktIntäktsbudget]
ADD CONSTRAINT [FK_ProduktIntäktsbudget_Intäktsbudget]
    FOREIGN KEY ([Intäktsbudget_IntäktsbudgetID])
    REFERENCES [dbo].[Intäktsbudget]
        ([IntäktsbudgetID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProduktIntäktsbudget_Intäktsbudget'
CREATE INDEX [IX_FK_ProduktIntäktsbudget_Intäktsbudget]
ON [dbo].[ProduktIntäktsbudget]
    ([Intäktsbudget_IntäktsbudgetID]);
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

-- Creating foreign key on [Avdelning_AvdelningID] in table 'Produkt'
ALTER TABLE [dbo].[Produkt]
ADD CONSTRAINT [FK_ProduktAvdelning]
    FOREIGN KEY ([Avdelning_AvdelningID])
    REFERENCES [dbo].[Avdelning]
        ([AvdelningID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProduktAvdelning'
CREATE INDEX [IX_FK_ProduktAvdelning]
ON [dbo].[Produkt]
    ([Avdelning_AvdelningID]);
GO

-- Creating foreign key on [Kostnadsbudget_KostnadsbudgetID] in table 'KostnadsbudgetProdukt'
ALTER TABLE [dbo].[KostnadsbudgetProdukt]
ADD CONSTRAINT [FK_KostnadsbudgetProdukt_Kostnadsbudget]
    FOREIGN KEY ([Kostnadsbudget_KostnadsbudgetID])
    REFERENCES [dbo].[KostnadsbudgetSet]
        ([KostnadsbudgetID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Produkt_ProduktID] in table 'KostnadsbudgetProdukt'
ALTER TABLE [dbo].[KostnadsbudgetProdukt]
ADD CONSTRAINT [FK_KostnadsbudgetProdukt_Produkt]
    FOREIGN KEY ([Produkt_ProduktID])
    REFERENCES [dbo].[Produkt]
        ([ProduktID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_KostnadsbudgetProdukt_Produkt'
CREATE INDEX [IX_FK_KostnadsbudgetProdukt_Produkt]
ON [dbo].[KostnadsbudgetProdukt]
    ([Produkt_ProduktID]);
GO

-- Creating foreign key on [Kostnadsbudget_KostnadsbudgetID] in table 'KostnadsbudgetDirektkostnad'
ALTER TABLE [dbo].[KostnadsbudgetDirektkostnad]
ADD CONSTRAINT [FK_KostnadsbudgetDirektkostnad_Kostnadsbudget]
    FOREIGN KEY ([Kostnadsbudget_KostnadsbudgetID])
    REFERENCES [dbo].[KostnadsbudgetSet]
        ([KostnadsbudgetID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Direktkostnad_DirektkostnadID] in table 'KostnadsbudgetDirektkostnad'
ALTER TABLE [dbo].[KostnadsbudgetDirektkostnad]
ADD CONSTRAINT [FK_KostnadsbudgetDirektkostnad_Direktkostnad]
    FOREIGN KEY ([Direktkostnad_DirektkostnadID])
    REFERENCES [dbo].[Direktkostnad]
        ([DirektkostnadID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_KostnadsbudgetDirektkostnad_Direktkostnad'
CREATE INDEX [IX_FK_KostnadsbudgetDirektkostnad_Direktkostnad]
ON [dbo].[KostnadsbudgetDirektkostnad]
    ([Direktkostnad_DirektkostnadID]);
GO

-- Creating foreign key on [Personal_PersonalID] in table 'PersonalKostnadsbudget'
ALTER TABLE [dbo].[PersonalKostnadsbudget]
ADD CONSTRAINT [FK_PersonalKostnadsbudget_Personal]
    FOREIGN KEY ([Personal_PersonalID])
    REFERENCES [dbo].[Personal]
        ([PersonalID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Kostnadsbudget_KostnadsbudgetID] in table 'PersonalKostnadsbudget'
ALTER TABLE [dbo].[PersonalKostnadsbudget]
ADD CONSTRAINT [FK_PersonalKostnadsbudget_Kostnadsbudget]
    FOREIGN KEY ([Kostnadsbudget_KostnadsbudgetID])
    REFERENCES [dbo].[KostnadsbudgetSet]
        ([KostnadsbudgetID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonalKostnadsbudget_Kostnadsbudget'
CREATE INDEX [IX_FK_PersonalKostnadsbudget_Kostnadsbudget]
ON [dbo].[PersonalKostnadsbudget]
    ([Kostnadsbudget_KostnadsbudgetID]);
GO

-- Creating foreign key on [Aktivitet_AktivitetID] in table 'AktivitetKostnadsbudget'
ALTER TABLE [dbo].[AktivitetKostnadsbudget]
ADD CONSTRAINT [FK_AktivitetKostnadsbudget_Aktivitet]
    FOREIGN KEY ([Aktivitet_AktivitetID])
    REFERENCES [dbo].[Aktivitet]
        ([AktivitetID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Kostnadsbudget_KostnadsbudgetID] in table 'AktivitetKostnadsbudget'
ALTER TABLE [dbo].[AktivitetKostnadsbudget]
ADD CONSTRAINT [FK_AktivitetKostnadsbudget_Kostnadsbudget]
    FOREIGN KEY ([Kostnadsbudget_KostnadsbudgetID])
    REFERENCES [dbo].[KostnadsbudgetSet]
        ([KostnadsbudgetID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AktivitetKostnadsbudget_Kostnadsbudget'
CREATE INDEX [IX_FK_AktivitetKostnadsbudget_Kostnadsbudget]
ON [dbo].[AktivitetKostnadsbudget]
    ([Kostnadsbudget_KostnadsbudgetID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------