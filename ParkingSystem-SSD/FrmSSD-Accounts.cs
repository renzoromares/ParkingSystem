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
    public partial class FrmAccounts : Form
    {

        
        public FrmAccounts()
        {
            InitializeComponent();
        }

        private void FrmAccounts_Load(object sender, EventArgs e)
        {
            loadAccounts();
        }

        private void loadAccounts()
        {
            dataGridDesign();
            dataLoad();
        }
        private void dataGridDesign()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(196, 210, 245);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(237, 236, 254);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(2, 48, 15);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9);
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 8);
            dataGridView1.ColumnHeadersHeight = 80;
        }

        private void dataLoad()
        {
            dataGridView1.Rows.Clear();
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {

                try
                {

                    string query = "SELECT * FROM VEHICLE_OWNER";

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
                                i++;
                               
                                status = reader[7].ToString();
                                string result = messageStatus(status);
     
                                dataGridView1.Rows.Add(i,reader[0].ToString(), reader[1].ToString().ToUpper() + " " + reader[2].ToString().ToUpper(),reader[5].ToString().ToUpper(), reader[3].ToString().ToUpper(), reader[8].ToString(), reader[9].ToString(), result);
                                dataGridView1.Rows[i-1].Cells[8].Value = false;
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

        private string messageStatus(string status)
        {

            if (string.Equals(status, "0"))
            {
                status = "Pending";
            }
            else if (string.Equals(status, "1"))
            {
                status = "Approved";
            }
            else if (string.Equals(status, "2"))
            {
                status = "Disapproved";
            }
            else if (string.Equals(status, "3"))
            {
                status = "Expired";
            }

                return status;
        }

        private void filterData(string data)
        {
            dataGridView1.Rows.Clear();
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {

                try
                {

                    string query = "SELECT * FROM VEHICLE_OWNER WHERE Status = '"+ data + "' ";

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
                                i++;
                                status = reader[7].ToString();
                                string result = messageStatus(status);

                                dataGridView1.Rows.Add(i, reader[0].ToString(), reader[1].ToString().ToUpper() + " " + reader[2].ToString().ToUpper(), reader[5].ToString().ToUpper(), reader[3].ToString().ToUpper(),reader[8].ToString(), reader[9].ToString(), result);
                                dataGridView1.Rows[i - 1].Cells[8].Value = false;

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

        private void cmbFilterStatus_SelectedValueChanged(object sender, EventArgs e)
        { 
            if (string.Equals(cmbFilterStatus.Text.ToString(), "Pending"))
            {
                filterData("0");
            }
            else if (string.Equals(cmbFilterStatus.Text.ToString(), "Approved"))
            {
                filterData("1");
            }
            else if (string.Equals(cmbFilterStatus.Text.ToString(), "Disapproved"))
            {
                filterData("2");
            }
            
               
        }

        private void getOwnerID(string status)
        {
            string id = string.Empty;
            int count = 0;

            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewRow row = dataGridView1.Rows[i];
                    bool isSelected = Convert.ToBoolean(row.Cells["Checkbox"].Value);
                    if (isSelected)
                    {
                        count++;
                        id = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        updDateAccount(status, id);
                        sendSMS(status,id);
                    }
                }

                if(count > 0 && string.Equals(status,"1"))
                {
                    MessageBox.Show("Account/s Aprroved!");
                    MessageBox.Show("Approved message successfuly sent to the Vehicle Onwer!");
                }
                else if (count > 0 && string.Equals(status, "2"))
                {
                    MessageBox.Show("Account/s Disapproved!");
                    MessageBox.Show("Disapproved message successfuly sent to the Vehicle Onwer!");
                }
            }
            else
            {
                MessageBox.Show("No record display!");

            }
        }

        private void sendSMS(string status, string id)
        {
            string theStatus = status;
            getPhone(theStatus, id);
        }

        private void getPhone(string status, string id)
        {
            string query = "SELECT Contacts FROM VEHICLE_OWNER WHERE Id_Number = '" + id + "' ";
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
                                 deliverSMS(status, phone);
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
                if (string.Equals(status,"1"))
                {
                    theMessage = "This is from USJR SSD " +
                                 "Please be infromed that " +
                                 "your VEHICLE ACCOUNT APPLICATION has been approved.\n" +
                                 "You may now login to your account! Thank you!";
                }
                else if (string.Equals(status, "2"))
                {
                    theMessage = "This is from USJR SSD " +
                                 "Please be informed that " +
                                 "your VEHICLE ACCOUNT APPLICATION has been disapproved.\n" +
                                 "You may contact USJR SSD. Thank you";
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
            }
            catch
            {
                MessageBox.Show("Message unsuccessful please try again");
            }
            
        }


        private void updDateAccount(string status, string id)
        {

            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE VEHICLE_OWNER SET STATUS = @Status" +
                                                            ",Time_Approved = @Time_Approved " +
                                                            "WHERE Id_Number = @Id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@Status", status);
                        cmd.Parameters.AddWithValue("@Time_Approved", DateTime.Now.ToShortDateString());
                        cmd.ExecuteNonQuery();
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
        private void btnApprove_Click_1(object sender, EventArgs e)
        {
            getOwnerID("1");

        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            getOwnerID("2");
        }

    }

}
