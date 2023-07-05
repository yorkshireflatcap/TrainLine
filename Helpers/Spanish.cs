using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ohce.Helpers
{
    public class Words : IWords
    {
        public string text { get; set; }
        public bool palindrome { get; set; }
    }

    public class SpanishWords : ISpanishWords
    {
        public List<Words> data { get; set; }
        public void Greetings(string name)
        {

            var currentHour = DateTime.Now.Hour;
            if (currentHour >= 6 && currentHour < 12)
            {
                Console.WriteLine($"¡Buenas días {name}!");
            }
            else
            if (((currentHour >= 20) && (currentHour <= 23)) ||
                ((currentHour >= 0) && (currentHour <= 6)))
            {
                Console.WriteLine($"¡Buenas noches {name}!");
            }
            else
            if ((currentHour >= 12) && (currentHour < 20))
            {
                Console.WriteLine($"¡Buenas tardes {name}!");
            }
        }
    }
}
