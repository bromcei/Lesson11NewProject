using Microsoft.VisualBasic;
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
                if (country.IsEuropean)
                {
                    reportItem = new ReportItem(
                        plane.TailNumber, 
                        _aircraftModelRepository.Retrieve(plane.AircraftModelID).ModelName, 
                        _companyRepository.Retrieve(companyID).CompanyName, 
                        country.Continent, 
                        country.CountryName,
                        country.IsEuropean,
                        country.IsEU)
;                   ReportList.Add(reportItem);
                }
            }


            return ReportList;
        }


        public List<ReportItem> GenerateReportAllAircrafts()
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
          
                reportItem = new ReportItem(
                plane.TailNumber,
                _aircraftModelRepository.Retrieve(plane.AircraftModelID).ModelName,
                _companyRepository.Retrieve(companyID).CompanyName,
                country.Continent,
                country.CountryName,
                country.IsEuropean,
                country.IsEU);                      
                ReportList.Add(reportItem);
               
            }


            return ReportList;
        }



        public void GeneratereportAircraftInEUHTML() 
        { 
            DateTime currDate = DateTime.Now;
            string HTMLPath = $"C:\\Users\\tomas.ceida\\source\\repos\\Lesson11NewProject\\Lesson11NewProject\\Reports\\Report_EU_aircrafts_{currDate.ToString("yyyy'-'MM'-'dd'T'HH'_'mm'_'ss")}.html";

            string HTMLUpperPart = $@"
                <!DOCTYPE html>
                <html>
                <body>
                <h1>Aircraft Report {currDate.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss")} </h1>
                <table>
                  <tr>
                    <th>TailNumber</th>
                    <th>ModelName</th>
                    <th>CompanyName</th>
                    <th>CountryName</th>
                  </tr>
                        ";


            string HTMLLowerPart = @"
                </table>
                </body>
                </html>
                ";

            string HTMLTable = "";
            string backGroundColor;
            List<ReportItem> ReportList = GeneratereportAircraftInEurope();

            foreach (ReportItem reportItem in ReportList)
            {
                if (reportItem.IsEu)
                {
                    backGroundColor = "#00FFFF";
                }
                else
                {
                    backGroundColor = "#AA4A44";
                }
                HTMLTable += $@"
                <tr style=""background-color:{backGroundColor}"">
                <td>{reportItem.TailNumber}</td>
                <td>{reportItem.AircraftModel}</td>
                <td>{reportItem.CompanyName}</td>
                <td>{reportItem.Country}</td>
                </tr>
                ";
            }
            Console.WriteLine(HTMLUpperPart + HTMLTable + HTMLLowerPart);
            System.IO.File.WriteAllText(HTMLPath, HTMLUpperPart + HTMLTable + HTMLLowerPart);
        }

        public void GeneratereportAllAircraftsHTML()
        {
            DateTime currDate = DateTime.Now;
            string HTMLPath = $"C:\\Users\\tomas.ceida\\source\\repos\\Lesson11NewProject\\Lesson11NewProject\\Reports\\Report_All_Aircrafts_{currDate.ToString("yyyy'-'MM'-'dd'T'HH'_'mm'_'ss")}.html";

            string HTMLUpperPart = $@"
                <!DOCTYPE html>
                <html>
                <body>
                <h1>Aircraft Report {currDate.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss")} </h1>
                <table>
                  <tr>
                    <th>TailNumber</th>
                    <th>ModelName</th>
                    <th>CompanyName</th>
                    <th>CountryName</th>
                  </tr>
                        ";


            string HTMLLowerPart = @"
                </table>
                </body>
                </html>
                ";

            string HTMLTable = "";
            string backGroundColor;
            List<ReportItem> ReportList = GenerateReportAllAircrafts();

            foreach (ReportItem reportItem in ReportList)
            {
                if (reportItem.IsEu)
                {
                    backGroundColor = "#00FFFF";
                }
                else
                {
                    backGroundColor = "#AA4A44";
                }
                HTMLTable += $@"
                <tr style=""background-color:{backGroundColor}"">
                <td>{reportItem.TailNumber}</td>
                <td>{reportItem.AircraftModel}</td>
                <td>{reportItem.CompanyName}</td>
                <td>{reportItem.Country}</td>
                </tr>
                ";
            }

            System.IO.File.WriteAllText(HTMLPath, HTMLUpperPart + HTMLTable + HTMLLowerPart);
        }

    }
}
