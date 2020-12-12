drop table if exists album;
drop table if exists personne;

create table album(
    album_id integer not null primary key auto_increment,
    nom varchar(100) not null,
    serie varchar(100),
    auteurs varchar(100) not null,
    categorie varchar(100) not null,
    genre varchar(100) not null,
    editeur varchar(100) not null,
    couverture varchar(100) );

create table personne (
	person_id integer not null primary key auto_increment,
	type varchar(100) not null,
	login varchar(100) not null,
        mdp varchar(100) not null
);