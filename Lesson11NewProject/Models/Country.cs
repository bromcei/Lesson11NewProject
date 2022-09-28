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
        public bool IsEU { get; set; }

        public Country(string countryName, string countryShortName, int countryCode, bool isEU)
        {
            CountryName = countryName;
            CountryShortName = countryShortName;
            CountryCode = countryCode;
            IsEU = isEU;
        }
    }
}
