use videoclub

	DROP IF EXIST emprunts;
	DROP IF EXIST clients;
	DROP IF EXIST adresses;
	DROP IF EXIST etats;
	DROP IF EXIST cassettes;
	DROP IF EXIST realisateurs;
	DROP IF EXIST acteurs;
	DROP IF EXIST films;
	

	CREATE TABLE emprunts
	(
	emprunt_id INT IDENTITY(1,1),
	emprunt_date DATETIME2 NOT NULL DEFAULT CURRENT_TIMESTAMP,
	PRIMARY KEY (emprunt_id)
	);

	CREATE TABLE clients
	(
	client_id INT IDENTITY (1,1),
	client_nom VARCHAR(100) NOT NULL,
	client_prenom VARCHAR(100) NOT NULL,
	client_caution DECIMAL(5,2) NOT NULL,
	PRIMARY KEY(client_id)
	);

	CREATE TABLE adresses
	(
	adresse_id INT IDENTITY (1,1),
	adresse_numero_de_voie	SMALLINT NOT NULL,
	adresse_numero_de_voie_complement VARCHAR(10),
	adresse_type_de_voie VARCHAR(16) NOT NULL,
	adresse_nom_de_voie VARCHAR(50) NOT NULL,
	adresse_complement VARCHAR(100), 
	adresse_code_postal CHAR(5) NOT NULL,
	adresse_ville VARCHAR(50) NOT NULL,
	PRIMARY KEY( adresse_id)
	);

	CREATE TABLE etats
	(

	PRIMARY KEY (etat_id)
	);
	CREATE TABLE cassettes
	(

	PRIMARY KEY (cassette_id)
	);
	

	CREATE TABLE relalisateurs
	(

	PRIMARY KEY (realisateur_id)
	);

	CREATE TABLE acteurs
	(

	PRIMARY KEY (acteur_id)
	);
	CREATE TABLE films
	(

	PRIMARY KEY (film_id)
	);
	