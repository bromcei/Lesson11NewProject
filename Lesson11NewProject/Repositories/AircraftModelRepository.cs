using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11NewProject
{

    public class AircraftModelRepository
    {
        public List<AircraftModel> AircraftModelsList { get; set; }

        public AircraftModelRepository()
        {
            AircraftModelsList = new List<AircraftModel>();
            AircraftModelsList.Add(new AircraftModel("Boeing 737-800", "Boeing", "Carrier", 2, 0));
            AircraftModelsList.Add(new AircraftModel("Airbus 320", "Airbus", "Carrier", 2, 1));
            AircraftModelsList.Add(new AircraftModel("C-27J Spartan", "Alenia ", "Military Cargo", 2, 2));
            AircraftModelsList.Add(new AircraftModel("F-16", "Lockheed Martin", "Fighter", 2, 3));
            AircraftModelsList.Add(new AircraftModel("Boeing 747", "Boeing", "Cargo", 4, 4));
            AircraftModelsList.Add(new AircraftModel("Airbus 340", "Airbus", "Carrier", 4, 5));

        }

        public AircraftModel Retrieve(int aircraftModelID)
        {
            return AircraftModelsList.Where(mod => mod.ModelID == aircraftModelID).FirstOrDefault();
        }

        public List<AircraftModel> Retrieve()
        {
            return AircraftModelsList;
        }

    }
}
