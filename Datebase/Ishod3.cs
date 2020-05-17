using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace PPPKprojektDotNet.Datebase
{
    public static class Ishod3
    {
        public static int ImportXmlRoutes(string xmlFileName)
        {
            using (StreamReader sr = new StreamReader(xmlFileName))
            {
                using (XmlReader reader = XmlReader.Create(sr))
                {
                    using (DataSet ds = new DataSet())
                    {
                        ds.ReadXml(reader);
                        return SaveDataSetToRoutes(ds);
                    }
                }
            }
        }

        private static int SaveDataSetToRoutes(DataSet ds)
        {
            int v = 0;
            using(SqlConnection conn = new SqlConnection(DbProps.GetCs()))
            {
                string selectQuery = "SELECT * FROM Routes";
                string insertQuery = "INSERT INTO Routes" +
                    "(WarrantID, DateFrom, DateTo, CoordA, CoordB, DistanceInKm, AvgV, FuelSpent) VALUES " +
                    "(@warrantid, @datefrom, @dateto, @cooA, @cooB, @disInKm, @avgV, @fuel)";
                string updateQuery = "UPDATE Routes SET WarrantId = @warrantid, " +
                    "DateFrom = @datefrom, DateTo = @dateto, CoordA = @cooA, CoordB = @cooB, " +
                    "DistanceInKm = @disInKm, AvgV = @avgV, FuelSpent = @fuel " +
                    "where IDRoute = @routeId";
                string deleteQuery = "DELETE FROM Routes WHERE IDRoute = @routeId";

                SqlCommand selectCommand = new SqlCommand(selectQuery, conn);
                SqlCommand insertCommand = new SqlCommand(insertQuery, conn);
                SqlCommand updateCommand = new SqlCommand(updateQuery, conn);
                SqlCommand deleteCommand = new SqlCommand(deleteQuery, conn);
                using(SqlDataAdapter adapter = new SqlDataAdapter(selectCommand))
                {
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);

                    insertCommand.Parameters.Add("@warrantid", SqlDbType.Int, 4, dataSet.Tables[0].Columns[1].ColumnName);
                    insertCommand.Parameters.Add("@datefrom", SqlDbType.DateTime, 4, dataSet.Tables[0].Columns[2].ColumnName);
                    insertCommand.Parameters.Add("@dateto", SqlDbType.DateTime, 4, dataSet.Tables[0].Columns[3].ColumnName);
                    insertCommand.Parameters.Add("@cooA", SqlDbType.NVarChar, 20, dataSet.Tables[0].Columns[4].ColumnName);
                    insertCommand.Parameters.Add("@cooB", SqlDbType.NVarChar, 20, dataSet.Tables[0].Columns[5].ColumnName);
                    insertCommand.Parameters.Add("@disInKm", SqlDbType.Int, 4, dataSet.Tables[0].Columns[6].ColumnName);
                    insertCommand.Parameters.Add("@avgV", SqlDbType.Int, 4, dataSet.Tables[0].Columns[7].ColumnName);
                    insertCommand.Parameters.Add("@fuel", SqlDbType.Int, 4, dataSet.Tables[0].Columns[8].ColumnName);
                    adapter.InsertCommand = insertCommand;

                    dataSet.Merge(ds, true, MissingSchemaAction.Ignore);
                    v = adapter.Update(dataSet);
                }
            }
            return v;
        }

        public static string ExportXmlRoutes(int warrantid)
        {
            // TODO: Remove ID from exported
            string toRet;
            using (SqlConnection conn = new SqlConnection(DbProps.GetCs()))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    adapter.TableMappings.Add("Routes", "Routes");
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select * from Routes where WarrantID = @warrantid", conn)
                    {
                        CommandType = CommandType.Text
                    };
                    cmd.Parameters.AddWithValue("@warrantid", warrantid);

                    adapter.SelectCommand = cmd;
                    using (DataSet ds = new DataSet("RoutesDataSet"))
                    {
                        adapter.Fill(ds);
                        toRet = ds.GetXml();
                    }
                }
            }
            return toRet;
        }
    }
}
