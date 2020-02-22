using PPPKprojektDotNet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPKprojektDotNet.Datebase
{
    public static class Ishod4
    {
        public static IList<Route> GetRoutesForWarrant(TravelWarrant tw)
        {
            IList<Route> routes = new List<Route>();

            return routes;
        }

        public static int UpdateRoute(Route r)
        {

        }

        public static int DeleteRoute(Route r)
        {
            int rid = r.IDRoute;
        }

        public static int SaveRoute(Route r, TravelWarrant tw)
        {
            int travelID = tw.IDWarrant;
            int v = 0;

            return v;
        }
    }
}
