--USE ecfuser

DROP TABLE IF EXISTS product_done;
DROP TABLE IF EXISTS products;
DROP TABLE IF EXISTS product_lines;

CREATE TABLE product_lines
(
line_id CHAR (3) NOT NULL,
line_label VARCHAR(50) NOT NULL,
product_id INT,
PRIMARY KEY (line_id)
);

CREATE TABLE product_done
(
forge_id INT,
forge_date DATE NOT NULL,
forge_quantity INT NOT NULL,
line_id char(3),
product_id INT,
PRIMARY KEY (forge_id)
);

CREATE TABLE products
(
product_id INT,
product_name VARCHAR(128) UNIQUE NOT NULL,
product_value INT NOT NULL,
PRIMARY KEY (product_id)
);

ALTER TABLE product_lines
	ADD FOREIGN KEY(product_id) REFERENCES products(product_id);

ALTER TABLE product_done
	ADD FOREIGN KEY(line_id) REFERENCES product_lines(line_id),
	FOREIGN KEY (product_id) REFERENCES products(product_id);

