using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class Administrateur : Personne
    {
        public virtual IList<Action> AdminActions { get; set; }
        public Administrateur() { this.Type = "Admin"; }
        public Administrateur(string nom, string type, string login, string mdp)
        {
            Nom = nom;
            Type = type;
            Login = login;
            Mdp = mdp;
            AdminActions = new List<Action>();
        }
    }
}
