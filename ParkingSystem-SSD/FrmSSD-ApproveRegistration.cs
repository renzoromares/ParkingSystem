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
    public partial class FrmSSD_ApproveRegistration : Form
    {
        public string id = string.Empty;
        public string status = string.Empty;
        public FrmSSD_ApproveRegistration()
        {
            InitializeComponent();
        }

        public FrmSSD_ApproveRegistration(string id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void FrmSSD_ApproveRegistration_Load(object sender, EventArgs e)
        {
            MessageBox.Show(id);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            updDateAccount("1");
            MessageBox.Show("Account accepted!");
            Visible = false;
        }
        private void btnDecline_Click(object sender, EventArgs e)
        {
            updDateAccount("2");
            MessageBox.Show("Account declined not allowed for entry!");
            Visible = false;
        }

        private void updDateAccount(string status)
        {

            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE VEHICLE_OWNER SET STATUS = '"+status+"' WHERE Id_Number = @Id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
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

       
    }
}
