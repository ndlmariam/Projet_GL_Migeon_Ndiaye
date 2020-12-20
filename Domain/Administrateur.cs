using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class Administrateur : Personne
    {

        public virtual IList<Action> Ajouts { get; set; }
        public virtual IList<Action> Suppression { get; set; }
        public Administrateur() { }
        public Administrateur(string nom, string type, string login, string mdp)
        {
            Nom = nom;
            Type = type;
            Login = login;
            Mdp = mdp;
            Ajouts = new List<Action>();
            Suppression = new List<Action>();
        }

       /* public virtual void AjouterAuMarche(Action marche, Album alb)
        {
            marche.ListAlbums.Add(alb);
        }*/
    }
}
