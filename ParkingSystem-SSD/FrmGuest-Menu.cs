using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingSystem_SSD
{
    public partial class FrmGuest_Menu : Form
    {
        public FrmGuest_Menu()
        {
            InitializeComponent();
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            FrmGuest_AddVehicle addVehicle = new FrmGuest_AddVehicle();
            mainPanel.Controls.Clear();
            addVehicle.TopLevel = false;
            mainPanel.Controls.Add(addVehicle);
            addVehicle.Show();
        }
        private void btnRecords_Click(object sender, EventArgs e)
        {
            FrmGuest_Records records = new FrmGuest_Records();
            mainPanel.Controls.Clear();
            records.TopLevel = false;
            mainPanel.Controls.Add(records);
            records.Show();
        }

        private void btnRegisteredVehicle_Click(object sender, EventArgs e)
        {

            FrmGuest_RegisteredVehicle vehicle = new FrmGuest_RegisteredVehicle();
            mainPanel.Controls.Clear();
            vehicle.TopLevel = false;
            mainPanel.Controls.Add(vehicle);
            vehicle.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Visible = false;
            FrmGuest_Login login = new FrmGuest_Login();
            login.Show();
        }

       
    }
}
