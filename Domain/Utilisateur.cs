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
      
        public virtual List<Action> Voeux { get; set; }
        public virtual List<Action> Achats { get; set; }
        public virtual IList<Action> ActionsUser { get; set; }



        public Utilisateur() {
            Voeux = new List<Action>();
        ListSouhaits = new List<Album>();
            ActionsUser = new List<Action>();
            ListAlbums = new List<Domain.Album>();
        }
        
        public Utilisateur(string nom, string type, string login, string mdp)
        {
            Nom = nom;
            Type = type;
            Login = login;
            Mdp = mdp;
            ListSouhaits = new List<Album>();
            ListAlbums = new List<Domain.Album>();
            Voeux = new List<Action>();
             Achats = new List<Action>();
            ActionsUser = new List<Action>();

        }

     

      
    }

}
