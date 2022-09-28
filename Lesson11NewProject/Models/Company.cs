using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11NewProject
{
    public class Company
    {
        public string CompanyName { get; set; }
        public string CompanyType { get; set; }
        public int CompanyCountryID { get; set; }
        public string CompanyAddress { get; set; }
        public int CompanyID { get; set; }

        public Company(string companyName, string companyType, int companyCountryID, string companyAddress, int companyID)
        {
            CompanyName = companyName;
            CompanyType = companyType;
            CompanyCountryID = companyCountryID;
            CompanyAddress = companyAddress;
            CompanyID = companyID;
        }
    }
}
