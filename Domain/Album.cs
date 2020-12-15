using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Album
    {
       public virtual int idAlbum { get; set; }
        public virtual string Nom { get; set; }
        public virtual string Serie { get; set; }
        public virtual string Couverture { get; set; }
        public virtual string Categorie { get; set; }
        public virtual string Genre { get; set; }
        public virtual string Editeur { get; set; }
        public virtual Marche Marche { get; set; }
        //public virtual IList <string> Auteurs { get; set; }

        public Album() { }
        public Album(string nom, string serie, string couverture, string cate, string genre, string editeur, List<string> auteurs)
        {
            Nom = nom;
            Serie = serie;
            Couverture = couverture;
            Categorie = cate;
            Genre = genre;
            Editeur = editeur;
           // Auteurs = auteurs;
        }

    }
}
