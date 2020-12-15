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
        public List<Marche> GetAll()
        {
            return Session.Query<Marche>().ToList();
        }

        public void Save(Marche marche)
        {
            Session.SaveOrUpdate(marche);
            Session.Flush();
        }
    }
}
