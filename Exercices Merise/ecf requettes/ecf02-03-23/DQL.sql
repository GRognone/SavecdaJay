--USE ecfuser

--Queries1

SELECT
product_id,
product_name,
product_value
FROM products
ORDER BY product_value
;

--Queries2

SELECT
product_name
FROM products
WHERE product_name LIKE '%X'
;

--Queries3
SELECT
line_id,
line_label
FROM product_line
WHERE line_label LIKE '%PR%'
;

--Queries4

SELECT
product_name,
product_value,
line_label
FROM products
INNER JOIN product_line ON product_line.product_id = products.product_id
;

--Queries5

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

--Queries6

SELECT
PL1.line_id,
line_label,
PRD1.forge_quantity ,
P01.product_id
FROM product_LINE AS PL1
INNER JOIN products AS P01 ON  PL1.product_id = P01.product_id
LEFT JOIN product_done AS PRD1 ON PL1.product_id = PRD1.product_id
GROUP BY PL1.line_id,line_label,forge_quantity,P01.product_id
;

--Queries7

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

--Queries8

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

SELECT
sum (product_value * forge_quantity) AS PRODS_TOTAL_VALUE
FROM products
INNER JOIN product_done ON products.product_id = product_done.product_id
