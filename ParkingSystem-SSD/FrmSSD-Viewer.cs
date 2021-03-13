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
    public partial class FrmViewer : Form
    {
        public FrmViewer()
        {
            InitializeComponent();
        }
        public string plateID = string.Empty;
        public FrmViewer(int id, string plateID)
        {
            User.theOption = id;
            this.plateID = plateID;
            InitializeComponent();
        }

        private void FrmViewer_Load(object sender, EventArgs e)
        {
            if(User.theOption == 1)
            {
                loadDataOR();
            }
            else if(User.theOption == 2)
            {
                loadDataCR();
            }
           
        }

        private void loadDataCR()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {

                try
                {
                    conn.Open();
                    string query = "SELECT* FROM CREDENTIALS WHERE PlateID = '" + plateID + "' ";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {

                            //await Task.Delay(100);
                            while (reader.Read())
                            {

                                byte[] imgCR = (byte[])(reader[6]);

                                MemoryStream msCR = new MemoryStream(imgCR);
                                picBox.Image = Image.FromStream(msCR);

                            }
                            reader.Close();
                        }
                        else
                        {
                            MessageBox.Show("Cannot find image!");

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

        private void loadDataOR()
        {

            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {

                try
                {
                    conn.Open();
                    string query = "SELECT* FROM CREDENTIALS WHERE PlateID = '" + plateID + "' ";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {

                            //await Task.Delay(100);
                            while (reader.Read())
                            {

                                byte[] imgOR = (byte[])(reader[5]);

                                MemoryStream msOR = new MemoryStream(imgOR);
                                picBox.Image = Image.FromStream(msOR);

                            }
                            reader.Close();
                        }
                        else
                        {
                            MessageBox.Show("Cannot find image!");

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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
