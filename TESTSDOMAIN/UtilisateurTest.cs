using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;
using Domain;
using NHibernate;
using NHibernate.Cfg;
using System.Collections.Generic;

namespace DomainTests
{
    [TestClass]
    public class UtilisateurTest
    {
        private Utilisateur _utilisateur;
        private string _nom = "Leray";
        private string _type = "Utilisateur";
        private string _login = "marmtest";
        private string _mdp = "mdptest";
        private IList<Album> ListAlbums { get; set; }
        private IList<Album> ListSouhaits { get; set; }
        private IList<Album> Panier { get; set; }

        [TestInitialize()]
        public void Initialize()
        {
            _utilisateur = new Utilisateur(_nom, _type, _login, _mdp);
           /* Album _album = new Album("AlbumNom", "Blabla", "cover", "Lacategorie", "Fantastique", "MoietToi");
            ListSouhaits.Add(_album);
            Album _album2 = new Album("PanierNom", "PanierBlabla", "Paniercover", "PanierLacategorie", "Fantastique", "PanierMoietToi");
            Panier.Add(_album2);*/

        }

        [TestMethod]

        public void TestAdmin_Creation()
        {
            var personne = new Utilisateur("Jeanne", "User", "jeh", "motdp");
            Assert.AreEqual(personne.Login, "jeh");

        }

    }
}
