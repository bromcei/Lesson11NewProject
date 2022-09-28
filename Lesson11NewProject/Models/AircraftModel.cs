using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11NewProject
{
    public class AircraftModel
    {
        public string ModelName { get; set; }
        public string Manufacturer { get; set; }
        public string AircraftType { get; set; }
        public int EngingeCount { get; set; }
        public int ModelID { get; set; }

        public AircraftModel(string modelName, string manufacturer, string aircraftType, int engingeCount, int modelID)
        {
            ModelName = modelName;
            Manufacturer = manufacturer;
            AircraftType = aircraftType;
            EngingeCount = engingeCount;
            ModelID = modelID;
        }
    }
}
