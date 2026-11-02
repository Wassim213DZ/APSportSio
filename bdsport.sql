CREATE DATABASE IF NOT EXISTS bdSport;
USE bdSport;

CREATE TABLE utilisateur (
    id INT AUTO_INCREMENT PRIMARY KEY,
    login VARCHAR(50) NOT NULL,
    motDePasse VARCHAR(50) NOT NULL
);


CREATE TABLE sport (
    idSport INT AUTO_INCREMENT PRIMARY KEY,
    nomSport VARCHAR(50) NOT NULL
);


CREATE TABLE niveau (
    idNiveau INT AUTO_INCREMENT PRIMARY KEY,
    libelleNiveau VARCHAR(50) NOT NULL
);


CREATE TABLE sportif (
    idSportif INT AUTO_INCREMENT PRIMARY KEY,
    nom VARCHAR(50) NOT NULL,
    prenom VARCHAR(50) NOT NULL,
    dateNaissance DATE NOT NULL,
    ville VARCHAR(50) NOT NULL,
    niveauExperience VARCHAR(50) NOT NULL,
    nomSport VARCHAR(50) NOT NULL
);


INSERT INTO utilisateur (login, motDePasse) VALUES ('admin', 'admin');


INSERT INTO sportif (nom, prenom, dateNaissance, ville, niveauExperience, nomSport) VALUES 
('Dupont', 'Thomas', '1998-05-12', 'Paris', 'Confirme', 'Football'),
('Martin', 'Chloe', '2001-09-23', 'Lyon', 'Debutant', 'Tennis'),
('Bernard', 'Lucas', '1995-02-15', 'Marseille', 'Professionnel', 'Basketball'),
('Thomas', 'Sarah', '1999-11-04', 'Paris', 'Avance', 'Natation'),
('Petit', 'Alexandre', '2003-07-30', 'Bordeaux', 'Debutant', 'Judo');