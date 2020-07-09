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
                writer.WriteStartElement("Drivers");
                IList<Model.Driver> drivers = Ishod1.GetDrivers();
                foreach (var driver in drivers)
                {
                    writer.WriteStartElement("Driver");
                    writer.WriteElementString("ID", driver.Id.ToString());
                    writer.WriteElementString("Name", driver.Name.ToString());
                    writer.WriteElementString("Surname", driver.Surname.ToString());
                    writer.WriteElementString("PhoneNumber", driver.PhoneNumber.ToString());
                    writer.WriteElementString("DriversLicenseID", driver.DriversLicenseID.ToString());
                    writer.WriteEndElement();

                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
            return sb.ToString();
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
