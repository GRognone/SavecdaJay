/*
pour faire des commentaires multi lignes
*/
-- commentaire sur une ligne

--S�lection de la base de donn�e "Biblio2210"

use Biblio2210; /* pour selectionner la base de donn�e � gerer */

; /* pour valider l'instruction*/

-- DDL : CREATE / ALTER / DROP (Data Definition Language)

/*CREATE TABLE editeurs 
(
editeur_id INT PRIMARY KEY IDENTITY (1, 1) /* (1 Signifie le num�ro de d�part, 1 apres la virgule signifi le pas de l'incrementation)*/ MS SQLSERVER
editeur_id INT PRIMARY KEY AUTO_INCREMENT -- MYSQL ou MariaDB
editeur_id INT PRIMARY KEY SERIAL --postgresql
editeur_id INT PRIMARY KEY AUTOINCREMENT -- sqlite

);
*/
DROP TABLE IF EXISTS emprunts;
DROP TABLE IF EXISTS clients;
DROP TABLE IF EXISTS adresses;
DROP TABLE IF EXISTS livres_auteur;
DROP TABLE IF EXISTS livres;
DROP TABLE IF EXISTS etats_livres;
DROP TABLE IF EXISTS auteurs;
DROP TABLE IF EXISTS editeurs; /* pour supprimer table �diteurs*/ 


CREATE TABLE editeurs 
(
editeur_id INT PRIMARY KEY IDENTITY (1, 1), /* (1 Signifie le num�ro de d�part, 1 apres la virgule signifi le pas de l'incrementation) --1 ere facon de d�clarer une cl� primaire */ 
editeur_nom VARCHAR(100) NOT NULL -- DEFAUT 'editeurs inconnu'
);


CREATE TABLE auteurs
(
auteur_id INT IDENTITY (1,1), 
auteur_nom VARCHAR(100) NOT NULL,
auteur_prenom VARCHAR(100) NULL, --apres la derni�re instuction de la table pas de virgule
PRIMARY KEY (auteur_id) --2eme facon de d�clarer une cl� primaire SYNTAXE RECOMMANDEE
);


 CREATE TABLE	etats_livres
 (
 etat_livre_id INT IDENTITY (1,1),
 etat_livre_nom VARCHAR(50),
 PRIMARY KEY (etat_livre_id)
 );

 CREATE TABLE livres
 (
 livre_id INT IDENTITY(1,1),
 livre_isbn CHAR(17) NOT NULL UNIQUE,
 livre_titre VARCHAR(255) NOT NULL,
 livre_date_achat DATE NOT NULL DEFAULT CURRENT_TIMESTAMP,-- DEFAULT CURRENT_TIMESTAMP si aucune date d'achat n'est entr�e un prendra la date � l'instant t de l'entree utilisateur
 livre_etat_commentaire VARCHAR(1000) NULL,
 etat_livre_id INT NOT NULL,
 editeur_id INT NOT NULL,
 PRIMARY KEY (livre_id),
 FOREIGN KEY (etat_livre_id) REFERENCES  etats_livres(etat_livre_id),
 CONSTRAINT FK_livres_editeur FOREIGN KEY (editeur_id) REFERENCES  editeurs(editeur_id),
  );

 CREATE TABLE livres_auteur
 (
 auteur_id INT,
 livre_id INT,
 PRIMARY KEY (auteur_id, livre_id)-- cle primaire composee
 );


  CREATE TABLE adresses
 (
 adresse_id INT IDENTITY(1,1),
 adresse_numero SMALLINT,
 adresse_extention VARCHAR(10),
 adresse_voie VARCHAR (50),
 adresse_complement VARCHAR (50),
 adresse_ville VARCHAR (50),
 adresse_code_postal CHAR(5),
 PRIMARY KEY (adresse_id),
   );


 CREATE TABLE clients
 (
 client_id INT IDENTITY (1,1),
 client_nom VARCHAR (100) NOT NULL,
 client_prenom VARCHAR (100) NOT NULL,
 client_caution DECIMAL (5,2) CHECK (client_caution > 0 AND client_caution< 100), --  CHECK () veut dire regarde si la caution du client est bien comprise entre 0 et 100
 adresse_id INT NOT NULL,
 PRIMARY KEY (client_id),
 FOREIGN KEY (adresse_id) REFERENCES adresses(adresse_id),
 );

 
  CREATE TABLE emprunts
 (
 emprunt_id INT IDENTITY (1,1),
 emprunt_date DATETIME2 NOT NULL DEFAULT CURRENT_TIMESTAMP,
 client_id INT NOT NULL,
 livre_id INT NOT NULL,
 PRIMARY KEY (emprunt_id),
 FOREIGN KEY (client_id) REFERENCES clients(client_id),
 CONSTRAINT FK_emprunts_livres FOREIGN KEY (livre_id) REFERENCES  livres(livre_id),
 );


 ALTER TABLE livres_auteur
	ADD FOREIGN KEY (auteur_id) REFERENCES auteurs(auteur_id),
	CONSTRAINT FK_TOTO FOREIGN KEY (livre_id) REFERENCES livres(livre_id);


 /*ALTER TABLE auteurs/*modifier les elements d'une table*/
 ADD PRIMARY KEY (auteur_id); --3 eme solution pour d�clarer une cl� primaire de la table*/

