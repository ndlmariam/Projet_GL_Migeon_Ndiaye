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
        /// <summary>
        /// Retourner toutes les personnes
        /// </summary>
        
        List<Personne> GetAll();

        /// <summary>
        /// Sauvegarder une personne
        /// </summary>
        bool CompareMdp(string login, string mdp);
        bool PresentBDD(string login);
        void Save(Personne personne);
       Personne TrouverPersonne(string login, string mdp, string type);
      //  IList<Domain.Action>  GetWishes(Utilisateur user);
     
    }
}



