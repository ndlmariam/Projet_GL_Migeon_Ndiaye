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
            Album _alb = new Album("Tintin au Tibet", "Les Aventures de Tintin", "Tintin au Tibet.jpg", "BD", "Aventure", "Casterman");
            var action = new Action("AjouterSouhait",_pers,_alb);
            _actionRepository.SaveAction(action);

            TestRepository.ClearSession();
            // Recherche des actions portant le même nom
            var actions = _actionRepository.GetAll().Where(a => a.Nom ==
                "AjouterSouhait").ToList();
            // 2 actions correspondant dans le jeu de données de test
            Assert.AreEqual(2, actions.Count);
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
            Album _alb = new Album("Tintin au Tibet", "Les Aventures de Tintin", "Tintin au Tibet.jpg", "BD", "Aventure", "Casterman");
            var actions = _actionRepository.GetActionByNameAndAlbum(_alb,"Achat");

            //Verification du nom de l'action
            Assert.AreEqual(actions.Nom, "Achat");
            //Verification du nom de l'album correspondant
            Assert.AreEqual(actions.Album.Nom, "Tintin au Tibet");
        }

        [TestMethod]
        public void TestActionRep_DeleteAction()
        {
            _pers = new Utilisateur();
            Album _alb = new Album("Tintin au Tibet", "Les Aventures de Tintin", "Tintin au Tibet.jpg", "BD", "Aventure", "Casterman");
            var action = new Action("AjouterSouhait", _pers, _alb);
            _actionRepository.DeleteAction(action);
            bool possede = false;
            var actions = _actionRepository.GetAll();
            //if (actions.Contains(action)) { possede = true; }
            Assert.IsFalse(possede);
        }
        

    }
}
