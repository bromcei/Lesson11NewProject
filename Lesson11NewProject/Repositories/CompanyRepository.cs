using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11NewProject
{

    public class CompanyRepository
    {
        public List<Company> CompaniesList { get; set; }

        public CompanyRepository()
        {
            CompaniesList = new List<Company>();
            CompaniesList.Add(new Company("LAF", "Military", 0, "Verkiu 1, Vilnius", 0));
            CompaniesList.Add(new Company("Lufthansa", "Carrier", 8, "OctoberFest Straße 15, Dortmund", 1));
            CompaniesList.Add(new Company("TNT", "Cargo", 2, "Burger Street 15, new York", 2));
            CompaniesList.Add(new Company("Air France", "Carrier", 3, "La Bagette venue 13, Paris", 3));
            CompaniesList.Add(new Company("Norwegian Airlines", "Carrier", 9, "Fjord str 14, Oslo", 4));
            CompaniesList.Add(new Company("Egypt Airlines", "Carrier", 6, "Pyramid Scheme 15, cairo", 5));
            CompaniesList.Add(new Company("Level", "Cargo", 5, "", 6));
            CompaniesList.Add(new Company("Random", "Carrier", 5, "Randominis", 7));

        }

       public Company Retrieve(int companyID)
        {
            return CompaniesList.Where(comp => comp.CompanyID == companyID).FirstOrDefault();
        }

        public List<Company> Retrieve()
        {
            return CompaniesList;
        }

    }
}
