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
    public class ActionTest
    {
        protected Domain.Action _action;
        protected int _idAction = 0;
        protected string _nom = "Achat";
        protected DateTime _date;
        protected Personne _personne;
        protected Album _album;


        [TestInitialize()]
        public void Initialize()
        {

            _album = new Album("AlbumNom", "Blabla", "cover", "Lacategorie", "Fantastique", "MoietToi", "Auteur");
            _action = new Domain.Action(_nom, _personne, _album);

        }

        [TestMethod]

        public void TestAction_Creation()
        {
            _album = new Album("AlbumNom", "Blabla", "cover", "Lacategorie", "Fantastique", "MoietToi", "Auteur");
            var personne = new Administrateur("Jean", "Admin", "jp", "pj");
            var action = new Domain.Action("AjoutMarché", personne, _album);
            Assert.AreEqual(action.Personne.Nom, "Jean");

        }
    }
}
