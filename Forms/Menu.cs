using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPPKprojektDotNet.Forms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            new DriversForm().Visible = true;
        }

        private void btnRoutes_Click(object sender, EventArgs e)
        {
            new RouteForm().Visible = true;
        }

        private void btnTravelWarrants_Click(object sender, EventArgs e)
        {
            new TravelWarrantsForm().Visible = true;
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            new XmlForm().Visible = true;
        }

        private void btnCarServices_Click(object sender, EventArgs e)
        {
            new CarServices().Visible = true;
        }
    }
}
