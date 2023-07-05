using NUnit.Framework;
using ohce.Helpers;
using ohce.Language;
using System;


namespace ohce
{
    internal class Application : IApplication
    {
        ISpeakSpanish _speakSpanish;
        public Application(ISpeakSpanish speakSpanish)
        {
            _speakSpanish = speakSpanish;
        }

        public void CorrectGreeting(string Name)
        {
            _speakSpanish.Name = Name;
            if (_speakSpanish.IsNightTime())
            {
                Assert.IsTrue(_speakSpanish.Message == "¡Buenas noches");
            }
            else
            if (_speakSpanish.IsAfterNoon())
            {
                Assert.IsTrue(_speakSpanish.Message == "¡Buenas tardes");
            }
            else
            if (_speakSpanish.IsMorning())
            {
                Assert.True(_speakSpanish.Message == "¡Buenas días");
            }
            Assert.IsFalse(_speakSpanish.Message == "Error");

            Console.WriteLine($"{_speakSpanish.Message} {Name}!");
        }
        public void Run(string Name)
        {
            string input;
            while ((input = Console.ReadLine()) != "Stop!")
            {
                var reversedString = input.ReverseString();
                Assert.AreNotEqual(Name, reversedString);
                
                Console.WriteLine(reversedString);
                
                if (input.IsPalindrome(reversedString) )
                {
                    Console.WriteLine(_speakSpanish.IsPalindrome);
                }
            }
            Console.WriteLine(_speakSpanish.SayGoodbye);
        }
    }
}
