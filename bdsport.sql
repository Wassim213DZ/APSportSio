USE bdSport;

CREATE TABLE Sportif (
    idSportif INT AUTO_INCREMENT PRIMARY KEY,
    nom VARCHAR(50) NOT NULL,
    prenom VARCHAR(50) NOT NULL,
    dateNaissance DATE NOT NULL,
    rue VARCHAR(100) NOT NULL,
    codePostal VARCHAR(10) NOT NULL,
    ville VARCHAR(50) NOT NULL,
    niveauExperience VARCHAR(20) NOT NULL,
    nomSport VARCHAR(50) NOT NULL
    );

insert into Sportif(nom,prenom,dateNaissance,rue,codePostal,ville,niveauExperience,nomSport) VALUES
('DAVOLIO', 'Jeanne', '1998-03-15', '12 rue des Lilas', '75001', 'Paris', 'Avance', 'Tennis'),
('MARTIN', 'Julien', '2001-07-22', '5 avenue Victor Hugo', '69002', 'Lyon', 'Confirme', 'Football'),
('DUPONT', 'Emma', '1995-11-09', '8 rue de la Paix', '33000', 'Bordeaux', 'Debutant', 'Natation'),
('BERNARD', 'Lucas', '1999-01-30', '3 rue Pasteur', '59000', 'Lille', 'Professionnel', 'Judo'),
('PETIT', 'Chloe', '2003-05-18', '17 rue du Commerce', '44000', 'Nantes', 'Confirme', 'Basketball'),
('ROBERT', 'Hugo', '1997-09-04', '22 rue de la Republique', '31000', 'Toulouse', 'Avance', 'Rugby'),
('RICHARD', 'Lea', '2000-12-25', '9 rue des Fleurs', '13001', 'Marseille', 'Debutant', 'Course');


