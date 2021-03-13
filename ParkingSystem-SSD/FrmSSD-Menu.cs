using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;


namespace ParkingSystem_SSD
{
    public partial class FrmSSD_Menu : Form
    {
        public FrmSSD_Menu()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Visible = false;
            FrmMainMenu menu = new FrmMainMenu();
            menu.Show();
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            FrmActivate activate = new FrmActivate();
            mainPanel.Controls.Clear();
            activate.TopLevel = false;
            mainPanel.Controls.Add(activate);
            activate.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            panelApplication.Size = new Size(173, 54);
            panelUpdate.Size = new Size(173, 54);
            
        }

        private void btnApplication_Click(object sender, EventArgs e)
        {
            if(panelApplication.Height == 54)
            {
                panelApplication.Height = 126;
            }
            else
            {
                panelApplication.Height = 54;
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(panelUpdate.Height == 54)
            {
                panelUpdate.Height = 126;
            }
            else if(panelUpdate.Height == 126)
            {
                panelUpdate.Height = 54;
            }

            
        }

        private void btnAddGuard_Click(object sender, EventArgs e)
        {

            FrmRegisterSecurityGuard registerSecurityGuard = new FrmRegisterSecurityGuard();
            mainPanel.Controls.Clear();
            registerSecurityGuard.TopLevel = false;
            mainPanel.Controls.Add(registerSecurityGuard);
            registerSecurityGuard.Show();
        }

        private void btnSendSMS_Click(object sender, EventArgs e)
        {

            FrmSendSMS sendSMS = new FrmSendSMS();
            mainPanel.Controls.Clear();
            sendSMS.TopLevel = false;
            mainPanel.Controls.Add(sendSMS);
            sendSMS.Show();
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            FrmAccounts accounts = new FrmAccounts();
            mainPanel.Controls.Clear();
            accounts.TopLevel = false;
            mainPanel.Controls.Add(accounts);
            accounts.Show();
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            FrmSSD_UpdateVehiclePass update = new FrmSSD_UpdateVehiclePass();
            mainPanel.Controls.Clear();
            update.TopLevel = false;
            mainPanel.Controls.Add(update);
            update.Show();
        }

        private void btnUpdateAccounts_Click(object sender, EventArgs e)
        {
            FrmSSD_UpdateAccount updateAccount = new FrmSSD_UpdateAccount();
            mainPanel.Controls.Clear();
            updateAccount.TopLevel = false;
            mainPanel.Controls.Add(updateAccount);
            updateAccount.Show();
        }

        private void btnUpdateVehiclePass_Click(object sender, EventArgs e)
        {
            FrmSSD_UpdateVehiclePass updateVehiclePass = new FrmSSD_UpdateVehiclePass();
            mainPanel.Controls.Clear();
            updateVehiclePass.TopLevel = false;
            mainPanel.Controls.Add(updateVehiclePass);
            updateVehiclePass.Show();
        }
    }
}
