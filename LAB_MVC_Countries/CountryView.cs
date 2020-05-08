using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_MVC_Countries
{
    class CountryView
    {
        public Country DisplayCountry { get; set; }
        public CountryView(Country DisplayCountry)
        {
            this.DisplayCountry = DisplayCountry;
        }
        public void DisplayColorized(string s)
        {
            int i = 0;
            ConsoleColor screenColor;
            foreach (char c in s)
            {
                screenColor = StringUtil.GetConsoleColor(this.DisplayCountry.Colors[i]);
                Console.BackgroundColor = screenColor;
                Console.Write(c);
                i++;
                if (i == this.DisplayCountry.Colors.Count)
                {
                    i = 0;
                }
            }
            Console.ResetColor();
        }
        public void Display()
        {
            Console.Write($"Country: {this.DisplayCountry.Name} ");

            DisplayColorized($"{new string(' ', this.DisplayCountry.Colors.Count)}\n");

            Console.WriteLine($"Continent: {this.DisplayCountry.Continent}");
        }
    }
}
