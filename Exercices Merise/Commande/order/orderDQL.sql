--1. Obtenir l�utilisateur ayant le pr�nom �Muriel� et le mot de passe �test11�, sachant que l�encodage du mot de passe est 
--effectu� avec l�algorithme Sha1.


--2. Obtenir la liste de tous les produits qui sont pr�sent sur plusieurs commandes.

SELECT 
nom
--commande_id
FROM commande_ligne
order by nom

--3. Obtenir la liste de tous les produits qui sont pr�sent sur plusieurs commandes et y ajouter une colonne qui liste les 
--identifiants des commandes associ�es.


--4. Enregistrer le prix total � l�int�rieur de chaque ligne des commandes, en fonction du prix unitaire et de la quantit�.


--5. Obtenir le montant total pour chaque commande et y voir facilement la date associ�e � cette commande ainsi que le 
--pr�nom et nom du client associ�.


--6. (Difficult� tr�s haute) Enregistrer le montant total de chaque commande dans le champ intitul� �cache_prix_total�.


--7. Obtenir le montant global de toutes les commandes, pour chaque mois.


--8. Obtenir la liste des 10 clients qui ont effectu� le plus grand montant de commandes, et obtenir ce montant total pour 
--chaque client.


--9. Obtenir le montant total des commandes pour chaque date.

