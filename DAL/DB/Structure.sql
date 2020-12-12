drop table if exists livre;
drop table if exists utilisateur;

create table livre (
    book_id integer not null primary key auto_increment,
    isbn varchar(13) not null,
    auteur varchar(100) not null,
	titre varchar(100));

create table utilisateur (
	user_id integer not null primary key auto_increment,
	nom varchar(200) not null,
	prenom varchar(1000) not null
);