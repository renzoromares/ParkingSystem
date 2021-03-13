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
    public partial class FrmSSD_UpdateVehiclePass : Form
    {
        public FrmSSD_UpdateVehiclePass()
        {
            InitializeComponent();
        }

        string tempString = string.Empty;
        private void FrmUpdate_Load(object sender, EventArgs e)
        {

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panelContainer.ClientRectangle, Color.Gray, ButtonBorderStyle.Solid);

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panelContainer.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void loadData()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {

                try
                {
                    conn.Open();
                    string query = "SELECT VEHICLE_OWNER.Id_Number" +
                                         ",VEHICLE_OWNER.FirstName" +
                                         ",VEHICLE_OWNER.LastName" +
                                         ",VEHICLE_OWNER.Position" +
                                         ",VEHICLE_OWNER.Department" +
                                         ",CREDENTIALS.Vehicle_Type" +
                                         ",CREDENTIALS.Vehicle_Carmake" +
                                         ",CREDENTIALS.Vehicle_Model" +
                                         ",CREDENTIALS.Vehicle_Color" +
                                         ",CREDENTIALS.PlateID " +
                                         "FROM VEHICLE_OWNER INNER JOIN CREDENTIALS ON VEHICLE_OWNER.Id_Number = CREDENTIALS.Id_Number " +
                                         "WHERE CREDENTIALS.PLateID = '" + txtId_Plate.Text + "' ";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                displayHidden();
                                txtIdNumber.Text = reader.GetValue(0).ToString();
                                txtFullname.Text = reader.GetValue(1).ToString().ToUpper() + " " +reader.GetValue(2).ToString().ToUpper();
                                txtPosition.Text = reader.GetValue(3).ToString();
                                txtDepartment.Text = reader.GetValue(4).ToString();
                                txtVehicleType.Text = reader.GetValue(5).ToString();
                                txtModel.Text = reader.GetValue(6).ToString() + " " + reader.GetValue(7).ToString() + " - "  +reader.GetValue(8).ToString();
                                txtPlateNumber.Text = reader.GetValue(9).ToString();
                              
                                
                                txtFaceImage.Text = reader.GetValue(0).ToString() +".png";
                                txtOfficialReceipt.Text = reader.GetValue(0).ToString() + ".png";
                                txtCR.Text = reader.GetValue(0).ToString() + ".png";
                                tempString = reader.GetValue(0).ToString() + ".png";
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

        private void displayHidden()
        {
            panelContainer.Enabled = true;
            btnEdit.Enabled = true;
        }

        private void btnViewFaceImage_Click(object sender, EventArgs e)
        {
            FrmDisplayImage displayImage = new FrmDisplayImage(txtId_Plate.Text,7);
            displayImage.Show();
        }

        private void btnORView_Click(object sender, EventArgs e)
        {
            FrmDisplayImage displayImage = new FrmDisplayImage(txtId_Plate.Text,5);
            displayImage.Show();
        }

        private void btnCRView_Click(object sender, EventArgs e)
        {
            FrmDisplayImage displayImage = new FrmDisplayImage(txtId_Plate.Text, 6);
            displayImage.Show();
        }




        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int count = 0;
            
            if(!string.Equals(txtFaceImage.Text,"") && !string.Equals(txtFaceImage.Text,tempString))
            {
                count++;
                save2CredentialFaceUpdate();
            }
            if (!string.Equals(txtOfficialReceipt.Text, "") && !string.Equals(txtOfficialReceipt.Text, tempString))
            {
                count++;
                save2CredentialORUpdate();
            }
            if (!string.Equals(txtOfficialReceipt.Text, "") && !string.Equals(txtOfficialReceipt.Text, tempString))
            {
                count++;
                save2CredentialCR();
            }

            if(count > 0)
            {
                refresh();
                MessageBox.Show("Update Successful");
               
            }
            else
            {
                MessageBox.Show("No data is updated!");
            }




                //refresh();



        }

        private void refresh()
        {
            panelContainer.Visible = false;
            txtIdNumber.Text = "";
        }

        private void save2CredentialORUpdate()
        {

            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                try
                {

                    string query = "UPDATE CREDENTIALS SET Official_Receipt=@Official_Receipt " +
                                                          "WHERE PlateID=@PlateID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();


                        byte[] img = null;
                        FileStream fs2 = new FileStream(txtOfficialReceipt.Text.ToString(), FileMode.Open, FileAccess.Read);
                        BinaryReader br2 = new BinaryReader(fs2);
                        img = br2.ReadBytes((int)fs2.Length);

                        cmd.Parameters.AddWithValue("@PlateID", txtId_Plate.Text);
                        cmd.Parameters.AddWithValue("@Official_Receipt", img);

                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void save2CredentialFaceUpdate()
        {

            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                try
                {

                    string query = "UPDATE CREDENTIALS SET Face_Image=@Face_Image " +
                                                          "WHERE PlateID=@PlateID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();


                        byte[] img = null;
                        FileStream fs2 = new FileStream(txtFaceImage.Text.ToString(), FileMode.Open, FileAccess.Read);
                        BinaryReader br2 = new BinaryReader(fs2);
                        img = br2.ReadBytes((int)fs2.Length);

                        cmd.Parameters.AddWithValue("@PlateID", txtId_Plate.Text);
                        cmd.Parameters.AddWithValue("@Face_Image", img);

                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void save2CredentialCR()
        {

            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                try
                {

                    string query = "UPDATE CREDENTIALS SET Cert_Registration=@Cert_Registration " +
                                                          "WHERE PlateID=@PlateID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();


                        byte[] img = null;
                        FileStream fs2 = new FileStream(txtCR.Text.ToString(), FileMode.Open, FileAccess.Read);
                        BinaryReader br2 = new BinaryReader(fs2);
                        img = br2.ReadBytes((int)fs2.Length);

                        cmd.Parameters.AddWithValue("@PlateID", txtId_Plate.Text);
                        cmd.Parameters.AddWithValue("@Cert_Registration", img);

                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }



        private void txtfname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar);
        }

        private void txtlname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnAddOR_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "(*.jpg; *.jpeg; *.png; )| *.jpg; *.jpeg; *.png;";
                if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtOfficialReceipt.Text = open.FileName;
                }
            }
            catch
            {
                MessageBox.Show("Invalid File uploaded!");
            }
        }

        private void btnAddFace_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "(*.jpg; *.jpeg; *.png; )| *.jpg; *.jpeg; *.png;";
                if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtFaceImage.Text = open.FileName;
                }
            }

            catch
            {
                MessageBox.Show("Invalid File uploaded!");
            }
        }

        private void btnAddCR_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "(*.jpg; *.jpeg; *.png; )| *.jpg; *.jpeg; *.png;";
                if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtCR.Text = open.FileName;
                }
            }
            catch
            {
                MessageBox.Show("Invalid File uploaded!");
            }

        }
    }
}
