using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using DAL;
using Domain;
using System.Collections.Generic;

namespace DALTests
{
    [TestClass]
    public class AlbumRepositoryTest
    {
        private AlbumRepository _albumRepository;

        [TestInitialize()]
        public void Initialize()
        {
            TestRepository.InitDB();

            _albumRepository = new AlbumRepository();
        }

        [TestMethod]
        public void TestAlbumRepo_GetAll()
        {
            var albums = _albumRepository.GetAll();
            // 2 albums dans le jeu de données de test
            Assert.AreEqual(2, albums.Count);
            var actual = albums.Select(album => album.Nom).ToList();
            var expected = new List<string> { "Tintin au Tibet", "Folle à lier" };
            CollectionAssert.AreEquivalent(actual, expected);
        }


        /* [TestMethod]
         public void TestLivreRepo_SaveNew()
         {
             var livre = new Livre("098-7654321098", "High Fidelity", "Nick Hornby");
             _livreRepository.Save(livre);

             TestRepository.ClearSession();
             // Recherche des livres portant le même titre
             var livres = _livreRepository.GetAll().Where(l => l.Titre ==
                 "High Fidelity").ToList();
             // 1 seul livre correspondant dans le jeu de données de test
             Assert.AreEqual(1, livres.Count);
             Livre nouveauLivre = livres[0];
             Assert.AreEqual("High Fidelity", nouveauLivre.Titre);
             Assert.AreEqual("Nick Hornby", nouveauLivre.Auteur);
         }

         [TestMethod]
         public void TestLivreRepo_SaveExisting()
         {
             var livre = _livreRepository.GetAll()[0];
             livre.Auteur = "JCR";
             _livreRepository.Save(livre);
             TestRepository.ClearSession();
             livre = _livreRepository.GetAll().Where(l => l.Titre ==
                 "Rouge Brésil").ToList()[0];
             Assert.AreEqual("JCR", livre.Auteur);
         }*/
    }
}
