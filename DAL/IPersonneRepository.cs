using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public interface IPersonneRepository
    {
        
        
       // List<Personne> GetAll();

      
        bool CompareMdp(string login, string mdp);
        bool PresentBDD(string login);
        void Save(Personne personne);
       Personne TrouverPersonne(string login, string mdp, string type);
     
     
    }
}



