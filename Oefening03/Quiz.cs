using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening03
{
    public class Quiz
    {
        private int score = 0;

        public Quiz()
        {
            // Lijst van vragen samenstellen.
            // Hier hardcoded, maar zou ook uit file kunnen opgeladen worden, via web ophalen, ...
            this.Vragen = new List<Vraag>()
            {
                new Meerkeuzevraag(
                    "In welke stad kun je het Gravensteen bezoeken?", 
                    0, 
                    "Gent", "Brussel", "Leuven", "Brugge"),
                new Meerkeuzevraag(
                    "Wie geld heeft kan het zich permitteren: kaviaar. Van welke vis zijn dit de eitjes?",
                    2,
                    "Tong", "Haai", "Steur", "Zeeduivel"),
                new Meerkeuzevraag(
                    "In welke legendarische TV-serie zijn Jefferson en Marcy D'Arcy de buren?",
                    1,
                    "That '70s show", "Married with Children", "Friends", "Wonder years"),
                new Meerkeuzevraag(
                    "Hoe schrijf je het getal 37 in het binaire stelsel?",
                    0,
                    "100101", "100110", "1100101", "101010"),
                new Meerkeuzevraag(
                    "In welke gemeente woonde Eddy Wally?",
                    3,
                    "Aalst", "Knokke", "Denderleeuw", "Ertvelde"),
            };
        }

        /// <summary>
        /// Lijst van vragen die tijdens de quiz gesteld zullen worden.
        /// </summary>
        public List<Vraag> Vragen { get; set; }

        /// <summary>
        /// Starten met de quiz.
        /// </summary>
        public void Play()
        {
            for (int i = 0; i < Vragen.Count; i++)
            {
                Console.WriteLine($"(Vraag {i + 1}/{Vragen.Count}) " + Vragen[i].ToString());
                Console.Write("Antwoord: ");
                string antwoord = Console.ReadKey().KeyChar.ToString();
                bool? checkedAntwoord = null;
                while (checkedAntwoord == null)
                {
                    checkedAntwoord = Vragen[i].CheckAntwoord(antwoord);
                }
                if (checkedAntwoord.Value) score++;
                Console.WriteLine();
                Console.WriteLine();
            }

            if (score >= 3)
            {
                Console.WriteLine("Proficiat, je hebt gewonnen!");
            }
            else
            {
                Console.WriteLine("Spijtig, volgende keer beter...");
            }
        }
    }
}
