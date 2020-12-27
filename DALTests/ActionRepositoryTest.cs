using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using DAL;
using Domain;
using System.Collections.Generic;

namespace DALTests
{
    [TestClass]
    public class ActionRepositoryTest
    {
        private ActionRepository _actionRepository;
        private Personne _pers;

        [TestInitialize()]
        public void Initialize()
        {
            TestRepository.InitDB();

            _actionRepository = new ActionRepository();
        }


        [TestMethod]
        public void TestActionRepo_GetAll()
        {
            var actions = _actionRepository.GetAll();
            // 5 actions dans le jeu de données de test
            Assert.AreEqual(5, actions.Count);
            var actual = actions.Select(action => action.Nom).ToList();
            // Nom des actions
            var expected = new List<string> { "AjoutMarché", "AjouterSouhait", "Achat" };
            CollectionAssert.AreEquivalent(actual, expected);
        }

        [TestMethod]
        public void TestActionRepo_SaveNew()
        {
            _pers = new Utilisateur();
            Album _alb = new Album("Tintin au Tibet", "Les Aventures de Tintin", "https://lh3.googleusercontent.com/proxy/btVDprQoDF035Jdu8VIbdrxCZ5EgvUghVTjWRlvXEh1_HNkxtkKH40gX_XGNyENA4S_HuVNAkPecvmsmopgM5yw6rV_317d_p7sNGqcHT3dOqg", "BD", "Aventure", "Casterman");
            var action = new Action("AjouterSouhait",_pers,_alb);
            _actionRepository.SaveAction(action);

            TestRepository.ClearSession();
            // Recherche des actions portant le même nom
            var actions = _actionRepository.GetAll().Where(a => a.Nom ==
                "AjouterSouhait").ToList();
            // 1 seule action correspondant dans le jeu de données de test
            Assert.AreEqual(1, actions.Count);
           /* Album nouvelAlbum = actions[0];
            Assert.AreEqual("AjouterSouhait", nouvelAlbum.Titre);
            Assert.AreEqual("Nick Hornby", nouveauLivre.Auteur);*/
        }

        [TestMethod]
        public void TestActionRepo_SaveExisting()
        {
            //Etrange le getall est un album ici


            /*var livre = _livreRepository.GetAll()[0];
            livre.Auteur = "JCR";
            _livreRepository.Save(livre);
            TestRepository.ClearSession();
            livre = _livreRepository.GetAll().Where(l => l.Titre ==
                "Rouge Brésil").ToList()[0];
            Assert.AreEqual("JCR", livre.Auteur);*/
        }

        [TestMethod]
        public void TestActionRepo_GetActionByNameAndAlbum()
        {
            Album _alb = new Album("Tintin au Tibet", "Les Aventures de Tintin", "https://lh3.googleusercontent.com/proxy/btVDprQoDF035Jdu8VIbdrxCZ5EgvUghVTjWRlvXEh1_HNkxtkKH40gX_XGNyENA4S_HuVNAkPecvmsmopgM5yw6rV_317d_p7sNGqcHT3dOqg", "BD", "Aventure", "Casterman");
            var actions = _actionRepository.GetActionByNameAndAlbum(_alb,"Achat");

            //Verification du nom de l'action
            Assert.AreEqual(actions.Nom, "Achat");
            //Verification du nom de l'album correspondant
            Assert.AreEqual(actions.Album.Nom, "Tintin au Tibet");
        }

        [TestMethod]
        public void TestActionRep_DeleteAction()
        {

           /* _actionRepository.DeleteAction();
            Session.Delete(action);
            Session.Flush();*/
        }
        

    }
}
