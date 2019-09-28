using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening03
{
    public abstract class Antwoord
    {
        public Antwoord(string tekst)
        {
            this.Tekst = tekst;
        }

        public string Tekst { get; set; }

        public override string ToString()
        {
            return Tekst;
        }
    }
}
