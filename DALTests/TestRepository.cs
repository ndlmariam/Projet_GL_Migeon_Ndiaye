using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;
using Domain;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace DALTests
{
    [TestClass]
    public class TestRepository : Repository
    {

        internal static void ResetSchema()
        {
            Session.Clear();
            new SchemaExport(Configuration).Execute(false, true, false);
        }

        internal static void ClearSession()
        {
            Session.Clear();
        }

        internal static void Execute(string sql)
        {
            ISQLQuery query = Session.CreateSQLQuery(sql);
            query.ExecuteUpdate();
        }

        /// <summary>
        /// Load database with test data
        /// </summary>
        public static void InitDB()
        {
            ResetSchema();

             Execute(
                  "insert into album values(1, 'Tintin au Tibet', 'Les Aventures de Tintin', 'Hergé', 'BD', 'Aventure', 'Casterman', 'Tintin au Tibet.jpg', 'Un avion de ligne à bord duquel le jeune Chinois Tchang se rendait en Europe s''est écrasé dans l''Himalaya. Tintin, son ami, va donc partir à sa recherche.'); "+
                "insert into album values(2, 'Folle à lier', 'Harley Quinn', 'Jimmy Palmiotti, Amanda Conner, Chad Hardin', 'BD', 'Super-héro', 'Urban Comics', 'Folle à lier.jpg', 'Un jour Power Girl vient s''écraser aux pieds d''Harley Quinn. Frappée d''amnésie, la puissante Kryptonienne se retrouve malgré elle entrainée dans les missions abracadabrantesques de sa coéquipière autoproclamée. ');" +
                "insert into album values (3, 'La ferme abandonnée', 'Sylvain et Sylvette', 'Jean-Louis Pesch', 'BD', 'Humour', 'Dargaud', 'La ferme abandonnée.jpg', 'Ces récits pour la jeunesse relatent les aventures de Sylvain et Sylvette, deux enfants d''environ douze ans, le frère et la sœur, qui, s''étant un jour égarés, vivent dans une forêt en compagnie d''animaux domestiques.');"+
                "insert into album values(4, 'L''étoile mystérieuse', 'Les Aventures de Tintin', 'Hergé', 'BD', 'Aventure', 'Casterman', 'LetoileMysterieuse.jpg19', 'On entend à la radio qu une météorite s est écrasée dans l océan Arctique.');" +

                "insert into album values (5, 'Après moi l''déluge', 'ENO ONE', 'Polpine, Anton Lavigne', 'BD', 'Aventure', 'Theloma', 'EnoOne.JPG23', 'Pas facile de se retrouver seul et désœuvré dans un Paris quasiment désertique, ravagé par une sècheresse historique. C''est ce que vit Eno One, contrôleur des bacs de récupération d''eau de pluie des bords de Seine. Jusqu''au jour où la capitale est submergée par un raz de marée. ');" +
               "insert into album values (6, 'Astérix et Cléopatre', 'Astérix', 'Goscinny, Uderzo', 'BD', 'Humour', 'Dargaud', 'AsterixetCleopatre.JPG21', 'Dans cette aventure, la Reine Cléopâtre ne supporte plus les critiques de Jules César sur son peuple égyptien, ses superstitions et sa culture. Afin de lui prouver que l''Égypte est toujours incarnée par un grand peuple, elle fait le pari de construire un nouveau palais en moins de trois mois.');" +
                "insert into album values (7, 'Aux sources du Z', 'Spirou et Fantasio', 'Morvan, Yann, Munuera', 'BD', 'Aventure', 'Dupuis', 'AuxSourcesDuZ.JPG19', 'Zorglub, contre la volonté du comte de Champignac, demande l''aide de Spirou. Miss Flanner est mourante, et le seul moyen de la sauver est de retourner dans le passé, le jour de son terrible accident, pour éviter que celui-ci se produise.');" +
                "insert into album values (8, 'Cicatrices', 'ZORRO', 'McGregor, Sidney Lima', 'BD', 'Aventure','Glénat', 'CicatricesZorro.JPG21', 'Une version liftée du héros masqué ! Il y a des choses immuables : Zorro est toujours Don Diego de la Vega sous le masque, et il défend toujours la veuve et l''orphelin grâce à son fouet et son épée.');" +
                "insert into album values (9, 'Professeur Moustache étale sa science', 'Tu mourras moins bête', 'Marion Montaigne', 'BD', 'Humour', 'Delcourt', 'ProfesseurMoustache.JPG30', 'Des sujets aussi variés que l''espace, la pâtée pour chien ou la vitesse de chute de Gandalf ! Mais aussi, des notes made in prof Moustache sur les absurdités cinématographiques ou bibliques. ');" +
                "insert into album values (10, 'La disparition', 'Seuls', 'Gazzotti,Vehlmann', 'BD', 'Aventure', 'Dupuis', 'LaDisparition.JPG25', 'Cinq enfants se réveillent un matin et constatent que tous les habitants de la ville ont mystérieusement disparu. Que s''est-il passé ? Où sont leurs parents et amis ? Ils se retrouvent livrés à eux-mêmes dans une grande ville vide et vont devoir apprendre à se débrouiller... SEULS !');" +
                "insert into album values (11, 'Histoires de Schtroumpfs', 'Les Schtroumpfs', 'Peyo', 'BD', 'Humour', 'Dupuis', 'HistoireDeSchtroumpfs.JPG24', 'Sous l''autorité débonnaire du grand Schtroumpf, ce sympathique petit peuple organise sa vie et lutte contre l''abominable sorcier Gargamel, qui ne rêve que de les détruire.');" +
                "insert into album values (12, 'Calamity Jane', 'Lucky Luke', 'Morris, Groscinny', 'BD', 'Humour, Aventure', 'Dupuis', 'CalamityJane.JPG20', 'Le 27 Août 1859, le colonel Drake découvre un gisement d''or noir à Titusville. Immédiatement, c''est la ruée. Le maire appelle Lucky Luke pour maintenir l''ordre. ');" +
               //"insert into album values (13, 'Volume 1', 'Valerian', 'Christin, Mézières', 'BD', 'SF', 'Dargaud, 'ValerianV1', 'Un des technocrates de première classe, Xonbul, a déréglé les programmes de la machine à Rêves, ce qui perturbe les rêves des Terriens qui ne font plus que ça. Xombul a pris la fuite et se réfugie en l''an Mil. ');" +
               "insert into album values (13, 'Tome 1', 'Détective Conan', 'Gosho AOYAMA', 'Manga', 'Policier', 'Kana', 'ConanT1.JPG22', 'Shinichi Kudo est un jeune détective de 17 ans. Son talent est déjà reconnu par la police et il leur vient en aide de temps en temps. Pour faire plaisir à son amie Ran Mouri, la capitaine de l''équipe de karaté du lycée, Shinichi l''emmène au parc d''attraction Tropical Land. Sur le manège passant dans un tunnel, un jeune homme, deux rangs devant eux, est décapité.');" +
               "insert into album values (14, 'Le serment du gladiateur', 'Alix', 'Martin, Jailloux, Bréda', 'BD', 'Aventure', 'Casterman', 'LeSermentDuGladiateur.JPG29', 'Alix a quitté Rome pour se rendre dans la belle cité de Pompéi chez sa cousine Tullia. Son attention est attirée en particulier par un combattant marse que la foule acclame avec ferveur et qui se nomme Acteus. ');" +
               "insert into album values (15, 'Le cas Lagaffe', 'Gaston', '', 'BD', 'Humour', 'Dupuis', 'LeCasLagaffe.JPG26', 'Une nouvelle série de gags d''une page où Gaston Lagaffe est toujours aussi inventif et peu enclin au travail que lui demande Prunelle.');" +
               "insert into album values (16, 'Angor', '', 'Gaudin, Armand', 'BD', 'Fantasy', 'Soleil', 'AngorIntegrale.JPG20', 'Pour échapper à un destin sinistre imposé par leur caste, trois jeunes gens vont quitter la cité d''Angor et vivre une aventure hors du commun !');" +
               "insert into album values (17, 'Le destin du jongleur', 'Les forêts d''Opale', 'Arleston, Fernandez', 'BD', 'Fantasy', 'Soleil', 'LeDestinDuJongleur.JPG27', 'Depuis que le titan de Darko s''est sacrifié en absorbant la plus grande partie des pierres de lumière, la magie est rare dans les Cinq Royaumes. Or, de nouveaux ordres religieux sont en train d''apparaître, et certains pourraient devenir dangereux pour la paix. ');" +
               "insert into album values (18, 'Les 3 clefs', 'Haven', 'Lamontagne, Kan-J', 'BD', 'Fantasy', 'Soleil', 'LesClefs.JPG28', 'Haven en compagnie de Tuena et Ghaërr font route vers Dawndark. Mais il reste encore des épreuves à passer, des périples inattendues. Tuena semble sur le point de mourir.');"
                );
              Execute(
                  "insert into personne values(1, 'User', 'Agathe', 'agathe', 'mdp');" +
                  "insert into personne values(2, 'Admin', 'AgAdmin', 'agathe', 'admin');" +
                  "insert into personne values(3, 'User', 'marm210', 'marm', 'mdp');"+
                  "insert into personne values(4, 'User', 'pol', 'poly', 'mdp');"
                  );
            Execute(
                  "insert into action values(1, 'AjoutMarché', '2020-12-01', 1, 2);" +
                  "insert into action values(2, 'AjoutMarché', '2020-12-02', 2, 2 );" +
                  "insert into action values(3, 'AjoutMarché', '2020-12-02', 3, 2);" +
                  "insert into action values(4, 'AjoutMarché', '2020-12-02', 4, 2);" +
                  "insert into action values(5, 'AjouterSouhait','2020-12-02', 1, 3 );" +
                  "insert into action values(6, 'AjouterSouhait', '2020-12-02', 2, 3); " +
                  "insert into action values(7, 'AjouterSouhait', '2020-12-02', 3, 3); " +
                 "insert into action values(8, 'AjoutMarché', '2020-12-02', 5, 2);" +
                 "insert into action values(9, 'AjoutMarché', '2020-12-02', 6, 2);" +
                 "insert into action values(10, 'AjoutMarché', '2020-12-02', 7, 2);" +
                 "insert into action values(11, 'AjoutMarché', '2020-12-02', 8, 2);" +
                 "insert into action values(12, 'AjoutMarché', '2020-12-02', 9, 2);" +
                 "insert into action values(13, 'AjoutMarché', '2020-12-02', 10, 2);" +
                 "insert into action values(14, 'AjoutMarché', '2020-12-02', 11, 2);" +
                 "insert into action values(15, 'AjoutMarché', '2020-12-02', 12, 2);" +
                 "insert into action values(16, 'AjoutMarché', '2020-12-02', 13, 2);" +
                 "insert into action values(17, 'AjoutMarché', '2020-12-02', 14, 2);" +
                 "insert into action values(18, 'AjoutMarché', '2020-12-02', 15, 2);" +
                 "insert into action values(19, 'AjoutMarché', '2020-12-02', 16, 2);" +
                 "insert into action values(20, 'AjoutMarché', '2020-12-02', 17, 2);" +
                 "insert into action values(21, 'AjoutMarché', '2020-12-02', 18, 2);" 
                // "insert into action values(22, 'AjoutMarché', '2020-12-02', 19, 2);" 

                  ) ;
         


        }
    }
}
