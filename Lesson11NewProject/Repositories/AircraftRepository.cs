using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11NewProject
{
    public class AircraftRepository
    {

        public List<Aircraft> AircraftsList { get; set; }
        public AircraftRepository()
        {
            AircraftsList = new List<Aircraft>();
            AircraftsList.Add(new Aircraft("D-AIJA", "White", 1, 1));
            AircraftsList.Add(new Aircraft("LT-07", "Gray", 2, 0));
            AircraftsList.Add(new Aircraft("N101FE", "Yellow", 4, 2)); 
        }

        public List<Aircraft> Retrieve()
        {
            return AircraftsList;
        }

        public Aircraft Retrieve(string tailNumber)
        {
            return AircraftsList.Where(airc => airc.TailNumber == tailNumber).FirstOrDefault();
        }
    }
}
