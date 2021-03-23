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
            deactivateStatusOnDuty();
            FrmSG_ParkingSpace parkingSpace = new FrmSG_ParkingSpace(1);
            parkingSpace.Show();

        }

        private void deactivateStatusOnDuty()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {

                try
                {
                    conn.Open();

                    string query = "UPDATE Security_Staff SET Status = @status where Staff_Id = @userID ";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userID", User.userID);
                        cmd.Parameters.AddWithValue("@status", 0);

                        cmd.ExecuteNonQuery();
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
        private void FrmSG_Menu_Load(object sender, EventArgs e)
        {
            lblGuardOnDuty.Text = "SGT." + User.lastname.ToUpper();
            activateStatusOnDuty();
            
        }
        private void activateStatusOnDuty()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {

                try
                {
                    conn.Open();

                    string query = "UPDATE Security_Staff SET Status = @status where Staff_Id = @userID ";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userID", User.userID);
                        cmd.Parameters.AddWithValue("@status", 1);

                       
                        cmd.ExecuteNonQuery();
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

        private void btnParkingSpace_Click(object sender, EventArgs e)
        {
            Visible = false;
            FrmSG_ViewParkingSpace parkingSpace = new FrmSG_ViewParkingSpace();
            parkingSpace.Show();
        }
    }
}
