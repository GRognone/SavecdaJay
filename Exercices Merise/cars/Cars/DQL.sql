--use Cars

--1. S�lectionner le nom et le num�ro d�immatriculation de toutes les voitures tri�es par immatriculation (ordre croissant).

SELECT
car_name,
car_registration
FROM Cars
ORDER BY car_registration ASC;

--2. S�lectionner toutes les informations de toutes les voitures, incluant le nom de la marque ainsi que le nom et pr�nom du 
--propri�taire. Trier la liste par nom de marque (ordre croissant) puis par nom de propri�taire (ordre croissant).

SELECT
car_id,
car_name,
car_registration,
brand_name,
owner_lastname,
owner_firstname
FROM Cars 
JOIN Brands ON Brands.brand_id = Cars.brand_id
JOIN Owners ON Owners.owner_id = car_owner_id
ORDER BY brand_name ASC, owner_lastname ASC;

--3. S�lectionner le nom de toutes les marques incluant le nombre de voitures de chaque marque.
SELECT
brand_name AS 'Brand',
COUNT (car_id) AS 'Number of cars by brand'
FROM Cars
JOIN Brands ON Brands.brand_id = Cars.brand_id
GROUP BY brand_name;

--4. S�lectionner le nom de toutes les marques incluant le nombre de propri�taires de chaque marque.
SELECT
brand_name,
COUNT(DISTINCT car_owner_id) AS 'Number of Owners by brand'
FROM Cars
JOIN Brands ON Brands.brand_id = Cars.brand_id
JOIN Owners ON Owners.owner_id = Cars.car_owner_id
GROUP BY brand_name;

--5. S�lectionner les pr�noms des propri�taires dont le pr�nom commence par la lettre A.
SELECT
owner_firstname
FROM Owners
WHERE owner_firstname LIKE'A%';

--6. S�lectionner le noms et pr�nom des propri�taires dont le pr�nom contient plus de 5 lettres.
SELECT
owner_lastname,
owner_firstname
FROM Owners
GROUP BY owner_lastname, owner_firstname
HAVING LEN (owner_lastname) > 5; -- LEN signifie length

--7. S�lectionner les noms et pr�noms des propri�taires poss�dant plus d�une voiture avec le nombre de voitures poss�d�es 
--par propri�taire. Trier la liste par nombre de voitures poss�d�es. Les propri�taires poss�dant le plus de voitures
--apparaissent en 1er.
SELECT
owner_lastname,
owner_firstname,
COUNT(car_owner_id) AS 'Number of Cars by Owner'
FROM Cars
JOIN Brands ON Brands.brand_id = Cars.brand_id
JOIN Owners ON Owners.owner_id = Cars.car_owner_id
GROUP BY owner_firstname,owner_lastname
HAVING COUNT (car_owner_id)>1
ORDER BY ('Number of Cars by Owner')DESC;

--8. S�lectionner les noms et pr�noms des propri�taires poss�dant plus d�une voiture de m�me marque. Pour chaque marque 
--de voiture trouv�e, afficher le nom de la marque et le nombre de voiture poss�d�es pour cette marque.

SELECT
owner_lastname,
owner_firstname,
brand_name,
brand_slogan,
COUNT(car_owner_id) AS 'Number of brand Cars by Owner'
FROM Cars
JOIN Brands ON Brands.brand_id = Cars.brand_id
JOIN Owners ON Owners.owner_id = Cars.car_owner_id
GROUP BY brand_name, owner_firstname, owner_lastname,brand_slogan
HAVING COUNT (car_owner_id)>1
ORDER BY ('Number of brand Cars by Owner')DESC;