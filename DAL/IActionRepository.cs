using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public interface IActionRepository
    {
        /// <summary>
        /// Retourner tous les marches
        /// </summary>
        /// <returns></returns>
         List<Album> GetAll();
  

        void SaveAction(Domain.Action action);
        Domain.Action GetActionByNameAndAlbum(Album alb, String nameofaction);
        void DeleteAction(Domain.Action action);

    }
}



