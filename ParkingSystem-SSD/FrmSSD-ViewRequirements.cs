using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;


namespace ParkingSystem_SSD
{
    public partial class FrmViewRequirements : Form
    {
        public FrmViewRequirements()
        {
            InitializeComponent();
        }

        public string plateID = string.Empty;
        public FrmViewRequirements(string id)
        {
            plateID = id;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmViewRequirements_Load(object sender, EventArgs e)
        {
            requirementsLoad();
        }

        private bool checkExpireDate()
        {
            DateTime exp = DateTime.Parse(dateTimePicker1.Value.ToString());
            DateTime today = DateTime.Now;
            if (exp >= today)
                return true;
            else
                return false;
        }

        private void requirementsLoad()
        {
            
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {

                try
                {
                    conn.Open();
                    string query = "SELECT* FROM CREDENTIALS WHERE PlateID = '"+plateID+"' ";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {

                            //await Task.Delay(100);
                            while (reader.Read())
                            {

                                lblPlatenumber.Text = reader[0].ToString();
                                lblVehicleType.Text = reader[1].ToString();
                                lblVehicleModel.Text = reader[2].ToString();
                                lblCarmake.Text = reader[3].ToString();
                                lblVehicleColor.Text = reader[4].ToString();

                                byte[] imgOR = (byte[])(reader[5]);
                                byte[] imgCR = (byte[])(reader[6]);

                                MemoryStream msOR = new MemoryStream(imgOR);
                                picBoxOR.Image = Image.FromStream(msOR);

                                MemoryStream msCR = new MemoryStream(imgCR);
                                picBoxCR.Image = Image.FromStream(msCR);
                                
                            }
                            reader.Close();
                        }
                        else
                        {
                            MessageBox.Show("Plate number don't exist!");
                            Visible = false;
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

        private void activateAccount()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE CREDENTIALS SET Status = @Status" +
                                                        ",Time_Approved = @Time_Approved" +
                                                        ",Time_Due = @Time_Due " +
                                                        "WHERE PlateID = @PlateID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        DateTime dateTime = Convert.ToDateTime(dateTimePicker1.Value.ToString());
                        cmd.Parameters.AddWithValue("@PlateID", plateID);
                        cmd.Parameters.AddWithValue("@Status", "1");
                        cmd.Parameters.AddWithValue("@Time_Approved", DateTime.Now.ToShortDateString());
                        cmd.Parameters.AddWithValue("@Time_Due", dateTime.ToShortDateString());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Vehicle Pass Approved!");
                        conn.Close();
                    }
                }
                catch(SqlException ex)
                {
                    conn.Close();
                    MessageBox.Show(ex.ToString());
                }
            }
        }


        private void deActivateVehicle()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE CREDENTIALS SET Status = @Status," +
                                                          "Time_Approved = @Time_Approved " +
                                                          "WHERE PlateID = @PlateID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                       
                        cmd.Parameters.AddWithValue("@Status", "2");
                        cmd.Parameters.AddWithValue("@Time_Approved", DateTime.Now.ToShortDateString());
                        cmd.Parameters.AddWithValue("@PlateID", plateID);
                        
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Vehicle disapproved!");
                        conn.Close();
                    }
                }
                catch (SqlException ex)
                {
                    conn.Close();
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void picBoxOR_Click(object sender, EventArgs e)
        {
           
            FrmViewer viewer = new FrmViewer(1,plateID);
            viewer.Show();
        }

        private void picBoxCR_Click(object sender, EventArgs e)
        {
            FrmViewer viewer = new FrmViewer(2,plateID);
            viewer.Show();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (checkExpireDate())
            {
                activateAccount();
                getPhone("1");
                Visible = false;
            }
            else
            {
                MessageBox.Show("Please set valid expiration date!");
            }
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            deActivateVehicle();
            getPhone("2");
            Visible = false;
        }

        private void getPhone(string status)
        {
            string query = "SELECT VEHICLE_OWNER.Contacts " +
                            "FROM VEHICLE_OWNER JOIN " +
                            "CREDENTIALS ON VEHICLE_OWNER.Id_Number = CREDENTIALS.Id_Number " +
                            "WHERE CREDENTIALS.PlateID = '"+plateID+" ' ";

            string phone = string.Empty;

            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {

                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                phone = reader.GetValue(0).ToString();
                                deliverSMS(status,phone);
                            }
                            reader.Close();
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

        private void deliverSMS(string status, string phone)
        {

            try
            {
                string theMessage = string.Empty;
                string displayMessage = string.Empty;

                if (string.Equals(status, "1"))
                {
                    theMessage = "This is from USJR SSD " +
                                 "Please be infromed that " +
                                 "your VEHICLE PASS APPLICATION has been approved.\n" +
                                 "Thank you!";

                    displayMessage = "Approved message successfuly sent to the Vehicle Onwer!";


                }
                else if (string.Equals(status, "2"))
                {
                    theMessage = "This is from USJR SSD " +
                                 "Please be informed that " +
                                 "your VEHICLE PASS APPLICATION has been disapproved.\n" +
                                 "You may contact the USJR SSD. Thank you";

                    displayMessage = "Disapproved message successfuly sent to the Vehicle Onwer!";
                }



                var accountSid = "AC05524deac756a6ab1c18b87cac2fc174";
                var authToken = "8590e8152542c85141e7b1be76bfbd87";
                TwilioClient.Init(accountSid, authToken);

                var messageOptions = new CreateMessageOptions(
                    new PhoneNumber(phone));
                messageOptions.From = new PhoneNumber("+19293252234");
                messageOptions.Body = theMessage;

                var message = MessageResource.Create(messageOptions);
                Console.WriteLine(message.Body);

                MessageBox.Show(displayMessage);
            }
            catch
            {
                MessageBox.Show("Message unsuccessful please try again");
            }

        }

    }
}
