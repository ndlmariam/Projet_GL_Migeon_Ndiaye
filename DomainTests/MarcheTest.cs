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
    public class MarcheTest
    {
        protected Marche _marche;
        protected int _idAction = 0;
        protected string _nom = "MarcheTest";
        protected DateTime _date;
        protected Personne _personne;
        // public virtual Album Album { get; set; }
        protected IList<Album> ListAlbums;


        [TestInitialize()]
        public void Initialize()
        {
            _marche = new Marche(_nom);
            Album _album = new Album("AlbumNom", "Blabla", "cover", "Lacategorie", "Fantastique", "MoietToi");
            ListAlbums.Add(_album);
            Album _album2 = new Album("PanierNom", "PanierBlabla", "Paniercover", "PanierLacategorie", "Fantastique", "PanierMoietToi");
            ListAlbums.Add(_album2);
        }
    }
}
