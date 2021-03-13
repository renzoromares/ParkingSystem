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
            this.Visible = false;
            FrmSG_ParkingSpace parkingSpace = new FrmSG_ParkingSpace();
            parkingSpace.Show();
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

        private void btnGuard_MouseEnter(object sender, EventArgs e)
        {
            btnGuard.BackColor = Color.FromArgb(2, 48, 15);
            btnGuard.ForeColor = Color.White;
        }

        private void btnGuard_MouseLeave(object sender, EventArgs e)
        {
            btnGuard.BackColor = Color.Silver;
            btnGuard.ForeColor = Color.Black;
        }

        private void btnSSD_MouseEnter(object sender, EventArgs e)
        {
            btnSSD.BackColor = Color.FromArgb(2, 48, 15);
            btnSSD.ForeColor = Color.White;
        }

        private void btnSSD_MouseLeave(object sender, EventArgs e)
        {
            btnSSD.BackColor = Color.Silver;
            btnSSD.ForeColor = Color.Black;
        }

        private void btnGuest_MouseEnter(object sender, EventArgs e)
        {
            btnGuest.BackColor = Color.FromArgb(2, 48, 15);
            btnGuest.ForeColor = Color.White;
        }

        private void btnGuest_MouseLeave(object sender, EventArgs e)
        {
            btnGuest.BackColor = Color.Silver;
            btnGuest.ForeColor = Color.Black;
        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
