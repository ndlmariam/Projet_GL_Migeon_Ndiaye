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

        [TestInitialize()]
        public void Initialize()
        {
            TestRepository.InitDB();

            _actionRepository = new ActionRepository();
        }

    }
}
