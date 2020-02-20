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
    }
}
