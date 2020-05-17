using PPPKprojektDotNet.Datebase;
using PPPKprojektDotNet.Model;
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
    public partial class TravelWarrantsForm : Form
    {
        IList<TravelWarrant> warrants;
        IList<TravelWarrantVM> warrantsView;
        IList<TravelWarrantVM> warrantsOpen;
        IList<TravelWarrantVM> warrantsClosed;
        IList<TravelWarrantVM> warrantsFuture;
        HashSet<Driver> drivers;
        HashSet<Vehicle> vehicles;
        TravelWarrant clicked;

        public TravelWarrantsForm()
        {
            InitializeComponent();
            setData();
            setWidgets();
        }

        

        private void setData()
        {
            warrants = Ishod1.GetAllTravelWarrants();
            warrantsView = new List<TravelWarrantVM>();
            warrantsOpen = new List<TravelWarrantVM>();
            warrantsFuture = new List<TravelWarrantVM>();
            warrantsClosed = new List<TravelWarrantVM>();
            drivers = new HashSet<Driver>();
            vehicles = new HashSet<Vehicle>();
            foreach (var item in warrants)
            {
                warrantsView.Add(new TravelWarrantVM(item));
                switch (item.WarrantState)
                {
                    case TravelWarrantStateEnum.OPEN:
                        warrantsOpen.Add(new TravelWarrantVM(item));
                        break;
                    case TravelWarrantStateEnum.CLOSED:
                        warrantsClosed.Add(new TravelWarrantVM(item));
                        break;
                    case TravelWarrantStateEnum.FUTURE:
                        warrantsFuture.Add(new TravelWarrantVM(item));
                        break;
                    default:
                        break;
                }
                drivers.Add(item.Driver);
                vehicles.Add(item.Vehicle);
            }
        }
        private void setWidgets()
        {
            BindingSource bs = new BindingSource
            {
                DataSource = warrantsView
            };
            dgWarrants.DataSource = bs;
            cbFilter.DataSource = Enum.GetValues(typeof(TravelWarrantStateEnum));
            cbWarrantState.DataSource = Enum.GetValues(typeof(TravelWarrantStateEnum));
            cbDrivers.DataSource = drivers.ToList<Driver>();
            cbVehicle.DataSource = vehicles.ToList<Vehicle>();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            TravelWarrantStateEnum en = (TravelWarrantStateEnum) cbFilter.SelectedItem;
            switch (en)
            {
                case TravelWarrantStateEnum.OPEN:
                    dgWarrants.DataSource = warrantsOpen;
                    break;
                case TravelWarrantStateEnum.CLOSED:
                    dgWarrants.DataSource = warrantsClosed;
                    break;
                case TravelWarrantStateEnum.FUTURE:
                    dgWarrants.DataSource = warrantsFuture;
                    break;
                case TravelWarrantStateEnum.DEFAULT:
                    dgWarrants.DataSource = warrantsView;
                    break;
                default:
                    break;
            }
        }

        private void dgWarrants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblWarrantID.Text = warrants[e.RowIndex].IDWarrant.ToString();
            clicked = warrants[e.RowIndex];
            cbWarrantState.SelectedItem = clicked.WarrantState;
        }

        private void btnRoutes_Click(object sender, EventArgs e)
        {
            new RouteForm(clicked).Visible = true;
            //new RouteForm(int.Parse(lblWarrantID.Text)).Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var t = new TravelWarrant(((Driver)cbDrivers.SelectedItem).Id, ((Vehicle)cbVehicle.SelectedItem).IDVehicle, TravelWarrantStateEnum.OPEN); ;
            Ishod1.SaveWarrant(t);
            setData();
            setWidgets();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int item = dgWarrants.SelectedCells[0].RowIndex;
            TravelWarrant tw = warrants[item];
            Ishod1.DeleteWarrant(tw.IDWarrant);
            setData();
            setWidgets();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            clicked.WarrantState = (TravelWarrantStateEnum) cbWarrantState.SelectedItem;
            Ishod1.UpdateWarrant(clicked.IDWarrant, clicked);
            setData();
            setWidgets();
        }
    }
}
