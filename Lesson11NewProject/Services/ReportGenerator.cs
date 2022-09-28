using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11NewProject
{
    public class ReportGenerator
    {
        public AircraftRepository _aircraftRepository { get; set; }
        public AircraftModelRepository _aircraftModelRepository { get; set; }
        public CompanyRepository _companyRepository { get; set; }
        public CountryRepository _countryRepository { get; set; }

        public ReportGenerator(AircraftRepository aircraftRepository, AircraftModelRepository aircraftModelRepository, CompanyRepository companyRepository, CountryRepository countryRepository)
        {
            _aircraftRepository = aircraftRepository;
            _aircraftModelRepository = aircraftModelRepository;
            _companyRepository = companyRepository; 
            _countryRepository = countryRepository;
        }

        public List<ReportItem> GeneratereportAircraftInEurope()
        {
            List<Aircraft> AllAirCrafts = _aircraftRepository.Retrieve();
            List<ReportItem> ReportList = new List<ReportItem>();

            int companyID;
            int countryID;
            Country country;
            ReportItem reportItem;
            foreach (Aircraft plane in AllAirCrafts)
            {
                companyID = plane.CompanyAircraftID;
                countryID = _companyRepository.Retrieve(companyID).CompanyCountryID;
                country = _countryRepository.Retrieve(countryID);
                if (country.IsEU)
                {
                    reportItem = new ReportItem(plane.TailNumber, _aircraftModelRepository.Retrieve(plane.AircraftModelID).ModelName, _companyRepository.Retrieve(companyID).CompanyName, country.CountryName)
;                   ReportList.Add(reportItem);
                }
            }


            return ReportList;

        }
    }
}
