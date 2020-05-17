using PPPKprojektDotNet.Datebase;
using PPPKprojektDotNet.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPPKprojektDotNet.Forms
{
    public partial class RouteForm : Form
    {
        IList<Route> routes;
        IList<string> routeStrings;
        private int WarrantId;
        TravelWarrant tw;

        public RouteForm(int warrantId)
        {
            InitializeComponent();
            WarrantId = warrantId;
            routes = Ishod1.GetRoutes(WarrantId);
            initData(routes);
            initWidgets();
        }

        public RouteForm(TravelWarrant travelWarrant)
        {
            InitializeComponent();
            tw = travelWarrant;
            routes = Ishod4.GetRoutesForWarrant(tw);
            initData(routes);
            initWidgets();
        }

        public RouteForm()
        {
        }

        private void initData(IList<Route> routes)
        {
            routeStrings = new List<string>();
            for (int i = 0; i < routes.Count; i++)
            {
                routeStrings.Add(i.ToString());
            }
        }

        private void initWidgets()
        {
            cbRoutes.DataSource = routeStrings;
        }

        private void cbRoutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int routeCount = cbRoutes.SelectedIndex;
            fillData(routes[routeCount]);
        }

        private void fillData(Route route)
        {
            dtStart.Value = route.DateStart;
            dtEnd.Value = route.DateEnd;
            tbAvgV.Text = route.AvgSpeed.ToString();
            tbCity.Text = route.CoordA;
            tbCity2.Text = route.CoordB;
            tbDistance.Text = route.DistanceKm.ToString();
            tbGas.Text = route.FuelSpent.ToString();


        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            deleteData();
        }

        //TODO: Finish saving new route
        private void btnSave_Click(object sender, EventArgs e)
        {
            Route r = new Route();
            r.DateStart = dtStart.Value;
            r.DateEnd = dtEnd.Value;
            r.CoordA = tbCity.Text;
            r.CoordB = tbCity2.Text;
            r.DistanceKm = int.Parse(tbDistance.Text);
            r.FuelSpent = int.Parse(tbGas.Text);
            r.AvgSpeed = int.Parse(tbAvgV.Text);
            Ishod4.SaveRoute(r);
        }

        private void deleteData()
        {
            dtStart.Value = DateTime.Now;
            dtEnd.Value = DateTime.Now;
            tbAvgV.Text = "";
            tbCity.Text = "";
            tbCity2.Text = "";
            tbDistance.Text = "";
            tbGas.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Ishod1.DeleteRoute(routes[cbRoutes.SelectedIndex].IDRoute);
        }

        private void btnXmlExport_Click(object sender, EventArgs e)
        {
            string res = Ishod3.ExportXmlRoutes(WarrantId);
            using(SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.FileName = "Route export";
                sfd.Filter = "xml files (*.xml)|*.xml";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, res);
                }
            }
        }

        private void btnXmlImport_Click(object sender, EventArgs e)
        {
            string content = "";
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "xml files (*.xml)|*.xml";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Ishod3.ImportXmlRoutes(ofd.FileName);
                }
            }
        }
    }
}
