using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class ActionRepository : Repository, IActionRepository
    {
        public List<Album> GetAll()
        {
            return Session.Query<Album>().ToList();
        }

         public void SaveAction(Domain.Action action)
         {
             Session.SaveOrUpdate(action);
             Session.Flush();
         }
      public  Domain.Action GetActionByNameAndAlbum(Album alb, String nameofaction)
        {
            Domain.Action action = new Domain.Action();
            string requete = "select a from Action a where a.Nom = ? and a.Album.Nom = ? ";
            var result = Session.CreateQuery(requete).SetString(0, nameofaction).SetString(1, alb.Nom).Enumerable<Domain.Action>();
            foreach (Domain.Action row in result)
            {
                action = row;


            }
            return action;
        }
    public void DeleteAction(Domain.Action action)
        {
            Session.Delete(action);
            Session.Flush();
        }


    }
}
