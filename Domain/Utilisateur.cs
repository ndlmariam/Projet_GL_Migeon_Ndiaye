using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Utilisateur : Personne
    {
        protected List<Album> ListAlbums { get; set; }
        protected List<Album> ListSouhaits { get; set; }
        protected List<Album> Panier { get; set; }

        public Utilisateur(){}
        public Utilisateur(string nom, string type, string login, string mdp)
        {
            Nom = nom;
            Type = type;
            Login = login;
            Mdp = mdp;

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
