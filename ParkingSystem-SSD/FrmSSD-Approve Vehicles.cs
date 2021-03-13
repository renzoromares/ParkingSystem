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
    public partial class FrmActivate : Form
    {

  
        public FrmActivate()
        {
            InitializeComponent();
        }

        private  void FrmActivate_Load(object sender, EventArgs e)
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
            dataGridView1.Columns["Date_Submitted"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

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

                    string query = "SELECT VEHICLE_OWNER.Id_Number" +
                                         ",VEHICLE_OWNER.FirstName" +
                                         ",VEHICLE_OWNER.LastName" +
                                         ",VEHICLE_OWNER.Position" +
                                         ",CREDENTIALS.Status" +
                                         ",CREDENTIALS.PlateID" +
                                         ",CREDENTIALS.Time_Submitted" +
                                         ",CREDENTIALS.Time_Approved" +
                                         ",CREDENTIALS.Time_Due" +
                                         " FROM VEHICLE_OWNER INNER JOIN " +
                                         "CREDENTIALS ON VEHICLE_OWNER.Id_Number = CREDENTIALS.Id_Number ";

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
                                status = reader[4].ToString();
                                string result = messageStatus(status);

                                dataGridView1.Rows.Add(i,reader[0].ToString(),reader[1].ToString().ToUpper()+" " + reader[2].ToString().ToUpper(), reader[3].ToString(),reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), result);
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

            if (string.Equals(status,"0"))
            {
                status = "Pending";
            }
            else if (string.Equals(status, "1"))
            {
                status = "Allowed Entry";
            }
            else if (string.Equals(status, "2"))
            {
                status = "Not Allowed Entry";
            }
            else if(string.Equals(status,"3"))
            {
                status = "Expired";
            }
            return status;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Checkbox")
                {
                    string id = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    viewUserRequirements(id);
                }
            }
            catch
            {

            }
        }

        private void viewUserRequirements(string id)
        {
            
            FrmViewRequirements viewRequirements = new FrmViewRequirements(id);
            viewRequirements.Show();
        }

        private void lblActivate_Click(object sender, EventArgs e)
        {

        }
        private void filterData(string data)
        {
            dataGridView1.Rows.Clear();
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {

                try
                {

                    string query = "SELECT VEHICLE_OWNER.Id_Number" +
                                         ",VEHICLE_OWNER.FirstName" +
                                         ",VEHICLE_OWNER.LastName" +
                                         ",VEHICLE_OWNER.Position" +
                                         ",CREDENTIALS.Status" +
                                         ",CREDENTIALS.PlateID" +
                                         ",CREDENTIALS.Time_Submitted" +
                                         ",CREDENTIALS.Time_Approved" +
                                         ",CREDENTIALS.Time_Due" +
                                         " FROM VEHICLE_OWNER INNER JOIN " +
                                         "CREDENTIALS ON VEHICLE_OWNER.Id_Number = CREDENTIALS.Id_Number " +
                                         "WHERE CREDENTIALS.Status = '"+data+"' ";

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
                                status = reader[4].ToString();
                                string result = messageStatus(status);
                                dataGridView1.Rows.Add(i, reader[0].ToString(), reader[1].ToString().ToUpper() + " " + reader[2].ToString().ToUpper(), reader[3].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), result);
                                
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
            else if (string.Equals(cmbFilterStatus.Text.ToString(), "Allowed Entry"))
            {
                filterData("1");
            }
            else if (string.Equals(cmbFilterStatus.Text.ToString(), "Not Allowed Entry"))
            {
                filterData("2");
            }
            else if (string.Equals(cmbFilterStatus.Text.ToString(), "Expired"))
            {
                filterData("3");
            }
        }

    }
}
