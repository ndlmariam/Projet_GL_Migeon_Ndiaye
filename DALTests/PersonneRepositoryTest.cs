using System;
using System.Collections.Generic;
using DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Domain;

namespace DALTests
{
    [TestClass]
    public class PersonneRepositoryTest
    {
        private PersonneRepository _personneRepository;

        [TestInitialize()]
        public void Initialize()
        {
            TestRepository.InitDB();

            _personneRepository = new PersonneRepository();
        }

        [TestMethod]
        public void TestPersonneRepo_GetAll()
        {
            var utilisateurs = _personneRepository.GetAll();
            // 3 utilisateurs dans le jeu de données de test
            Assert.AreEqual(3, utilisateurs.Count);
            var actual = utilisateurs.Select(util => util.Nom).ToList();
            var expected = new List<string> { "Agathe", "AgAdmin", "marm210" };
            CollectionAssert.AreEquivalent(actual, expected);
        }


        [TestMethod]
        public void TestPersonneRepo_SaveNew()
        {
            Personne personne = new Utilisateur("paul", "User", "pvulo", "julo");
            _personneRepository.Save(personne);

            TestRepository.ClearSession();
            // Recherche des personnes portant le même titre
            var personnes = _personneRepository.GetAll().Where(p => p.Nom ==
                "paul").ToList();
            // 1 seule personne correspondant dans le jeu de données de test
            Assert.AreEqual(1, personnes.Count);
            Personne nouvellePersonne = personnes[0];
            Assert.AreEqual("paul", nouvellePersonne.Nom);
            Assert.AreEqual("User", nouvellePersonne.Type);
        }

        [TestMethod]
        public void TestPersonneRepo_SaveExisting()
        {
            var personne = _personneRepository.GetAll()[3];
            personne.Nom = "paulochon";
            _personneRepository.Save(personne);
            TestRepository.ClearSession();
            personne = _personneRepository.GetAll().Where(p => p.Nom ==
                "paulochon").ToList()[0];
            Assert.AreEqual("polochon", personne.Nom);
        }

        [TestMethod]
        public void TestPersonneRepo_CompareMdp()
        {
            //mot de passe de l'utilisateur marm est mdp
            Assert.IsTrue(_personneRepository.CompareMdp("marm", "mdp"));
        }

        [TestMethod]
        public void TestPersonneRepo_TrouverPersonne()
        {
            Personne personne = _personneRepository.TrouverPersonne("marm", "mdp", "User");
            Assert.AreEqual("marm210", personne.Nom);
        }
        [TestMethod]
        public void TestPersonneRepo_PrentBDD()
        {
            //recherche d'un login innexistant
            Assert.IsFalse(_personneRepository.PresentBDD("bigo"));
        }


    }
}
