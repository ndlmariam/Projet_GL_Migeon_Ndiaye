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

        //Test de récupération
        [TestMethod]
        public void TestAlbumRepo_GetAll()
        {
            var albums = _albumRepository.GetAll();
            // 18 albums dans le jeu de données de test
            Assert.AreEqual(18, albums.Count);
        }

        //Test de sauvegarde d'un nouvel album
        [TestMethod]
         public void TestAlbumRepo_SaveNew()
         {
            Album _alb = new Album("A l'aube d'une grande aventure", "One Piece", "", "Manga", "Aventure", "Shueisha", "Eiichiro Oda");
             _albumRepository.Save(_alb);
             TestRepository.ClearSession();
             // Recherche des albums portant le même titre
             var albums = _albumRepository.GetAll().Where(a => a.Nom ==
                 "A l'aube d'une grande aventure").ToList();
             // 1 seul album correspondant dans le jeu de données de test
             Assert.AreEqual(1, albums.Count);
         }

        //Test de sauvegarde d'un album existant
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

        //Test de récupération d'un album par l'id d'une action
        [TestMethod]
        public void TestAlbumRepo_GetAlbumByActionID()
        {
            Album album = _albumRepository.GetAlbumByActionID(3);
            Assert.AreEqual("La ferme abandonnée", album.Nom);
        }

        //Test de récupération d'un album par son titre
        [TestMethod]
        public void TestAlbumRepo_GetAlbumByTitle()
        {
            Album album = _albumRepository.GetAlbumByTitle("Tintin au Tibet");
            Assert.AreEqual(album.Editeur, "Casterman");
        }

        //Test de récupération d'un album par un mot clé
        [TestMethod]
        public void TestAlbumRepo_GetAlbumByRecherche()
        {
            List<Album> albums = _albumRepository.GetAlbumByRecherche("Hergé");
            //2 albums avec Hergé
            Assert.AreEqual(2, albums.Count);
        }

        //Test de sauvegarde de suppression d'un album
        [TestMethod]
        public void TestAlbumRepo_DeleteAlbum()
        {
            Album _alb = new Album("Tintin au Tibet", "Les Aventures de Tintin", "Tintin au Tibet.jpg", "BD", "Aventure", "Casterman","Hergé");
            _albumRepository.Delete(_alb);
            bool possede = false;
            var albums = _albumRepository.GetAll();
            if (albums.Contains(_alb)) { possede = true; }
            Assert.IsFalse(possede);
        }

    }
}
