
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/02/2017 12:21:34
-- Generated from EDMX file: C:\Users\Hp PROBOOK  6450b\documents\visual studio 2015\Projects\Admin_pro\Admin_pro\Models\Library.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Manage Books];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_appartient_Ouvrage]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[appartient] DROP CONSTRAINT [FK_appartient_Ouvrage];
GO
IF OBJECT_ID(N'[dbo].[FK_Commande_Etudiant]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Commande] DROP CONSTRAINT [FK_Commande_Etudiant];
GO
IF OBJECT_ID(N'[dbo].[FK_Ecrire_Auteur]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Ecrire] DROP CONSTRAINT [FK_Ecrire_Auteur];
GO
IF OBJECT_ID(N'[dbo].[FK_Ecrire_Ouvrage]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Ecrire] DROP CONSTRAINT [FK_Ecrire_Ouvrage];
GO
IF OBJECT_ID(N'[dbo].[FK_Exemplaire_Etudiant]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Exemplaire] DROP CONSTRAINT [FK_Exemplaire_Etudiant];
GO
IF OBJECT_ID(N'[dbo].[FK_Exemplaire_Ouvrage]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Exemplaire] DROP CONSTRAINT [FK_Exemplaire_Ouvrage];
GO
IF OBJECT_ID(N'[dbo].[FK_Formation_professour]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Formation] DROP CONSTRAINT [FK_Formation_professour];
GO
IF OBJECT_ID(N'[dbo].[FK_Mise_a_Jour_Ouvrage]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Mise_a_Jour] DROP CONSTRAINT [FK_Mise_a_Jour_Ouvrage];
GO
IF OBJECT_ID(N'[dbo].[FK_Mise_a_Jour_Version_ouvrage]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Mise_a_Jour] DROP CONSTRAINT [FK_Mise_a_Jour_Version_ouvrage];
GO
IF OBJECT_ID(N'[dbo].[FK_Ouvrage_Auteur1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Ouvrage] DROP CONSTRAINT [FK_Ouvrage_Auteur1];
GO
IF OBJECT_ID(N'[dbo].[FK_Ouvrage_Editeur]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Ouvrage] DROP CONSTRAINT [FK_Ouvrage_Editeur];
GO
IF OBJECT_ID(N'[dbo].[FK_Ouvrage_Editeur1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Ouvrage] DROP CONSTRAINT [FK_Ouvrage_Editeur1];
GO
IF OBJECT_ID(N'[dbo].[FK_Ouvrage_Editeur2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Ouvrage] DROP CONSTRAINT [FK_Ouvrage_Editeur2];
GO
IF OBJECT_ID(N'[dbo].[FK_Ouvrage_Ouvrage]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Ouvrage] DROP CONSTRAINT [FK_Ouvrage_Ouvrage];
GO
IF OBJECT_ID(N'[dbo].[FK_Ouvrage_Type1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Ouvrage] DROP CONSTRAINT [FK_Ouvrage_Type1];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Acheter]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Acheter];
GO
IF OBJECT_ID(N'[dbo].[appartient]', 'U') IS NOT NULL
    DROP TABLE [dbo].[appartient];
GO
IF OBJECT_ID(N'[dbo].[Auteur]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Auteur];
GO
IF OBJECT_ID(N'[dbo].[Authentification]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Authentification];
GO
IF OBJECT_ID(N'[dbo].[Commande]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Commande];
GO
IF OBJECT_ID(N'[dbo].[Ecrire]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Ecrire];
GO
IF OBJECT_ID(N'[dbo].[Editeur]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Editeur];
GO
IF OBJECT_ID(N'[dbo].[Etudiant]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Etudiant];
GO
IF OBJECT_ID(N'[dbo].[Exemplaire]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Exemplaire];
GO
IF OBJECT_ID(N'[dbo].[Formation]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Formation];
GO
IF OBJECT_ID(N'[dbo].[InfoUser]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InfoUser];
GO
IF OBJECT_ID(N'[dbo].[Inscription]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Inscription];
GO
IF OBJECT_ID(N'[dbo].[Mise_a_Jour]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Mise_a_Jour];
GO
IF OBJECT_ID(N'[dbo].[Ouvrage]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Ouvrage];
GO
IF OBJECT_ID(N'[dbo].[professour]', 'U') IS NOT NULL
    DROP TABLE [dbo].[professour];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[Type]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Type];
GO
IF OBJECT_ID(N'[dbo].[Version_ouvrage]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Version_ouvrage];
GO
IF OBJECT_ID(N'[ModelStoreContainer].[Commander]', 'U') IS NOT NULL
    DROP TABLE [ModelStoreContainer].[Commander];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Acheters'
CREATE TABLE [dbo].[Acheters] (
    [Etudiant] int  NOT NULL,
    [Ouvrage] int  NOT NULL,
    [date_Acheter] datetime  NULL
);
GO

-- Creating table 'appartients'
CREATE TABLE [dbo].[appartients] (
    [id_ouvrage] int  NOT NULL,
    [id_type] varchar(50)  NOT NULL
);
GO

-- Creating table 'Auteurs'
CREATE TABLE [dbo].[Auteurs] (
    [id_Auteur] int IDENTITY(1,1) NOT NULL,
    [nom] varchar(50)  NULL,
    [prenom] varchar(50)  NULL,
    [Nationalite] varchar(50)  NULL,
    [date_deces] datetime  NULL
);
GO

-- Creating table 'Authentifications'
CREATE TABLE [dbo].[Authentifications] (
    [User_Name] varchar(50)  NOT NULL,
    [Password_cle] varchar(50)  NULL,
    [Roles] varchar(50)  NULL
);
GO

-- Creating table 'Commandes'
CREATE TABLE [dbo].[Commandes] (
    [Num_commande] int  NOT NULL,
    [num_etudiant] int  NULL,
    [datecommande] datetime  NULL,
    [destinataire] varchar(100)  NULL,
    [ville_livraison] varchar(50)  NULL,
    [pays_livraison] varchar(50)  NULL,
    [adresse_livraison] varchar(200)  NULL,
    [code_postal_livraison] int  NULL,
    [date_envoi] nchar(10)  NULL
);
GO

-- Creating table 'Editeurs'
CREATE TABLE [dbo].[Editeurs] (
    [id_Editeur] int IDENTITY(1,1) NOT NULL,
    [ville] varchar(50)  NULL,
    [Email] varchar(50)  NULL,
    [nomE] varchar(50)  NULL,
    [prenomE] varchar(50)  NULL,
    [nationalite] varchar(50)  NULL
);
GO

-- Creating table 'Etudiants'
CREATE TABLE [dbo].[Etudiants] (
    [num_etudiant] int IDENTITY(1,1) NOT NULL,
    [nom] varchar(30)  NULL,
    [prenom] varchar(30)  NULL,
    [date_naissance] datetime  NULL,
    [telephone] varchar(20)  NULL,
    [adresse] varchar(100)  NULL,
    [ville] varchar(50)  NULL,
    [code_postal] varchar(50)  NULL,
    [Pays] varchar(50)  NULL
);
GO

-- Creating table 'Exemplaires'
CREATE TABLE [dbo].[Exemplaires] (
    [num_exemplaire] int IDENTITY(1,1) NOT NULL,
    [titre] varchar(100)  NULL,
    [nb_pages] int  NULL,
    [num_etudiant] int  NULL,
    [id_ouvrage] int  NULL,
    [Categorie] varchar(50)  NULL
);
GO

-- Creating table 'Formations'
CREATE TABLE [dbo].[Formations] (
    [id_formation] int  NOT NULL,
    [libelle] varchar(100)  NULL,
    [date_debut] datetime  NULL,
    [date_fin] datetime  NULL,
    [id_prof] int  NULL,
    [type] varchar(50)  NULL
);
GO

-- Creating table 'InfoUsers'
CREATE TABLE [dbo].[InfoUsers] (
    [id] int IDENTITY(1,1) NOT NULL,
    [Email] varchar(50)  NULL,
    [Prenom] varchar(50)  NULL,
    [Name] varchar(50)  NULL,
    [DateCreation] datetime  NULL,
    [password] varchar(50)  NULL,
    [telephone] varchar(50)  NULL,
    [Adresse] varchar(100)  NULL,
    [Confirmpassword] nchar(10)  NULL,
    [Photo] varchar(200)  NULL
);
GO

-- Creating table 'Inscriptions'
CREATE TABLE [dbo].[Inscriptions] (
    [Username] varchar(50)  NOT NULL,
    [Nom] varchar(50)  NULL,
    [Prenom] varchar(50)  NULL,
    [Email] varchar(50)  NULL,
    [DateNaissance] datetime  NULL,
    [Password] varchar(50)  NULL,
    [Confirm_Password] varchar(50)  NULL,
    [Nationalite] varchar(50)  NULL,
    [Ville] varchar(50)  NULL,
    [Numerotele] varchar(50)  NULL
);
GO

-- Creating table 'Mise_a_Jour'
CREATE TABLE [dbo].[Mise_a_Jour] (
    [id_ouvrage] int  NOT NULL,
    [id_version] varchar(30)  NOT NULL,
    [date_miseajour] datetime  NULL
);
GO

-- Creating table 'Ouvrages'
CREATE TABLE [dbo].[Ouvrages] (
    [id_ouvrage] int IDENTITY(1,1) NOT NULL,
    [titre] varchar(100)  NULL,
    [nb_pages] int  NULL,
    [id_Editeur] int  NULL,
    [Quantite] int  NULL,
    [Type] varchar(100)  NULL,
    [id_Auteur] int  NULL,
    [Photo] varchar(200)  NULL,
    [id_type] int  NULL,
    [libelle] varchar(100)  NULL
);
GO

-- Creating table 'professours'
CREATE TABLE [dbo].[professours] (
    [id_prof] int  NOT NULL,
    [Nom] varchar(50)  NULL,
    [prenom] varchar(50)  NULL,
    [datenaissance] datetime  NULL,
    [email] varchar(50)  NULL,
    [adresse] varchar(50)  NULL,
    [domaine] varchar(50)  NULL
);
GO

-- Creating table 'Types'
CREATE TABLE [dbo].[Types] (
    [id_type] int  NOT NULL,
    [libelle] varchar(100)  NULL
);
GO

-- Creating table 'Version_ouvrage'
CREATE TABLE [dbo].[Version_ouvrage] (
    [id_version] varchar(30)  NOT NULL,
    [libelle] varchar(60)  NULL
);
GO

-- Creating table 'Commanders'
CREATE TABLE [dbo].[Commanders] (
    [id_ouvrage] int  NOT NULL,
    [Prix] float  NULL,
    [quantite] int  NULL,
    [remise] float  NULL,
    [Num_commande] int  NULL
);
GO

-- Creating table 'Ecrire'
CREATE TABLE [dbo].[Ecrire] (
    [Auteurs_id_Auteur] int  NOT NULL,
    [Ouvrages1_id_ouvrage] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Etudiant], [Ouvrage] in table 'Acheters'
ALTER TABLE [dbo].[Acheters]
ADD CONSTRAINT [PK_Acheters]
    PRIMARY KEY CLUSTERED ([Etudiant], [Ouvrage] ASC);
GO

-- Creating primary key on [id_ouvrage], [id_type] in table 'appartients'
ALTER TABLE [dbo].[appartients]
ADD CONSTRAINT [PK_appartients]
    PRIMARY KEY CLUSTERED ([id_ouvrage], [id_type] ASC);
GO

-- Creating primary key on [id_Auteur] in table 'Auteurs'
ALTER TABLE [dbo].[Auteurs]
ADD CONSTRAINT [PK_Auteurs]
    PRIMARY KEY CLUSTERED ([id_Auteur] ASC);
GO

-- Creating primary key on [User_Name] in table 'Authentifications'
ALTER TABLE [dbo].[Authentifications]
ADD CONSTRAINT [PK_Authentifications]
    PRIMARY KEY CLUSTERED ([User_Name] ASC);
GO

-- Creating primary key on [Num_commande] in table 'Commandes'
ALTER TABLE [dbo].[Commandes]
ADD CONSTRAINT [PK_Commandes]
    PRIMARY KEY CLUSTERED ([Num_commande] ASC);
GO

-- Creating primary key on [id_Editeur] in table 'Editeurs'
ALTER TABLE [dbo].[Editeurs]
ADD CONSTRAINT [PK_Editeurs]
    PRIMARY KEY CLUSTERED ([id_Editeur] ASC);
GO

-- Creating primary key on [num_etudiant] in table 'Etudiants'
ALTER TABLE [dbo].[Etudiants]
ADD CONSTRAINT [PK_Etudiants]
    PRIMARY KEY CLUSTERED ([num_etudiant] ASC);
GO

-- Creating primary key on [num_exemplaire] in table 'Exemplaires'
ALTER TABLE [dbo].[Exemplaires]
ADD CONSTRAINT [PK_Exemplaires]
    PRIMARY KEY CLUSTERED ([num_exemplaire] ASC);
GO

-- Creating primary key on [id_formation] in table 'Formations'
ALTER TABLE [dbo].[Formations]
ADD CONSTRAINT [PK_Formations]
    PRIMARY KEY CLUSTERED ([id_formation] ASC);
GO

-- Creating primary key on [id] in table 'InfoUsers'
ALTER TABLE [dbo].[InfoUsers]
ADD CONSTRAINT [PK_InfoUsers]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [Username] in table 'Inscriptions'
ALTER TABLE [dbo].[Inscriptions]
ADD CONSTRAINT [PK_Inscriptions]
    PRIMARY KEY CLUSTERED ([Username] ASC);
GO

-- Creating primary key on [id_ouvrage], [id_version] in table 'Mise_a_Jour'
ALTER TABLE [dbo].[Mise_a_Jour]
ADD CONSTRAINT [PK_Mise_a_Jour]
    PRIMARY KEY CLUSTERED ([id_ouvrage], [id_version] ASC);
GO

-- Creating primary key on [id_ouvrage] in table 'Ouvrages'
ALTER TABLE [dbo].[Ouvrages]
ADD CONSTRAINT [PK_Ouvrages]
    PRIMARY KEY CLUSTERED ([id_ouvrage] ASC);
GO

-- Creating primary key on [id_prof] in table 'professours'
ALTER TABLE [dbo].[professours]
ADD CONSTRAINT [PK_professours]
    PRIMARY KEY CLUSTERED ([id_prof] ASC);
GO

-- Creating primary key on [id_type] in table 'Types'
ALTER TABLE [dbo].[Types]
ADD CONSTRAINT [PK_Types]
    PRIMARY KEY CLUSTERED ([id_type] ASC);
GO

-- Creating primary key on [id_version] in table 'Version_ouvrage'
ALTER TABLE [dbo].[Version_ouvrage]
ADD CONSTRAINT [PK_Version_ouvrage]
    PRIMARY KEY CLUSTERED ([id_version] ASC);
GO

-- Creating primary key on [id_ouvrage] in table 'Commanders'
ALTER TABLE [dbo].[Commanders]
ADD CONSTRAINT [PK_Commanders]
    PRIMARY KEY CLUSTERED ([id_ouvrage] ASC);
GO

-- Creating primary key on [Auteurs_id_Auteur], [Ouvrages1_id_ouvrage] in table 'Ecrire'
ALTER TABLE [dbo].[Ecrire]
ADD CONSTRAINT [PK_Ecrire]
    PRIMARY KEY CLUSTERED ([Auteurs_id_Auteur], [Ouvrages1_id_ouvrage] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [id_ouvrage] in table 'appartients'
ALTER TABLE [dbo].[appartients]
ADD CONSTRAINT [FK_appartient_Ouvrage]
    FOREIGN KEY ([id_ouvrage])
    REFERENCES [dbo].[Ouvrages]
        ([id_ouvrage])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [id_Auteur] in table 'Ouvrages'
ALTER TABLE [dbo].[Ouvrages]
ADD CONSTRAINT [FK_Ouvrage_Auteur1]
    FOREIGN KEY ([id_Auteur])
    REFERENCES [dbo].[Auteurs]
        ([id_Auteur])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Ouvrage_Auteur1'
CREATE INDEX [IX_FK_Ouvrage_Auteur1]
ON [dbo].[Ouvrages]
    ([id_Auteur]);
GO

-- Creating foreign key on [num_etudiant] in table 'Commandes'
ALTER TABLE [dbo].[Commandes]
ADD CONSTRAINT [FK_Commande_Etudiant]
    FOREIGN KEY ([num_etudiant])
    REFERENCES [dbo].[Etudiants]
        ([num_etudiant])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Commande_Etudiant'
CREATE INDEX [IX_FK_Commande_Etudiant]
ON [dbo].[Commandes]
    ([num_etudiant]);
GO

-- Creating foreign key on [id_Editeur] in table 'Ouvrages'
ALTER TABLE [dbo].[Ouvrages]
ADD CONSTRAINT [FK_Ouvrage_Editeur]
    FOREIGN KEY ([id_Editeur])
    REFERENCES [dbo].[Editeurs]
        ([id_Editeur])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Ouvrage_Editeur'
CREATE INDEX [IX_FK_Ouvrage_Editeur]
ON [dbo].[Ouvrages]
    ([id_Editeur]);
GO

-- Creating foreign key on [id_Editeur] in table 'Ouvrages'
ALTER TABLE [dbo].[Ouvrages]
ADD CONSTRAINT [FK_Ouvrage_Editeur1]
    FOREIGN KEY ([id_Editeur])
    REFERENCES [dbo].[Editeurs]
        ([id_Editeur])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Ouvrage_Editeur1'
CREATE INDEX [IX_FK_Ouvrage_Editeur1]
ON [dbo].[Ouvrages]
    ([id_Editeur]);
GO

-- Creating foreign key on [id_Editeur] in table 'Ouvrages'
ALTER TABLE [dbo].[Ouvrages]
ADD CONSTRAINT [FK_Ouvrage_Editeur2]
    FOREIGN KEY ([id_Editeur])
    REFERENCES [dbo].[Editeurs]
        ([id_Editeur])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Ouvrage_Editeur2'
CREATE INDEX [IX_FK_Ouvrage_Editeur2]
ON [dbo].[Ouvrages]
    ([id_Editeur]);
GO

-- Creating foreign key on [num_etudiant] in table 'Exemplaires'
ALTER TABLE [dbo].[Exemplaires]
ADD CONSTRAINT [FK_Exemplaire_Etudiant]
    FOREIGN KEY ([num_etudiant])
    REFERENCES [dbo].[Etudiants]
        ([num_etudiant])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Exemplaire_Etudiant'
CREATE INDEX [IX_FK_Exemplaire_Etudiant]
ON [dbo].[Exemplaires]
    ([num_etudiant]);
GO

-- Creating foreign key on [id_ouvrage] in table 'Exemplaires'
ALTER TABLE [dbo].[Exemplaires]
ADD CONSTRAINT [FK_Exemplaire_Ouvrage]
    FOREIGN KEY ([id_ouvrage])
    REFERENCES [dbo].[Ouvrages]
        ([id_ouvrage])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Exemplaire_Ouvrage'
CREATE INDEX [IX_FK_Exemplaire_Ouvrage]
ON [dbo].[Exemplaires]
    ([id_ouvrage]);
GO

-- Creating foreign key on [id_prof] in table 'Formations'
ALTER TABLE [dbo].[Formations]
ADD CONSTRAINT [FK_Formation_professour]
    FOREIGN KEY ([id_prof])
    REFERENCES [dbo].[professours]
        ([id_prof])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Formation_professour'
CREATE INDEX [IX_FK_Formation_professour]
ON [dbo].[Formations]
    ([id_prof]);
GO

-- Creating foreign key on [id_ouvrage] in table 'Mise_a_Jour'
ALTER TABLE [dbo].[Mise_a_Jour]
ADD CONSTRAINT [FK_Mise_a_Jour_Ouvrage]
    FOREIGN KEY ([id_ouvrage])
    REFERENCES [dbo].[Ouvrages]
        ([id_ouvrage])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [id_version] in table 'Mise_a_Jour'
ALTER TABLE [dbo].[Mise_a_Jour]
ADD CONSTRAINT [FK_Mise_a_Jour_Version_ouvrage]
    FOREIGN KEY ([id_version])
    REFERENCES [dbo].[Version_ouvrage]
        ([id_version])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Mise_a_Jour_Version_ouvrage'
CREATE INDEX [IX_FK_Mise_a_Jour_Version_ouvrage]
ON [dbo].[Mise_a_Jour]
    ([id_version]);
GO

-- Creating foreign key on [id_ouvrage] in table 'Ouvrages'
ALTER TABLE [dbo].[Ouvrages]
ADD CONSTRAINT [FK_Ouvrage_Ouvrage]
    FOREIGN KEY ([id_ouvrage])
    REFERENCES [dbo].[Ouvrages]
        ([id_ouvrage])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [id_type] in table 'Ouvrages'
ALTER TABLE [dbo].[Ouvrages]
ADD CONSTRAINT [FK_Ouvrage_Type1]
    FOREIGN KEY ([id_type])
    REFERENCES [dbo].[Types]
        ([id_type])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Ouvrage_Type1'
CREATE INDEX [IX_FK_Ouvrage_Type1]
ON [dbo].[Ouvrages]
    ([id_type]);
GO

-- Creating foreign key on [Auteurs_id_Auteur] in table 'Ecrire'
ALTER TABLE [dbo].[Ecrire]
ADD CONSTRAINT [FK_Ecrire_Auteur]
    FOREIGN KEY ([Auteurs_id_Auteur])
    REFERENCES [dbo].[Auteurs]
        ([id_Auteur])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Ouvrages1_id_ouvrage] in table 'Ecrire'
ALTER TABLE [dbo].[Ecrire]
ADD CONSTRAINT [FK_Ecrire_Ouvrage]
    FOREIGN KEY ([Ouvrages1_id_ouvrage])
    REFERENCES [dbo].[Ouvrages]
        ([id_ouvrage])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Ecrire_Ouvrage'
CREATE INDEX [IX_FK_Ecrire_Ouvrage]
ON [dbo].[Ecrire]
    ([Ouvrages1_id_ouvrage]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------