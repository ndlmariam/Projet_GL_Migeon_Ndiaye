using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Album
    { public virtual bool selected { get; set; }
       public virtual int idAlbum { get; set; }
        public virtual string Nom { get; set; }
        public virtual string Serie { get; set; }
        public virtual string Couverture { get; set; }
        public virtual string Categorie { get; set; }
        public virtual string Genre { get; set; }
        public virtual string Auteur { get; set; }
        public virtual string Editeur { get; set; }
        public virtual string Resume { get; set; }
        public virtual IList <Action> Actions { get; set; }
        public virtual IList <Utilisateur> Users { get; set; }
       

        public Album() { }
        public Album(string nom, string serie, string couverture, string cate, string genre, string editeur, /*List<string>*/ string auteur)
        {
            Nom = nom;
            Serie = serie;
            Couverture = couverture;
            Categorie = cate;
            Genre = genre;
            Editeur = editeur;
            Auteur = auteur;
        }

        //Pour le test sans les auteurs pour l'instant
        public Album(string nom, string serie, string couverture, string cate, string genre, string editeur)
        {
            Nom = nom;
            Serie = serie;
            Couverture = couverture;
            Categorie = cate;
            Genre = genre;
            Editeur = editeur;
        }

    }
}
