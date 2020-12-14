using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class Personne
    { protected int ID { get; set; }
      protected string Nom { get; set; }
        protected string Type { get; set; }
    }
}
