-- 1. Obtenir la liste des 10 villes les plus peuplées en 2012

SELECT TOP 10
ville_nom_reel,
ville_population_2012
FROM villes_france_free
ORDER BY ville_population_2012 DESC;

-- 2. Obtenir la liste des 50 villes ayant la plus faible superficie

SELECT TOP 50
ville_nom_reel,
ville_surface
FROM villes_france_free
ORDER BY ville_surface ASC;

-- 3. Obtenir la liste des départements d’outres-mer, c’est-à-dire ceux dont le numéro de département commencent par
-- “97”

SELECT
departement_nom,
departement_code
FROM departement
WHERE departement_code LIKE '97%'
ORDER BY departement_code ASC;


-- 4. Obtenir le nom des 10 villes les plus peuplées en 2012, ainsi que le nom du département associé

SELECT TOP 10
ville_nom_reel,
ville_population_2012,
departement_nom
FROM villes_france_free AS Villes_dept
JOIN departement AS dept ON  Villes_dept.ville_departement = dept.departement_code
ORDER BY ville_population_2012 DESC;

-- 5. Obtenir la liste du nom de chaque département, associé à son code et du nombre de commune au sein de ces
-- département, en triant afin d’obtenir en priorité les départements qui possèdent le plus de communes

SELECT
departement_nom,
departement_code,
COUNT (Villes_dept.ville_departement) AS 'number cities by department'
FROM departement AS Dept
JOIN villes_france_free AS Villes_dept ON Dept.departement_code = Villes_dept.ville_departement
GROUP BY departement_nom,
departement_code
ORDER BY 'number cities by department' DESC

-- 6. Obtenir la liste des 10 plus grands départements, en termes de superficie

SELECT TOP 10
departement_nom,
sum (ville_surface) AS 'area department'
FROM departement AS Dept
JOIN villes_france_free AS Villes_dept ON Dept.departement_code = Villes_dept.ville_departement
GROUP BY departement_nom
ORDER BY 'area department' desc

-- 7. Compter le nombre de villes dont le nom commence par “Saint”

SELECT
count (ville_nom) AS 'Cities name begin by Saint'
FROM villes_france_free
WHERE ville_nom like 'Saint%'
ORDER BY 'Cities name begin by Saint' ASC;

-- 8. Obtenir la liste des villes qui ont un nom existants plusieurs fois, et trier afin d’obtenir en premier celles dont le nom est
-- le plus souvent utilisé par plusieurs communes

SELECT
ville_nom,
count (ville_nom) AS 'Cities with the same name'
FROM villes_france_free
GROUP BY ville_nom
ORDER BY 'Cities with the same name' DESC

-- 9. Obtenir en une seule requête SQL la liste des villes dont la superficie est supérieur à la superficie moyenne

SELECT
V2.ville_nom,
V2.ville_surface,
AVG (V1.ville_surface) AS 'Medium area'
FROM villes_france_free AS V1
JOIN villes_france_free AS V2 ON V2.ville_surface >0 --??? pourquoi
GROUP BY V2.ville_nom, V2.ville_surface
HAVING V2.ville_surface > AVG (V1.ville_surface)
ORDER BY V2.ville_surface

-- 10. Obtenir la liste des départements qui possèdent plus de 2 millions d’habitants


-- 11. Remplacez les tirets par un espace vide, pour toutes les villes commençant par “SAINT-” (dans la colonne qui contient
-- les noms en majuscule).
