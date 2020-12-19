using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Utilisateur : Personne
    {
        public virtual IList<Album> ListAlbums { get; set; }
        public virtual IList<Album> ListSouhaits { get; set; }
        public virtual IList<Album> Panier { get; set; }
        public virtual IList<Action> Voeux { get; set; }
        public virtual IList<Action> Achats { get; set; }


        public Utilisateur() { ListSouhaits = new List<Album>(); }
        
        public Utilisateur(string nom, string type, string login, string mdp)
        {
            Nom = nom;
            Type = type;
            Login = login;
            Mdp = mdp;
            ListSouhaits = new List<Album>();
            Voeux = new List<Action>();
             Achats = new List<Action>();

        }

        public virtual void AjouterSouhait(Album alb)
        {
            ListSouhaits.Add(alb);
        }

        public virtual void AjouterAlbums(Album alb)
        {
            ListAlbums.Add(alb);
        }

        public virtual void AjouterPanier(Album alb)
        {
            Panier.Add(alb);
        }
    }

}
