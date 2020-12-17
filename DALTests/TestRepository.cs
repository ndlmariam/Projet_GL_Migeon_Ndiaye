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
        [TestMethod]
        public void TestMethod1()
        {
        }

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
                "insert into album values(1, 'Tintin au Tibet', 'Les Aventures de Tintin', 'Hergé', 'BD', 'Aventure', 'Casterman', 'https://lh3.googleusercontent.com/proxy/btVDprQoDF035Jdu8VIbdrxCZ5EgvUghVTjWRlvXEh1_HNkxtkKH40gX_XGNyENA4S_HuVNAkPecvmsmopgM5yw6rV_317d_p7sNGqcHT3dOqg'); " +
                "insert into album values(2, 'Folle à lier', 'Harley Quinn', 'Jimmy Palmiotti (Scénario) / \r\n\r\nAmanda Conner (Scénario) / \r\n\r\nChad Hardin (Dessin)', 'BD', 'Super-héro', 'Urban Comics', 'https://www.bdfugue.com/media/catalog/product/cache/1/image/400x/17f82f742ffe127f42dca9de82fb58b1/9/7/9782365778404_1_75.jpg')");
        }
    }
}
