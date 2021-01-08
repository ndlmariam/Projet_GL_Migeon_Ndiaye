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
                  "insert into album values(2, 'Folle à lier', 'Harley Quinn', 'Jimmy Palmiotti, Amanda Conner, Chad Hardin', 'BD', 'Super-héro', 'Urban Comics', 'Folle à lier.jpg', '');" +
                  "insert into album values (3, 'La ferme abandonnée', 'Sylvain et Sylvette', 'Jean-Louis Pesch', 'BD', 'Humour', NULL, 'La ferme abandonnée.jpg', '');"+
                "insert into album values(4, 'L''étoile mystérieuse', 'Les Aventures de Tintin', 'Hergé', 'BD', 'Aventure', 'Casterman', 'L''étoile mystérieuse3', 'On entend à la radio qu une météorite s est écrasée dans l océan Arctique.');"
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
                  "insert into action values(7, 'AjouterSouhait', '2020-12-02', 3, 3); " 
                 

                  ) ;
         


        }
    }
}
