using PPPKprojektDotNet.Datebase;
using PPPKprojektDotNet.Datebase.I7;
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
    public partial class CarServices : Form
    {
        IList<Datebase.I7.Vehicle> vehicles;
        IList<Datebase.I7.CarService> services;
        Vehicle chosenVehicle;
        CarService chosenService;
        public CarServices()
        {
            InitializeComponent();
            initWidgets();
        }

        private void initWidgets()
        {
            vehicles = Ishod7.GetVehicles();
            dgVehicles.DataSource = vehicles;
            chosenVehicle = vehicles[0];
        }

        private void initServices()
        {
            services = Ishod7.GetAllServices(chosenVehicle);
            dgServices.DataSource = services;
            chosenService = services[0];
        }
        private void initServiceItems()
        {
            var serviceItems = Ishod7.GetItemsForService(chosenService);
            dgServiceItems.DataSource = serviceItems;
        }

        private void dgVehicles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Datebase.I7.Vehicle vehicle = vehicles[e.RowIndex];
            chosenVehicle = vehicle;
            initServices();
            lblVehicle.Text = vehicle.Type + vehicle.YearOfMaking;
        }

        private void dgServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var service = services[e.RowIndex];
            chosenService = service;
            initServiceItems();
            lblService.Text = service.Date.ToString();
        }

        private void btnSaveService_Click(object sender, EventArgs e)
        {
            var service = new Datebase.I7.CarService();
            service.VehicleID = chosenVehicle.IDVehicle;
            service.Date = dtService.Value;
            int res = Ishod7.CreateService(service);
            lblStatus.Text = $"Saved {res} service.";
            initServices();

        }

        private void btnSaveItem_Click(object sender, EventArgs e)
        {
            var servItem = new ServiceItem();
            servItem.CarServiceID = chosenService.IDService;
            servItem.Name = tbItemName.Text;
            servItem.TotalPrice = int.Parse(tbPrice.Text);
            int v = Ishod7.SaveItem(chosenService, servItem);
            lblStatus.Text = $"Saved {v} service item.";
            initServiceItems();
        }
    }
}
