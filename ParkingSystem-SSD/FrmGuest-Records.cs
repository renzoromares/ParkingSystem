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
    public partial class FrmGuest_Records : Form
    {
        public FrmGuest_Records()
        {
            InitializeComponent();
        }

        private void FrmGuest_Records_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            dataGridDesign();
            loadData();
        }

        public void dataGridDesign()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(247, 199, 195);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Blue;
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
            using (SqlConnection con = new SqlConnection(ConnectionString.connect))
            {

                string query = "SELECT CREDENTIALS.PlateID" +
                              ",VEHICLE_OWNER.FirstName" +
                              ",VEHICLE_OWNER.LastName" +
                              ",LOG.Time_in" +
                              ",LOG.Time_out" +
                              ",LOG._Date FROM CREDENTIALS " +
                              "JOIN VEHICLE_OWNER ON VEHICLE_OWNER.Id_Number = CREDENTIALS.Id_Number JOIN LOG ON CREDENTIALS.PlateID = LOG.PlateID " +
                              "WHERE VEHICLE_OWNER.Id_Number = '" + User.ownerID + "' ";
                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        dataGridView1.Rows.Clear();
                        int i = 0;
                        while (dr.Read())
                        {
                            DateTime dateTime = Convert.ToDateTime(dr[5].ToString());
                            i++;

                            dataGridView1.Rows.Add(i, dr[0].ToString().ToUpper(), dr[1].ToString().ToUpper() + " " + dr[2].ToString().ToUpper(), dr[3].ToString(), dr[4].ToString(), dateTime.ToShortDateString());
                        }
                        dr.Close();
                    }
                    con.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                    con.Close();
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateChanged();
        }
        public void dateChanged()
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.connect))
            {

                string query = "SELECT CREDENTIALS.PlateID" +
                             ",VEHICLE_OWNER.FirstName" +
                             ",VEHICLE_OWNER.LastName" +
                             ",LOG.Time_in" +
                             ",LOG.Time_out" +
                             ",LOG._Date FROM CREDENTIALS " +
                             "JOIN VEHICLE_OWNER ON VEHICLE_OWNER.Id_Number = CREDENTIALS.Id_Number JOIN LOG ON CREDENTIALS.PlateID = LOG.PlateID " +
                             "WHERE LOG._Date = '" + dateTimePicker1.Value.ToString() + "' ";
                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        dataGridView1.Rows.Clear();
                        int i = 0;
                        while (dr.Read())
                        {
                            DateTime dateTime = Convert.ToDateTime(dr[5].ToString());
                            i++;

                            dataGridView1.Rows.Add(i, dr[0].ToString().ToUpper(), dr[1].ToString().ToUpper() + " " + dr[2].ToString().ToUpper(), dr[3].ToString(), dr[4].ToString(), dateTime.ToShortDateString());
                        }
                        dr.Close();
                    }
                    con.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                    con.Close();
                }
            }
        }
    }
}
