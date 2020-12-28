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
                "insert into album values(1, 'Tintin au Tibet', 'Les Aventures de Tintin', 'Hergé', 'BD', 'Aventure', 'Casterman', 'Tintin au Tibet.jpg', ''); " +
               /* "insert into album values(2, 'Folle à lier', 'Harley Quinn', 'Jimmy Palmiotti (Scénario) / \r\n\r\nAmanda Conner (Scénario) / \r\n\r\nChad Hardin (Dessin)', 'BD', 'Super-héro', 'Urban Comics', 'Folle à lier.jpg', '');" +*/
                "insert into album values (5, 'La ferme abandonnée', 'Sylvain et Sylvette', 'Jean-Louis Pesch', 'BD', 'Humour', NULL, 'La ferme abandonnée.jpg', '');" 
                );
            Execute(
                "insert into personne values(1, 'Agathe', 'User', 'agathe', 'mdp');" +
                "insert into personne values(7, 'AgAdmin', 'Admin', 'agathe', 'admin');" +
                "insert into personne values(10, 'marm210', 'User', 'marm', 'mdp');"
                ) ;
            Execute(
                "insert into action values(1, 'AjoutMarché', '2020-12-01', 5, 7);" +
                "insert into action values(2, 'AjoutMarché', '2020-12-02', 2,7 );" +
                "insert into action values(3, 'AjoutMarché', '2020-12-02'10, 1,7);" +
                "insert into action values(4, 'AjouterSouhait','2020-12-02' 1, 10 );" +
                "insert into action values(5, 'Achat','2020-12-02', 1, 10 );"

                ) ;


        }
    }
}
