using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class AlbumRepository : Repository, IAlbumRepository
    {
        public List<Album> GetAll()
        {
            return Session.Query<Album>().ToList();
        }
     public List<Album> GetByNameOfAction(string action)
        {
           List <Album> Listalbumparaction = new List <Album>();
            string requete = "select a from Action a where a.Nom = ?";
            var result = Session.CreateQuery(requete).SetString(0, action).Enumerable<Domain.Action>();
            foreach (Domain.Action row in result)
            {
                Listalbumparaction.Add(row.Album);


            }
            return Listalbumparaction;
        }
        public void Save(Album album)
        {
            Session.SaveOrUpdate(album);
            Session.Flush();
        }
        public void Delete(Album album)
        {
            Session.Delete(album);
            Session.Flush();
        }


      public Album GetAlbumByActionID(int actionid)
        {
            Album album = new Album();
            string requete = "select alb from Album alb where alb.Action.idAction= ? ";
            var result = Session.CreateQuery(requete).SetInt32(0, actionid).Enumerable<Album>();
            foreach (Album row in result)
            {
               album = row;


            }
            return album;
        }
        public Album GetAlbumByTitle(string title)
        {
            Album album = new Album();
            string requete = "select alb from Album alb where alb.Nom = ? ";
          var result = Session.CreateQuery(requete).SetString(0, title).Enumerable<Album>();
            foreach (Album row in result)
            {
                album = row;


            }
            return album;
        }

        public List<Album> GetAlbumByTitleRecherche(string title)
        {
            List<Album> albums = new List<Album>();
            string requete = "select alb from Album alb where alb.Nom LIKE %?% ";
         //   var result = Session.CreateQuery(requete).SetString(0, title).Enumerable<Album>();
            var result = Session.CreateQuery(requete).SetParameter(0, title).Enumerable<Album>();

            foreach (Album row in result)
            {
                albums.Add(row);


            }
            return albums;
        }
    }
}
