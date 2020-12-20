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
       /* List<Album> GetWishes(Utilisateur user)
        {

        }*/
        
    }
}
