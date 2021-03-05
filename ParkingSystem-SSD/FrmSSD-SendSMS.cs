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
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace ParkingSystem_SSD
{
    public partial class FrmSendSMS : Form
    {
        public FrmSendSMS()
        {
            InitializeComponent();
        }

        private void FrmSendSMS_Load(object sender, EventArgs e)
        {

        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
           if(string.Equals(rtxtMessage.Text.ToString(),""))
           {
                MessageBox.Show("Message is empty!");
           }
           else
           {
                string message = "This is from USJR SSD - " + rtxtMessage.Text.ToString();
                FrmSSD_DeliverSMS deliverSMS = new FrmSSD_DeliverSMS(message);
                deliverSMS.Show();
           }
        }
        private void rtxtMessage_TextChanged(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panelContainer.ClientRectangle, Color.Gray, ButtonBorderStyle.Solid);
        }
    }
}
