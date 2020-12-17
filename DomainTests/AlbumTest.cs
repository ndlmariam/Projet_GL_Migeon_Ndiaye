using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;
using Domain;
using NHibernate;
using NHibernate.Cfg;

namespace DomainTests
{
    [TestClass]
    public class AlbumTest
    {
        private Album _album;
        private string _nom = "";
        private string _serie = "";
        private string _couverture = "";
        private string _categorie = "";
        private string _genre = "";
        private string _editeur = "";
        private Marche _marche;

        [TestInitialize()]
        public void Initialize()
        {
            _album = new Album(_nom, _serie, _couverture, _categorie,_genre,_editeur);
        }
    }
}
