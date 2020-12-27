-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : Dim 27 déc. 2020 à 11:22
-- Version du serveur :  10.4.11-MariaDB
-- Version de PHP : 7.4.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `bdtheque`
--

-- --------------------------------------------------------

--
-- Structure de la table `action`
--

CREATE TABLE `action` (
  `action_id` int(11) NOT NULL,
  `action_nom` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `personne_id` int(11) DEFAULT NULL,
  `album_id` int(11) NOT NULL,
  `date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `action`
--

INSERT INTO `action` (`action_id`, `action_nom`, `personne_id`, `album_id`, `date`) VALUES
(1, 'AjoutMarché', 7, 5, '2020-12-01'),
(2, 'AjoutMarché', 7, 2, '2020-12-02'),
(3, 'AjoutMarché', 7, 1, '2020-12-17'),
(53, 'Achat', 1, 5, '2020-12-27');

-- --------------------------------------------------------

--
-- Structure de la table `album`
--

CREATE TABLE `album` (
  `album_id` int(11) NOT NULL,
  `nom` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `serie` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `auteurs` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `categorie` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `genre` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `editeur` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `couverture` varchar(800) COLLATE utf8_unicode_ci DEFAULT NULL,
  `resume` varchar(800) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `album`
--

INSERT INTO `album` (`album_id`, `nom`, `serie`, `auteurs`, `categorie`, `genre`, `editeur`, `couverture`, `resume`) VALUES
(1, 'Tintin au Tibet', 'Les Aventures de Tintin', 'Hergé', 'BD', 'Aventure', 'Casterman', 'Tintin au Tibet.jpg', ''),
(2, 'Folle à lier', 'Harley Quinn', 'Jimmy Palmiotti (Scénario) / \r\n\r\nAmanda Conner (Scénario) / \r\n\r\nChad Hardin (Dessin)', 'BD', 'Super-héro', 'Urban Comics', 'Folle à lier.jpg', ''),
(5, 'La ferme abandonnée', 'Sylvain et Sylvette', 'Jean-Louis Pesch', 'BD', 'Humour', NULL, 'La ferme abandonnée.jpg', '');

-- --------------------------------------------------------

--
-- Structure de la table `personne`
--

CREATE TABLE `personne` (
  `personne_id` int(11) NOT NULL,
  `nom` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `type` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `login` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `mdp` varchar(100) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `personne`
--

INSERT INTO `personne` (`personne_id`, `nom`, `type`, `login`, `mdp`) VALUES
(1, 'Agathe', 'User', 'agathe', 'mdp'),
(7, 'AgAdmin', 'Admin', 'agathe', 'admin');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `action`
--
ALTER TABLE `action`
  ADD PRIMARY KEY (`action_id`);

--
-- Index pour la table `album`
--
ALTER TABLE `album`
  ADD PRIMARY KEY (`album_id`);

--
-- Index pour la table `personne`
--
ALTER TABLE `personne`
  ADD PRIMARY KEY (`personne_id`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `action`
--
ALTER TABLE `action`
  MODIFY `action_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=54;

--
-- AUTO_INCREMENT pour la table `album`
--
ALTER TABLE `album`
  MODIFY `album_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT pour la table `personne`
--
ALTER TABLE `personne`
  MODIFY `personne_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
