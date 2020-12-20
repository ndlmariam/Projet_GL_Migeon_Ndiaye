using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Utilisateur : Personne
    {
      
        public virtual List<Album> ListAlbums { get; set; }
        public virtual List<Album> ListSouhaits { get; set; }
        public virtual List<Album> Panier { get; set; }
        public virtual List<Action> Voeux { get; set; }
        public virtual List<Action> Achats { get; set; }
        public virtual IList<Action> ActionsUser { get; set; }



        public Utilisateur() {
            Voeux = new List<Action>();
        ListSouhaits = new List<Album>();
            ActionsUser = new List<Action>(); }
        
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
