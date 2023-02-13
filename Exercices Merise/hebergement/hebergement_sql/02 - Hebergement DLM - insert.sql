-- use Hebergement;--

INSERT INTO Roles
(role_nom)
VALUES
('Admin'), --1
('Directeur'), --2
('Médecin'), --3
('Éducateur'), --4
('Résisdent'); --5

INSERT INTO Personnes
(personne_nom, personne_prenom, personne_ddn, role_id)
VALUES
('DEV', 'MIKE', '1981-11-12', 1),
('Etudiant', 'Gérard', '1977-10-27',1),
('DEV', 'Franck', '2005-09-30', 5);

SELECT * FROM Roles;
SELECT *FROM Personnes;