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
    public partial class FrmGuest_UpdateVehiclePass : Form
    {
        public FrmGuest_UpdateVehiclePass()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panelContainer.Enabled = true;
            btnUpdate.Enabled = true;
        }
    }
}
