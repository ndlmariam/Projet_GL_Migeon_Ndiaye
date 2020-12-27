using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public interface IAlbumRepository
    {
        /// <summary>
        /// Retourner tous les albums
        /// </summary>
       
        List<Album> GetAll();
        List<Album> GetByNameOfAction(string action);

        /// <summary>
        /// Sauvegarder un album
        /// </summary>

        void Save(Album album);
        void Delete(Album album);
       Album GetAlbumByActionID(int actionid);
        Album GetAlbumByTitle(string title);
        List<Album> GetAlbumByTitleRecherche(string title);
        
    }
}



