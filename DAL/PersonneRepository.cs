using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class PersonneRepository : Repository, IPersonneRepository
    {
        public List<Personne> GetAll()
        {
            return Session.Query<Personne>().ToList();
        }

        public void Save(Personne personne)
        {
            Session.SaveOrUpdate(personne);
            Session.Flush();
        }
    }
}
