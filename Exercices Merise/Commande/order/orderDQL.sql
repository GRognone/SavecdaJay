--1. Obtenir l’utilisateur ayant le prénom “Muriel” et le mot de passe “test11”, sachant que l’encodage du mot de passe est 
--effectué avec l’algorithme Sha1.


--2. Obtenir la liste de tous les produits qui sont présent sur plusieurs commandes.

SELECT 
nom
--commande_id
FROM commande_ligne
order by nom

--3. Obtenir la liste de tous les produits qui sont présent sur plusieurs commandes et y ajouter une colonne qui liste les 
--identifiants des commandes associées.


--4. Enregistrer le prix total à l’intérieur de chaque ligne des commandes, en fonction du prix unitaire et de la quantité.


--5. Obtenir le montant total pour chaque commande et y voir facilement la date associée à cette commande ainsi que le 
--prénom et nom du client associé.


--6. (Difficulté très haute) Enregistrer le montant total de chaque commande dans le champ intitulé “cache_prix_total”.


--7. Obtenir le montant global de toutes les commandes, pour chaque mois.


--8. Obtenir la liste des 10 clients qui ont effectué le plus grand montant de commandes, et obtenir ce montant total pour 
--chaque client.


--9. Obtenir le montant total des commandes pour chaque date.

