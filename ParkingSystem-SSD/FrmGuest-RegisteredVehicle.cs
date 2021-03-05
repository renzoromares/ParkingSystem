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
    public partial class FrmGuest_RegisteredVehicle : Form
    {
        public FrmGuest_RegisteredVehicle()
        {
            InitializeComponent();
        }

        private void FrmGuest_RegisteredVehicle_Load(object sender, EventArgs e)
        {
            loadRegisteredVehicle();
            dataGridDesign();
        }

        public void dataGridDesign()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(247, 199, 195);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Blue;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(2, 48, 15);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridView1.RowHeadersVisible = false;
        }

        public void loadRegisteredVehicle()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                string query = "SELECT PlateID" +
                                    ",Vehicle_Type" +
                                    ",Vehicle_Model" +
                                    ",Vehicle_Carmake" +
                                    ",Vehicle_Color" +
                                    ",Status From CREDENTIALS WHERE Id_Number = '" + User.ownerID + "'";
                conn.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        dataGridView1.Rows.Clear();
                        int i = 0;
                        while (dr.Read())
                        {
                            i++;
                            int temp = Convert.ToInt32(dr[5].ToString());
                            string status = dr[5].ToString();
                            string result = messageStatus(status);
                            dataGridView1.Rows.Add(i, dr[0].ToString().ToUpper(), dr[1].ToString().ToUpper(), dr[2].ToString().ToUpper(), dr[3].ToString().ToUpper(), dr[4].ToString().ToUpper(), result);
                        }
                        dr.Close();
                    }
                    conn.Close();

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
                status = "ALLOWED ENTRY";
            }
            else if (string.Equals(status, "2"))
            {
                status = "NOT ALLOWED ENTRY";
            }
            return status;
        }
    }
}
