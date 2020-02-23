using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPKprojektDotNet.Model
{
    public class Route
    {
        public int IDRoute { get; set; }
        public int WarrantID { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }

        public string CoordA { get; set; }
        public string CoordB { get; set; }
        public int DistanceKm { get; set; }
        public int AvgSpeed { get; set; }
        public int FuelSpent { get; set; }
    }
}
