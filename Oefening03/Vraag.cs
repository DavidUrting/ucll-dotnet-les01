using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening03
{
    public abstract class Vraag
    {
        public Vraag(string tekst)
        {
            this.Tekst = tekst;
        }

        /// <summary>
        /// De vraag die gesteld moet worden aan de speler.
        /// </summary>
        public string Tekst { get; set; }

        /// <summary>
        /// Te implementeren methode die het antwoord van de gebruiker controleert.
        /// </summary>
        /// <param name="antwoord"></param>
        /// <returns>null indien het antwoord niet kan geïnterpreteerd worden.</returns>
        public abstract bool? CheckAntwoord(string antwoord);

        /// <summary>
        /// De vraag stellen.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Tekst;
        }
    }
}
