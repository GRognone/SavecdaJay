
DROP TABLE IF EXISTS departement;
DROP TABLE IF EXISTS villes_france_free;


CREATE TABLE departement
(
  departement_id int NOT NULL,
  departement_code varchar(3) DEFAULT NULL,
  departement_nom varchar(255) DEFAULT NULL,
  departement_nom_uppercase varchar(255) DEFAULT NULL,
  departement_slug varchar(255) DEFAULT NULL,
  departement_nom_soundex varchar(20) DEFAULT NULL,
  PRIMARY KEY (departement_id),
) ;

ALTER TABLE departement
	ADD CONSTRAINT PK_departement PRIMARY KEY (departement_id),
		CONSTRAINT FR_departement FOREIGN KEY (ville_id) REFERENCES departement(departement_id);

CREATE TABLE villes_france_free
(
  ville_id int NOT NULL,
  ville_departement varchar(3) DEFAULT NULL,
  ville_slug varchar(255) DEFAULT NULL,
  ville_nom varchar(45) DEFAULT NULL,
  ville_nom_simple varchar(45) DEFAULT NULL,
  ville_nom_reel varchar(45) DEFAULT NULL,
  ville_nom_soundex varchar(20) DEFAULT NULL,
  ville_nom_metaphone varchar(22) DEFAULT NULL,
  ville_code_postal varchar(255) DEFAULT NULL,
  ville_commune varchar(3) DEFAULT NULL,
  ville_code_commune varchar(5) NOT NULL,
  ville_arrondissement smallint DEFAULT NULL,
  ville_canton varchar(4) DEFAULT NULL,
  ville_amdi smallint DEFAULT NULL,
  ville_population_2010 int DEFAULT NULL,
  ville_population_1999 int DEFAULT NULL,
  ville_population_2012 int DEFAULT NULL,
  ville_densite_2010 int DEFAULT NULL,
  ville_surface float DEFAULT NULL,
  ville_longitude_deg float DEFAULT NULL,
  ville_latitude_deg float DEFAULT NULL,
  ville_longitude_grd varchar(9) DEFAULT NULL,
  ville_latitude_grd varchar(8) DEFAULT NULL,
  ville_longitude_dms varchar(9) DEFAULT NULL,
  ville_latitude_dms varchar(8) DEFAULT NULL,
  ville_zmin int DEFAULT NULL,
  ville_zmax int DEFAULT NULL,
  PRIMARY KEY (ville_id),
  UNIQUE (ville_code_commune),
  UNIQUE (ville_slug)
  
) ;
