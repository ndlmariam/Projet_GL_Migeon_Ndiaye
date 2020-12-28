using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;
using Domain;
using NHibernate;
using NHibernate.Cfg;

namespace DomainTests
{
    [TestClass]
    public class AlbumTest
    {
        private Album _album;
        private string _nom = "";
        private string _serie = "";
        private string _couverture = "";
        private string _categorie = "";
        private string _genre = "";
        private string _editeur = "";
        private Domain.Action _action;

        [TestInitialize()]
        public void Initialize()
        {
            _album = new Album(_nom, _serie, _couverture, _categorie, _genre, _editeur);
        }

        [TestMethod]

        public void TestAdmin_Creation()
        {
            var album = new Album("L'étoile mystérieuse", "Les Aventures de Tintin", "", "BD", "Aventure", "Casterman");
            Assert.AreEqual(album.Nom, "L'étoile mystérieuse");

        }
    }
}
