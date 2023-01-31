/*
pour faire des commentaires multi lignes
*/
-- commentaire sur une ligne

--Sélection de la base de donnée "Biblio2210"

use Biblio2210; /* pour selectionner la base de donnée à gerer */

; /* pour valider l'instruction*/

-- DDL : CREATE / ALTER / DROP (Data Definition Language)

/*CREATE TABLE editeurs 
(
editeur_id INT PRIMARY KEY IDENTITY (1, 1) /* (1 Signifie le numéro de départ, 1 apres la virgule signifi le pas de l'incrementation)*/ MS SQLSERVER
editeur_id INT PRIMARY KEY AUTO_INCREMENT -- MYSQL ou MariaDB
editeur_id INT PRIMARY KEY SERIAL --postgresql
editeur_id INT PRIMARY KEY AUTOINCREMENT -- sqlite

);
*/
DROP TABLE IF EXISTS livres_auteur;
DROP TABLE IF EXISTS livres;
DROP TABLE IF EXISTS etats_livres;
DROP TABLE IF EXISTS auteurs;
DROP TABLE IF EXISTS editeurs; /* pour supprimer table éditeurs*/ 

CREATE TABLE editeurs 
(
editeur_id INT PRIMARY KEY IDENTITY (1, 1), /* (1 Signifie le numéro de départ, 1 apres la virgule signifi le pas de l'incrementation) --1 ere facon de déclarer une clé primaire */ 
editeur_nom VARCHAR(100) NOT NULL -- DEFAUT 'editeurs inconnu'
);


CREATE TABLE auteurs
(
auteur_id INT IDENTITY (1,1), 
auteur_nom VARCHAR(100) NOT NULL,
auteur_prenom VARCHAR(100) NULL, --apres la dernière instuction de la table pas de virgule
PRIMARY KEY (auteur_id) --2eme facon de déclarer une clé primaire SYNTAXE RECOMMANDEE
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
 livre_isbn CHAR(17) NOT NULL,
 livre_titre VARCHAR(255) NOT NULL,
 livre_date_achat DATE NOT NULL DEFAULT CURRENT_TIMESTAMP,-- DEFAULT CURRENT_TIMESTAMP si aucune date d'achat n'est entrée un prendra la date à l'instant t de l'entree utilisateur
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

 ALTER TABLE livres_auteur
	ADD FOREIGN KEY (auteur_id) REFERENCES auteurs(auteur_id),
	CONSTRAINT FK_TOTO FOREIGN KEY (livre_id) REFERENCES livres(livre_id);


 /*ALTER TABLE auteurs/*modifier les elements d'une table*/
 ADD PRIMARY KEY (auteur_id); --3 eme solution pour déclarer une clé primaire de la table*/
