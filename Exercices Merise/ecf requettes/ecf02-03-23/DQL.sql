--USE ecfuser

--1 Selectionner tous les micro-processeurs tri�s par valeur commerciale (product_value).

SELECT
product_id,
product_name,
product_value
FROM products
ORDER BY product_value
;

--2 S�lectionner les CPUs dont le nom se termine par la lettre "X".

SELECT
product_name
FROM products
WHERE product_name LIKE '%X'
;

--3 Selectionner les lignes de production dont le lib�ll�contient la chaine "PR".
SELECT
line_id,
line_label
FROM product_line
WHERE line_label LIKE '%PR%'
;

--4 Selectionner le nom, le prix de tous les microprocesseurs.
--Pour chaque CPU list�, on doit conna�tre le libell� de la ligne de production associ�e.

SELECT
product_name,
product_value,
line_label
FROM products
INNER JOIN product_line ON product_line.product_id = products.product_id
;

--5- S�lectionner les productions termin�es dont le nombre de CPU produits d�passe 20.
--La requ�te doit retourner le nom du CPU, son prix, le libell� de la ligne de production et le nombre d�unit�s produites.

SELECT
P01.product_name,
product_value,
line_label,
forge_quantity
FROM products AS P01
INNER JOIN product_done ON P01.product_id = product_done.product_id
INNER JOIN product_line ON P01.product_id = product_line.product_id
GROUP BY P01.product_name,product_value,line_label,forge_quantity
having (forge_quantity) >20
;

--6- S�lectionner toutes les lignes de production (identifiant, libell�) avec le nombre TOTAL d�unit�s produites
--par ligne de production ainsi que l�identifiant du CPU associ�.

SELECT
PL1.line_id,
line_label,
PRD1.forge_quantity ,
P01.product_id
FROM product_line AS PL1
INNER JOIN products AS P01 ON  PL1.product_id = P01.product_id
LEFT JOIN product_done AS PRD1 ON PL1.product_id = PRD1.product_id
GROUP BY PL1.line_id,line_label,forge_quantity,P01.product_id
;

--7- M�me requ�te que la pr�c�dente mais en ne s�lectionnant que les lignes de production qui ont produit au moins 1 unit�.

SELECT
PL1.line_id,
line_label,
forge_quantity,
P01.product_id
FROM products AS P01
INNER JOIN product_done ON P01.product_id = product_done.product_id
INNER JOIN product_line AS PL1 ON P01.product_id = PL1.product_id
GROUP BY PL1.line_id,line_label,forge_quantity,P01.product_id
;

--8- Afficher la valeur totale de tous les CPUs d�j� produits avec le nom du CPU ayant rapport� le plus, toute production confondues.

SELECT TOP 1 
(SELECT
sum (product_value * forge_quantity) AS PRODS_TOTAL_VALUE
FROM products
INNER JOIN product_done ON products.product_id = product_done.product_id) 
as toto,
product_name
FROM products
INNER JOIN product_done ON products.product_id = product_done.product_id
GROUP BY product_value,product_name,forge_quantity
ORDER BY  sum (product_value * forge_quantity) DESC

