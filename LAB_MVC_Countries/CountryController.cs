using System;
using System.Collections.Generic;
using System.Text;
using Utilities;

namespace LAB_MVC_Countries
{
    class CountryController
    {
        public List<Country> CountryDb { get; set; }
        public CountryController(List<Country> CountryDb)
        {
            this.CountryDb = CountryDb;
        }
        public void CountryAction(Country c)
        {
             // This will take in a Country model, passing the model into the CountryView constructor,
             // and call Display Country on your CountryView object
            CountryView cv = new CountryView(c);
            cv.Display();
        }
        // This will take no parameter and pass CountryDb into the CountryListView class.
        // Then, it will print “Hello, welcome to the country app. Please select a country from the following list:” 
        // Then it will call Display() on the CountryListView.
        // Next allow the user to select a country by index.
        // Upon getting the country out of CountryDb, pass that country along to the CountryAction() method.
        // After that’s done, ask if the user would like to learn about another country.
        public void WelcomeAction()
        {
            CountryListView clv = new CountryListView(this.CountryDb);
            bool continueApp = true;
            while (continueApp)
            {
                Console.Clear();
                Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:");
                clv.Display();
                int countryIndex = InputUtil.ReadInteger("Please select a country", 0, clv.Countries.Count - 1);
                Country choice = clv.Countries[countryIndex];
                this.CountryAction(choice);
                continueApp = InputUtil.GetYesNo("\nWould you like to learn about another country? (y/n)");
            }
        }
    }
}
