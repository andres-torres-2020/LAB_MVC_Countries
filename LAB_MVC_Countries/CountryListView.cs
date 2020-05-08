using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_MVC_Countries
{
    class CountryListView
    {
        public List<Country> Countries { get; set; }
        public CountryListView(List<Country> Countries)
        {
            this.Countries = Countries;
        }
        public void Display()
        {
            for (int i = 0; i < Countries.Count; i++)
            {
                Console.WriteLine($"\t{i,2} {Countries[i].Name}");
            }
        }
    }
}
