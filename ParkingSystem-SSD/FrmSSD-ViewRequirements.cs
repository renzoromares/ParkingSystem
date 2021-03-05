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

namespace ParkingSystem_SSD
{
    public partial class FrmViewRequirements : Form
    {
        public FrmViewRequirements()
        {
            InitializeComponent();
        }

        public FrmViewRequirements(string id)
        {
            User.theID = id;
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

        private void requirementsLoad()
        {
            
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {

                try
                {
                    conn.Open();
                    string query = "SELECT* FROM CREDENTIALS WHERE PlateID = '"+User.theID+"' ";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {

                            //await Task.Delay(100);
                            while (reader.Read())
                            {

                                lblPlatenumber.Text = reader[9].ToString();
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

        private void btnActivate_Click(object sender, EventArgs e)
        {
            activateAccount();
            Visible = false;
            
        }
        private void activateAccount()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE CREDENTIALS SET STATUS = '1' WHERE PlateID = @Id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", User.theID);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Account approved! \n Vehicle allowed for entry!");
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

        private void picBoxOR_Click(object sender, EventArgs e)
        {
           
            FrmViewer viewer = new FrmViewer(1);
            viewer.Show();
        }

        private void picBoxCR_Click(object sender, EventArgs e)
        {
            FrmViewer viewer = new FrmViewer(2);
            viewer.Show();
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            deActivateVehicle();
            Visible = false;
        }

        private void deActivateVehicle()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE CREDENTIALS SET STATUS = '2' WHERE PlateID = @Id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", User.theID);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Vehicle will not be allowed to enter!");
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


    }
}
