using PPPKprojektDotNet.Datebase;
using PPPKprojektDotNet.Forms;
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

namespace PPPKprojektDotNet
{
    public partial class DriversForm : Form
    {
        IList<Driver> drivers;
        public DriversForm()
        {
            InitializeComponent();
            getData();
        }

        private void getData()
        {
            drivers = Ishod1.GetDrivers();
            dgDrivers.DataSource = drivers;
        }

        private void dgDrivers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Driver d = drivers[e.RowIndex];
            fillTextBoxes(d);
        }

        private void fillTextBoxes(Driver d)
        {
            tbID.Text = d.Id.ToString();
            tbName.Text = d.Name;
            tbSurname.Text = d.Surname;
            tbTeleNum.Text = d.PhoneNumber;
            tbDriversLicenseID.Text = d.DriversLicenseID.ToString();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            tbID.Text = "";
            tbName.Text = "";
            tbSurname.Text = "";
            tbTeleNum.Text = "";
            tbDriversLicenseID.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbID.Text.Equals(string.Empty))
            {
                Driver d = new Driver(tbName.Text, tbSurname.Text, tbDriversLicenseID.Text, tbTeleNum.Text);
                Ishod1.SaveDriver(d);
                RefreshData();
            }
            else
            {
                Driver d = drivers.Where(x => x.Id == int.Parse(tbID.Text)).FirstOrDefault();
                d.Name = tbName.Text;
                d.Surname = tbSurname.Text;
                d.DriversLicenseID = tbDriversLicenseID.Text;
                d.PhoneNumber = tbTeleNum.Text;
                Ishod1.UpdateDriver(d, int.Parse(tbID.Text));
                RefreshData();
            }
        }

        private void RefreshData()
        {
            drivers = Ishod1.GetDrivers();
            dgDrivers.DataSource = drivers;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Ishod1.DeleteDriver(int.Parse(tbID.Text));
            RefreshData();
        }

        private void btnWarrants_Click(object sender, EventArgs e)
        {
            Visible = false;
            new TravelWarrantsForm().Visible = true;
        }
    }
}
