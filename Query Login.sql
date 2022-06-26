CREATE DATABASE Banco_Americano;

USE Banco_Americano;

CREATE TABLE login(
usuario VARCHAR(40)NOT NULL,
contrasena VARCHAR(70)NOT NULL 
);

SELECT * FROM login;

INSERT INTO login
VALUES ("Admin", "Password");

INSERT INTO login
VALUES ("Root", "123");


