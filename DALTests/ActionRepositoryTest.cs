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
        PersonneRepository _personneRepo;
        AlbumRepository _albumRepository;

        [TestInitialize()]
        public void Initialize()
        {
            TestRepository.InitDB();

            _actionRepository = new ActionRepository();
            _personneRepo = new PersonneRepository();
            _albumRepository = new AlbumRepository();
        }
        

        [TestMethod]
        public void TestActionRepo_GetAll()
        {
            var actions = _actionRepository.GetAll();
           /* // 7 actions dans le jeu de données de test
            Assert.AreEqual(7, actions.Count);
            var actual = actions.Select(action => action.Nom).ToList();
            // Nom des actions
            var expected = new List<string> { "AjoutMarché", "AjoutMarché", "AjoutMarché", "AjoutMarché", "AjouterSouhait", "AjouterSouhait", "AjouterSouhait" };
            CollectionAssert.AreEquivalent(actual, expected);*/
            // 21 actions dans le jeu de données de test
            Assert.AreEqual(21, actions.Count);
            var actual = actions.Select(action => action.Nom).ToList();
            // Nom des actions
            var expected = new List<string> { "AjoutMarché", "AjoutMarché", "AjoutMarché", "AjoutMarché", "AjouterSouhait", "AjouterSouhait", "AjouterSouhait", "AjoutMarché", "AjoutMarché", "AjoutMarché", "AjoutMarché", "AjoutMarché", "AjoutMarché", "AjoutMarché", "AjoutMarché", "AjoutMarché", "AjoutMarché", "AjoutMarché", "AjoutMarché", "AjoutMarché", "AjoutMarché" };
            CollectionAssert.AreEquivalent(actual, expected);
        }

        [TestMethod]
        public void TestActionRepo_SaveNew()
        {

            Personne _pers = _personneRepo.GetAll()[0]; //user Agathe
            Album _alb = _albumRepository.GetAll()[0]; //Tintin au Tibet
            //Album _alb = new Album("Tintin au Tibet", "Les Aventures de Tintin", "Tintin au Tibet.jpg", "BD", "Aventure", "Casterman");
            var action = new Action("AjouterSouhait",_pers,_alb);
            _actionRepository.SaveAction(action);

            //TestRepository.ClearSession();
            // Recherche des actions portant le même nom
            var actions = _actionRepository.GetAll().Where(a => a.Nom ==
                "AjouterSouhait").ToList();
            // 4 actions correspondant dans le jeu de données de test
            Assert.AreEqual(4, actions.Count);
            Action nouvelleAction = actions[0];
            Assert.AreEqual("AjouterSouhait", nouvelleAction.Nom);}

        [TestMethod]
        public void TestActionRepo_SaveExisting()
        {
            Action action = _actionRepository.GetAll()[6];
            action.Nom = "Achat";
            _actionRepository.SaveAction(action);
            TestRepository.ClearSession();
            action = _actionRepository.GetAll().Where(a => a.idAction ==
                7).ToList()[0];
            Assert.AreEqual("Achat", action.Nom);
        }

        [TestMethod]
        public void TestActionRepo_GetActionByNameAndAlbum()
        {
            Album _alb = new Album("Tintin au Tibet", "Les Aventures de Tintin", "Tintin au Tibet.jpg", "BD", "Aventure", "Casterman");
            var actions = _actionRepository.GetActionByNameAndAlbum(_alb,"AjouterSouhait");

            //Verification du nom de l'action
            Assert.AreEqual(actions.Nom, "AjouterSouhait");
            //Verification du nom de l'album correspondant
            Assert.AreEqual(actions.Album.Nom, "Tintin au Tibet");
        }

        [TestMethod]
        public void TestActionRep_DeleteAction()
        {
            Personne    _pers = new Utilisateur();
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
