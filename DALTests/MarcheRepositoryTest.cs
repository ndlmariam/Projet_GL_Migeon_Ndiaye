using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using DAL;
using Domain;
using System.Collections.Generic;

namespace DALTests
{
    [TestClass]
    public class MarcheRepositoryTest
    {
        private MarcheRepository _marcheRepository;

        [TestInitialize()]
        public void Initialize()
        {
            TestRepository.InitDB();

            _marcheRepository = new MarcheRepository();
        }

    }
}
