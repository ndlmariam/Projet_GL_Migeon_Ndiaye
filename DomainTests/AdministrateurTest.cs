using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;
using Domain;
using NHibernate;
using NHibernate.Cfg;

namespace DomainTests
{
    [TestClass]
    public class AdministrateurTest
    {
        private Administrateur _admin;
        private string _nom = "Leray";
        private string _type = "Administrateur";
        private string _login = "kassytest";
        private string _mdp = "mdptest";

        [TestInitialize()]
        public void Initialize()
        {
            _admin = new Administrateur(_nom, _type, _login, _mdp);

        }

        [TestMethod]

        public void TestAdmin_Creation()
        {
            var personne = new Administrateur("Jean", "Admin", "jp", "pj");
            Assert.AreEqual(personne.Nom, "Jean");

        }

    }
}
