using System;
using System.Collections.Generic;
using DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

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
            // 0 utilisateur dans le jeu de données de test
            Assert.AreEqual(0, utilisateurs.Count);
            var actual = utilisateurs.Select(util => util.Nom).ToList();
            var expected = new List<string> { "" };
            CollectionAssert.AreEquivalent(actual, expected);
        }
    }
}
