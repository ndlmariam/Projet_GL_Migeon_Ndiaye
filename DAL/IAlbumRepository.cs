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
        /// <returns></returns>
        List<Album> GetAll();

        /// <summary>
        /// Sauvegarder un album
        /// </summary>
        /// <param name="album">L'album </param>
        void Save(Album album);
    }
}



