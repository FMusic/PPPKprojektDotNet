using PPPKprojektDotNet.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using PPPKprojektDotNet.Datebase;

namespace PPPKprojektDotNet
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new DriversForm());
            IList<Model.Driver> list = Ishod1.GetDrivers();
            Application.Run(new TravelWarrantsForm());
        }
    }
}
