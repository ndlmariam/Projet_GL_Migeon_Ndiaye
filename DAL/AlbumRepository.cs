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

        public void Save(Album album)
        {
            Session.SaveOrUpdate(album);
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

    }
}
