using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson11NewProject
{

    public class CountryRepository
    {
        public List<Country> CountryList { get; set; }

        public CountryRepository()
        {
            CountryList = new List<Country>();
            CountryList.Add(new Country("Lithuania", "LT", 0, true));
            CountryList.Add(new Country("United States of America", "USA", 1, false));
            CountryList.Add(new Country("Canada", "CAN", 2, false));
            CountryList.Add(new Country("France", "FRA", 3, false));
            CountryList.Add(new Country("India", "IND", 4, false)) ;
            CountryList.Add(new Country("Spain", "ESP", 5, true));
            CountryList.Add(new Country("Egypt", "EGY", 6, false));
            CountryList.Add(new Country("Sweden", "SWE", 7, true));
            CountryList.Add(new Country("Germany", "GER", 8, true));
        }
        public Country Retrieve(int countryID)
        {

            //return CountryList[countryID];
            return CountryList.Where(c => c.CountryCode == countryID).FirstOrDefault();
        }

        public List<Country> Retrieve()
        {
            return CountryList;
        }

    }
}
