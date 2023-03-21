--use Cars

INSERT INTO Brands
(brand_name, brand_slogan)
VALUES
('Chevrolet','Un vrai plus'), --1
('Audi','Vorsprung durch Technik'),-- 2
('Toyota','Always a Better Way'), --3
('Peugeot','Motion & Emotion '),--4
('AMC','Si vous deviez vous battre contre GM, Ford et Chrysler, que feriez-vous?')--5

INSERT INTO Owners
(owner_lastname, owner_firstname)
VALUES
('Petit','Annie'),--1
('Marshall','Bénédicte'),--2
('Doe','John'),--3
('Bouchra','Amine'),--4
('Jones','Steeven')--5

INSERT INTO Cars
(car_id, car_registration, car_name, brand_id, car_owner_id)
VALUES
(12, 'AA-123-AA', 'Chevelle Concours',1,1),
(16, 'BB-274-BB', 'A6 Break',2,5),
(21, 'CA-789-BA', 'Corolla',3,2),
(19, 'CC-546-FV', 'Monte Carlo',1,4),
(27, 'CG-274-ZG', '504',4,4),
(30, 'ER-355-GX', 'Q8',2,3),
(28, 'FV-313-FT', '100 LS',2,5),
(23, 'DE-228-KS', 'Hornet',5,5),
(26, 'CF-614-PM', '3008',4,5);

SELECT * FROM Cars;
SELECT * FROM Owners;
SELECT * FROM Brands;