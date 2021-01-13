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
        public virtual Album Album { get; set; }

        public Action() { }
        public Action(string nom,Personne pers,Album alb)
        {
            Nom = nom;
            Date = DateTime.Now;
            Personne = pers;
            Album = alb;
        }
    }
}
