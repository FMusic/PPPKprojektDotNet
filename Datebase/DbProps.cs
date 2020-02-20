using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPKprojektDotNet.Datebase
{
    public static class DbProps
    {
        public static string GetCs()
        {
            return ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        }
    }
}
