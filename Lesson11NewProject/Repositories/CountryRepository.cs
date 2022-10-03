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
            CountryList.Add(new Country("Lithuania", "LT", 0, "Europe", true, true));
            CountryList.Add(new Country("United States of America", "USA", 1, "North America", false, false));
            CountryList.Add(new Country("Canada", "CAN", 2, "North America",false, false));
            CountryList.Add(new Country("France", "FRA", 3, "Europe", false, true));
            CountryList.Add(new Country("India", "IND", 4, "North America", false, false)) ;
            CountryList.Add(new Country("Spain", "ESP", 5, "Europe", true, true));
            CountryList.Add(new Country("Egypt", "EGY", 6, "Africa", false, false));
            CountryList.Add(new Country("Sweden", "SWE", 7, "Europe", true, true));
            CountryList.Add(new Country("Germany", "GER", 8, "Europe", true, true));
            CountryList.Add(new Country("Norway", "NOR", 9, "Europe",false, true));
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
