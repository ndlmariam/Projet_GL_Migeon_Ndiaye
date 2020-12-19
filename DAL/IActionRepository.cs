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

        /// <summary>
        /// Sauvegarder un marche
        /// </summary>
        /// <param name="marche">Le marche </param>
    //  void Save(Marche marche);
      //  List<Album> GetWishes(Utilisateur user);
       /* List<Album> GetShopping(Utilisateur user);
        void AddComics(Administrateur Admin,Album comics);
        void DeleteComics(Administrateur Admin, Album comics);*/

    }
}



