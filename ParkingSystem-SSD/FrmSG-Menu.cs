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
    public partial class FrmSG_Menu : Form
    {
        public FrmSG_Menu()
        {
            InitializeComponent();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            FrmSG_Records records = new FrmSG_Records();
            mainPanel.Controls.Clear();
            records.TopLevel = false;
            mainPanel.Controls.Add(records);
            records.Show();
        }

        private void btnSearchAcc_Click(object sender, EventArgs e)
        {
            FrmSG_SearchAccount searchAccount = new FrmSG_SearchAccount();
            mainPanel.Controls.Clear();
            searchAccount.TopLevel = false;
            mainPanel.Controls.Add(searchAccount);
            searchAccount.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Visible = false;
            FrmMainMenu menu = new FrmMainMenu();
            menu.Show();
        }
    }
}
