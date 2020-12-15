using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Marche
    {
        public virtual int idAction { get; set; }
        public virtual string Nom { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual Personne Personne{get;set;}
       // public virtual Album Album { get; set; }
        public virtual IList <Album> ListAlbums { get; set; }
       

        public Marche() { ListAlbums = new List<Album>(); }
        public Marche(string nom)
        {
            Nom = nom;
        }

    }
}
