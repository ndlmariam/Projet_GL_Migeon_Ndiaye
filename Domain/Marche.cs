using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Marche
    {
        protected int idAction { get; set; }
        public string Nom { get; set; }
        public DateTime Date { get; set; }
        protected int idPersonne{get;set;}
        protected int idAlbum { get; set; }
        public List<Album> ListAlbums { get; set; }
        //pour date et personnes je sais pas si c'est une liste aussi ?

        public Marche() { }
        public Marche(string nom)
        {
            Nom = nom;
        }

    }
}
