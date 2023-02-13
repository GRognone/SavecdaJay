 -- use Hebergement;

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