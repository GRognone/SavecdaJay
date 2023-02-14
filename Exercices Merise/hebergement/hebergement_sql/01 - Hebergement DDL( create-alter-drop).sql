 -- use Hebergement;
 DROP TABLE IF EXISTS Activites;
 DROP TABLE IF EXISTS Type_Activites;
 DROP TABLE IF EXISTS Etats;
 DROP TABLE IF EXISTS Roles;
 DROP TABLE IF EXISTS Personnes;

CREATE TABLE Roles 
(
role_id INT IDENTITY (1,1) ,
role_nom VARCHAR (25) NOT NULL UNIQUE,
PRIMARY KEY (role_id)
 );

 CREATE TABLE Personnes
 (
 personne_id INT IDENTITY (1,1),
 personne_nom VARCHAR (50) NOT NULL,
 personne_prenom VARCHAR (50) NOT NULL,
 Personne_ddn DATE NOT NULL,
 role_id INT NOT NULL,
 PRIMARY KEY (personne_id)
  );

  CREATE TABLE Etats
  (
  etat_id INT IDENTITY (1,1),
  etat_intiltule VARCHAR(25),
  PRIMARY KEY (etat_id)
  );

  CREATE TABLE Type_Activites
  (
  type_activite_id INT IDENTITY (1,1),
  type_activite_nom VARCHAR (50) NOT NULL UNIQUE (type_activite_nom) ,
  PRIMARY KEY (type_activite_id)
  );

  CREATE TABLE Activites
  (
  activite_id INT IDENTITY (1,1),
  activite_intitule VARCHAR(100) NOT NULL,
  activite_debut DATETIME2 NOT NULL,
  activite_fin DATETIME2 NOT NULL,
  type_activite_id INT NOT NULL,
  etat_id INT NOT NULL,
  PRIMARY KEY (activite_id),
  FOREIGN KEY (type_activite_id) REFERENCES Type_Activites (type_activite_id),
  FOREIGN KEY (etat_id) REFERENCES Etats ( etat_id)
  );