drop table if exists album;
drop table if exists personne;
drop table if exists marché;

CREATE TABLE `album` (
  `album_id` int(11) NOT NULL,primary key auto_increment,
  `nom` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `serie` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `auteurs` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `categorie` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `genre` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `editeur` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `couverture` varchar(800) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

CREATE TABLE `personne` (
  `person_id` int(11) NOT NULL,primary key auto_increment,
  `nom` int(11) NOT NULL,
  `type` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `login` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `mdp` varchar(100) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

CREATE TABLE `marché` (
  `action_id` int(11) NOT NULL,primary key auto_increment,
  `action_nom` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `personne_id` int(11) DEFAULT NULL,
  `album_id` int(11) NOT NULL,
  `date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;