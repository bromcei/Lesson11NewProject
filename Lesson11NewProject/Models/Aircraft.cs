using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11NewProject
{
    public class Aircraft
    {
        public string TailNumber { get; set; }
        public string AircraftColor { get; set; }
        public int AircraftModelID { get; set; }
        public int CompanyAircraftID { get; set; }

        public Aircraft(string tailNumber, string aircraftColor, int aircraftModelID, int companyAircraftID)
        {
            TailNumber = tailNumber;
            AircraftColor = aircraftColor;
            AircraftModelID = aircraftModelID;
            CompanyAircraftID = companyAircraftID;
        }

    }
}
