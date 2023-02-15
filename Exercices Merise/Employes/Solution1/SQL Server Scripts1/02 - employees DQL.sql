-- use employees ( nom de la base de donn�e)

--1. S�lectionner le nom, pr�nom et salaire de tous les employ�s tri�s par date d�embauche de la plus ancienne � la plus 
--r�cente.
SELECT
emp_lastname,
emp_firstname,
emp_salary,
emp_hiredate
FROM employees
ORDER BY emp_hiredate ASC;


--2. S�lectionner le nom, salaire, date d�embauche de tous les employ�s tri�s par identifiant de manager (croissant) puis par 
--nom (ordre alphab�tique).

SELECT
emp_lastname,
emp_salary,
emp_hiredate,
emp_manager_id
FROM employees
ORDER BY emp_manager_id ASC, emp_lastname ASC;

--3. S�lectionner le nom, pr�nom, salaire, date d�embauche, nom et pr�nom du manager de tous les employ�s. Trier la liste par 
--nom de manager (ordre croissant) puis par date d�embauche de la plus r�cente � la plus ancienne.

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



--4. S�lectionner les employ�s sans manager.

SELECT * FROM employees WHERE emp_manager_id IS NULL;

--5. S�lectionner le pr�nom et nom de tous les managers avec, pour chacun, le nombre de leur subordonn�s. Les managers 
--avec le moins de subordonn�s apparaissent en 1er

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

-- cette instruction v�rifie s'il y a effectivement 5 employ�es qui son manadg� par le manager N�5
SELECT COUNT(*) AS 'count subordinate'
FROM employees
WHERE employees.emp_manager_id = 5;

--6. S�lectionner le nom de tous les managers avec, pour chacun, la moyenne des salaires de leur subordonn�s. Trier le r�sultat 
--selon la valeur de la moyenne par ordre d�croissant.

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

-- cette instruction v�rifie s'il y a effectivement 5 employ�es qui son manadg� par le manager N�5
SELECT COUNT(*) AS 'count subordinate'
FROM employees
WHERE employees.emp_manager_id = 5;


--7. Cr�er la requ�te SELECT correspondant au r�sultat suivant :( voir document)

