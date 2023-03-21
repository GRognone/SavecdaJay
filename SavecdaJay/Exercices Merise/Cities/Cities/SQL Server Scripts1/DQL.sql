--use Cities


--PARTIE 3 DQL = SELECT,CALL

-- 1. Selectionner le nom de toutes les villes

SELECT city_name
FROM cities;

-- 2. Sélectionner l’identifiant et le nom de toutes les villes triées par nom de ville et par ordre alphabétique.

SELECT city_id,city_name
FROM cities
ORDER BY city_name ASC

-- 3. Sélectionner toutes les villes avec le nom du pays associé à chaque ville. Trier la liste par code pays et par ordre alphabétique inverse.

SELECT
city_id AS Ville,
city_name AS 'Nom de la ville',-- renomme les colonnes dans le jeu de résultat
country_name AS 'Nom du pays',-- renomme les colonnes dans le jeu de résultat
countries.country_code AS 'Code du pays'-- renomme les colonnes dans le jeu de résultat
FROM cities JOIN countries ON countries.country_code = cities.country_code
ORDER BY countries.country_code DESC; 

-- 4. Sélectionner le code ISO et le nom de tous les pays avec le nombre de villes par pays. Les pays avec le moins de villes apparaissent en 1er.

SELECT
countries.country_code,
country_name,
COUNT (cities.city_id) AS 'number of cities from countries' -- nomme la colonne de décompte
FROM countries JOIN cities ON countries.country_code = cities.country_code
GROUP BY countries.country_code, country_name;

-- SERT A VERIFIER LE NOMBRE DE VILLE DANS UN PAYS PAR SON CODE.
SELECT
COUNT(*) AS 'number of cities from countries'
FROM cities WHERE country_code = 'FR';

-- 5. Créer la requête SELECT correspondant au résultat suivant : VOIR DOCUMENT

SELECT
C01.country_code,
country_name,
CI1.city_name,
COUNT (CI1.city_id) AS 'number of cities from countries'
FROM countries AS C01
JOIN cities AS CI1 ON C01.country_code = CI1.country_code
JOIN cities AS CI2 ON C01.country_code = CI2.country_code
GROUP BY C01.country_code, country_name, CI1.city_name
ORDER BY 'number of cities from countries' DESC;