using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPKprojektDotNet.Model
{
    public class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DriversLicenseID { get; set; }
        public string PhoneNumber { get; set; }

        public Driver()
        {

        }

        public Driver(string name, string surname, string driversLicenseID, string phoneNumber)
        {
            Name = name;
            Surname = surname;
            DriversLicenseID = driversLicenseID;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return Name+" "+Surname;
        }
    }
}

