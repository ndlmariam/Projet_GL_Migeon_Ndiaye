using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Action
    {
        public virtual int idAction { get; set; }
        public virtual string Nom { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual Personne Personne {get;set;}
       // public virtual Album Album { get; set; }
        public virtual IList <Album> ListAlbums { get; set; }
       

        public Action() { ListAlbums = new List<Album>(); }
        public Action(string nom)
        {
            Nom = nom;
        }

    }
}
