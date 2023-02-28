
DROP TABLE IF EXISTS commande_ligne;
DROP TABLE IF EXISTS commande;
DROP TABLE IF EXISTS client;

CREATE TABLE  client (
  id int NOT NULL,
  prenom varchar(255) NOT NULL,
  nom varchar(255) NOT NULL,
  email varchar(255) NOT NULL,
  ville varchar(255) NOT NULL,
  [password] varchar(255) NOT NULL,
  PRIMARY KEY (id)
);

CREATE TABLE commande (
  id int NOT NULL,
  client_id int NOT NULL,
  date_achat date NOT NULL,
  reference varchar(255) NOT NULL,
  cache_prix_total float NOT NULL,
  PRIMARY KEY (id)
);

CREATE TABLE commande_ligne (
  id int NOT NULL,
  commande_id int NOT NULL,
  nom varchar(255) NOT NULL,
  quantite int NOT NULL,
  prix_unitaire float NOT NULL,
  prix_total float NOT NULL,
  PRIMARY KEY (id)
) ;