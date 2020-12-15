using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public interface IMarcheRepository
    {
        /// <summary>
        /// Retourner tous les marches
        /// </summary>
        /// <returns></returns>
     List<Album> GetAll();

        /// <summary>
        /// Sauvegarder un marche
        /// </summary>
        /// <param name="marche">Le marche </param>
      void Save(Marche marche);
    }
}



