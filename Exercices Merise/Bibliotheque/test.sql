USE Biblio2210;

/*
	DML : Data Modeling Language
		INSERT : Inserer des données dans une table
		UPDATE : modifier des données existantes dans une table
		DELETE : supprimer des données d'une table
		TRUNCATE : vider une table et reinitialiser les compteurs (auto increment)
*/
-- Vider une table et réinitialiser les compteurs (ceci- ne fonctionne pas avec SQLSERVER DANS LE CAS OU LA TABLE EST REFERENCE DANS UNE AUTRE TABLE)
--TRUNCATE TABLE editeurs;
--TRUNCATE TABLE auteurs;

-- supprimer les données d'une table
-- les 2 instructions suivantes remplacent le TRUNCATE (uniquement SQLSERVER)


DELETE FROM livres; -- supprimer toutes les données de la table
DBCC CHECKIDENT('livres', RESEED, 0); -- ( table choisie, repartie de , valeur dela ligne d'où on veut repartir) reinitialise la colonne auto incrementé

DELETE FROM etats_livres;
DBCC CHECKIDENT('etats_livres', RESEED, 0);

DELETE FROM editeurs; 
DBCC CHECKIDENT('editeurs', RESEED, 0); 

DELETE FROM auteurs;
DBCC CHECKIDENT('auteurs', RESEED, 0);

INSERT INTO editeurs
(editeur_nom)
VALUES
('toto'),
('tata'),
('titi');

INSERT INTO auteurs -- avec cette solution l'ordre nom prenom n'a pas 'importance lors de la saisie de la valeur et sera affiché dans l'ordre choisi dans la table 
(auteur_prenom, auteur_nom)
VALUES
('Gérard', 'Rognone'),
('Mike', 'Devoldere');

	/*INSERT INTO auteurs -- non recommandé à eviter.
	VALUES
	('Rognone', 'Gérard');*/

INSERT INTO etats_livres
(etat_livre_nom)
VALUES
('neuf'),--1
('très bon état'),
('bon état'),
('bof'),
('abimé'),
('très abime');--6

INSERT INTO livres
(livre_isbn, livre_titre, livre_date_achat,etat_livre_id,editeur_id)
VALUES
('472-1', 'SQL pour les nuls', '31-01-2022', 1, 1);


	-- Mettre à jour un enregistrement
UPDATE auteurs
SET auteur_nom = 'EtAutreChose'--met à jour auteur_nom qui prends la valeur 'comprise entre les tremas '
WHERE auteur_id =2;--qui est situé à la ligne auteur_id  = numero; 
-- <> signifie est different de qui équivaut à !=

UPDATE auteurs
SET auteur_nom ='Dev', auteur_prenom ='Toto'
WHERE auteur_id = 1;

SELECT * FROM editeurs; -- pour afficher les données saisies dans la table.
SELECT * FROM auteurs;
SELECT * FROM livres;
SELECT * FROM etats_livres;
