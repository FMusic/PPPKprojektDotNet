using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPKprojektDotNet.Model
{
    class TravelWarrantVM
    {

        public int IDWarrant { get; set; }
        public TravelWarrantStateEnum WarrantStateEnum { get; set; }
        public Driver Driver { get; set; }
        public Vehicle Vehicle { get; set; }
        public TravelWarrantVM(TravelWarrant tv)
        {
            this.IDWarrant = tv.IDWarrant;
            this.WarrantStateEnum = tv.WarrantState;
            this.Driver = tv.Driver;
            this.Vehicle = tv.Vehicle;
        }
    }
}
