-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : ven. 15 jan. 2021 à 13:51
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
  `action_nom` varchar(255) NOT NULL,
  `date` datetime NOT NULL,
  `album_id` int(11) DEFAULT NULL,
  `person_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `action`
--

INSERT INTO `action` (`action_id`, `action_nom`, `date`, `album_id`, `person_id`) VALUES
(1, 'AjoutMarché', '2020-12-01 00:00:00', 1, 2),
(2, 'AjoutMarché', '2020-12-02 00:00:00', 2, 2),
(3, 'AjoutMarché', '2020-12-02 00:00:00', 3, 2),
(4, 'AjoutMarché', '2020-12-02 00:00:00', 4, 2),
(5, 'AjouterSouhait', '2020-12-02 00:00:00', 1, 3),
(8, 'AjoutMarché', '2020-12-02 00:00:00', 5, 2),
(9, 'AjoutMarché', '2020-12-02 00:00:00', 6, 2),
(10, 'AjoutMarché', '2020-12-02 00:00:00', 7, 2),
(11, 'AjoutMarché', '2020-12-02 00:00:00', 8, 2),
(12, 'AjoutMarché', '2020-12-02 00:00:00', 9, 2),
(13, 'AjoutMarché', '2020-12-02 00:00:00', 10, 2),
(14, 'AjoutMarché', '2020-12-02 00:00:00', 11, 2),
(15, 'AjoutMarché', '2020-12-02 00:00:00', 12, 2),
(16, 'AjoutMarché', '2020-12-02 00:00:00', 13, 2),
(17, 'AjoutMarché', '2020-12-02 00:00:00', 14, 2),
(18, 'AjoutMarché', '2020-12-02 00:00:00', 15, 2),
(19, 'AjoutMarché', '2020-12-02 00:00:00', 16, 2),
(20, 'AjoutMarché', '2020-12-02 00:00:00', 17, 2),
(21, 'AjoutMarché', '2020-12-02 00:00:00', 18, 2),
(22, 'AjoutMarché', '2020-12-02 00:00:00', 19, 2),
(23, 'AjoutMarché', '2020-12-02 00:00:00', 20, 2),
(24, 'AjoutMarché', '2020-12-02 00:00:00', 21, 2),
(25, 'AjoutMarché', '2020-12-02 00:00:00', 22, 2),
(26, 'AjoutMarché', '2020-12-02 00:00:00', 23, 2),
(27, 'AjoutMarché', '2020-12-02 00:00:00', 24, 2),
(28, 'Achat', '2021-01-15 13:46:15', 3, 1),
(29, 'Achat', '2021-01-15 13:46:19', 2, 1);

-- --------------------------------------------------------

--
-- Structure de la table `album`
--

CREATE TABLE `album` (
  `album_id` int(11) NOT NULL,
  `nom` varchar(255) NOT NULL,
  `serie` varchar(255) DEFAULT NULL,
  `auteurs` varchar(255) NOT NULL,
  `categorie` varchar(255) NOT NULL,
  `genre` varchar(255) NOT NULL,
  `editeur` varchar(255) DEFAULT NULL,
  `couverture` varchar(255) DEFAULT NULL,
  `resume` mediumtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `album`
--

INSERT INTO `album` (`album_id`, `nom`, `serie`, `auteurs`, `categorie`, `genre`, `editeur`, `couverture`, `resume`) VALUES
(1, 'Tintin au Tibet', 'Les Aventures de Tintin', 'Hergé', 'BD', 'Aventure', 'Casterman', 'Tintin au Tibet.jpg', 'Un avion de ligne à bord duquel le jeune Chinois Tchang se rendait en Europe s\'est écrasé dans l\'Himalaya. Tintin, son ami, va donc partir à sa recherche.'),
(2, 'Folle à lier', 'Harley Quinn', 'Jimmy Palmiotti, Amanda Conner, Chad Hardin', 'BD', 'Super-héro', 'Urban Comics', 'Folle à lier.jpg', 'Un jour Power Girl vient s\'écraser aux pieds d\'Harley Quinn. Frappée d\'amnésie, la puissante Kryptonienne se retrouve malgré elle entrainée dans les missions abracadabrantesques de sa coéquipière autoproclamée. '),
(3, 'La ferme abandonnée', 'Sylvain et Sylvette', 'Jean-Louis Pesch', 'BD', 'Humour', 'Dargaud', 'La ferme abandonnée.jpg', 'Ces récits pour la jeunesse relatent les aventures de Sylvain et Sylvette, deux enfants d\'environ douze ans, le frère et la sœur, qui, s\'étant un jour égarés, vivent dans une forêt en compagnie d\'animaux domestiques.'),
(4, 'L\'étoile mystérieuse', 'Les Aventures de Tintin', 'Hergé', 'BD', 'Aventure', 'Casterman', 'LetoileMysterieuse.jpg19', 'On entend à la radio qu une météorite s est écrasée dans l océan Arctique.'),
(5, 'Après moi l\'déluge', 'ENO ONE', 'Polpine, Anton Lavigne', 'BD', 'Aventure', 'Theloma', 'EnoOne.JPG23', 'Pas facile de se retrouver seul et désœuvré dans un Paris quasiment désertique, ravagé par une sècheresse historique. C\'est ce que vit Eno One, contrôleur des bacs de récupération d\'eau de pluie des bords de Seine. Jusqu\'au jour où la capitale est submergée par un raz de marée. '),
(6, 'Astérix et Cléopatre', 'Astérix', 'Goscinny, Uderzo', 'BD', 'Humour', 'Dargaud', 'AsterixetCleopatre.JPG21', 'Dans cette aventure, la Reine Cléopâtre ne supporte plus les critiques de Jules César sur son peuple égyptien, ses superstitions et sa culture. Afin de lui prouver que l\'Égypte est toujours incarnée par un grand peuple, elle fait le pari de construire un nouveau palais en moins de trois mois.'),
(7, 'Aux sources du Z', 'Spirou et Fantasio', 'Morvan, Yann, Munuera', 'BD', 'Aventure', 'Dupuis', 'AuxSourcesDuZ.JPG19', 'Zorglub, contre la volonté du comte de Champignac, demande l\'aide de Spirou. Miss Flanner est mourante, et le seul moyen de la sauver est de retourner dans le passé, le jour de son terrible accident, pour éviter que celui-ci se produise.'),
(8, 'Cicatrices', 'ZORRO', 'McGregor, Sidney Lima', 'BD', 'Aventure', 'Glénat', 'CicatricesZorro.JPG21', 'Une version liftée du héros masqué ! Il y a des choses immuables : Zorro est toujours Don Diego de la Vega sous le masque, et il défend toujours la veuve et l\'orphelin grâce à son fouet et son épée.'),
(9, 'Professeur Moustache ', 'Tu mourras moins bête', 'Marion Montaigne', 'BD', 'Humour', 'Delcourt', 'ProfesseurMoustache.JPG30', 'Des sujets aussi variés que l\'espace, la pâtée pour chien ou la vitesse de chute de Gandalf ! Mais aussi, des notes made in prof Moustache sur les absurdités cinématographiques ou bibliques. '),
(10, 'La disparition', 'Seuls', 'Gazzotti,Vehlmann', 'BD', 'Aventure', 'Dupuis', 'LaDisparition.JPG25', 'Cinq enfants se réveillent un matin et constatent que tous les habitants de la ville ont mystérieusement disparu. Que s\'est-il passé ? Où sont leurs parents et amis ? Ils se retrouvent livrés à eux-mêmes dans une grande ville vide et vont devoir apprendre à se débrouiller... SEULS !'),
(11, 'Histoires de Schtroumpfs', 'Les Schtroumpfs', 'Peyo', 'BD', 'Humour', 'Dupuis', 'HistoireDeSchtroumpfs.JPG24', 'Sous l\'autorité débonnaire du grand Schtroumpf, ce sympathique petit peuple organise sa vie et lutte contre l\'abominable sorcier Gargamel, qui ne rêve que de les détruire.'),
(12, 'Calamity Jane', 'Lucky Luke', 'Morris, Groscinny', 'BD', 'Humour, Aventure', 'Dupuis', 'CalamityJane.JPG20', 'Le 27 Août 1859, le colonel Drake découvre un gisement d\'or noir à Titusville. Immédiatement, c\'est la ruée. Le maire appelle Lucky Luke pour maintenir l\'ordre. '),
(13, 'Tome 1', 'Détective Conan', 'Gosho AOYAMA', 'Manga', 'Policier', 'Kana', 'ConanT1.JPG22', 'Shinichi Kudo est un jeune détective de 17 ans. Son talent est déjà reconnu par la police et il leur vient en aide de temps en temps. Pour faire plaisir à son amie Ran Mouri, la capitaine de l\'équipe de karaté du lycée, Shinichi l\'emmène au parc d\'attraction Tropical Land. Sur le manège passant dans un tunnel, un jeune homme, deux rangs devant eux, est décapité.'),
(14, 'Le serment du gladiateur', 'Alix', 'Martin, Jailloux, Bréda', 'BD', 'Aventure', 'Casterman', 'LeSermentDuGladiateur.JPG29', 'Alix a quitté Rome pour se rendre dans la belle cité de Pompéi chez sa cousine Tullia. Son attention est attirée en particulier par un combattant marse que la foule acclame avec ferveur et qui se nomme Acteus. '),
(15, 'Le cas Lagaffe', 'Gaston', 'Franquin', 'BD', 'Humour', 'Dupuis', 'LeCasLagaffe.JPG26', 'Une nouvelle série de gags d\'une page où Gaston Lagaffe est toujours aussi inventif et peu enclin au travail que lui demande Prunelle.'),
(16, 'Angor', '', 'Gaudin, Armand', 'BD', 'Fantasy', 'Soleil', 'AngorIntegrale.JPG20', 'Pour échapper à un destin sinistre imposé par leur caste, trois jeunes gens vont quitter la cité d\'Angor et vivre une aventure hors du commun !'),
(17, 'Le destin du jongleur', 'Les forêts d\'Opale', 'Arleston, Fernandez', 'BD', 'Fantasy', 'Soleil', 'LeDestinDuJongleur.JPG27', 'Depuis que le titan de Darko s\'est sacrifié en absorbant la plus grande partie des pierres de lumière, la magie est rare dans les Cinq Royaumes. Or, de nouveaux ordres religieux sont en train d\'apparaître, et certains pourraient devenir dangereux pour la paix. '),
(18, 'Les 3 clefs', 'Haven', 'Lamontagne, Kan-J', 'BD', 'Fantasy', 'Soleil', 'LesClefs.JPG28', 'Haven en compagnie de Tuena et Ghaërr font route vers Dawndark. Mais il reste encore des épreuves à passer, des périples inattendues. Tuena semble sur le point de mourir.'),
(19, 'Empire tome 1', 'Empire', 'Waid,Kitson', 'Comics', 'Super-heros', 'Semic', 'Empire.JPG', 'Golgoth a gagné la guerre. Le monde est maintenant déchiré après les combats qu\'il a livré contre les super-héros. La possession de la téléportation a été un atout déterminant dans sa victoire.Plaçant aux différents ministères de sa dictature ses proches les plus fidèles, Golgoth fait régner sur le monde une dictature implacable qui écrase une à une les dernières poches de résistance.Le monde libre n\'est plus qu\'un lointain souvenir.Élevant sa fille et ordonnant à la Terre entière, Golgoth vit dans un monde de haine et de duplicité que seule sa poigne de fer fait taire.Combien de temps encore la dictature des super - vilains s\'imposera-t-elle à l\'humanité ? '),
(20, 'Lara Croft 1', 'Tomb Raider', 'Jurgens,Dan', 'Comics', 'Aventure', 'Semic', 'Lara.JPG', 'Lara Croft, alias Tomb Raider, libre et indépendante, archéologue multi-millionnaire, est une aventurière qui parcourt le monde.Petite fille, elle a survécu à l\'accident d\'avion dans lequel ont péri ses parents.Depuis qu\'elle a frôlé la mort, Lara croque la vie à pleines dents et prend des risques à chaque instant. Et quand il y a du danger pour autrui, elle n\'hésite pas à sortir ses 9mm.'),
(21, 'L\'Avénement', 'Darkness', 'Silvestri,Ennis', 'Comics', 'Aventure', 'Delcourt', 'Darkness.JPG', 'Jackie Estacado - orphelin et protégé de Don Franchetti - est le tueur le plus redoutable de la mafia newyorkaise. Cruel, expéditif et Don Juan irrécupérable, Jackie est un cauchemar pour ses rivaux. Le jour de ses 21 ans, il est choisi pour devenir, malgré lui, l\'hôte du Darkness, une entité millénaire qui tire ses pouvoirs de l\'obscurité. Il devient alors l\'assassin parfait.'),
(22, 'Danger Girl 1', 'Danger girl', 'Hartnell', 'Comics', 'Fiction', 'Graph Zeppelin Eds', 'Danger.JPG', 'Deux organisations tellement secrètes qu\'elles s\'ignorent l\'une l\'autre, Danger Girl et G.I. Joe, sont aux prises avec une des plus grandes menaces de la planète. G.I. Joe est une unité militaire qui œuvre dans l\'ombre pour protéger le monde des diaboliques projets de groupuscules malveillants. Danger Girl est une agence d\'espionnes  secrètes spécialisées dans la lutte contre les grands méchants.C\'est en pistant le même gibier que ces deux équipes hors norme se rencontreront pour mener à bien leur mission avec élégance...'),
(23, 'Bride Stories 1', 'Bride Stories', 'Kaoru Mori', 'Manga', 'Romance historique', 'ki-oons', 'Bride-Stories.JPG', 'La vie d\'Amir, 20 ans, est bouleversée le jour où elle est envoyée dans le clan voisin pour y être mariée. Elle y rencontre Karluk, son futur époux... un garçon de huit ans son cadet ! Autre village, autre moeurs... La jeune fille, chasseuse accomplie, découvre une existence différente, entre l\'aïeule acariâtre, une ribambelle d\'enfants et Smith, l\'explorateur anglais venu étudier leurs traditions. Mais avant même que le jeune couple ait eu le temps de se faire à sa nouvelle vie, le couperet tombe : pour conclure une alliance plus avantageuse avec un puissant voisin, le clan d\'Amir décide de récupérer la jeune femme coûte que coûte...'),
(24, 'Spider Man 1', 'Amazing fantasy spiderman', 'stan lee,steve ditko', 'Comics', 'Super-Héros', 'amazing fantasy', 'SpiderMan.JPG', 'Orphelin, Peter Parker est élevé par sa tante May et son oncle Ben dans le quartier Queens de New York. Tout en poursuivant ses études à l\'université, il trouve un emploi de photographe au journal Daily Bugle. Il partage son appartement avec Harry Osborn, son meilleur ami, et rêve de séduire la belle Mary Jane.');

-- --------------------------------------------------------

--
-- Structure de la table `personne`
--

CREATE TABLE `personne` (
  `person_id` int(11) NOT NULL,
  `type` varchar(255) NOT NULL,
  `nom` varchar(255) NOT NULL,
  `login` varchar(255) NOT NULL,
  `mdp` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `personne`
--

INSERT INTO `personne` (`person_id`, `type`, `nom`, `login`, `mdp`) VALUES
(1, 'User', 'Agathe', 'agathe', 'mdp'),
(2, 'Admin', 'AgAdmin', 'agathe', 'admin'),
(3, 'User', 'marm210', 'marm', 'mdp'),
(4, 'User', 'pol', 'poly', 'mdp');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `action`
--
ALTER TABLE `action`
  ADD PRIMARY KEY (`action_id`),
  ADD KEY `album_id` (`album_id`),
  ADD KEY `person_id` (`person_id`);

--
-- Index pour la table `album`
--
ALTER TABLE `album`
  ADD PRIMARY KEY (`album_id`);

--
-- Index pour la table `personne`
--
ALTER TABLE `personne`
  ADD PRIMARY KEY (`person_id`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `action`
--
ALTER TABLE `action`
  MODIFY `action_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- AUTO_INCREMENT pour la table `album`
--
ALTER TABLE `album`
  MODIFY `album_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT pour la table `personne`
--
ALTER TABLE `personne`
  MODIFY `person_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `action`
--
ALTER TABLE `action`
  ADD CONSTRAINT `FK_9233DFAF` FOREIGN KEY (`album_id`) REFERENCES `album` (`album_id`),
  ADD CONSTRAINT `FK_E64BA262` FOREIGN KEY (`person_id`) REFERENCES `personne` (`person_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
