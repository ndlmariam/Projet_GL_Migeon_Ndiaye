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
        public void TestAlbum_AjouterAuMarche()
        {
            //ajouter album et tester si le dernier album ajouter à la liste est présent dans la liste
            Album _album = new Album("AlbumTest", "LesTests", "pasdecover", "Lacate", "Fantastique", "Moi");
            Domain.Action _action = new Domain.Action("MarcheTest");
            _admin.AjouterAuMarche(_action, _album);
            int taille = _action.ListAlbums.Count;
            //vérifier toutes les caractéristiques
            Assert.AreEqual(_action.ListAlbums[taille - 1].Nom, _album.Nom);
        }

    }
}
