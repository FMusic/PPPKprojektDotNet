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
            using (XmlReader reader = XmlReader.Create(GetStream(xmlFileName)))
            {
                using (DataSet ds = new DataSet())
                {
                    ds.ReadXml(reader);
                    return SaveDataSetToDb(ds);
                }
            }
        }

        private static Stream GetStream(string xmlFileName)
        {
            throw new NotImplementedException();
        }

        private static int SaveDataSetToDb(DataSet ds)
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                int v = adapter.Update(ds, "Routes");
                return v;
            }
        }

        public static string ExportXmlRoutes()
        {
            string toRet;
            using (SqlConnection conn = new SqlConnection(DbProps.GetCs()))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    adapter.TableMappings.Add("Routes", "Routes");
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select * from Routes", conn)
                    {
                        CommandType = CommandType.Text
                    };

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
