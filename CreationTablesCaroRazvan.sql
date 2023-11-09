-- ===========================================================================
-- fichier : CreationTablesCaroRazvan.sql				
-- Projet 2
-- ===========================================================================



USE B56Projet2Equipe7

Print  'Création de la base de données pour la gestion des clubs de golf'
print ''
Print  'Destruction des tables...'

IF OBJECT_ID ('Depenses') is not null 
DROP TABLE Depenses;
IF OBJECT_ID ('Services') is not null 
DROP TABLE "Services";
IF OBJECT_ID ('Employes') is not null 
DROP TABLE Employes;
IF OBJECT_ID ('TypesEmploye') is not null 
DROP TABLE TypesEmploye;
IF OBJECT_ID ('Dependants') is not null 
DROP TABLE Dependants;
IF OBJECT_ID ('PartiesJouees') is not null 
DROP TABLE PartiesJouees;
IF OBJECT_ID ('Terrains') is not null 
DROP TABLE Terrains;
IF OBJECT_ID ('Reabonnements') is not null 
DROP TABLE Reabonnements;
IF OBJECT_ID ('Abonnements') is not null 
DROP TABLE Abonnements;
IF OBJECT_ID ('Provinces') is not null
DROP TABLE Provinces;
IF OBJECT_ID ('PrixDepensesAbonnements') is not null 
DROP TABLE PrixDepensesAbonnements;
IF OBJECT_ID ('TypesAbonnement') is not null 
DROP TABLE TypesAbonnement;


PRINT ''
PRINT 'Création des tables ========================================================'
PRINT ''

PRINT  'Création de la table TypesAbonnement...'
CREATE TABLE TypesAbonnement(
  No			INT NOT NULL UNIQUE,
  Description	VARCHAR(100) NOT NULL,
  Remarque		VARCHAR(100),
  CONSTRAINT pk_TypesAbonnement PRIMARY KEY(No)
 );

PRINT  'Création de la table PrixDepensesAbonnements...'
CREATE TABLE PrixDepensesAbonnements(
  NoTypeAbonnement		INT NOT NULL,
  Annee					NUMERIC NOT NULL,
  Prix					MONEY NOT NULL,
  DepensesObligatoires	MONEY NOT NULL,
  Remarque				VARCHAR(100),
  CONSTRAINT pk_PrixDepensesAbonnements PRIMARY KEY(NoTypeAbonnement,Annee),
  CONSTRAINT fk_PrixDepensesTypesAbonnement FOREIGN KEY (NoTypeAbonnement) REFERENCES TypesAbonnement(No)
 );

PRINT  'Création de la table Provinces...'
CREATE TABLE Provinces(
  Id			VARCHAR(2) NOT NULL UNIQUE,
  Nom			VARCHAR(100) NOT NULL,
  Remarque		VARCHAR(100),
  CONSTRAINT pk_Provinces PRIMARY KEY(Id)
 );

PRINT  'Création de la table Abonnements...'
CREATE TABLE Abonnements(
  Id				VARCHAR(100) NOT NULL UNIQUE,
  DateAbonnement	DATE NOT NULL,
  Nom				VARCHAR(100) NOT NULL,
  Prenom			VARCHAR(100) NOT NULL,
  Sexe				VARCHAR(1) NOT NULL,
  DateNaissance		DATE NOT NULL,
  NoCivique			INT NOT NULL,
  Rue				VARCHAR(100) NOT NULL,
  Ville				VARCHAR(100) NOT NULL,
  IdProvince		VARCHAR(2) NOT NULL,
  CodePostal		VARCHAR(6) NOT NULL,
  Telephone			NUMERIC(10) NOT NULL,
  Cellulaire		NUMERIC(10),
  Courriel			VARCHAR(100) NOT NULL,
  NoTypeAbonnement	INT NOT NULL,
  Remarque			VARCHAR(100),
  CONSTRAINT pk_Abonnements PRIMARY KEY(Id),
  CONSTRAINT fk_AbonnementsProvinces FOREIGN KEY (IdProvince) REFERENCES Provinces(Id),
  CONSTRAINT fk_AbonnementsTypesAbonnement FOREIGN KEY (NoTypeAbonnement) REFERENCES TypesAbonnement(No)
 );

PRINT  'Création de la table Reabonnements...'
CREATE TABLE Reabonnements(
  IdAbonnement			VARCHAR(100) NOT NULL,
  DateRenouvellement	DATE NOT NULL,
  Remarque				VARCHAR(100),
  CONSTRAINT pk_Reabonnements PRIMARY KEY(IdAbonnement,DateRenouvellement),
  CONSTRAINT fk_ReabonnementsAbonnements FOREIGN KEY (IdAbonnement) REFERENCES Abonnements(Id)
 );

PRINT  'Création de la table Terrains...'
CREATE TABLE Terrains(
  No			INT NOT NULL UNIQUE,
  Nom			VARCHAR(100) NOT NULL,
  NombreTrous	INT NOT NULL,
  Description	VARCHAR(100) NOT NULL,
  Remarque		VARCHAR(100),
  CONSTRAINT pk_Terrains PRIMARY KEY (No),
 );

PRINT  'Création de la table PartiesJouees...'
CREATE TABLE PartiesJouees(
  IdAbonnement		VARCHAR(100) NOT NULL,
  NoTerrain			INT NOT NULL,
  DatePartie		DATE NOT NULL,
  Pointage			INT NOT NULL,
  Remarque			VARCHAR(100),
  CONSTRAINT pk_PartiesJouees PRIMARY KEY (IdAbonnement,NoTerrain,DatePartie),
  CONSTRAINT fk_PartiesJoueesTerrains FOREIGN KEY (NoTerrain) REFERENCES Terrains(No),
  CONSTRAINT fk_PartiesJoueesAbonnements FOREIGN KEY (IdAbonnement) REFERENCES Abonnements(Id)
 );

PRINT  'Création de la table Dependants...'
CREATE TABLE Dependants(
  Id				VARCHAR(100) NOT NULL UNIQUE,
  Nom				VARCHAR(100) NOT NULL,
  Prenom			VARCHAR(100) NOT NULL,
  Sexe				VARCHAR(1) NOT NULL,
  DateNaissance		DATE NOT NULL,
  IdAbonnement		VARCHAR(100) NOT NULL,
  Remarque			VARCHAR(100),
  CONSTRAINT pk_Dependants PRIMARY KEY (Id),
  CONSTRAINT fk_DependantsAbonnements FOREIGN KEY (IdAbonnement) REFERENCES Abonnements(Id)
 );

PRINT  'Création de la table TypesEmploye...'
CREATE TABLE TypesEmploye(
  No				INT NOT NULL UNIQUE,
  Description		VARCHAR(100) NOT NULL,
  Remarque			VARCHAR(100),
  CONSTRAINT pk_TypesEmploye PRIMARY KEY (No),
 );

PRINT  'Création de la table Employes...'
CREATE TABLE Employes(
  No				INT NOT NULL UNIQUE,
  MotDePasse		VARCHAR(100) NOT NULL,
  Nom				VARCHAR(100) NOT NULL,
  Prenom			VARCHAR(100) NOT NULL,
  Sexe				VARCHAR(1) NOT NULL,
  Age				INT NOT NULL,
  NoCivique			INT NOT NULL,
  Rue				VARCHAR(100) NOT NULL,
  Ville				VARCHAR(100) NOT NULL,
  IdProvince		VARCHAR(2) NOT NULL,
  CodePostal		VARCHAR(6) NOT NULL,
  Telephone			NUMERIC(10) NOT NULL,
  Cellulaire		NUMERIC(10),
  Courriel			VARCHAR(100) NOT NULL,
  SalaireHoraire	MONEY NOT NULL,
  NoTypeEmploye		INT NOT NULL,
  Remarque			VARCHAR(100),
  CONSTRAINT pk_Employes PRIMARY KEY(No),
  CONSTRAINT fk_EmployesProvinces FOREIGN KEY (IdProvince) REFERENCES Provinces(Id),
  CONSTRAINT fk_EmployesTypesEmploye FOREIGN KEY (NoTypeEmploye) REFERENCES TypesEmploye(No)
 );

PRINT  'Création de la table Services...'
CREATE TABLE Services(
  No				INT NOT NULL UNIQUE,
  TypeService		VARCHAR(100) NOT NULL,
  NoEmploye			INT NOT NULL,
  Remarque			VARCHAR(100),
  CONSTRAINT pk_Services PRIMARY KEY(No),
  CONSTRAINT fk_ServicesEmployes FOREIGN KEY (NoEmploye) REFERENCES Employes(No)
 );

PRINT  'Création de la table Depenses...'
CREATE TABLE Depenses(
  No				INT NOT NULL UNIQUE,
  IdAbonnement		VARCHAR(100) NOT NULL,
  DateDepense		DATE NOT NULL,
  Montant			MONEY NOT NULL,
  NoService			INT NOT NULL,
  Remarque			VARCHAR(100),
  CONSTRAINT pk_Depenses PRIMARY KEY(No),
  CONSTRAINT fk_DepensesAbonnements FOREIGN KEY (IdAbonnement) REFERENCES Abonnements(Id),
  CONSTRAINT fk_DepensesServices FOREIGN KEY (NoService) REFERENCES Services(No)
 );


PRINT ''
PRINT 'Ajout de données dans les tables ==========================================='
PRINT ''

PRINT  'Ajouts dans TypesAbonnement...'
INSERT INTO TypesAbonnement(No, Description)
VALUES (1, 'Personne seule'), (2, 'Âge d''or'), (3, 'Couple'),
(4, 'Famille (couple + 1 enfant)'), (5, 'Famille (couple + 2 enfants)'), (6, 'Famille (couple + 3 enfants ou plus)');

PRINT  'Ajouts dans PrixDepensesAbonnements...'
INSERT INTO PrixDepensesAbonnements(NoTypeAbonnement,Annee,Prix,DepensesObligatoires)
VALUES (1, 2023, 850, 400), (2, 2023, 500, 400), (3, 2023, 1200, 700),
(4, 2023, 1700, 700), (5, 2023, 1900, 700), (6, 2023, 2100, 700);

PRINT  'Ajouts dans Provinces...'
INSERT INTO Provinces(Id,Nom)
VALUES ('AB','Alberta'), ('BC','Colombie-Britannique'), ('MB','Manitoba'), ('NB','Nouveau-Brunswick'),
('NL','Terre-Neuve et Labrador'), ('NT','Territoires du Nord-Ouest'), ('NS','Nouvelle-Écosse'), ('NU','Nunavut'),
('ON','Ontario'), ('PE','Île-du-Prince-Édouard'), ('QC','Québec'), ('SK','Saskatchewan'), ('YT','Territoire du Yukon');

PRINT  'Ajouts dans Terrains...'
INSERT INTO Terrains(No, Nom, NombreTrous, Description)
VALUES (1, 'Golf et Fun', 18, 'Situé à: St-Lazare'), (2, 'Golf en Famille', 18, 'Situé à: Vaudreuil'),
(3, 'Terrier du Lapin', 18, 'Situé à: Les Cèdres'), (4, 'Terrain de Saint-Clet', 9, 'Situé à: Saint-Clet'),
(5, 'La Maison du Golf', 9, 'Situé à: Coteau-du-Lac'), (6, 'Terrain de la Marmotte', 9, 'Situé à: Sainte-Marthe');

PRINT  'Ajouts dans TypesEmploye...'
INSERT INTO TypesEmploye(No, Description, Remarque)
VALUES (1, 'Administrateur', 'Il n''y en a qu''un et son numéro est 1'), (2, 'Direction',''), (3, 'Propriétaire d''un club',''),
(4, 'Employé d''un club',''), (5, 'Employé Pro-Shop',''), (6, 'Employé d''un restaurant',''), (7, 'Professeur de golf','');

PRINT  'Ajouts de l''administrateur...'
INSERT INTO Employes
VALUES (1,'Password1','St-Pierre','George','H',40,888,'Rue des Mésanges','Vaudreuil',
'QC','J7J2J7','4444043234','8889942345','georgep2@gmail.com', 35.55 , 1, 'Admin');