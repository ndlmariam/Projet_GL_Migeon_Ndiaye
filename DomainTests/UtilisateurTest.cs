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
            Album _album = new Album("AlbumNom", "Blabla", "cover", "Lacategorie", "Fantastique", "MoietToi");
            ListSouhaits.Add(_album);
            Album _album2 = new Album("PanierNom", "PanierBlabla", "Paniercover", "PanierLacategorie", "Fantastique", "PanierMoietToi");
            Panier.Add(_album2);

        }

        [TestMethod]
        public void TestAlbum_AjouterSouhait()
        {
            //ajouter album et tester si le dernier album ajouter à la liste est présent dans la liste
            Album _album = new Album("AlbumTest", "LesTests", "pasdecover", "Lacate", "Fantastique", "Moi");
            _utilisateur.AjouterSouhait(_album);
            int taille = ListSouhaits.Count;
            //vérifier toutes les caractéristiques
            Assert.AreEqual(ListSouhaits[taille-1].Nom, _album.Nom);
        }

        [TestMethod]
        public void TestAlbum_AjouterAlbums()
        {
            //ajouter album et tester si le dernier album ajouter à la liste est présent dans la liste
            Album _album = new Album("AlbumTest", "LesTests", "pasdecover", "Lacate", "Fantastique", "Moi");
            _utilisateur.AjouterAlbums(_album);
            int taille = ListAlbums.Count;
            //vérifier toutes les caractéristiques
            Assert.AreEqual(ListAlbums[taille - 1].Nom, _album.Nom);
        }

        [TestMethod]
        public void TestAlbum_AjouterPanier()
        {
            //ajouter album et tester si le dernier album ajouter à la liste est présent dans la liste
            Album _album = new Album("AlbumTest", "LesTests", "pasdecover", "Lacate", "Fantastique", "Moi");
            _utilisateur.AjouterPanier(_album);
            int taille = Panier.Count;
            //vérifier toutes les caractéristiques
            Assert.AreEqual(Panier[taille - 1].Nom, _album.Nom);
        }

        [TestMethod]
        public void TestAlbum_SupprimerPanier()
        {
            //supprimer album et tester si il n'est plus présent dans la liste
            Album _album = new Album("PanierNom", "PanierBlabla", "Paniercover", "PanierLacategorie", "Fantastique", "PanierMoietToi");
            _utilisateur.SupprimerPanier(_album);
            bool supprimer = true;
            foreach(Album alb in Panier)
            {
                if (_album.IsEqual(alb)) { supprimer = false; }
            }
            Assert.IsTrue(supprimer);
        }

        [TestMethod]
        public void TestAlbum_SupprimerSouhait()
        {
            //supprimer album et tester si il n'est plus présent dans la liste
            Album _album = new Album("AlbumNom", "Blabla", "cover", "Lacategorie", "Fantastique", "MoietToi");
            _utilisateur.SupprimerSouhait(_album);
            bool supprimer = true;
            foreach (Album alb in ListSouhaits)
            {
                if (_album.IsEqual(alb)) { supprimer = false; }
            }
            Assert.IsTrue(supprimer);
        }

    }
}
