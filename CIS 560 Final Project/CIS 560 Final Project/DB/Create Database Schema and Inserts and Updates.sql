--CREATE SCHEMA Clinic
--GO

DROP TABLE IF EXISTS Clinic.PetAilment
DROP TABLE IF EXISTS Clinic.Ailment
DROP TABLE IF EXISTS Clinic.Visit
DROP TABLE IF EXISTS Clinic.Vet
DROP TABLE IF EXISTS Clinic.Pet
DROP TABLE IF EXISTS Clinic.Owner
DROP TABLE IF EXISTS Clinic.Breed
DROP TABLE IF EXISTS Clinic.Clinic

CREATE TABLE Clinic.Clinic(
  ClinicId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
  Name NVARCHAR(64) NOT NULL,
  UNIQUE(
    Name ASC
  )
);

CREATE TABLE Clinic.Owner(
  OwnerId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
  ClinicId INT NOT NULL FOREIGN KEY
		REFERENCES Clinic.Clinic(ClinicId), -- ?
  PhoneNumber NVARCHAR(15) NOT NULL,
  FirstName NVARCHAR(32) NOT NULL,
  LastName NVARCHAR(32) NOT NULL, 
  HappinessPercent DECIMAL NOT NULL,
  UNIQUE(
    PhoneNumber ASC 
  )
);

CREATE TABLE Clinic.Breed(
  BreedId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
  Species NVARCHAR(64) NOT NULL
);

CREATE TABLE Clinic.Pet(
  PetId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
  OwnerId INT NOT NULL FOREIGN KEY
		REFERENCES Clinic.Owner(OwnerId), 
  BreedId INT NOT NULL FOREIGN KEY
		REFERENCES Clinic.Breed(BreedId),
  [Name] NVARCHAR(32) NOT NULL UNIQUE, 
  BirthDate DATETIME NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
);

CREATE TABLE Clinic.Vet(
  VetId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
  Name NVARCHAR(32) NOT NULL,
);

CREATE TABLE Clinic.Visit(
  VisitId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
  PetId INT NOT NULL FOREIGN KEY
		REFERENCES Clinic.Pet(PetId),
  VetId INT NOT NULL FOREIGN KEY
		REFERENCES Clinic.Vet(VetId),
  VisitedOn DATETIME NOT NULL DEFAULT(SYSDATETIMEOFFSET()) UNIQUE,
  Weight DECIMAL NOT NULL,
);

CREATE TABLE Clinic.Ailment(
  AilmentId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
  Symptoms NVARCHAR(64) NOT NULL,
  Name NVARCHAR(32) NOT NULL,
  UNIQUE(
    Name ASC
  )
);

CREATE TABLE Clinic.PetAilment(
  PetAilmentId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
  AilmentId INT NOT NULL FOREIGN KEY
		REFERENCES Clinic.Ailment(AilmentId) UNIQUE,
  PetId INT NOT NULL FOREIGN KEY 
		REFERENCES Clinic.Pet(PetId) UNIQUE,
  IsActive BIT NOT NULL, 
);

--works
INSERT Clinic.Clinic([Name])
	VALUES (N'The Fun Palace')

--works
INSERT Clinic.Owner(ClinicId, PhoneNumber, FirstName, LastName, HappinessPercent)
SELECT C.ClinicId, O.PhoneNumber, O.FirstName, O.LastName, O.HappinessPercent
FROM
	(
		VALUES
			(N'The Fun Palace', N'7858675309', N'Payton', N'The Legend', 69)
	) O([Name], PhoneNumber, FirstName, LastName, HappinessPercent)
INNER JOIN Clinic.Clinic C ON C.[Name] = O.[Name]

--works ezpz
INSERT Clinic.Breed(Species)
	VALUES(N'Pikachu')

--works
INSERT Clinic.Vet([Name])
	VALUES(N'Dr. FeelGood')

--works but depends on owner/breed :P
INSERT Clinic.Pet(OwnerId, BreedId, [Name], BirthDate)
SELECT O.OwnerId, B.BreedId, P.[Name], P.BirthDate
FROM 
	(
		VALUES
			(N'7858675309', N'Pikachu', N'SomePetName', '2011-11-14 16:00:00')	
	) P(PhoneNumber, Species, [Name], BirthDate)
INNER JOIN Clinic.Owner O ON O.PhoneNumber = P.PhoneNumber
INNER JOIN Clinic.Breed B ON B.Species = P.Species

-- needs a vet and a pet NOT DONE WANT NAP
INSERT Clinic.Visit(VetId, PetId, VisitedOn, [Weight])
SELECT VET.VetId, P.PetId, CV.VisitedOn, CV.[Weight]
FROM
	(
		VALUES
			(N'Dr. FeelGood', N'SomePetName', '2019-02-05 18:00:00', 420)
	) CV([Name], PetName,  VisitedOn, [Weight])
INNER JOIN Clinic.Vet VET ON VET.[Name] = CV.[Name]
INNER JOIN Clinic.Pet P ON P.[Name] = CV.PetName


/*This all prolly works, but you have to have a clinic, owner, breed, then pet in the table that fits this shaz*/


INSERT Clinic.Ailment([Name], Symptoms)
	VALUES (N'Spring Fever', N'Causes a problem or something idk')

INSERT Clinic.PetAilment(AilmentId, PetId, IsActive)
SELECT A.AilmentId, P.PetId, PA.IsActive
FROM
	(
		VALUES
			(N'Spring Fever', N'SomePetName', 1)
	) PA([Name], PetName, IsActive)
INNER JOIN Clinic.Ailment A ON A.[Name] = PA.[Name]
INNER JOIN Clinic.Pet P ON P.[Name] = PA.PetName

SELECT *
FROM Clinic.[Owner] O
INNER JOIN Clinic.Pet P ON P.OwnerId = O.OwnerId
INNER JOIN Clinic.Visit Vi ON Vi.PetId = P.PetId
INNER JOIN Clinic.PetAilment PA ON PA.PetId = P.PetId
INNER JOIN Clinic.Ailment A ON A.AilmentId = PA.AilmentId

--works i think
UPDATE PA
SET
	IsActive = 0
FROM Clinic.PetAilment PA
INNER JOIN Clinic.Pet P ON P.PetId = PA.PetId
INNER JOIN Clinic.Ailment A ON A.AilmentId = PA.AilmentId
WHERE P.[Name] = N'SomePetName' AND A.[Name] = N'Spring Fever'

--help it works
UPDATE O
SET
	HappinessPercent = 70
FROM Clinic.[Owner] O
WHERE O.PhoneNumber = N'7858675309'

