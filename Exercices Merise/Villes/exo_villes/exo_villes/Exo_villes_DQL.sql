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
Villes_dept.ville_nom_reel,
Villes_dept.ville_population_2012,
Villes_dept.ville_departement
FROM villes_france_free AS Villes_dept
JOIN villes_france_free AS nom_ville_departement ON  Villes_dept.ville_departement = nom_ville_departement.departement_code
ORDER BY ville_population_2012 DESC;

-- 5. Obtenir la liste du nom de chaque département, associé à son code et du nombre de commune au sein de ces
-- département, en triant afin d’obtenir en priorité les départements qui possèdent le plus de communes

-- 6. Obtenir la liste des 10 plus grands départements, en termes de superficie

-- 7. Compter le nombre de villes dont le nom commence par “Saint”

-- 8. Obtenir la liste des villes qui ont un nom existants plusieurs fois, et trier afin d’obtenir en premier celles dont le nom est
-- le plus souvent utilisé par plusieurs communes

-- 9. Obtenir en une seule requête SQL la liste des villes dont la superficie est supérieur à la superficie moyenne

-- 10. Obtenir la liste des départements qui possèdent plus de 2 millions d’habitants

-- 11. Remplacez les tirets par un espace vide, pour toutes les villes commençant par “SAINT-” (dans la colonne qui contient
-- les noms en majuscule).
