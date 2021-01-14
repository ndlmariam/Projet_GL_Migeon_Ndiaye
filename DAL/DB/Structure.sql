
drop table if exists album;
drop table if exists personne;
drop table if exists action;

create table album (
  album_id int(11) not null primary key auto_increment,
  nom varchar(255)  not null,
  serie varchar(255) not null ,
  auteurs varchar(255)  not null,
  categorie varchar(255)  not null,
  genre varchar(255)  not null,
  editeur varchar(255) not null,
  couverture varchar(255) ,
  resume mediumtext  not null
) ;

create table personne (
  person_id int(11) not null primary key auto_increment,
  type varchar(255)  not null,
  nom varchar(255) not null,
  login varchar(255)  not null,
  mdp varchar(255)  not null
) ;

create table action (
  action_id int(11) not null primary key auto_increment,
  action_nom varchar(255) not null,
  date date not null,
  album_id integer not null,
  person_id integer not null,
  foreign key (album_id) references album(album_id),
  foreign key (person_id) references personne(person_id)
) ;



