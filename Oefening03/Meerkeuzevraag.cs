using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening03
{
    public class Meerkeuzevraag: Vraag
    {
        public Meerkeuzevraag(string tekst, int indexOfCorrectAntwoord, params string[] antwoorden)
            :base(tekst)
        {
            for (int i = 0; i < antwoorden.Length; i++)
            {
                Antwoorden.Add(new MeerkeuzevraagAntwoord((char)('A' + i), antwoorden[i], i == indexOfCorrectAntwoord));
            }
        }

        /// <summary>
        /// Lijst van mogelijke antwoorden.
        /// </summary>
        public List<MeerkeuzevraagAntwoord> Antwoorden { get; set; } = new List<MeerkeuzevraagAntwoord>();

        /// <summary>
        /// De vraag stellen en alle mogelijke antwoorden tonen.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder(base.ToString());
            builder.AppendLine();
            foreach (Antwoord antwoord in Antwoorden)
            {
                builder.AppendLine(antwoord.ToString());
            }
            return builder.ToString();
        }

        /// <summary>
        /// Controleren of het gegeven antwoord juist is.
        /// </summary>
        /// <param name="antwoord"></param>
        /// <returns>null indien het antwoord niet kan geïnterpreteerd worden.</returns>
        public override bool? CheckAntwoord(string antwoord)
        {
            antwoord = antwoord.ToUpper();
            if (antwoord.Length == 1 && Antwoorden.Exists(a => a.Code == antwoord[0]))
            {
                return Antwoorden.Exists(a => a.Code == antwoord[0] && a.IsCorrectAntwoord);
            }
            else
            {
                return null;
            }
        }
    }
}
