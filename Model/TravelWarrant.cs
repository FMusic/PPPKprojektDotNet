using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPKprojektDotNet.Model
{
    public class TravelWarrant
    {
        public int IDWarrant { get; set; }
        public int DriverID { get; set; }
        public int VehicleID { get; set; }
        public TravelWarrantStateEnum WarrantState { get; set; }
        public int WarrantStateID { 
            get {
                return (int)WarrantState;
            }
            set
            {
                WarrantState = (TravelWarrantStateEnum) value;
            }
        }
        public Driver Driver { get; set; }
        public Vehicle Vehicle { get; set; }

        public IList<Route> Routes { get; set; }

        public TravelWarrant()
        {

        }

        public TravelWarrant(int driverID, int vehicleID, TravelWarrantStateEnum twstate)
        {
            DriverID = driverID;
            VehicleID = vehicleID;
            WarrantState = twstate;
        }
    }

    public enum TravelWarrantStateEnum
    {
        OPEN = 1,
        CLOSED = 2,
        FUTURE = 3,
        //REFERENCE FOR ALL
        DEFAULT = 0
    }
}
