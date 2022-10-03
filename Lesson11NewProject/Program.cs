using System;
using System.Collections.Generic;

namespace Lesson11NewProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ReportGenerator reportGenerator = new ReportGenerator(new AircraftRepository(), new AircraftModelRepository(), new CompanyRepository(), new CountryRepository());

            foreach (ReportItem report in reportGenerator.GeneratereportAircraftInEurope())
            {
                Console.WriteLine($"{report.TailNumber}, {report.AircraftModel}, {report.CompanyName}, {report.Country}");
            }

            reportGenerator.GeneratereportAircraftInEUHTML();
            reportGenerator.GeneratereportAllAircraftsHTML();



        }
    }
}
