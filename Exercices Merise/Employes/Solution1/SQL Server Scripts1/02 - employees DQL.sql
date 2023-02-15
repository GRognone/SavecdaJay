-- use employees ( nom de la base de donnée)

--1. Sélectionner le nom, prénom et salaire de tous les employés triés par date d’embauche de la plus ancienne à la plus 
--récente.
SELECT
emp_lastname,
emp_firstname,
emp_salary,
emp_hiredate
FROM employees
ORDER BY emp_hiredate ASC;


--2. Sélectionner le nom, salaire, date d’embauche de tous les employés triés par identifiant de manager (croissant) puis par 
--nom (ordre alphabétique).

SELECT
emp_lastname,
emp_salary,
emp_hiredate,
emp_manager_id
FROM employees
ORDER BY emp_manager_id ASC, emp_lastname ASC;

--3. Sélectionner le nom, prénom, salaire, date d’embauche, nom et prénom du manager de tous les employés. Trier la liste par 
--nom de manager (ordre croissant) puis par date d’embauche de la plus récente à la plus ancienne.

SELECT
E0.emp_lastname,
E0.emp_firstname,
E0.emp_salary,
E0.emp_hiredate,
E0.emp_manager_id,
E1.emp_id AS 'Manager id',
E1.emp_lastname AS 'Manager last name',
E1.emp_lastname AS 'Manager first name'
FROM employees AS E0
LEFT JOIN employees AS E1 ON E0.emp_manager_id = E1.emp_id
ORDER BY E1.emp_lastname ASC, E0.emp_hiredate DESC;



--4. Sélectionner les employés sans manager.

SELECT * FROM employees WHERE emp_manager_id IS NULL;

--5. Sélectionner le prénom et nom de tous les managers avec, pour chacun, le nombre de leur subordonnés. Les managers 
--avec le moins de subordonnés apparaissent en 1er

SELECT
Man1.emp_lastname,
Man1.emp_firstname,
COUNT(Emp1.emp_id) AS 'Manager_count'
FROM employees AS Man1
JOIN employees AS Emp1 ON Man1.emp_id = Emp1.emp_manager_id
GROUP BY 
Man1.emp_lastname,
Man1.emp_firstname
ORDER BY 
manager_count asc;

-- cette instruction vérifie s'il y a effectivement 5 employées qui son manadgé par le manager N°5
SELECT COUNT(*) AS 'count subordinate'
FROM employees
WHERE employees.emp_manager_id = 5;

--6. Sélectionner le nom de tous les managers avec, pour chacun, la moyenne des salaires de leur subordonnés. Trier le résultat 
--selon la valeur de la moyenne par ordre décroissant.

SELECT
Man1.emp_lastname,
AVG(Emp2.emp_SALARY) AS 'Salary_avarage',
(SELECT AVG (Emp2.emp_salary) FROM employees Emp2 WHERE Emp2.emp_manager_id = Man1.emp_id AS 'Luc'
FROM employees AS Man1
JOIN employees AS Emp1 ON Man1.emp_id = Emp1.emp_manager_id
GROUP BY 
Man1.emp_lastname,
ORDER BY 
Luc asc;

-- cette instruction vérifie s'il y a effectivement 5 employées qui son manadgé par le manager N°5
SELECT COUNT(*) AS 'count subordinate'
FROM employees
WHERE employees.emp_manager_id = 5;


--7. Créer la requête SELECT correspondant au résultat suivant :( voir document)

