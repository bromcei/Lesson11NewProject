using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11NewProject
{
    public class ReportItem
    {
        public string TailNumber { get; set; }
        public string AircraftModel { get; set; }
        public string CompanyName { get; set; }
        public string Country { get; set; }

        public ReportItem(string tailNumber, string aircraftModel, string companyName, string country)
        {
            TailNumber = tailNumber;
            AircraftModel = aircraftModel;
            CompanyName = companyName;
            Country = country;
        }
    }

}
