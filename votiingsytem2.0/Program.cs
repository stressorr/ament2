using System;
using System.Collections.Generic;

namespace votiingsytem2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int yCount = 0;
            int nCount = 0;
            int aCount = 0;
            //Put all the country in a list
            List<Country> CountryList = new List<Country>();

            //list of all the country
            CountryList.Add(new Country("Austrai", 1.98));
            CountryList.Add(new Country("Belgium", 2.56));
            CountryList.Add(new Country("Bulgaria", 1.56));
            CountryList.Add(new Country("Croatia", 0.91));
            CountryList.Add(new Country("Cyprus", 0.20));
            CountryList.Add(new Country("Crech Republic", 2.35));
            CountryList.Add(new Country("Denmark", 1.30));
            CountryList.Add(new Country("Estonia", 0.30));
            CountryList.Add(new Country("Finland", 1.23));
            CountryList.Add(new Country("France", 14.98));
            CountryList.Add(new Country("Germany", 18.54));
            CountryList.Add(new Country("Greece", 2.40));
            CountryList.Add(new Country("Hungary", 2.18));
            CountryList.Add(new Country("Italy", 13.65));
            CountryList.Add(new Country("Latvia", 0.43));
            CountryList.Add(new Country("Lithuania", 0.62));
            CountryList.Add(new Country("Luxembourg", 0.14));
            CountryList.Add(new Country("Malta", 0.11));
            CountryList.Add(new Country("Netherland", 3.89));
            CountryList.Add(new Country("Poland", 8.49));
            CountryList.Add(new Country("Portugal", 2.30));
            CountryList.Add(new Country("Romania", 4.34));
            CountryList.Add(new Country("Slovakia", 1.22));
            CountryList.Add(new Country("Slovenia", 0.47));
            CountryList.Add(new Country("Spain", 10.49));
            CountryList.Add(new Country("Sweden", 2.29));

            foreach(var country in CountryList)
            {
                Console.WriteLine($"{country.CountryName} {country.CountryPercent} Yes:{yCount} No:{nCount} Abstain:{aCount}");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                string userInput = Console.ReadLine();
                if(userInput == "y")
                {
                    yCount++;
                }
                if(userInput == "n")
                {
                    nCount++;
                }
                else if(userInput == "a")
                {
                    aCount++;
                }
            }

        }
    }
}
