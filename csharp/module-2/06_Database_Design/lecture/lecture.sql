--let's write a creat script >:)

--switch to using the system database

USE master;
GO --batch separator, run the command and then move onto the next step

DROP DATABASE IF EXISTS ArtGallery

CREATE DATABASE ArtGallery;
GO

--in order to add tables and stuff to the ArtGallery DB, you gotta use the ArtGallery DB
USE ArtGallery;
GO

--now we start adding tables

CREATE TABLE customer (

customer_id INT IDENTITY(1,1), --IDENTITY is a MS SQL Server auto-incrementing column
customer_name VARCHAR(50) NOT NULL,
address VARCHAR(100) NOT NULL,
phone VARCHAR(14) NOT NULL,

--Add the orimary key constraint 
--CONSTRAINT (constraint name) TYPE (column name)
CONSTRAINT pk_customer PRIMARY KEY (customer_id)
);

CREATE TABLE artwork(
artwork_id INT IDENTITY(1,1),
description VARCHAR(50), -- we will let the description be null
title VARCHAR(50) NOT NULL,
artist_id INT NOT NULL,

CONSTRAINT pk_artwork PRIMARY KEY (artwork_id),
CONSTRAINT fk_artist FOREIGN KEY (artist_id) REFERENCES artist(artist_id)
--CONSTRAINT name FOREIGN KEY (column name) REFERENCES table name (column name)
);

CREATE TABLE artwork_customer(
customer_id INT NOT NULL, --the id is coming from another table so no IDENTITY here
artwork_id INT NOT NULL, 
purchase_date DATE NOT NULL,
price INT NOT NULL,

CONSTRAINT pk_artwork_customer PRIMARY KEY (customer_id, artwork_id) --composite key based on two columns
CONSTRAINT fk_artwork_customer_customer FOREIGN KEY (customer_id) REFERENCES customer(customer_id);

COMMIT;