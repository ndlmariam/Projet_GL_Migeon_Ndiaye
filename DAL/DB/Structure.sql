drop table if exists album;
drop table if exists personne;
drop table if exists marché;

CREATE TABLE album (
  album_id int(11) NOT NULL,primary key auto_increment,
  nom varchar(100)  NOT NULL,
  serie varchar(100)  DEFAULT NULL,
  auteurs varchar(100)  NOT NULL,
  categorie varchar(100)  NOT NULL,
  genre varchar(100)  NOT NULL,
  editeur varchar(100)  NOT NULL,
  couverture varchar(800)  DEFAULT NULL
) ;

CREATE TABLE personne (
  person_id int(11) NOT NULL,primary key auto_increment,
  nom int(11) NOT NULL,
  type varchar(100)  NOT NULL,
  login varchar(100)  NOT NULL,
  mdp varchar(100)  NOT NULL
) ;

CREATE TABLE marché (
  action_id int(11) NOT NULL,primary key auto_increment,
  action_nom varchar(100) NOT NULL,
  personne_id int(11) DEFAULT NULL,
  album_id int(11) NOT NULL,
  date date NOT NULL
) ;