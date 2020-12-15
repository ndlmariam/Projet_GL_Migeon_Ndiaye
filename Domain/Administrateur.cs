using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Administrateur : Personne
    {
       

        public Administrateur() { }
        public Administrateur(string nom, string type, string login, string mdp)
        {
            Nom = nom;
            Type = type;
            Login = login;
            Mdp = mdp;
        }

        public virtual void AjouterAuMarche(Marche marche, Album alb)
        {
            marche.ListAlbums.Add(alb);
        }
    }
}
