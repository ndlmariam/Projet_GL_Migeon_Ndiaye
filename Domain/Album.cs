using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Album
    {
        protected int idAlbum { get; set; }
        public string Nom { get; set; }
        public string Serie { get; set; }
        public string Couverture { get; set; }
        public string Categorie { get; set; }
        public string Genre { get; set; }
        public string Editeur { get; set; }
        public List<string> Auteurs { get; set; }

        public Album() { }
        public Album(string nom, string serie, string couverture, string cate, string genre, string editeur, List<string> auteurs)
        {
            Nom = nom;
            Serie = serie;
            Couverture = couverture;
            Categorie = cate;
            Genre = genre;
            Editeur = editeur;
            Auteurs = auteurs;
        }

    }
}
