using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PPPKprojektDotNet.Datebase
{
    public static class Ishod5
    {
        private const string DSName = "BazaPPPK";

        public static string GetAllDataFromDb()
        {
            StringBuilder sb = new StringBuilder();
            XmlWriterSettings settings = new XmlWriterSettings()
            {
                Indent = true,
                NewLineOnAttributes = false
            };
            using (XmlWriter writer = XmlWriter.Create(sb, settings))
            {
                writer.WriteStartDocument();
                using (DataSet ds = GetDataFromDb())
                {
                    ds.WriteXml(writer, XmlWriteMode.WriteSchema);
                }
            }
            return sb.ToString();
        }

        private static DataSet GetDataFromDb()
        {
            DataSet ds = new DataSet(DSName);
            using (SqlConnection conn = new SqlConnection(DbProps.GetCs()))
            {
                string query1 = "SELECT * FROM Drivers";
                string query2 = "SELECT * FROM Vehicles";
                string query3 = "SELECT * FROM Routes";
                string query4 = "SELECT * FROM TravelWarrants";
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    adapter.SelectCommand = new SqlCommand(query1, conn);
                    adapter.Fill(ds, "Drivers");
                    adapter.SelectCommand = new SqlCommand(query2, conn);
                    adapter.Fill(ds, "Vehicles");
                    adapter.SelectCommand = new SqlCommand(query3, conn);
                    adapter.Fill(ds, "Routes");
                    adapter.SelectCommand = new SqlCommand(query4, conn);
                    adapter.Fill(ds, "TravelWarrants");
                }
            }
            return ds;
        }

        public static void SaveAllDataFromXml(string filepath)
        {
            SqlCommand sqlComm = new SqlCommand();
            SqlCommand sqlIdent = new SqlCommand();
            SqlCommand sqlIdentBack = new SqlCommand();
            DataSet ds = new DataSet(DSName);
            using (FileStream fs = File.OpenRead(filepath))
            {
                using (XmlReader reader = XmlReader.Create(fs))
                {
                    ds.ReadXml(reader);
                }
            }
            using (var conn = new SqlConnection(DbProps.GetCs()))
            {
                conn.Open();
                foreach (DataTable table in ds.Tables)
                {
                    StringBuilder sb = new StringBuilder();
                    using (XmlWriter writer = XmlWriter.Create(sb))
                    {
                        ds.WriteXml(writer);
                    }
                    sqlComm.Connection = conn;
                    sqlIdent.Connection = conn;
                    sqlIdentBack.Connection = conn;
                    sqlComm.CommandText = $"INSERT {table.TableName} VALUES (@xml)";
                    sqlComm.Parameters.Add("@xml", SqlDbType.Xml, sb.ToString().Length).Value = sb.ToString();
                    sqlIdent.CommandText = $"SET IDENTITY_INSERT {table.TableName} ON;";
                    sqlIdentBack.CommandText = $"SET IDENTITY_INSERT {table.TableName} OFF;";
                    sqlIdent.ExecuteNonQuery();
                    sqlComm.ExecuteNonQuery();
                    sqlIdentBack.ExecuteNonQuery();
                }
            }
            ds.Dispose();
            sqlComm.Dispose();
            sqlIdent.Dispose();
            sqlIdentBack.Dispose();
        }
    }
}
