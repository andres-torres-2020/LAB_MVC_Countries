using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace LAB_MVC_Countries
{
    class Program
    {
        static void Main(string[] args)
        {
            RunApp();
            //TestColors();
        }
        public static void TestColors()
        {
            string[] colors = { "Green", "red", "BlUe" };
            Array colz = Enum.GetValues(typeof(ConsoleColor));
            foreach (string color in colors)
            {
                ConsoleColor screenColor = StringUtil.GetConsoleColor(color);
                Console.BackgroundColor = screenColor;
                Console.WriteLine($"some text... in this color: {color} {screenColor}");
            }
        }
        public static void RunApp()
        {
            // Display information on different countries in the world using the
            // Model View Controller Design Pattern
            List<Country> CountryDb = new List<Country>
            {
                new Country("U.S.A.", "North America", new List<string>{ "magenta","White","Blue"}),
                new Country("Canada", "North America", new List<string>{ "Red","White"}),
                new Country("Mexico", "North America", new List<string>{ "Green","White","Red"}),
                new Country("Brazil", "South America", new List<string>{ "Green", "yellow", "Blue"}),
                new Country("Australia", "Australia", new List<string>{ "Blue","White","Red"}),
                new Country("China", "Asia", new List<string>{ "Red","yellow"}),
                new Country("India", "Asia", new List<string>{ "Green", "White", "yellow"}),
                new Country("Japan", "Asia", new List<string>{ "Red","White"}),
            };
            CountryController cc = new CountryController(CountryDb);
            cc.WelcomeAction();
        }
    }
}
