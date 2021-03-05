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
    public partial class FrmSG_SearchAccount : Form
    {
        public FrmSG_SearchAccount()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await searchOwner();
        }

        private async Task searchOwner()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {

                try
                {
                    await conn.OpenAsync();
                    string query = "SELECT CREDENTIALS.PlateID" +
                                         ",VEHICLE_OWNER.Id_Number" +
                                         ",VEHICLE_OWNER.FirstName" +
                                         ",VEHICLE_OWNER.LastName" +
                                         ",VEHICLE_OWNER.Position" +
                                         ",VEHICLE_OWNER.Department" +
                                         ",CREDENTIALS.Vehicle_Type" +
                                         ",CREDENTIALS.Vehicle_Model" +
                                         ",CREDENTIALS.Vehicle_Carmake" +
                                         ",CREDENTIALS.Vehicle_Color" +
                                         ",CREDENTIALS.Face_Image" +
                                         ",CREDENTIALS.Status " +
                                         "FROM VEHICLE_OWNER INNER JOIN CREDENTIALS ON VEHICLE_OWNER.Id_Number = CREDENTIALS.Id_Number " +
                                         "WHERE CREDENTIALS.PlateID = '" + txtPlateNumber.Text + "' ";
                                         


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            await Task.Delay(100);
                            while (reader.Read())
                            {
                                if(reader[11].ToString()=="1")
                                {

                                    pnlContainer.Visible = true;
                                    pnlfooter.Visible = true;

                                    lblPlatenumber.Text = reader.GetValue(0).ToString();
                                    lblIdNumber.Text = reader.GetValue(1).ToString();
                                    lblName.Text = reader.GetValue(2) + " " + reader.GetValue(3);
                                    lblPosition.Text = reader.GetValue(4).ToString();
                                    lblDepartment.Text = reader.GetValue(5).ToString();
                                    lblVehicleType.Text = reader.GetValue(6).ToString();
                                    lblVehicleModel.Text = reader.GetValue(7).ToString();
                                    lblCarmake.Text = reader.GetValue(8).ToString();
                                    lblVehicleColor.Text = reader.GetValue(9).ToString();


                                    byte[] img = (byte[])(reader[10]);
                                    if (img == null)
                                    {
                                        pictureBox1.Image = null;
                                    }
                                    else
                                    {
                                        MemoryStream ms = new MemoryStream(img);
                                        pictureBox1.Image = Image.FromStream(ms);
                                    }
                                }
                                else if(reader[11].ToString() == "0")
                                {
                                    MessageBox.Show("Your registration is still pending!\nPlease contact your administrator");
                                }
                                else if(reader[11].ToString() == "0")
                                {
                                    MessageBox.Show("Your registration is disapproved!\nPlease contact your administrator");
                                }

                            }
                            reader.Close();
                        }
                        else
                        {
                            MessageBox.Show("Plate number don't Exist!");

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

        private void pnlContainer_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.pnlContainer.ClientRectangle, Color.Gray, ButtonBorderStyle.Solid);
        }

        private void pnlfooter_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.pnlContainer.ClientRectangle, Color.Gray, ButtonBorderStyle.Solid);
        }
    }
}
