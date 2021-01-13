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
        List<Domain.Action> GetAll();
        void SaveAction(Domain.Action action);
        Domain.Action GetActionByNameAndAlbum(Album alb, String nameofaction);
        void DeleteAction(Domain.Action action);
    }
}



