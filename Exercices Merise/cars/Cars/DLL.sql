-- use Cars

DROP TABLE IF EXISTS Brands;
DROP TABLE IF EXISTS Owners;
DROP TABLE IF EXISTS Cars;


CREATE TABLE Brands
(
	brand_id INT IDENTITY,
	brand_name VARCHAR(50) NOT NULL,
	brand_slogan VARCHAR (255) NULL,
	PRIMARY KEY (brand_id)
);

CREATE TABLE Owners
(
	owner_id INT IDENTITY,
	owner_lastname VARCHAR(50) NOT NULL,
	owner_firstname VARCHAR(50) NOT NULL,
	PRIMARY KEY (owner_id)
);
CREATE TABLE Cars
(
	car_id INT,
	car_registration CHAR(9) UNIQUE NOT NULL,
	car_name VARCHAR (100) NOT NULL,
	car_owner_id INT NOT NULL,
	brand_id INT NOT NULL,
	PRIMARY KEY (car_id),
);
ALTER TABLE Cars
	ADD CONSTRAINT FK_Cars_Owners FOREIGN KEY (car_owner_id) REFERENCES Owners(owner_id),
	CONSTRAINT FK_Cars_Brands FOREIGN KEY (brand_id) REFERENCES Brands(brand_id)


	SELECT * FROM Cars;
	SELECT * FROM Brands;
	SELECT * FROM Owners;