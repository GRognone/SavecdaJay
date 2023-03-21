-- use Hebergement;

SELECT * FROM Personnes;

SELECT
personne_id AS 'Identifiant', -- renomme la colonne personne id en identifiant.
personne_nom AS 'Son Nom',
personne_prenom As 'Son Prenom'
FROM Personnes;

SELECT * FROM Personnes ORDER BY personne_prenom ASC; -- tri par ordre alphabethique
SELECT * FROM Personnes ORDER BY personne_prenom DESC; -- tri par ordre décroissant


SELECT * FROM Personnes
WHERE personne_ddn >= '2000'; -- affiche toutes les personne depuis 2000

SELECT * FROM Personnes
WHERE Personne_ddn BETWEEN '2000-01-01' AND '2005-12-31'; --affiche les personnes nées entre 2000 et 2005

SELECT * FROM Personnes --affiche toutes les personnes nées au mois d'octobre
WHERE MONTH (Personne_ddn) = '10';

SELECT * FROM Personnes --affiche toutes les personnes nées au mois d'octobre ( moins performant)
WHERE Personne_ddn LIKE '%-10-%';

SELECT 
personne_id,
personne_prenom AS 'Prénom'
FROM Personnes
WHERE personne_id >= 2
ORDER BY personne_nom DESC; -- affiche toutes les personnes dont el role est supérieur à 2 mais les classes par ordre alphabethique des noms des personnes.

SELECT * FROM Personnes
JOIN Roles ON Personnes.role_id = Roles.role_id-- il prends toutes les personnes et verifie le role qu'elles occupent.
WHERE personne_id >= 2; --affichera toutes les personnes dont le role est supérieur ou égal à 2.
