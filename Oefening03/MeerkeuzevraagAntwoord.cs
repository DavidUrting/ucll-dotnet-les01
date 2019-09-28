using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening03
{
    public class MeerkeuzevraagAntwoord: Antwoord
    {
        public MeerkeuzevraagAntwoord(char code, string tekst, bool isCorrectAntwoord): base(tekst)
        {
            this.Code = code;
            this.IsCorrectAntwoord = isCorrectAntwoord;
        }

        public char Code { get; set; }
        public bool IsCorrectAntwoord { get; set; }

        public override string ToString()
        {
            return Code + ": " + base.ToString();
        }
    }
}
