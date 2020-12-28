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
            // 3 albums dans le jeu de données de test
            Assert.AreEqual(3, albums.Count);
            var actual = albums.Select(album => album.Nom).ToList();
            var expected = new List<string> { "Tintin au Tibet", "Folle à lier", "La ferme abandonnée" };
            CollectionAssert.AreEquivalent(actual, expected);
        }


         [TestMethod]
         public void TestAlbumRepo_SaveNew()
         {
            Album _alb = new Album("L'étoile mystérieuse", "Les Aventures de Tintin", "", "BD", "Aventure", "Casterman");
             _albumRepository.Save(_alb);

             TestRepository.ClearSession();
             // Recherche des albums portant le même titre
             var albums = _albumRepository.GetAll().Where(a => a.Nom ==
                 "L'étoile mystérieuse").ToList();
             // 1 seul album correspondant dans le jeu de données de test
             Assert.AreEqual(1, albums.Count);
             Album nouvelAlbum = albums[0];
             Assert.AreEqual("L'étoile mystérieuse", nouvelAlbum.Nom);
             Assert.AreEqual("Casterman", nouvelAlbum.Editeur);
         }

         [TestMethod]
         public void TestAlbumRepo_SaveExisting()
         {
             var album = _albumRepository.GetAll()[0];
             album.Couverture = "";
             _albumRepository.Save(album);
             TestRepository.ClearSession();
             album = _albumRepository.GetAll().Where(a => a.Nom ==
                 "Tintin au Tibet").ToList()[0];
             Assert.AreEqual("", album.Couverture);
         }

        [TestMethod]
        public void TestAlbumRepo_GetAlbumByActionID()
        {
            Album album = _albumRepository.GetAlbumByActionID(2);
            Assert.AreEqual("La ferme abandonnée", album.Nom);
        }
        public void testAlbumRepo_GetAlbumByTitle()
        {
            Album album = _albumRepository.GetAlbumByTitle("Folle à lier");
            Assert.AreEqual(album.Editeur, "Urban Comics");
        }

        [TestMethod]
        public void TestAlbumRepo_GetAlbumByRecherche()
        {
            List<Album> albums = _albumRepository.GetAlbumByRecherche("Tintin");
            //Un seul album avec Tintin
            Assert.AreEqual(1, albums.Count);
        }

        [TestMethod]
        public void TestAlbumRepo_DeleteAlbum()
        {
            Album _alb = new Album("Tintin au Tibet", "Les Aventures de Tintin", "Tintin au Tibet.jpg", "BD", "Aventure", "Casterman");
            _albumRepository.Delete(_alb);
            bool possede = false;
            var albums = _albumRepository.GetAll();
            if (albums.Contains(_alb)) { possede = true; }
            Assert.IsFalse(possede);
        }

    }
}
