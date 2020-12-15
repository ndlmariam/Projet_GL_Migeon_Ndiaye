using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class MarcheRepository : Repository, IMarcheRepository
    {
        public List<Album> GetAll()
        {
            return Session.Query<Album>().ToList();
        }

        public void Save(Marche marche)
        {
            Session.SaveOrUpdate(marche);
            Session.Flush();
        }
    }
}
