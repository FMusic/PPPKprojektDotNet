using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPKprojektDotNet.Model
{
    class AllModel
    {
        public IList<Driver> Drivers { get; set; }
        public IList<Route> Routes { get; set; }
        public IList<TravelWarrant> TravelWarrants { get; set; }
        public IList<Vehicle> Vehicles { get; set; }

        public AllModel()
        {

        }

        public AllModel(IList<Driver> drivers, IList<Route> routes, 
            IList<TravelWarrant> travelWarrants, IList<Vehicle> vehicles)
        {
            Drivers = drivers;
            Routes = routes;
            TravelWarrants = travelWarrants;
            Vehicles = vehicles;

        }
    }
}
