using ohce.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ohce.Language
{
    public class SpeakSpanish : ISpeakSpanish
    {
        private int _currentHour = 0;
        private string _message = "Error";
        public SpeakSpanish()
        {
            _currentHour = DateTime.Now.Hour;
        }

        public string Message => _message;

        public string IsPalindrome => "¡Bonita palabra!";

        public string SayGoodbye => $"Adios {Name}";

        public string Name { get; set; }

        public bool IsMorning()
        {
            bool currentTime = false;
            if (_currentHour >= 6 && _currentHour < 12)
            {
                _message = $"¡Buenas días";
                currentTime = true;
            }
            return currentTime;
        }
        public bool IsNightTime()
        {
            bool currentTime = false;
            if (((_currentHour >= 20) && (_currentHour <= 23)) ||
             ((_currentHour >= 0) && (_currentHour <= 6)))
            {
                _message = $"¡Buenas noches";
                currentTime = true;
            }
            return currentTime;
        }
        public bool IsAfterNoon()
        {
            bool currentTime = false;
            if ((_currentHour >= 12) && (_currentHour < 20))
            {
                _message = $"¡Buenas tardes!";
                currentTime = true;
            }
            return currentTime;
        }
    }
}
