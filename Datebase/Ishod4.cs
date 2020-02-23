using Microsoft.ApplicationBlocks.Data;
using PPPKprojektDotNet.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            using (SqlDataReader reader = SqlHelper.ExecuteReader(DbProps.GetCs(), "GetWarrants"))
            {
                while (reader.Read())
                {
                    routes.Add(new Route
                    {
                        IDRoute = (int)reader["IDRoute"],
                        WarrantID = (int)reader["WarrantID"],
                        DateStart = DateTime.Parse(reader["DateFrom"].ToString()),
                        DateEnd = DateTime.Parse(reader["DateTo"].ToString()),
                        CoordA = reader["CoordA"].ToString(),
                        CoordB = reader["CoordB"].ToString(),
                        DistanceKm = (int) reader["DistanceInKm"],
                        AvgSpeed = (int) reader["AvgV"],
                        FuelSpent = (int) reader["FuelSpent"]
                    });
                }
            }
            return routes;
        }

        public static int UpdateRoute(Route r) => SqlHelper.ExecuteNonQuery(DbProps.GetCs(), "UpdateRoute", r.WarrantID, r.DateStart, r.DateEnd, r.CoordA, r.CoordB, r.DistanceKm, r.AvgSpeed, r.FuelSpent);

        public static int DeleteRoute(Route r) => SqlHelper.ExecuteNonQuery(DbProps.GetCs(), "DeleteRoute", r.IDRoute);

        public static int SaveRoute(Route r, TravelWarrant tw) => SqlHelper.ExecuteNonQuery(DbProps.GetCs(), "SaveRoute", r.WarrantID, r.DateStart, r.DateEnd, r.CoordA, r.CoordB, r.DistanceKm, r.AvgSpeed, r.FuelSpent);
    }
}
