--1. Obtenir l’utilisateur ayant le prénom “Muriel” et le mot de passe “test11”, sachant que l’encodage du mot de passe est 
--effectué avec l’algorithme Sha1.

select * from client
where prenom='Muriel' and [password]=CONVERT(VARCHAR(255),hashbytes('SHA1','test11'),2)
;

--2. Obtenir la liste de tous les produits qui sont présent sur plusieurs commandes.

SELECT 
nom,
COUNT (nom) AS number_of_same_product
FROM commande_ligne
GROUP BY nom
HAVING COUNT (nom)>1
ORDER BY number_of_same_product desc
;

--3. Obtenir la liste de tous les produits qui sont présent sur plusieurs commandes et y ajouter une colonne qui liste les 
--identifiants des commandes associées.

SELECT 
nom,
COUNT (nom) AS number_of_same_product,
STRING_AGG (commande_id, ' , ') AS Command_id -- Sert à regrouper toute les commandes dans une même colonne en 1 seule ligne.
FROM commande_ligne
GROUP BY nom
HAVING COUNT (nom)>1
ORDER BY number_of_same_product DESC
;

--4. Enregistrer le prix total à l’intérieur de chaque ligne des commandes, en fonction du prix unitaire et de la quantité.

UPDATE -- PARTIE UPDATE A INTEGRER AU DML NE PAS LAISSER DANS LE DQL
commande_ligne
SET
prix_total = prix_unitaire * quantite;

SELECT -- PARTIE DU DQL
id,
commande_id,
nom,
quantite,
prix_unitaire,
prix_total
FROM commande_ligne
;

--5. Obtenir le montant total pour chaque commande et y voir facilement la date associée à cette commande ainsi que le 
--prénom et nom du client associé.

SELECT 
commande_ligne.prix_total,
date_achat,
prenom,
client. nom
FROM commande
INNER JOIN commande_ligne ON commande_ligne.id = commande.id 
INNER JOIN client ON client.id = commande.client_id
ORDER BY date_achat
;

--6. (Difficulté très haute) Enregistrer le montant total de chaque commande dans le champ intitulé “cache_prix_total”.

UPDATE -- PARTIE UPDATE A INTEGRER AU DML NE PAS LAISSER DANS LE DQL
commande
SET
cache_prix_total =
	(
		SELECT SUM (prix_total)
		FROM commande_ligne
		WHERE commande_id = commande.id
	)

SELECT -- PARTIE DU DQL
id,
cache_prix_total
FROM commande
;

--7. Obtenir le montant global de toutes les commandes, pour chaque mois.

SELECT
YEAR (date_achat),
DATENAME(MONTH , (date_achat)) AS date_mois_achat,
SUM (cache_prix_total) AS montant_par_mois
FROM commande
GROUP BY MONTH(date_achat), YEAR (date_achat),DATENAME(MONTH , (date_achat))
ORDER BY MONTH(date_achat)
;

--8. Obtenir la liste des 10 clients qui ont effectué le plus grand montant de commandes, et obtenir ce montant total pour 
--chaque client.

SELECT TOP 10
prenom,
nom,
SUM (cache_prix_total) AS montant_par_client
FROM commande
INNER JOIN client ON client.id = commande.client_id
GROUP BY prenom,nom
ORDER BY SUM (cache_prix_total) DESC
;

--9. Obtenir le montant total des commandes pour chaque date.

SELECT
date_achat,
SUM (cache_prix_total) AS montant_date_achat
FROM commande
GROUP BY (date_achat)
ORDER BY (date_achat)
;