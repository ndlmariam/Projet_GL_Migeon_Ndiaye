using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class Personne
    {
        public virtual int ID { get; set; }
        public virtual string Nom { get; set; }
        public virtual string Type { get; set; }
        public virtual string Login { get; set; }
        public virtual string Mdp { get; set; }
      
        

    }
}
