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
    public partial class FrmUpdate : Form
    {
        public FrmUpdate()
        {
            InitializeComponent();
        }

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
                                         ",VEHICLE_OWNER.Contacts" +
                                         ",CREDENTIALS.Vehicle_Type" +
                                         ",CREDENTIALS.Vehicle_Carmake" +
                                         ",CREDENTIALS.Vehicle_Model" +
                                         ",CREDENTIALS.Vehicle_Color" +
                                         ",CREDENTIALS.PlateID" +
                                         ",VEHICLE_OWNER.Password " +
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
                                txtfname.Text = reader.GetValue(1).ToString();
                                txtlname.Text = reader.GetValue(2).ToString();
                                txtDepartment.Text = reader.GetValue(4).ToString();
                                txtPhone.Text = reader.GetValue(5).ToString();
                                txtPassword.Text = reader.GetValue(11).ToString();
                                txtModel.Text = reader.GetValue(7).ToString() + " " + reader.GetValue(8).ToString() + " "  +reader.GetValue(9).ToString();
                                txtPlateNumber.Text = reader.GetValue(10).ToString();
                                txtVehicleType.Text = reader.GetValue(6).ToString();
                                txtPosition.Text = reader.GetValue(3).ToString();
                                txtFaceImage.Text = reader.GetValue(0).ToString() +".png";
                                txtOfficialReceipt.Text = reader.GetValue(0).ToString() + ".png";
                                txtCR.Text = reader.GetValue(0).ToString() + ".png";
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
            panelContainer.Visible = true;
            btnEdit.Visible = true;
            btnUpdate.Visible = true;
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
            bool checker = checkValidation();
            if (checker == true)
            {
                save2Registration();
                save2Credential();
                MessageBox.Show("Update Successful!");
                refresh();
                
            }
           else
           {
                MessageBox.Show("Please complete the details!");
           } 

        }
        private bool checkValidation()
        {

            bool isValidator = false;
            if (!string.Equals(txtIdNumber.Text, "ID Number") && !string.Equals(txtIdNumber.Text, ""))
            {
                if (string.Equals(txtPassword.Text, txtConfirmPass.Text))
                {
                    if (!string.Equals(txtfname.Text, "First Name") && !string.Equals(txtfname.Text, ""))
                    {
                        if (!string.Equals(txtlname.Text, "Surname") && !string.Equals(txtlname.Text, ""))
                        {
                            if (!string.Equals(txtPhone.Text, "Phone No.") && !string.Equals(txtPhone.Text, ""))
                            {
                                if (!string.Equals(txtPlateNumber.Text, "Plate Number") && !string.Equals(txtPlateNumber.Text, ""))
                                {
                                    if (!string.Equals(txtDepartment.Text, "Department") && !string.Equals(txtDepartment.Text, ""))
                                    {

                                        if (!string.Equals(txtOfficialReceipt.Text, "" ))
                                        {
                                            if (!string.Equals(txtOfficialReceipt.Text, " "))
                                            {
                                                isValidator = true;
                                            }
                                        } 
                                        
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Password don't match!");
                    isValidator = false;
                }
            }
            else
            {

                isValidator = false;

            }
            return isValidator;


        }

        private void refresh()
        {
            panelContainer.Visible = false;
            txtIdNumber.Text = "";
        }

        private void save2Registration()
        {

           
                using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
                {
                    conn.Open();
                    string query = "UPDATE VEHICLE_OWNER SET FirstName=@FirstName" +
                                                            ",LastName=@LastName" +
                                                            ",Contacts=@Contacts" +
                                                            ",Department=@Department" +
                                                            ",Password=@Password WHERE Id_Number = @Id_Number";
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))

                    {

                        int id = Convert.ToInt32(txtIdNumber.Text);

                        cmd.Parameters.AddWithValue("@Id_Number", txtIdNumber.Text);
                        cmd.Parameters.AddWithValue("@FirstName", txtfname.Text);
                        cmd.Parameters.AddWithValue("@LastName", txtlname.Text);
                        cmd.Parameters.AddWithValue("@Contacts", txtPhone.Text);
                        cmd.Parameters.AddWithValue("@Department", txtDepartment.Text);
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                    }
                }
                catch
                {
                    MessageBox.Show("Invalid details!");

                }

            }
            
        }

        private void save2Credential()
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


                        byte[] img2 = null;
                        FileStream fs2 = new FileStream(txtOfficialReceipt.Text.ToString(), FileMode.Open, FileAccess.Read);
                        BinaryReader br2 = new BinaryReader(fs2);
                        img2 = br2.ReadBytes((int)fs2.Length);

                        cmd.Parameters.AddWithValue("@PlateID", txtId_Plate.Text);
                        cmd.Parameters.AddWithValue("@Cert_Registration", img2);

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

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPassword.isPassword = true;
        }

        private void txtConfirmPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtConfirmPass.isPassword = true;
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
    }
}
