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
    public partial class FrmSSD_DeliverSMS : Form
    {

        public string theMessage = string.Empty;
        public FrmSSD_DeliverSMS()
        {
            InitializeComponent();
        }

        public FrmSSD_DeliverSMS( string sms)
        {
            theMessage = sms;
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
           //MessageBox.Show(dataGridView1.Rows.Count.ToString());
            sendingMessage();
           
        }
        private void sendingMessage()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int count = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    sendSMS(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    count++;
                }
                if (count == dataGridView1.Rows.Count - 1)
                {
                    MessageBox.Show("Message sent!");
                }

            }
            else
            {
                MessageBox.Show("Please add recipients");
            }
        }



        private void FrmSSD_DeliverSMS_Load(object sender, EventArgs e)
        {
            dataGridDesign();
        }

        public async void sendSMS(string number)
        {
            try
            {
                
                
                var accountSid = "AC05524deac756a6ab1c18b87cac2fc174";
                var authToken = "8590e8152542c85141e7b1be76bfbd87";
                TwilioClient.Init(accountSid, authToken);

                var messageOptions = new CreateMessageOptions(
                    new PhoneNumber(number));
                messageOptions.From = new PhoneNumber("+19293252234");
                messageOptions.Body = theMessage;

                var message = MessageResource.Create(messageOptions);
                Console.WriteLine(message.Body);
                await Task.Delay(500);
            }
            catch
            {
                MessageBox.Show("Message unsuccessful please try again");
            }
        }

        public void dataGridDesign()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(211, 224, 234);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(2, 48, 15);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridView1.RowHeadersVisible = false;
        }

        private void loadData()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {

                try
                {

                    string query = "SELECT CREDENTIALS.PlateID" +
                                          ",VEHICLE_OWNER.FirstName" +
                                          ",VEHICLE_OWNER.LastName" +
                                          ",VEHICLE_OWNER.Department" +
                                          ",VEHICLE_OWNER.Contacts " +
                                          "FROM CREDENTIALS JOIN VEHICLE_OWNER ON  CREDENTIALS.Id_Number = VEHICLE_OWNER.Id_Number " +
                                          "WHERE CREDENTIALS.PlateID = '"+txtPlateNumber.Text+"' ";

                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {

                            int i = 0;
                            string status = string.Empty;
                            while (reader.Read())
                            {
                                i = dataGridView1.Rows.Count + 1;
                                dataGridView1.Rows.Add(i, reader[0].ToString(), reader[1].ToString().ToUpper() + " " + reader[2].ToString().ToUpper(), reader[3].ToString().ToUpper(), reader[4].ToString().ToUpper());

                            }
                            reader.Close();
                        }
                        else
                        {
                            MessageBox.Show("Plate number don't exist!");
                        }
                        conn.Close();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                    conn.Close();

                }

            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            loadData();
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
                {
                   
                }
            }
            catch
            {

            }
        }
    }
}
