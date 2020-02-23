using System;
using System.Collections.Generic;
using System.Data;
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
        public static string GetAllDataFromDb()
        {
            StringBuilder sb = new StringBuilder();
            using (XmlWriter writer = XmlWriter.Create(sb))
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
            DataSet ds = new DataSet("BazaPPPK");
            using (SqlConnection conn = new SqlConnection(DbProps.GetCs()))
            {
                string query = "SELECT * FROM Drivers";
                using(SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    adapter.SelectCommand = new SqlCommand(query, conn);
                    adapter.Fill(ds);
                }
            }
            return ds;
        }

        public static void SaveAllDataFromXml(string filepath)
        {
            using (FileStream fs = File.OpenRead(filepath))
            {
                using (XmlReader reader = XmlReader.Create(fs))
                {

                }
            }
        }
    }
}
