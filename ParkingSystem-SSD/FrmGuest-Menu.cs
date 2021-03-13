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

        private void FrmGuest_Menu_Load(object sender, EventArgs e)
        {
            panelUpdate.Size = new Size(173, 54);
            lblVehicleOwner.Text = User.fullName;
            lblPhone.Text = User.phone;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (panelUpdate.Height == 54)
            {
                panelUpdate.Height = 92;
            }
            else if (panelUpdate.Height == 92)
            {
                panelUpdate.Height = 54;
            }
        }

        private void btnUpdateAccounts_Click(object sender, EventArgs e)
        {
            FrmGuest_UpdateAccount updateAccount = new FrmGuest_UpdateAccount();
            mainPanel.Controls.Clear();
            updateAccount.TopLevel = false;
            mainPanel.Controls.Add(updateAccount);
            updateAccount.Show();
        }

        private void btnUpdateVehiclePass_Click(object sender, EventArgs e) /*For APPROVEVAL*/
        {
            /*FrmGuest_UpdateVehiclePass updateVehiclePass = new FrmGuest_UpdateVehiclePass();
            mainPanel.Controls.Clear();
            updateVehiclePass.TopLevel = false;
            mainPanel.Controls.Add(updateVehiclePass);
            updateVehiclePass.Show(); */
        }
    }
}
