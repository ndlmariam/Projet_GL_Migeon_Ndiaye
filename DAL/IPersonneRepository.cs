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
        /// <returns></returns>
        List<Personne> GetAll();

        /// <summary>
        /// Sauvegarder une personne
        /// </summary>
        /// <param name="personne">La personne </param>
        void Save(Personne personne);
    }
}



