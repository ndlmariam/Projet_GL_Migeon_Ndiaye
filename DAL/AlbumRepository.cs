using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class AlbumRepository : Repository, IAlbumRepository
    {
        public List<Album> GetAll()
        {
            return Session.Query<Album>().ToList();
        }

        //Récupère les albums en fonction du nom d'une action
        public List<Album> GetByNameOfAction(string action)
        {
           List <Album> Listalbumparaction = new List <Album>();
            string requete = "select a from Action a where a.Nom = ?";
            var result = Session.CreateQuery(requete).SetString(0, action).Enumerable<Domain.Action>();
            foreach (Domain.Action row in result) {  Listalbumparaction.Add(row.Album); }
            return Listalbumparaction;
        }
        
        public void Save(Album album)
        {
            Session.SaveOrUpdate(album);
            Session.Flush();
        }

        public void Delete(Album album)
        {
            Session.Delete(album);
            Session.Flush();
        }

        //Récupère l'album associé à l'id d'une action
        public Album GetAlbumByActionID(int actionid)
        {
            Album album = new Album();
            string requete = "select alb from Album alb inner join Action act on act.Album=alb where act.idAction=?";
            var result = Session.CreateQuery(requete).SetInt32(0, actionid).Enumerable<Album>();
            foreach (Album row in result) { album = row; }
            return album;
        }

        //Récupère un album à partir de son titre
        public Album GetAlbumByTitle(string title)
        {
            Album album = new Album();
            string requete = "select alb from Album alb where alb.Nom = ? ";
            var result = Session.CreateQuery(requete).SetString(0, title).Enumerable<Album>();
            foreach (Album row in result) { album = row; }
            return album;
        }

        //Récupère une liste d'albums à partir d'un mot clé
        public List<Album> GetAlbumByRecherche(string recherche)
        {
            List<Album> albums = new List<Album>();
            string requete = "select alb from Album alb where alb.Nom LIKE ? OR alb.Editeur LIKE ?  OR alb.Auteur LIKE ?   OR alb.Categorie LIKE ?  OR alb.Genre LIKE ? OR alb.Serie LIKE ?";
            var result = Session.CreateQuery(requete).SetParameter(0, "%"+ recherche+"%").SetParameter(1, "%" + recherche + "%").SetParameter(2, "%" + recherche + "%").SetParameter(3, "%" + recherche + "%").SetParameter(4, "%" + recherche + "%").SetParameter(5, "%" + recherche + "%").Enumerable<Album>();
            foreach (Album row in result) { albums.Add(row);}
            return albums;
        }
    }
}
