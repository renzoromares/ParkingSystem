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
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void btnGuard_Click(object sender, EventArgs e)
        {
            Visible = false;
            FrmSG_Login menu = new FrmSG_Login();
            menu.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnSSD_Click(object sender, EventArgs e)
        {
            Visible = false;
            FrmSSD_Login login = new FrmSSD_Login();
            login.Show();
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            Visible = false;
            FrmGuest_Login login = new FrmGuest_Login();
            login.Show();
        }
    }
}
