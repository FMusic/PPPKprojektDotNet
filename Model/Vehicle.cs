using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPKprojektDotNet.Model
{
    public class Vehicle
    {
        public int IDVehicle { get; set; }
        public string Maker { get; set; }
        public int YearOfMaking { get; set; }
        public int Miles { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return Maker + " " + Type + " " + YearOfMaking.ToString(); 
        }
    }
}
