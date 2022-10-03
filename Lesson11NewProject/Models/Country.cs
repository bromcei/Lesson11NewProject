using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11NewProject
{
    public class Country
    {
        public string CountryName { get; set; }
        public string CountryShortName { get; set; }
        public int CountryCode { get; set; }
        public string Continent { get; set; }
        public bool IsEU { get; set; }

        public bool IsEuropean { get; set;}

        public Country(string countryName, string countryShortName, int countryCode, string continent, bool isEU, bool isEuropean)
        {
            CountryName = countryName;
            CountryShortName = countryShortName;
            CountryCode = countryCode;
            Continent = continent;
            IsEU = isEU;
            IsEuropean = isEuropean;
        }
    }
}
