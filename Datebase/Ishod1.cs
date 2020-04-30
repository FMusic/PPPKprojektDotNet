using PPPKprojektDotNet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace PPPKprojektDotNet.Datebase
{
    public static class Ishod1
    {
        public static IList<Driver> GetDrivers()
        {
            IList<Driver> lista = new List<Driver>();
            string cs = DbProps.GetCs();
            string query = "Select * from Drivers";
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.HasRows)
                        {
                            while (r.Read())
                            {
                                Driver d = new Driver();
                                d.Id = (int)r["IDDriver"];
                                d.Name = r["Name"].ToString();
                                d.Surname = r["Surname"].ToString();
                                d.PhoneNumber = r["phoneNumber"].ToString();
                                d.DriversLicenseID = r["driversLicenseID"].ToString();
                                lista.Add(d);
                            }
                        }
                    }
                }
                conn.Close();
            }
            return lista;
        }

        public static int SaveDriver(Driver d)
        {
            string cs = DbProps.GetCs();
            string query = "INSERT INTO Driver(Name,Surname,phoneNumber,driversLicenseID) " +
                "VALUES(@param1,@param2,@param3,@param4)";
            int v;
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@param1", SqlDbType.VarChar).Value = d.Name;
                    cmd.Parameters.Add("@param2", SqlDbType.VarChar).Value = d.Surname;
                    cmd.Parameters.Add("@param3", SqlDbType.VarChar).Value = d.PhoneNumber;
                    cmd.Parameters.Add("@param3", SqlDbType.VarChar).Value = d.DriversLicenseID;
                    cmd.CommandType = CommandType.Text;
                    v = cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            return v;
        }

        public static int UpdateDriver(Driver d, int id)
        {
            string pname = "@name";
            string psurname = "@surname";
            string pphone = "@phone";
            string plicense = "@license";
            string pid = "@id";
            String cs = DbProps.GetCs();
            string delim = ",";
            string query = "UPDATE Driver(Name, Surname, phoneNumber, driversLicenseID) " +
                "SET (" + pname + delim + psurname + delim + pphone + delim + plicense + ")" +
                "WHERE IDDriver = " + pid;
            int v;
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.Parameters.AddWithValue(pid, id);
                    cmd.Parameters.AddWithValue(pname, d.Name);
                    cmd.Parameters.AddWithValue(psurname, d.Surname);
                    cmd.Parameters.AddWithValue(pphone, d.PhoneNumber);
                    cmd.Parameters.AddWithValue(plicense, d.DriversLicenseID);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    v = cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            return v;
        }

        public static int DeleteDriver(int id)
        {
            string query = "DELETE FROM Driver WHERE id=@pid";
            int v;
            using (SqlConnection conn = new SqlConnection(DbProps.GetCs()))
            {
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.Parameters.AddWithValue("@pid", id);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    v = cmd.ExecuteNonQuery();
                }
            }
            return v;
        }
        
        public static IList<TravelWarrant> GetAllTravelWarrants()
        {
            IList<Vehicle> vehicles = GetAllVehicles();
            IList<Driver> drivers = GetDrivers();
            IList<TravelWarrant> warrants = GetAllWarrants(vehicles, drivers);
            return warrants;
        }

        private static IList<TravelWarrant> GetAllWarrants(IList<Vehicle> vehicles, IList<Driver> drivers){
            IList<TravelWarrant> warrants = new List<TravelWarrant>();
            using (SqlConnection conn = new SqlConnection(DbProps.GetCs()))
            {
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "GetAllTravelWarrants";
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.HasRows)
                        {
                            while (r.Read())
                            {
                                warrants.Add(new TravelWarrant
                                {
                                    IDWarrant = (int)r["IDWarrant"],
                                    VehicleID = (int)r["VehicleID"],
                                    DriverID = (int)r["DriverID"],
                                    WarrantStateID = (int)r["WarrantStateEnumId"],
                                    Driver = drivers.Where(x => x.Id == (int)r["DriverID"]).FirstOrDefault(),
                                    Vehicle = vehicles.Where(x=> x.IDVehicle == (int)r["VehicleID"]).FirstOrDefault(),
                                    WarrantState = (TravelWarrantStateEnum)(int)r["WarrantStateEnumId"]
                                });
                            }
                        }
                    }
                }
                conn.Close();
            }
            return warrants;
        }

        private static IList<Vehicle> GetAllVehicles()
        {
            IList<Vehicle> lista = new List<Vehicle>();
            string cs = DbProps.GetCs();
            string query = "Select * from Vehicles";
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.HasRows)
                        {
                            while (r.Read())
                            {
                                Vehicle v = new Vehicle();
                                v.IDVehicle = (int)r["IDVehicle"];
                                v.Maker = r["[Maker]"].ToString();
                                v.Miles = (int)r["miles"];
                                v.Type = r["Type"].ToString();
                                v.YearOfMaking = (int)r["YearOfMaking"];
                                lista.Add(v);
                            }
                        }
                    }
                }
                conn.Close();
            }
            return lista;
        }

        public static int UpdateWarrant(int id, TravelWarrant tv)
        {
            int v = 0;
            using (SqlConnection conn = new SqlConnection(DbProps.GetCs()))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UpdateWarrant";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@travelwarrantID", id);
                    cmd.Parameters.AddWithValue("@vehicleid", tv.VehicleID);
                    cmd.Parameters.AddWithValue("@warrantstateid", tv.WarrantStateID);
                    cmd.Parameters.AddWithValue("@driverid", tv.DriverID);
                    v = cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            return v;
        }

        public static int DeleteWarrant(int id)
        {
            int v = 0;
            using (SqlConnection conn = new SqlConnection(DbProps.GetCs()))
            {
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DeleteWarrant";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@warrantid", id);
                    v = cmd.ExecuteNonQuery();
                }
            }
            return v;
        }

        public static int SaveWarrant(TravelWarrant tv)
        {
            int v = 0;
            using (SqlConnection conn = new SqlConnection(DbProps.GetCs()))
            {
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SaveWarrant";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@driverid", tv.DriverID);
                    cmd.Parameters.AddWithValue("@vehicleid", tv.VehicleID);
                    cmd.Parameters.AddWithValue("@warrantstateid", tv.WarrantStateID);
                    v = cmd.ExecuteNonQuery();
                }
            }
            return v;
        }
    }
}
