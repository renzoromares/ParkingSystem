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
    public partial class FrmDisplayImage : Form
    {
        public FrmDisplayImage()
        {
            InitializeComponent();
        }

        public FrmDisplayImage(string id, int option)
        {
            User.theID = id;
            User.theOption = option;
            InitializeComponent();
        }

        private void FrmDisplayImage_Load(object sender, EventArgs e)
        {
            loadLabel();
            loadUserImage();
            
        }

        private void loadLabel()
        {
            if(User.theOption == 5)
            {
                lblViewer.Text = "OFFICIAL RECEIPT";
                lblAdd.Location = new Point(111, 18);
                lblViewer.Location = new Point(203, 18);
            }
            else if (User.theOption == 6)
            {
                lblViewer.Text = "CERTIFICATE OF REGISTRATION";
            }
            else
            {
                lblViewer.Text = "REGISTERED FACE IMAGE";
            }

        }
        private void loadUserImage()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {

                try
                {
                    conn.Open();
                    string query = "SELECT * FROM CREDENTIALS WHERE PlateID = '" + User.theID + "' ";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                byte[] img = (byte[])(reader[User.theOption]);

                                MemoryStream ms = new MemoryStream(img);
                                picBoxImages.Image = Image.FromStream(ms);

                            }
                            reader.Close();
                        }
                        else
                        {
                            MessageBox.Show("Id Number does not exist!");

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
            btnExit.BackColor = Color.Transparent;
            this.Close();
        }
    }
}
